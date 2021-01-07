using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using CarBooking.Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.IO;
using System;
using System.Net.Http.Headers;
using CarBooking.Models;
using System.Security.Claims;
using CarBooking.ViewModels;

namespace CarBooking.Admin.Controllers
{
    [Route("admin/post")]
    [Authorize(Roles = "Admin")]
    public class PostController : Controller
    {
        private ApplicationDbContext _context;

        public PostController(
            ApplicationDbContext context
        )
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var posts = await _context.Posts.OrderByDescending(item => item.Id)
                                .Select(item => new PostIndexViewModel
                                {
                                    Id = item.Id,
                                    Title = item.Title,
                                    Description = item.Description,
                                    Author = item.User.FullName,
                                    CreatedAt = item.CreatedAt,

                                }).ToListAsync();
            return View("Views/Admin/Post/Index.cshtml", posts);
        }


        [HttpGet("create")]
        public IActionResult Create()
        {

            return View("Views/Admin/Post/Create.cshtml");
        }

        [Authorize(Roles = "Admin")]
        [HttpPost("upload-thumbnail"), DisableRequestSizeLimit]
        public IActionResult UploadThumbnail()
        {
            try
            {

                var file = Request.Form.Files[0];
                var folderName = Path.Combine("wwwroot", "uploads");
                var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), folderName);
                if (file.Length > 0)
                {
                    var now = DateTime.Now.Ticks.ToString();
                    var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                    var typeFile = fileName.Substring(fileName.LastIndexOf("."));
                    fileName = fileName.Substring(0, fileName.Length - typeFile.Length) + now + typeFile;
                    var fullPath = Path.Combine(pathToSave, fileName);
                    var dbPath = Path.Combine(folderName, fileName);
                    using (var stream = new FileStream(fullPath, FileMode.Create))
                    {
                        file.CopyTo(stream);
                    }

                    dbPath = dbPath.Substring(7);

                    return Ok(new { dbPath });
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception e)
            {
                return StatusCode(500, $"Internal server errors {e}");
            }
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create([FromForm] Post model)
        {


            if (ModelState.IsValid)
            {
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                model.UserId = userId;
                model.CreatedAt = DateTime.Now;
                await _context.Posts.AddAsync(model);
                await _context.SaveChangesAsync();
                return Redirect("/admin/Post");
            }


            return View("Views/Admin/Post/Create.cshtml");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Detail(int id)
        {

            var post = await _context.Posts.Where(i => i.Id == id).Select(p => new Post
            {
                Id             = p.Id,
                Title          = p.Title,
                Description    = p.Description,
                Content        = p.Content,
                Thumbnail      = p.Thumbnail,
                CreatedAt      = p.CreatedAt,
                UpdatedAt      = p.UpdatedAt,
                UserId         = p.UserId
            }).FirstAsync();
            if (post != null)
            {
                return View("Views/Admin/Post/Detail.cshtml", post);
            }

            return BadRequest("Không tồn tại bài viết");

        }

        [HttpPost("{id}")]
        public async Task<IActionResult> Update([FromForm] Post model, int id)
        {

            var post = await _context.Posts.FindAsync(id);

            //  id not found --> err

            if (post != null)
            {
                if (ModelState.IsValid)
                {
                    post.Title = model.Title;
                    post.Description = model.Description;
                    post.Content = model.Content;
                    post.Thumbnail = model.Thumbnail;
                    var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                    post.UserId = userId;
                    post.UpdatedAt = DateTime.Now;
                    await _context.SaveChangesAsync();
                }
                ViewBag.message = "Cập nhật thành công";
                return View("Views/Admin/Post/Detail.cshtml", post);
            }


            return BadRequest("Không tồn tại bài viết");
        }
    }

}