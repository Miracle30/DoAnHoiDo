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
    public class  DistrictController : Controller
    {
        
    }
}