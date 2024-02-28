using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WheelsMarket.Data;
using WheelsMarket.Data.Models;
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

        //public async Task<IEnumerable<AllVehicleViewModel>> ShowAllVehicleAsync()
        //{
        //    var entities = await context.Vehicles.Include(editions => editions.).ThenInclude(type => type.).ToListAsync();
        //    return entities
        //        .Select(b => new AllEditionViewModel
        //        {
        //            Id = b.Id,
        //            Name = b.Name,
        //            BrandName = b.Brand.Name,
        //        });
        //}

        public SelectList AddVehicleEditionAsync()
        {
            return new SelectList(this.context.Editions, "Id", "Name");
        } 
        public SelectList AddVehicleTypeAsync()
        {
            return new SelectList(this.context.VehicleTypeTypes, "Id", "Type");
        }
        public async Task AddVehicleAsync(AddVehicleViewModel addVehicleViewModel,User user)
        {
            Vehicle model = new Vehicle()
            {
                Id = Guid.NewGuid(),
                Color = addVehicleViewModel.Color,
                Distance = addVehicleViewModel.Distance,
                Fuel = addVehicleViewModel.Fuel,
                Condition = addVehicleViewModel.Condition,
                VehicleTypeTypeId = addVehicleViewModel.VehicleTypeTypeId,
                EditionId = addVehicleViewModel.EditionId,
                UserId = user.Id,
            };

            await this.context.Vehicles.AddAsync(model);
            await context.SaveChangesAsync();
        }
    }
}


