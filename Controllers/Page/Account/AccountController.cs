using System.Threading.Tasks;
using CarBooking.Models;
using CarBooking.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
namespace CarBooking.Page.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<ApplicationUser> _userManager;
        private RoleManager<ApplicationRole> _roleManager;
        private SignInManager<ApplicationUser> _signInManager;

        public AccountController(

            UserManager<ApplicationUser> userManager,
            RoleManager<ApplicationRole> roleManager,
            SignInManager<ApplicationUser> signInManager
        )
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register([FromForm] RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var User = new ApplicationUser
                {
                    FullName = model.FullName,
                    Email = model.Email,
                    UserName = model.UserName
                };

                var result = await _userManager.CreateAsync(User, model.Password);

                if (result.Succeeded)
                {

                    var roleUser = await _roleManager.FindByIdAsync("3");
                    await _userManager.AddToRoleAsync(User, roleUser.Name);

                    await _signInManager.SignInAsync(User, isPersistent: false);
                    return RedirectToAction("index", "home");
                }


                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

            }
            return View(model);
        }

        [HttpGet]
        public IActionResult LogIn()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login([FromForm] LoginViewModel model)
        {

            if (ModelState.IsValid)
            {

                var result = await _signInManager.PasswordSignInAsync(model.UserName, model.Password, model.RememberMe, false);

                if (result.Succeeded)
                {
                    if (!string.IsNullOrEmpty(model.ReturnUrl))
                    {
                        return Redirect(model.ReturnUrl);
                    }
                    else
                    {

                        return RedirectToAction("index", "home");
                    }
                }
                ModelState.AddModelError(string.Empty, "Sai tên đăng nhập hoặc mật khẩu");

            }

            return View(model);
        }



        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> makeRole()
        {
            var adminRole = new ApplicationRole
            {
                Name = "Admin"
            };


            await _roleManager.CreateAsync(adminRole);

            var staffRole = new ApplicationRole
            {
                Name = "System staff"
            };

            await _roleManager.CreateAsync(staffRole);

            var userRole = new ApplicationRole
            {
                Name = "User"
            };

            await _roleManager.CreateAsync(userRole);

            return Ok("Tạo vai trò thành công");
        }

        [Authorize(Roles="Admin")]
        public async Task<IActionResult> GetRole()
        {
            var roleUser = await _roleManager.FindByIdAsync("1");
            return Ok(roleUser);
        }

        public async Task<IActionResult> makeAdmin()
        {

            var User = new ApplicationUser
            {
                FullName = "admin",
                Email = "admin@gmail.com",
                UserName = "admin"
            };

            var result = await _userManager.CreateAsync(User, "123456");
            var roleUser = await _roleManager.FindByIdAsync("1");
            await _userManager.AddToRoleAsync(User, roleUser.Name);
            return Ok("Tạo admin thành công");
        }


    }
}