using Microsoft.AspNetCore.Mvc;
using WheelsMarket.Services.VehicleTypeTypes.ViewModel;
using WheelsMarket.Services.VehicleTypeTypes;
using WheelsMarket.Services.Editions;
using WheelsMarket.Services.Editions.ViewModel;

namespace WheelsMarket.Controllers
{
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
    }
}
