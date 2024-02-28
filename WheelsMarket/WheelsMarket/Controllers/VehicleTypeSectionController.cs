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
            var vehicleType = new AddVehicleTypeSectionViewModel()
            {
                Section = model.Section,
            };

            await vehicleTypeSectionService.AddVehicleTypeSectionAsync(vehicleType);
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
