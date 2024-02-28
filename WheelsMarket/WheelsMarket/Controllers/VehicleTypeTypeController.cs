using Microsoft.AspNetCore.Mvc;
using WheelsMarket.Services.VehicleTypeSections.ViewModel;
using WheelsMarket.Services.VehicleTypeSections;
using WheelsMarket.Services.VehicleTypeTypes;
using WheelsMarket.Services.VehicleTypeTypes.ViewModel;
using Microsoft.AspNetCore.Mvc.Rendering;
using WheelsMarket.Data;

namespace WheelsMarket.Controllers
{
    public class VehicleTypeTypeController:Controller
    {
        private readonly IVehicleTypeTypeService vehicleTypeTypeService;

        public VehicleTypeTypeController(IVehicleTypeTypeService vehicleTypeTypeService)
        {
            this.vehicleTypeTypeService = vehicleTypeTypeService;
        }

        public async Task<IActionResult> Index()
        {
            var model = await vehicleTypeTypeService.ShowAllVehicleTypeTypeAsync();

            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.VehicleTypeSectionId = this.vehicleTypeTypeService.AddVehicleTypeTypeAsync();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(AddVehicleTypeTypeViewModel viewModel)
        {
            if (!ModelState.IsValid) { return View(viewModel); }
            await this.vehicleTypeTypeService.AddVehicleTypeTypeAsync(viewModel);
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public async Task<IActionResult> Delete(
           [FromRoute]
            Guid id)
        {
            await vehicleTypeTypeService.DeleteVehicleTypeTypeAsync(id);
            return RedirectToAction("Index");
        }


    }
}
