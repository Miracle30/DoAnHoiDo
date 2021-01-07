using System;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Threading.Tasks;
using CarBooking.Data;
using CarBooking.Models;
using CarBooking.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CarBooking.Admin.Controllers {
    [Route ("admin/order")]
    [Authorize (Roles = "Admin")]
    public class OrderController : Controller {
        private ApplicationDbContext _context;

        public OrderController (
            ApplicationDbContext context
            ) {
                _context = context;
            }

        public async Task<IActionResult> Index () {
            var data = await _context.Orders
                .OrderByDescending (item => item.Id)
                .Select (item => new OrderViewModel {
                    Id = item.Id,
                        Amount = item.Amount,
                        Route = item.Route,
                        Car = item.Route.Tickets.FirstOrDefault ().Car,
                        CreatedAt = DateTime.Now
                })
                .ToListAsync ();
            return View ("/Views/Admin/Order/Index.cshtml", data);
        }

        // [HttpGet("{id}")]
        // public async Task<IActionResult> detail(int id) => View("/Views/Admin/Order/Detail.cshtml");
    }   
}