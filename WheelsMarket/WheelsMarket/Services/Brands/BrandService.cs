using WheelsMarket.Data.Models;
using WheelsMarket.Data;
using WheelsMarket.Services.VehicleTypeSections.ViewModel;
using WheelsMarket.Services.Brands.ViewModel;
using Microsoft.EntityFrameworkCore;

namespace WheelsMarket.Services.Brands
{
    public class BrandService:IBrandService
    {
        private readonly ApplicationDbContext context;

        public BrandService(ApplicationDbContext dbcontext)
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

        public async Task AddBrandAdminAsync(AddBrandViewModel addBrandViewModel)
        {
            var brand = new Brand()
            {
                Name = addBrandViewModel.Name
            };

            await context.Brands.AddAsync(brand);
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

        //public async Task AddBrandAsync(AddBrandViewModel addBrandViewModel)
        //{
        //    var brand = new Brand()
        //    {
        //        Name = addBrandViewModel.Name
        //    };

        //    await context.Brands.AddAsync(brand);
        //    await context.SaveChangesAsync();
        //}
    }
}
