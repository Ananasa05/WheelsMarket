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
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(AddVehicleViewModel viewModel)
        {
            if (viewModel.BrandId != default(Guid) && viewModel.EditionId == default(Guid))
            {
                var a = this.vehicleService.AddVehicleEditionAsync(viewModel.BrandId);
                ViewBag.EditionId = a;
                ViewBag.BrandId = this.vehicleService.AddBrandAsync();
				return View(viewModel);
            }
            else
            {
				if (!ModelState.IsValid) { return View(viewModel); }
				await this.vehicleService.AddVehicleAsync(viewModel);
				return RedirectToAction("Index", "Home");
			}
            
            
        }
        //[HttpPost]
        //public async Task<IActionResult> Brand(SelectBrand viewModel)
        //{
        //    ViewBag.BrandId = this.vehicleService.AddBrandAsync();
        //    return View();
        //}


    }//edition prazni li sa, ako sa vzemi mi vs za segashniq brand i vurni view-to
}
