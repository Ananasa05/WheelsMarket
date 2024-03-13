using Microsoft.AspNetCore.Mvc;
using WheelsMarket.Services.Vehicles.ViewModel;
using WheelsMarket.Services.Vehicles;
using WheelsMarket.Services.VehicleTypeSections;
using Microsoft.AspNetCore.Identity;
using WheelsMarket.Data.Models;
using WheelsMarket.Services.Brands.ViewModel;
using WheelsMarket.Services.Brands;
using WheelsMarket.Services.Editions.ViewModel;
using WheelsMarket.Services.Editions;

namespace WheelsMarket.Controllers
{
    public class VehicleController : Controller
    {
        private readonly IVehicleService vehicleService;
        private readonly UserManager<User> userManager;


        public VehicleController(IVehicleService vehicleService, UserManager<User> userManager)
        {
            this.vehicleService = vehicleService;
            this.userManager = userManager;
        }

		public async Task<IActionResult> Index()
		{
			var model = await vehicleService.ShowAllVehiclesAsync();
			return View(model);
		}


		[HttpGet]
        public IActionResult Add()
        {
            ViewBag.BrandId = this.vehicleService.AddBrandAsync();
            ViewBag.VehicleTypeSectionId = this.vehicleService.AddVehicleTypeSectionAsync();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(AddVehicleViewModel viewModel)
        {
            if (viewModel.BrandId != default(Guid) && viewModel.EditionId == default(Guid)&& viewModel.VehicleTypeTypeId == default(Guid) && viewModel.VehicleTypeSectionId != default(Guid))
            {
                var a = this.vehicleService.AddVehicleEditionAsync(viewModel.BrandId);
                ViewBag.EditionId = a;
                ViewBag.BrandId = this.vehicleService.AddBrandAsync();
				var b = this.vehicleService.AddVehicleTypeTypeAsync(viewModel.VehicleTypeSectionId);
				ViewBag.VehicleTypeTypeId = b;
				ViewBag.VehicleTypeSectionId = this.vehicleService.AddVehicleTypeSectionAsync();
				return View(viewModel);
            }
            //else if ()
            //{
                
            //    return View(viewModel);
            //}
            else
            {
				if (!ModelState.IsValid) { return View(viewModel); }
				await this.vehicleService.AddVehicleAsync(viewModel);
				return RedirectToAction("Index", "Home");
			}
            
            
        }

		[HttpGet]
		public async Task<IActionResult> Delete(
		  [FromRoute]
			Guid id)
		{
			await vehicleService.DeleteVehicleAdminAsync(id);
			return RedirectToAction("Index");
		}


	}
}
