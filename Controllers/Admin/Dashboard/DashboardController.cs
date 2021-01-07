
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using CarBooking.Data;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using CarBooking.Models;

namespace CarBooking.Admin.Controllers{

    [Route("admin/dashboard")]
    public class DashboardController : Controller
    {
        private ApplicationDbContext db;
        public DashboardController(ApplicationDbContext db)
        {
            this.db = db;
        }

        [Authorize(Roles="Admin")]
        public IActionResult index(){

            var Now = DateTime.Now;
            var LastFiveMonth = Now.AddMonths(-5);

            ViewBag.Data = db.Orders.Where(item => item.CreatedAt > LastFiveMonth)
                                .GroupBy(item => item.CreatedAt.Month)
                                .Select(g => new {
                                    g.Key,
                                    Amount = g.Sum(gg => gg.Amount)
                                })
                                .ToList();

            return View("Views/Admin/Dashboard/Index.cshtml");
        }

    }
}