using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WheelsMarket.Data;
using WheelsMarket.Data.Models;
using WheelsMarket.Services.Brands.ViewModel;
using WheelsMarket.Services.Editions.ViewModel;
using WheelsMarket.Services.Vehicles.ViewModel;
using WheelsMarket.Services.VehicleTypeTypes.ViewModel;

namespace WheelsMarket.Services.Vehicles
{
    public class VehicleService : IVehicleService
    {

        private readonly ApplicationDbContext context;

        public VehicleService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public SelectList AddVehicleEditionAsync(Guid brandId)
        {
            return new SelectList(this.context.Editions.Where(x => x.BrandId == brandId), "Id", "Name");
        }

        public SelectList AddBrandAsync()
        {
            return new SelectList(this.context.Brands, "Id", "Name");
        }

        public async Task AddVehicleAsync(AddVehicleViewModel addVehicleViewModel)
        {
            Vehicle model = new Vehicle()
            {
                Id = Guid.NewGuid(),
                Color = addVehicleViewModel.Color,
                EditionId = addVehicleViewModel.EditionId
            };

            await this.context.Vehicles.AddAsync(model);
            await context.SaveChangesAsync();
        }



    }
}


