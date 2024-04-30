using Microsoft.AspNetCore.Mvc;
using WheelsMarket.Services.VehicleTypeSections.ViewModel;
using WheelsMarket.Services.VehicleTypeSections;
using WheelsMarket.Services.VehicleTypeTypes;
using WheelsMarket.Services.VehicleTypeTypes.ViewModel;
using Microsoft.AspNetCore.Mvc.Rendering;
using WheelsMarket.Data;
using WheelsMarket.Data.Models;
using Microsoft.AspNetCore.Authorization;

namespace WheelsMarket.Controllers
{
    [Authorize(Roles = "Administrator")]
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
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Delete(
           [FromRoute]
            Guid id)
        {
            await vehicleTypeTypeService.DeleteVehicleTypeTypeAsync(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            VehicleTypeType vtt = await vehicleTypeTypeService.GetVehicleTypeTypeIdAsync(id);

            if (vtt != null)
            {
                EditVehicleTypeTypeViewModel viewModel = new EditVehicleTypeTypeViewModel()
                {
                    Id = vtt.Id,
                    Type = vtt.Type
                };
                return View("Edit", viewModel);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EditVehicleTypeTypeViewModel model)
        {
            if (ModelState.IsValid)
            {
                VehicleTypeType vtt = await vehicleTypeTypeService.GetVehicleTypeTypeIdAsync(model.Id);

                if (vtt != null)
                {
                    vtt.Type = model.Type;
                    //vts.VehicleTypeSectionId = model.VehicleTypeSectionsId;

                    await vehicleTypeTypeService.EditVehicleTypeTypeAsync(vtt);

                    return RedirectToAction("Index");
                }
            }
            return View("Edit", model);
        }
    }
}
