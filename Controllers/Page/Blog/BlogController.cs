using System.Threading.Tasks;
using CarBooking.Data;
using CarBooking.Helper;
using CarBooking.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
namespace CarBooking.Page.Controllers
{
    public class BlogController : Controller
    {
        private ApplicationDbContext _context;

        public BlogController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index(int? pageNumber)
        {
            var posts = from s in _context.Posts
                        select s;
            int pageSize = 2;
            var paginate = await PaginateList<Post>.CreateAsync(posts.AsNoTracking(), pageNumber ?? 1, pageSize);
            return View(paginate);
        }
        public async Task<IActionResult> Detail(int id)
        {
            var found = await _context.Posts.FindAsync(id);
            if (found != null)
            { 
                var post = await _context.Posts.Where(p  => p.Id == id).Select(p => new  Post{
                    Id = p.Id,
                    Thumbnail = p.Thumbnail,
                    Content = p.Content,
                    Description = p.Description,
                    UserId = p.UserId,
                    User =  p.User
                }).FirstOrDefaultAsync();
                return View(post);
            }
            return BadRequest();
        }
    }
}