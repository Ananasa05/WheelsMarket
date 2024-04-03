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

        [HttpGet]
        public async Task<IActionResult> ShowSelectedInformationForAllVehicles(int? min, int? max, string? transName,string? fuel,string? editionName,string? brandName, string? year, string? location, string? color, int? hoursePowerMin, int? hoursePowerMax, string? locationRegion, string? locationTown)
        {
            var model = await vehicleService.ShowAllVehiclesAsync(min, max, transName,fuel,editionName, brandName,year,location,color,hoursePowerMin,hoursePowerMax,locationRegion,locationTown);

            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> ShowAllInfoForAVehicle([FromRoute] Guid id)
        {
            var model = await vehicleService.ShowAllInformationForVehicle(id);
            return View(model);
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.VehicleTypeSectionId = this.vehicleService.AddVehicleTypeSectionAsync();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(AddVehicleViewModel viewModel)
        {
            ViewBag.VehicleTypeSectionId = this.vehicleService.AddVehicleTypeSectionAsync();

            if (viewModel.VehicleTypeSectionId != default(Guid))
            {
                ViewBag.VehicleTypeTypeId = this.vehicleService.AddVehicleTypeTypeAsync(viewModel.VehicleTypeSectionId);
                if (viewModel.VehicleTypeTypeId != default(Guid))
                {
                    ViewBag.BrandId = this.vehicleService.AddBrandAsync(viewModel.VehicleTypeTypeId);
                    if (viewModel.BrandId != default(Guid))
                    {
                        ViewBag.EditionId = this.vehicleService.AddVehicleEditionAsync(viewModel.BrandId);
                    }
                }
            }

            if (!ModelState.IsValid 
                || viewModel.VehicleTypeSectionId == default(Guid)
                || viewModel.VehicleTypeTypeId == default(Guid)
				|| viewModel.BrandId == default(Guid)
				|| viewModel.EditionId == default(Guid)
               )
            {
                  return View(viewModel); 
            }
            await this.vehicleService.AddVehicleAsync(viewModel);
            return RedirectToAction("ShowSelectedInformationForAllVehicles", "Vehicle");
        }

        [HttpGet]
        public async Task<IActionResult> Delete(
          [FromRoute]
            Guid id)
        {
            await vehicleService.DeleteVehicleAdminAsync(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult ByPriceFilter()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ByYearsFilter()
        {
            return View();
        }
        [HttpGet]
        public IActionResult ByTransFilter()
        {
            return View();
        }
        [HttpGet]
        public IActionResult ByFuelFilter()
        {
            return View();
        }
        [HttpGet]
        public IActionResult ByEditionFilter()
        {
            return View();
        }
        [HttpGet]
        public IActionResult ByBrandFilter()
        {
            return View();
        }
		[HttpGet]
		public IActionResult ByColorFilter()
		{
			return View();
		}
		[HttpGet]
		public IActionResult ByHoursePowerFilter()
		{
			return View();
		}
		[HttpGet]
		public IActionResult ByLocationTownFilter()
		{
			return View();
		}
		[HttpGet]
		public IActionResult ByLocationRegionFilter()
		{
			return View();
		}
	}
}

