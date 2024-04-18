using Microsoft.AspNetCore.Mvc;
using WheelsMarket.Services.VehicleTypeTypes.ViewModel;
using WheelsMarket.Services.VehicleTypeTypes;
using WheelsMarket.Services.Editions;
using WheelsMarket.Services.Editions.ViewModel;
using WheelsMarket.Data.Models;
using WheelsMarket.Services.Brands.ViewModel;
using WheelsMarket.Services.Brands;
using Microsoft.AspNetCore.Authorization;

namespace WheelsMarket.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class EditionController:Controller
    {
        private readonly IEditionService editionService;

        public EditionController(IEditionService editionService)
        {
            this.editionService = editionService;
        }

        public async Task<IActionResult> Index()
        {
            var model = await editionService.ShowAllEditionAsync();
            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.BrandId = this.editionService.AddEditionAsync();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(AddEditionViewModel viewModel)
        {
            if (!ModelState.IsValid) { return View(viewModel); }
            await this.editionService.AddEditionAsync(viewModel);
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public async Task<IActionResult> Delete(
           [FromRoute]
            Guid id)
        {
            await editionService.DeleteEditionAsync(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            Edition ediiton = await editionService.GetEditionIdAsync(id);

            if (ediiton != null)
            {
                EditEditionViewModel viewModel = new EditEditionViewModel()
                {
                    Id = ediiton.Id,
                    Name = ediiton.Name
                };
                return View("Edit", viewModel);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EditEditionViewModel model)
        {
            if (ModelState.IsValid)
            {
                Edition edition = await editionService.GetEditionIdAsync(model.Id);

                if (edition != null)
                {
                    edition.Name = model.Name;

                    await editionService.EditEditionAsync(edition);

                    return RedirectToAction("Index");
                }
            }
            return View("Edit", model);
        }
    }
}
