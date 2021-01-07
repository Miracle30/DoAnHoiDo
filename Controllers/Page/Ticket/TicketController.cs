using System.Threading.Tasks;
using CarBooking.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System;
using CarBooking.ViewModels;
using CarBooking.Models;

namespace CarBooking.Page.Controllers
{
    [Route("/ticket")]
    public class TicketController : Controller
    {
        private ApplicationDbContext _context;

        public TicketController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {

            var data = from route in _context.Routes.Where(r => r.TimeStart > DateTime.Now)
                       join ticket in _context.Tickets.Where(t => (int)t.StatusTicket != 3)
                       on route.Id equals ticket.RouteId
                       join car in _context.Cars
                       on ticket.CarId equals car.Id
                       join employee in _context.Employees
                       on car.Id equals employee.CarId
                       select new TicketViewModel()
                       {
                           Id = route.Id,
                           StartPoint = route.StartPoint,
                           Endpoint = route.EndPoint,
                           TimeStart = route.TimeStart,
                           TimeEnd = route.TimeEnd,
                           Price = ticket.Price,
                           Tickets = route.Tickets,
                           Car = new Car()
                           {
                               SeatNumber = car.SeatNumber,
                               CarImages = car.CarImages,
                               Thumbnail = car.Thumbnail,
                               Employees = car.Employees
                           }

                       };
            var result = await data.Distinct().ToListAsync();
            return View(result);
        }
        [HttpPost("book")]
        public async Task<IActionResult> BookTicket([FromBody] BookTicket model)
        {
            if (!ModelState.IsValid)
            {
                var errors = ModelState.Select(x => x.Value.Errors)
                                    .Where(y => y.Count > 0)
                                    .ToList();
                return BadRequest(errors);
            }
            
            var seatNumber = await _context.Tickets.Where(item => item.Id == Convert.ToInt32(model.SeatNumberId)).Select(item => item.SeatNumberId).FirstOrDefaultAsync();
            var BookTicket = new BookTicket
            {
                FullName = model.FullName,
                Address = model.Address,
                Phone = model.Phone,
                Email = model.Email,
                TicketId = Convert.ToInt32(model.SeatNumberId),
                SeatNumberId = seatNumber,
                Status = false,
                CreatedAt = DateTime.Now
            };
            await _context.BookTickets.AddAsync(BookTicket);
            await _context.SaveChangesAsync();
            return Ok(1);
        }
    }


}