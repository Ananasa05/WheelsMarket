using Microsoft.AspNetCore.Mvc;
using WheelsMarket.Services.VehicleTypeSections.ViewModel;
using WheelsMarket.Services.VehicleTypeSections;
using WheelsMarket.Services.Brands;
using WheelsMarket.Services.Brands.ViewModel;

namespace WheelsMarket.Controllers
{
    public class BrandController:Controller
    {
        private readonly IBrandService brandService;

        public BrandController(IBrandService brandService)
        {
            this.brandService = brandService;
        }

        public async Task<IActionResult> Index()
        {
            var model = await brandService.ShowAllBrandAsync();

            return View(model);
        }

        [HttpGet] 
        public IActionResult Create()
        {
            ViewBag.VehicleTypeTypeId = this.brandService.AddBrandAdminAsync();

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(AddBrandViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            await brandService.AddBrandAdminAsync(model);
            return RedirectToAction("Index");
        }




        [HttpGet]
        public async Task<IActionResult> Delete(
            [FromRoute]
            Guid id)
        {
            await brandService.DeleteBrandAdminAsync(id);
            return RedirectToAction("Index");
        }

    }
}
