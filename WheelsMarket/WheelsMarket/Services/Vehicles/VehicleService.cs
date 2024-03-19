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

		public async Task DeleteVehicleAdminAsync(Guid id)
		{
			var model = await this.context.Vehicles
				.FirstOrDefaultAsync(x => x.Id == id);


			if (model != null)
			{
				context.Vehicles.Remove(model);
				await context.SaveChangesAsync();
			}
			else
			{
				throw new ArgumentNullException();
			}
		}

        public async Task ByPriceFilter(int min, int max)
        {
            var model = await this.context.Vehicles.Where(x=>x.Price>min && x.Price<max).ToListAsync();
        }

        public async Task<AllVehicleViewModel> ShowAllInformationForVehicle(Guid id)
        {
            var model = await this.context.Vehicles
                 .Include(x => x.Edition)
                 .ThenInclude(x => x.Brand)
                .FirstOrDefaultAsync(x => x.Id == id);

            if (model != null)
            {
                var vehicle = new AllVehicleViewModel()
                {
                    Id = model.Id,
                    Distance = model.Distance,
                    Fuel = model.Fuel,
                    ImageURL = model.ImageURL,
                    Price = Convert.ToInt32( model.Price),
                    Volume = Convert.ToInt32(model.Volume),
                    Year = model.Year,
                    //EditionName = model.Edition,

                };

                return vehicle;
            }
            else
            {
                throw new ArgumentNullException();
            }
        }


        public async Task<IEnumerable<SelectedInformationForVehicle>> ShowAllVehiclesAsync()
		{
            var entities = await context.Vehicles.Include(vehicle => vehicle.Edition).ThenInclude(vehicle1=>vehicle1.Brand).ToListAsync();
            return entities
                .Select(b => new SelectedInformationForVehicle
                {
                    Id = b.Id,
                    Distance = b.Distance,
                    Fuel = b.Fuel,
                    ImageURL = b.ImageURL,
                    Price = Convert.ToInt32(b.Price),
                    Volume = Convert.ToInt32(b.Volume),
                    Year = b.Year,
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
                Distance = addVehicleViewModel.Distance,
                Fuel = addVehicleViewModel.Fuel,
                Condition = addVehicleViewModel.Condition,
                ImageURL = addVehicleViewModel.ImageURL,
                Price = addVehicleViewModel.Price,
                Volume = addVehicleViewModel.Volume,
                Year = addVehicleViewModel.Year,
				Тransmission = addVehicleViewModel.Тransmission,
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


