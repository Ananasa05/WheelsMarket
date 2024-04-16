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
using Microsoft.AspNetCore.Authorization;
using WheelsMarket.Services.VehicleTypeTypes.ViewModel;
using WheelsMarket.Services.VehicleTypeTypes;
using WheelsMarket.Services.VehicleTypeSections.ViewModel;

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
        public async Task<IActionResult> ShowSelectedInformationForAllVehicles(int? priceMin, int? priceMax, int? yearMin, int? yearMax, string? transmissionName, string? fuelName, int? horsePowerMin, int? horsePowerMax, string? locationTown, string? locationRegion, string? colorName)
        {
            var model = await vehicleService.ShowAllVehiclesAsync(priceMin, priceMax, yearMin, yearMax, transmissionName, fuelName, horsePowerMin,horsePowerMax, locationTown,locationRegion,colorName);
            //ako vehicleTypeSection e != null post-a na Add
            return View(model);
        }

		[HttpPost]
		public async Task<IActionResult> ShowSelectedInformationForAllVehicles(string brandName)
		{
			try
			{
				return View(await this.vehicleService.SearchVehiclesAsync(brandName));
			}
			catch (ArgumentNullException) { return View(); }
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
        public async Task<IActionResult> VehicleFavourite()
        {
            var user = await userManager.GetUserAsync(User);
            try
            {
                return View(await vehicleService.VehicleFavouritesAsync(user));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
            }
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public async Task<IActionResult> FavouriteVehicle(Guid id)
        {
            var user = await userManager.FindByNameAsync(User.Identity?.Name);

            try
            {
                await this.vehicleService.FavouritesVehicleAsync(id, user);
            }
            catch (Exception)
            {
                TempData["message"] = "Book is already marked as favourite!";
            }
            return RedirectToAction("VehicleFavourite");
        }

        [HttpGet]
        public async Task<IActionResult> RemoveFromFavourites(Guid vehicleId)
        {
            User user = await userManager.GetUserAsync(User);

            try
            {
                await this.vehicleService.RemoveFromFavouritesAsync(vehicleId, user);
            }
            catch (ArgumentException ex)
            {
                ModelState.AddModelError("", ex.Message);
            }
            return RedirectToAction("VehicleFavourite");
		}

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            Vehicle vtt = await vehicleService.GetEditIsApproved(id);

            if (vtt != null)
            {
                EditIsApprovedViewModel viewModel = new EditIsApprovedViewModel()
                {
                    Id = vtt.Id,
                    IsApproved = vtt.IsVehicleApproved
                };
                return View("Edit", viewModel);
            }
            return RedirectToAction("ShowSelectedInformationForAllVehicles", "Vehicle");
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EditIsApprovedViewModel model)
        {
            if (ModelState.IsValid)
            {
                Vehicle vtt = await vehicleService.GetEditIsApproved(model.Id);

                if (vtt != null)
                {
                    vtt.IsVehicleApproved = model.IsApproved;
                    //vts.VehicleTypeSectionId = model.VehicleTypeSectionsId;

                    await vehicleService.EditIsApproved(vtt);

                    return RedirectToAction("ShowSelectedInformationForAllVehicles", "Vehicle");
                }
            }
            return View("Edit", model);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(
          [FromRoute]
            Guid id)
        {
            await vehicleService.DeleteVehicleAdminAsync(id);
            return RedirectToAction("ShowSelectedInformationForAllVehicles", "Vehicle");
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
		public IActionResult ByLocationTownAndLocationRegionFilter()
		{
			return View();
		}
	}
}

