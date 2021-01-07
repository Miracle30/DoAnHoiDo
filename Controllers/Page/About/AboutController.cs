using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
namespace CarBooking.Page.Controllers
{
    public class AboutController : Controller
    {
    public IActionResult Index(){
        return View();
      }
    }
}