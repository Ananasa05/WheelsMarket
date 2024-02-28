using Microsoft.AspNetCore.Mvc;
using WheelsMarket.Services.Vehicles.ViewModel;
using WheelsMarket.Services.Vehicles;
using WheelsMarket.Services.VehicleTypeSections;
using Microsoft.AspNetCore.Identity;
using WheelsMarket.Data.Models;

namespace WheelsMarket.Controllers
{
    public class VehicleController:Controller
    {
        private readonly IVehicleService vehicleService;
                private readonly UserManager<User> userManager;


        public VehicleController(IVehicleService vehicleService,UserManager<User> userManager)
        {
            this.vehicleService = vehicleService;
            this.userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.EditionId = this.vehicleService.AddVehicleEditionAsync();
            ViewBag.VehicleTypeTypeId = this.vehicleService.AddVehicleTypeAsync();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(AddVehicleViewModel viewModel,Guid id)
        {
            var user = await userManager.FindByEmailAsync(User.Identity?.Name);
            //await this.vehicleService.AddVehicleAsync(user,id);
            if (!ModelState.IsValid) { return View(viewModel); }
            //await this.vehicleService.AddVehicleAsync(viewModel);
            return RedirectToAction("Index", "Home");
        }

    }
}
