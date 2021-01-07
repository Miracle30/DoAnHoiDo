using System.Threading.Tasks;
using CarBooking.ViewModels;
using CarBooking.Models;
using CarBooking.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CarBooking.Page.Controllers
{
    public class ContactController : Controller
    {
        private ApplicationDbContext _context;

        public ContactController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Create([FromForm] ContactViewModel model)
        {


            if (ModelState.IsValid)
            {

                var Contact = new Contact
                {
                    Name = model.Name,
                    Email = model.Email,
                    Phone = model.Phone,
                    Subject = model.Subject,
                    Message = model.Message,
                    Status = false,
                    CreatedAt = DateTime.Now
                };

                await _context.Contacts.AddAsync(Contact);
                await _context.SaveChangesAsync();
                ViewBag.message = "Gửi liên hệ thành công";
                ModelState.Clear();
                return View("/Views/Contact/Index.cshtml");

            }
            return View("/Views/Contact/Index.cshtml");
        }

    }
} 