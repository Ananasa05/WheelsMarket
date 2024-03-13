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

		public async Task<IEnumerable<AllVehicleViewModel>> ShowAllVehiclesAsync()
		{
            var entities = await context.Vehicles.Include(vehicle => vehicle.Edition).ThenInclude(vehicle1=>vehicle1.Brand).ToListAsync();
            return entities
                .Select(b => new AllVehicleViewModel
                {
                    Id = b.Id,
                    Color = b.Color,
                    Distance= b.Distance,
                    Fuel = b.Fuel,
                    EditionName = b.Edition.Name,
                    BrandName = b.Edition.Brand.Name,
                });
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
                EditionId = addVehicleViewModel.EditionId,
                VehicleTypeTypeId = addVehicleViewModel.VehicleTypeTypeId
            };

            await this.context.Vehicles.AddAsync(model);
            await context.SaveChangesAsync();
        }
        public SelectList AddVehicleTypeTypeAsync(Guid typeSectionId)
        {
            return new SelectList(this.context.VehicleTypeTypes.Where(x => x.VehicleTypeSectionId == typeSectionId), "Id", "Type");
        }

        public SelectList AddVehicleTypeSectionAsync()
        {
            return new SelectList(this.context.VehicleTypeSections, "Id", "Section");
        }


    }
}


