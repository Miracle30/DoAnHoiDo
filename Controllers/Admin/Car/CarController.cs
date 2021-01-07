using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using CarBooking.Data;
using CarBooking.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CarBooking.Admin.Controllers {
    [Route ("admin/car")]
    [Authorize (Roles = "Admin")]
    public class CarController : Controller {

        private ApplicationDbContext _context;

        public CarController (
            ApplicationDbContext context
        ) {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Index () {
            var data = await _context.Cars
                .Include (item => item.Employees)
                .ToListAsync ();
            return View ("Views/Admin/Car/Index.cshtml", data);
        }

        [HttpGet ("{id}")]
        public async Task<IActionResult> Detail (int id) {
            var car = await _context.Cars
                .Where (item => item.Id == id)
                .Include (item => item.CarImages)
                .Include (item => item.Employees)
                .FirstAsync ();

            ViewBag.MainDriver = await _context.Employees
                .Where (item => item.Position == Position.MainDriver)
                .ToListAsync ();

            if (car.SeatNumber >= 14) {

                ViewBag.MainDriver = await _context.Employees
                    .Where (item => item.Position == Position.MainDriver && (item.DriverLicense == DriverLicense.b2 || item.DriverLicense == DriverLicense.d || item.DriverLicense == DriverLicense.e ))
                    .ToListAsync ();

            }

            ViewBag.SubDriver = await _context.Employees
                .Where (item => item.Position == Position.SubDriver)
                .ToListAsync ();

            var query = _context.Employees.AsQueryable ();

            ViewBag.CurrentMainDriver = await query
                .Where (item => item.Position == Position.MainDriver)
                .Where (item => item.CarId == id)
                .OrderByDescending (item => item.Id)
                .FirstOrDefaultAsync ();

            ViewBag.CurrentSubDriver = await query
                .Where (item => item.Position == Position.SubDriver)
                .Where (item => item.CarId == id)
                .OrderByDescending (item => item.Id)
                .FirstOrDefaultAsync ();

            ViewBag.Routes = await _context.Routes
                .Where (item => item.TimeStart >= DateTime.Now)
                .ToListAsync ();

            return View ("Views/Admin/Car/Detail.cshtml", car);
        }

        [HttpGet ("create")]
        public IActionResult Create () {
            return View ("Views/Admin/Car/Create.cshtml");
        }

        [HttpPost ("create")]
        public async Task<IActionResult> Create ([FromForm] Car model) {
            if (ModelState.IsValid) {

                // string JsonString = Request.Form["CarImages"];
                // var CarImages  = JsonConvert.DeserializeObject<List<CarImage>>(model.CarImages);

                // JArray  o = JArray.Parse(JsonString);
                // foreach ( var item in o)
                // {
                //      dynamic data = JObject.Parse(item.ToString());

                //      return Ok(data.Url);

                //     //  CarImages.Add(new CarImage(){
                //     //      Url = data.Url,
                //     //      Size = data.Size,
                //     //      Created_At = DateTime.Now
                //     //  });
                // }

                var Car = new Car {
                    CarCode = model.CarCode,
                    Description = model.Description,
                    Thumbnail = model.Thumbnail,
                    SeatNumber = model.SeatNumber,
                    SeatNumberRest = model.SeatNumber,
                    StatusCar = StatusCar.Maintenance,
                    Created_At = DateTime.Now,
                    CarImages = model.CarImages

                };

                await _context.Cars.AddAsync (Car);
                await _context.SaveChangesAsync ();

                ViewBag.message = "Thêm xe thành công";
                ModelState.Clear ();
            }
            return View ("Views/Admin/Car/Create.cshtml");
        }

        [HttpPost ("update/{id}")]
        public async Task<IActionResult> Update ([FromForm] Car model, int id) {

            var car = await _context.Cars.FindAsync (id);

            if (car != null) {

                // update car 

                car.SeatNumber = model.SeatNumber;
                car.SeatNumberRest = model.SeatNumber;
                car.StatusCar = model.StatusCar;

                if(car.StatusCar == StatusCar.Running){
                    var ticketSuccess = _context.Tickets.Where(item => item.CarId == id && item.StatusTicket == StatusTicket.Used);
                    
                    // thêm đơn hàng
                    
                    var order = new Order{
                        RouteId = ticketSuccess.FirstOrDefault().RouteId,
                        Amount =  (int)ticketSuccess.Sum(item => item.Price),
                        Status = false
                    };

                    await _context.AddAsync(order);
                   await _context.SaveChangesAsync ();

                    // thêm chi tiết hóa đơn 

                    foreach (var item in ticketSuccess)
                    {
                      await  _context.orderDetails.AddAsync(new OrderDetail{
                        TicketId = item.Id,
                        OrderId = order.Id
                      });                      
                    }
                    var tickets = _context.Tickets.Where(item => item.CarId == id);   
                    await tickets.ForEachAsync( item => { 
                        item.StatusTicket = StatusTicket.TimeOut;
                    } );

                    return Redirect("/admin/order");
                }

                await _context.SaveChangesAsync ();

                // add employees inner car  xxxxxx

                var employees = model.Employees.Where (item => item.Id != 0).ToList ();

                if (employees.Count > 0) {
                    foreach (var item in employees) {
                        var employee = await _context.Employees.FindAsync (item.Id);

                        // update employee while change employees

                        var position = employee.Position;

                        var employeeByPosition = await _context.Employees
                            .Where (item => item.Position == position)
                            .Where (item => item.CarId == id)
                            .ToListAsync ();
                        foreach (var em in employeeByPosition) {
                            em.CarId = null;
                            await _context.SaveChangesAsync ();
                        }

                        employee.CarId = car.Id;
                        await _context.CarHistories.AddAsync (new CarHistory { CarId = id, EmployeeId = employee.Id , CreatedAt = DateTime.Now});
                        await _context.SaveChangesAsync ();

                    }
                }

                var routeId = Request.Form["routes"].FirstOrDefault ();
                var ticketPrice = Request.Form["ticketPrice"].FirstOrDefault ();

                // make tickets 

                if (int.TryParse (routeId, out int value)) {

                    var tickets = new List<Ticket> ();

                    for (int i = 1; i <= car.SeatNumber; i++) {
                        tickets.Add (new Ticket {

                            Price = Convert.ToDecimal (ticketPrice),
                                SeatNumberId = car.CarCode + "-GHE-" + i,
                                CarId = car.Id,
                                Phone = "",
                                Address = "",
                                Name = "",
                                RouteId = Convert.ToInt32 (routeId),
                                StatusTicket = StatusTicket.NotUsed,
                                CreatedAt = DateTime.Now,
                                UpdatedAt = DateTime.Now
                        });
                    }

                    await _context.Tickets.AddRangeAsync (tickets);
                    await _context.SaveChangesAsync ();

                    ViewBag.message = "Thêm lộ trình thành công";

                    return Redirect ("/admin/ticket");

                }

            }

            return Redirect ("/admin/car/" + id);
        }

        [HttpPost ("upload/thumbnail"), DisableRequestSizeLimit]
        public IActionResult UploadThumbnail () {

            try {

                var file = Request.Form.Files[0];
                var folderName = Path.Combine ("wwwroot", "uploads");
                var pathToSave = Path.Combine (Directory.GetCurrentDirectory (), folderName);
                if (file.Length > 0) {
                    var now = DateTime.Now.Ticks.ToString ();
                    var fileName = ContentDispositionHeaderValue.Parse (file.ContentDisposition).FileName.Trim ('"');
                    var typeFile = fileName.Substring (fileName.LastIndexOf ("."));
                    fileName = fileName.Substring (0, fileName.Length - typeFile.Length) + now + typeFile;
                    var fullPath = Path.Combine (pathToSave, fileName);
                    var thumbnail = Path.Combine (folderName, fileName);
                    using (var stream = new FileStream (fullPath, FileMode.Create)) {
                        file.CopyTo (stream);
                    }

                    thumbnail = thumbnail.Substring (7);

                    return Ok (new { thumbnail, fileSize = file.Length });
                } else {
                    return BadRequest ();
                }
            } catch (Exception e) {
                return StatusCode (500, $"Internal server errors {e}");
            }
        }

    }
}