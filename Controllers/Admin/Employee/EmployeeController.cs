using System;
using System.Linq;
using System.Threading.Tasks;
using CarBooking.Data;
using CarBooking.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CarBooking.Admin.Controllers {

    [Route ("admin/employee/")]
    [Authorize (Roles = "Admin")]
    public class EmployeeController : Controller {
        private ApplicationDbContext _ctx;

        public EmployeeController (ApplicationDbContext ctx) {
            _ctx = ctx;
        }

        [HttpGet]
        public async Task<IActionResult> Index () {

            var query = _ctx.Employees.AsQueryable ();
            var data = await query.OrderByDescending (item => item.Id).ToListAsync ();
            return View ("Views/Admin/Employee/Index.cshtml", data);
        }

        [HttpGet ("{id}")]
        public async Task<IActionResult> Get (int Id, Employee model) {

            var Employee = await _ctx.Employees.FindAsync (Id);
            if (Employee != null) {
                var query = _ctx.Employees.Where (item => item.Id == Id)
                    .Select (item => new Employee {
                        Car = item.Car,
                        Id = item.Id,
                        FullName = item.FullName,
                        YearOfBirth = item.YearOfBirth,
                        Phone = item.Phone,
                        Email = item.Email,
                        Address = item.Address,
                        Avatar = item.Avatar,
                        Position = item.Position,
                        DriverLicense = item.DriverLicense,
                        CreatedAt = item.CreatedAt,
                        CarHistories = item.CarHistories.Where(ch => ch.EmployeeId == Employee.Id).OrderByDescending(ch => ch.CreatedAt).Take(10).ToList()
                    });
                var data = await query.FirstAsync ();
                return View("/Views/Admin/Employee/Detail.cshtml",data);

            }
            return BadRequest ("Không tồn tại nhân viên");
        }

        [HttpGet ("create")]
        public IActionResult Create () {
            return View ("Views/Admin/Employee/Create.cshtml");
        }

        [HttpPost ("create")]

        public async Task<IActionResult> Create ([FromForm] Employee model) {
            
            if (ModelState.IsValid) {

                var Employee = new Employee {
                    FullName = model.FullName,
                    Email = model.Email,
                    Phone = model.Phone,
                    Address = model.Address,
                    YearOfBirth = model.YearOfBirth,
                    Position = model.Position,
                    DriverLicense = model.DriverLicense,
                    CreatedAt = DateTime.Now
                };
                await _ctx.Employees.AddAsync (Employee);
                await _ctx.SaveChangesAsync ();
                ViewBag.message = "Thêm nhân viên thành công";
                ModelState.Clear ();
            }
            return View ("Views/Admin/Employee/Create.cshtml");
        }

        [HttpGet ("delete/{id}")]
        public async Task<IActionResult> Delete (int id) {
            var foundCar = await _ctx.Employees
                .Where (item => item.Id == id && item.CarId != null)
                .Select (item => new Car {
                    CarCode = item.Car.CarCode
                })
                .FirstOrDefaultAsync ();
            if (foundCar != null) {
                return BadRequest ("Nhân viên đang chỉ định ở xe --" + foundCar.CarCode);
            }

            var found = await _ctx.Employees.FindAsync(id);
            if (found != null) {
                _ctx.Employees.Remove(found);
                await _ctx.SaveChangesAsync();
                return Redirect("/admin/employee");
            }
            return BadRequest ("Không tồn tại nhân viên --");

        }

    }
}