using Microsoft.AspNetCore.Mvc;
using WheelsMarket.Services.VehicleTypeSections;
using WheelsMarket.Services.VehicleTypeSections.ViewModel;

namespace WheelsMarket.Controllers
{
    public class VehicleTypeSectionController:Controller
    {
        private readonly IVehicleTypeSectionService vehicleTypeSectionService;

        public VehicleTypeSectionController(IVehicleTypeSectionService vehicleTypeSectionService)
        {
            this.vehicleTypeSectionService = vehicleTypeSectionService;
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}

        public async Task<IActionResult> Index()
        {
            var model = await vehicleTypeSectionService.ShowAllVehicleTypeSectionAsync();

            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(AddVehicleTypeSectionViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            await vehicleTypeSectionService.AddVehicleTypeSectionAsync(model);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public async Task<IActionResult> Delete(
            [FromRoute]
            Guid id)
        {
            await vehicleTypeSectionService.DeleteVehicleTypeSectionAsync(id);
            return RedirectToAction("Index");
        }

    }
}
