using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WheelsMarket.Data;
using WheelsMarket.Data.Models;
using WheelsMarket.Services.Account;

namespace WheelsMarket.Controllers
{
    public class UserController : Controller
    {
        private readonly UserManager<User> userManager;
        private readonly WheelsMarketDbContext applicationDbContext;
        //private readonly RoleManager<IdentityRole> roleManager;

        private readonly SignInManager<User> signInManager;

        public UserController(
            UserManager<User> _userManager,
            SignInManager<User> _signInManager, WheelsMarketDbContext dbContext/*, RoleManager<IdentityRole> roleManager*/)
        {
            userManager = _userManager;
            signInManager = _signInManager;
            applicationDbContext = dbContext;
            //this.roleManager = roleManager;
            //this.CreateRoles();
        }

        //[HttpGet]
        //[Authorize(Roles = "Administrator")]
        //public IActionResult MakeRole()
        //{
        //    return View();
        //}
        //[HttpPost]
        //[Authorize(Roles = "Administrator")]
        //public async Task<IActionResult> MakeRole(IdentityRole model)
        //{
        //    if (!roleManager.RoleExistsAsync(model.Name).GetAwaiter().GetResult())
        //    {
        //        roleManager.CreateAsync(new IdentityRole(model.Name)).GetAwaiter().GetResult();
        //    }
        //    return RedirectToAction("MakeRole");
        //}

        //private async Task CreateRoles()
        //{
        //    if (this.roleManager.Roles.Count() == 0)
        //    {
        //        await roleManager.CreateAsync(new IdentityRole() { Name = "User" });
        //        await roleManager.CreateAsync(new IdentityRole() { Name = "Administrator" });
        //    }

        //}


        [HttpGet]
        [AllowAnonymous]
        public IActionResult Register()
        {
            if (User?.Identity?.IsAuthenticated ?? false)
            {
                return RedirectToAction("Home", "Index");
            }

            var model = new RegisterViewModel();

            return View(model);
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var user = new User()
            {
                Email = model.Email,
                UserName = model.UserName
            };
            var result = await userManager.CreateAsync(user, model.Password);

            if (result.Succeeded)
            {
                await signInManager.SignInAsync(user, isPersistent: false);
                return RedirectToAction("Index", "Home");
            }
            foreach (var item in result.Errors)
            {
                ModelState.AddModelError("", item.Description);
            }
            return View(model);
        }
        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()
        {
            if (User?.Identity?.IsAuthenticated ?? false)
            {
                return RedirectToAction("Index", "Home");
            }

            var model = new LoginViewModel();

            return View(model);
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var user = await userManager.FindByNameAsync(model.UserName);

            if (user != null)
            {
                var result = await signInManager.PasswordSignInAsync(user, model.Password, false, false);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            ModelState.AddModelError("", "Invalid login");
            return View(model);
        }
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();

            return RedirectToAction("Index", "Home");
        }

    }

}
