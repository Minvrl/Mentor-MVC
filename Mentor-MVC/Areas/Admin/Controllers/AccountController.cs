using Mentor_MVC.Areas.Admin.ViewModels;
using Mentor_MVC.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Mentor_MVC.Areas.Admin.Controllers
{
    [Area("admin")]
    public class AccountController : Controller
    {
        private UserManager<AppUser> _userManager;
        private SignInManager<AppUser> _signInManager;

        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }


        public async Task<IActionResult> CreateAdmin()
        {
            AppUser admin = new AppUser { UserName = "admin" };

            var r = await _userManager.CreateAsync(admin, "hello9999");

            return Json(r);

        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> Login(AdminLoginViewModel logvm)
        {
            AppUser admin = await _userManager.FindByNameAsync(logvm.UserName);

            if(admin == null)
            {
                ModelState.AddModelError("", "Username or password is incorrect.");
                return View();
            }

            var result = await _signInManager.PasswordSignInAsync(admin, logvm.Password,false,false);

            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Username or password is incorrect.");
                return View();

            }
            return RedirectToAction("index", "dashboard");
        }
    }
}
