using WheelsMarket.Data.Models;
using WheelsMarket.Data;
using WheelsMarket.Services.VehicleTypeSections.ViewModel;
using WheelsMarket.Services.Brands.ViewModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using WheelsMarket.Services.VehicleTypeTypes.ViewModel;

namespace WheelsMarket.Services.Brands
{
    public class BrandService:IBrandService
    {
        private readonly WheelsMarketDbContext context;

        public BrandService(WheelsMarketDbContext dbcontext)
        {
            this.context = dbcontext;
        }

        public async Task<List<AllBrandViewModel>> ShowAllBrandAsync()
        {
            var model = await this.context.Brands
                .Select(a => new AllBrandViewModel()
                {
                    Id = a.Id,
                    Name = a.Name,
                })
                .ToListAsync();

            return model;
        }

        //public async Task AddBrandAdminAsync(AddBrandViewModel addBrandViewModel)
        //{
        //    var brand = new Brand()
        //    {
        //        Name = addBrandViewModel.Name,
        //        VehicleTypeTypeId = addBrandViewModel.VehicleTypeTypeId,
        //    };

        //    await context.Brands.AddAsync(brand);
        //    await context.SaveChangesAsync();
        //}

        public SelectList AddBrandAdminAsync()
        {
            return new SelectList(this.context.VehicleTypeTypes, "Id", "Type");
        }
        public async Task AddBrandAdminAsync(AddBrandViewModel addBrandViewModel)
        {
            Brand model = new Brand()
            {
                Id = Guid.NewGuid(),
                Name = addBrandViewModel.Name,
                VehicleTypeTypeId = addBrandViewModel.VehicleTypeTypeId
            };
            await this.context.Brands.AddAsync(model);
            await context.SaveChangesAsync();
        }


        public async Task DeleteBrandAdminAsync(Guid id)
        {
            var model = await this.context.Brands
                .FirstOrDefaultAsync(x => x.Id == id);


            if (model != null)
            {
                context.Brands.Remove(model);
                await context.SaveChangesAsync();
            }
            else
            {
                throw new ArgumentNullException();
            }
        }

        public async Task<Brand> GetBrandIdAsync(Guid id)
        {
            return await context.Brands.FindAsync(id);
        }

        public async Task EditBrandAsync(Brand vts)
        {
            context.Update(vts);
            await context.SaveChangesAsync();
        }
    }
}
