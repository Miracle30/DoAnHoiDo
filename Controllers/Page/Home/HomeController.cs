using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System;
using CarBooking.Models;
using CarBooking.Data;
namespace CarBooking.Page.Controllers
{

    public class HomeController : Controller
    {
        private ApplicationDbContext db;

        public HomeController (ApplicationDbContext db){
          this.db = db;
        }
        public IActionResult Index()
        {

            ViewBag.Posts = db.Posts
                            .OrderByDescending(item => item.CreatedAt)
                            .Take(4)
                            .ToList(); 
            // get post
              
            ViewBag.Tickets = db.Tickets
                              .Where(item => item.StatusTicket == StatusTicket.Pendding || item.StatusTicket == StatusTicket.NotUsed )
                              .OrderBy(item => item.CreatedAt)
                              .Take(4)
                              .Select(item => new Ticket{
                                Id = item.Id,
                                Car = item.Car, 
                                User = item.User, 
                                Price = item.Price,
                                Route = item.Route
                              })
                              .ToList(); 
             // get ticket 
            return View(); 
        }
    }
}