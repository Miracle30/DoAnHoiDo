using System;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using CarBooking.Data;
using CarBooking.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace CarBooking.Admin.Controllers
{
    [Route("admin/route")]
    [Authorize(Roles = "Admin")]
    public class  RouteController : Controller
    {
       
        private ApplicationDbContext _context;

        public RouteController(
            ApplicationDbContext context
        )
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var data = await _context.Routes 
                                     .ToListAsync();
            return View("Views/Admin/Route/Index.cshtml", data);
        }

        [HttpGet("create")]
        public IActionResult Create()
        {
            return View("Views/Admin/Route/Create.cshtml");
        }
        
        [HttpPost("create")]
        public async Task<IActionResult> Create([FromForm] Route model)
        {
            if(ModelState.IsValid){

                var route = new Route(){
                    StartPoint = model.StartPoint,
                    EndPoint   = model.EndPoint,
                    Range      = model.Range,
                    TimeStart  = model.TimeStart,
                    TimeEnd    = model.TimeEnd,
                    CreatedAt  = DateTime.Now
                };
            
                await _context.Routes.AddRangeAsync(route);
                await _context.SaveChangesAsync();
                
                ModelState.Clear();
                
                ViewBag.message = "Thêm Lộ trình thành công";


            }
            return View("Views/Admin/Route/Create.cshtml");
        }
    }
}