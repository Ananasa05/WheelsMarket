using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WheelsMarket.Data.Models;
using WheelsMarket.Services.VehicleTypeSections;
using WheelsMarket.Services.VehicleTypeSections.ViewModel;

namespace WheelsMarket.Controllers
{
    [Authorize(Roles = "Administrator")]
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

		[HttpGet]
		public async Task<IActionResult> Edit(Guid id)
		{
		    VehicleTypeSection vts = await vehicleTypeSectionService.GetVehicleTypeSectionIdAsync(id);

			if (vts != null)
			{
				EditVehicleTypeSectionViewModel viewModel = new EditVehicleTypeSectionViewModel()
				{
					Id = vts.Id,
					Section = vts.Section,
				};
				return View("Edit", viewModel);
			}
			return RedirectToAction("Index");
		}

		[HttpPost]
		public async Task<IActionResult> Edit(EditVehicleTypeSectionViewModel model)
		{
			if (ModelState.IsValid)
			{
				VehicleTypeSection vts = await vehicleTypeSectionService.GetVehicleTypeSectionIdAsync(model.Id);

				if (vts != null)
				{
					vts.Section= model.Section;

					await vehicleTypeSectionService.EditVehicleTypeSectionAsync(vts);

					return RedirectToAction("Index");
				}
			}
			return View("Edit", model);
		}

	}
}
