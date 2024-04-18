using Microsoft.AspNetCore.Mvc;
using WheelsMarket.Services.VehicleTypeSections.ViewModel;
using WheelsMarket.Services.VehicleTypeSections;
using WheelsMarket.Services.Brands;
using WheelsMarket.Services.Brands.ViewModel;
using WheelsMarket.Data.Models;
using WheelsMarket.Services.VehicleTypeTypes.ViewModel;
using WheelsMarket.Services.VehicleTypeTypes;
using Microsoft.AspNetCore.Authorization;

namespace WheelsMarket.Controllers
{
    [Authorize(Roles = "Administrator")]
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

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            Brand brand = await brandService.GetBrandIdAsync(id);

            if (brand != null)
            {
                EditBrandViewModel viewModel = new EditBrandViewModel()
                {
                    Id = brand.Id,
                    Name = brand.Name
                };
                return View("Edit", viewModel);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EditBrandViewModel model)
        {
            if (ModelState.IsValid)
            {
                Brand brand = await brandService.GetBrandIdAsync(model.Id);

                if (brand != null)
                {
                    brand.Name = model.Name;

                    await brandService.EditBrandAsync(brand);

                    return RedirectToAction("Index");
                }
            }
            return View("Edit", model);
        }
    }
}
