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

        public async Task<IEnumerable<AllVehicleViewModel>> ByPriceFilter(int min, int max)
        {
            IEnumerable<AllVehicleViewModel> model =
                await this.context.Vehicles.Where(x => x.Price >= min && x.Price <= max)
                .Select(b => new AllVehicleViewModel()
                {
                    Id = b.Id,
                    Distance = Convert.ToInt32(b.Distance),
                    Fuel = b.Fuel,
                    ImageURL = b.ImageURL,
                    Price = Convert.ToInt32(b.Price),
                    Volume = Convert.ToInt32(b.Volume),
                    Year = Convert.ToInt32(b.Year),
                    EditionName = b.Edition.Name,
                    BrandName = b.Edition.Brand.Name,
                })
                .ToListAsync();
            return model;
        }

        public async Task<IEnumerable<AllVehicleViewModel>> ByTransmisionFilter(string name)
        {
            IEnumerable<AllVehicleViewModel> model =
                await this.context.Vehicles.Where(x => x.Тransmission == name)
                .Select(b => new AllVehicleViewModel()
                {
                    Id = b.Id,
                    Distance = Convert.ToInt32(b.Distance),
                    Fuel = b.Fuel,
                    ImageURL = b.ImageURL,
                    Price = Convert.ToInt32(b.Price),
                    Volume = Convert.ToInt32(b.Volume),
                    Year = Convert.ToInt32(b.Year),
                    EditionName = b.Edition.Name,
                    BrandName = b.Edition.Brand.Name,
                })
                .ToListAsync();
            return model;
        }

        public async Task<AllVehicleViewModel> ShowAllInformationForVehicle(Guid id)
        {
            var model = await this.context.Vehicles
                 .Include(x => x.Edition)
                 .ThenInclude(x => x.Brand)
                 //.Include(x=>x.VehicleTypeType)
                 //.ThenInclude(x=>x.VehicleTypeSection)
                .FirstOrDefaultAsync(x => x.Id == id);

            if (model != null)
            {
                var vehicle = new AllVehicleViewModel()
                {
                    Id = model.Id,
                    Distance = Convert.ToInt32(model.Distance),//
                    Fuel = model.Fuel,//
                    Color = model.Color,//
                    Condition = model.Condition,//
                    ImageURL = model.ImageURL,//
                    Price = Convert.ToInt32(model.Price),//
                    Volume = Convert.ToInt32(model.Volume),//
                    Year = Convert.ToInt32(model.Year),//
                    Тransmission = model.Тransmission,//
                    EuroStandart = model.EuroStandard,//
                    //Location = model.Location,//
                    MoreInformation = model.MoreInformation,//
                    Currency = model.Currency,//
                    VinNumber = Convert.ToInt32(model.VinNumber),
                    HoursePower = Convert.ToInt32(model.HoursePower),
                    EditionName= model.Edition.Name,
                    BrandName= model.Edition.Brand.Name,
                    //TypeType = model.VehicleTypeType.Type,
                    //TypeSection = model.VehicleTypeType.VehicleTypeSection.Section
                };

                return vehicle;
            }
            else
            {
                throw new ArgumentNullException();
            }
        }


        public async Task<IEnumerable<AllVehicleViewModel>> ShowAllVehiclesAsync(int? min, int? max, string? transName,string? fuel,string? editionName,string? brandName,string? year, string? location, string? color, int? hoursePowerMin, int? hoursePowerMax, string? locationRegion, string? locationTown)
        {
            var entitiesDb = context.Vehicles.Include(x=>x.Edition).ThenInclude(b=>b.Brand).AsQueryable();

            if (min != null && max != null)
            {
                entitiesDb = entitiesDb.Where(x => x.Year >= min && x.Year <= max);
            }
            if (transName != null)
            {
                entitiesDb = entitiesDb.Where(x => x.Тransmission == transName);
            }
            if (fuel != null)
            {
                entitiesDb = entitiesDb.Where(x => x.Fuel== fuel);
            }
            if (brandName!=null&&editionName!=null)
            {
                var brand = await context.Brands.Where(x=>x.Name==brandName).FirstOrDefaultAsync();
                if (brand != null)
                {
                    var editionsFilterByBrand = context.Editions.Where(x => x.BrandId == brand.Id);

                    var editionsFilterByName = editionsFilterByBrand.Where(x=>x.Name==editionName).ToList();
                    entitiesDb = (IQueryable<Vehicle>)editionsFilterByName;
                }
            }
            if (color!=null)
            {
				entitiesDb = entitiesDb.Where(x => x.Color == color);
			}
            if (hoursePowerMin != null && hoursePowerMax != null)
            {
                entitiesDb = entitiesDb.Where(x => x.HoursePower >= hoursePowerMin && x.HoursePower <= hoursePowerMax);
            }
			if (locationRegion != null)
			{
				entitiesDb = entitiesDb.Where(x => x.LocationRegion == locationRegion);
			}
			if (locationTown!= null)
			{
				entitiesDb = entitiesDb.Where(x => x.LocationTown == locationTown);
			}

			var entities = await entitiesDb
                .ToListAsync();

            return entities
                .Select(b => new AllVehicleViewModel
                {
                    Id = b.Id,
                    Distance = Convert.ToInt32(b.Distance),
                    Fuel = b.Fuel,
                    ImageURL = b.ImageURL,
                    Price = Convert.ToInt32(b.Price),
                    Volume = Convert.ToInt32(b.Volume),
                    Year = Convert.ToInt32(b.Year),
                    EditionName = b.Edition.Name,
                    BrandName = b.Edition.Brand.Name,
                });
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
                EuroStandard = addVehicleViewModel.EuroStandart,
                VinNumber=addVehicleViewModel.VinNumber,
                MoreInformation = addVehicleViewModel.MoreInformation,
                HoursePower=addVehicleViewModel.HoursePower,
                LocationRegion = addVehicleViewModel.LocationRegion,
                LocationTown = addVehicleViewModel.LocationTown,
                Currency=addVehicleViewModel.Currency,
                EditionId = addVehicleViewModel.EditionId,
                //VehicleTypeTypeId = addVehicleViewModel.VehicleTypeTypeId
            };

            await this.context.Vehicles.AddAsync(model);
            await context.SaveChangesAsync();
        }//modify this code so specific vehicle to be to specific person

		public async Task FavouritesVehicleAsync(Guid id, User user)
		{
			Vehicle vehicle = await this.context.Vehicles.FindAsync(id);

			if (vehicle != null && user != null)
			{
				Favourite vehicle1 = new Favourite()
				{
					Vehicle = vehicle,
					User = user
				};
				await this.context.Favourites.AddAsync(vehicle1);
				await this.context.SaveChangesAsync();
			}
		}

        public async Task<IEnumerable<AllVehicleViewModel>> VehicleFavouritesAsync(User user)
        {
            User? userWithVehicle = await context.Users
                .Where(u => u.Id == user.Id)
                .Include(u => u.Favourites)
                .ThenInclude(v => v.Vehicle)
                .ThenInclude(e => e.Edition)
                .ThenInclude(b => b.Brand)
                .ThenInclude(v => v.VehicleTypeType)
                .ThenInclude(v => v.VehicleTypeSection)
                .FirstOrDefaultAsync();

            if (userWithVehicle.Favourites != null)
            {
                var vehicles = userWithVehicle.Favourites
                     .Select(v => new AllVehicleViewModel()
                     {
                         Id = v.Vehicle.Id,
                         Color = v.Vehicle.Color,
                         Distance = v.Vehicle.Distance,
                         Fuel = v.Vehicle.Fuel,
                         Condition = v.Vehicle.Condition,
                         ImageURL = v.Vehicle.ImageURL,
                         Price = v.Vehicle.Price,
                         Volume = v.Vehicle.Volume,
                         Year = v.Vehicle.Year,
                         Тransmission = v.Vehicle.Тransmission,
                         EuroStandart = v.Vehicle.EuroStandard,
                         VinNumber = v.Vehicle.VinNumber,
                         HoursePower = v.Vehicle.HoursePower,
                         LocationRegion = v.Vehicle.LocationRegion,
                         LocationTown = v.Vehicle.LocationTown,
                         MoreInformation = v.Vehicle.MoreInformation,
                         Currency = v.Vehicle.Currency,
                         EditionName = v.Vehicle.Edition.Name,
                         BrandName = v.Vehicle.Edition.Brand.Name,
                         TypeType = v.Vehicle.Edition.Brand.VehicleTypeType.Type,
                         TypeSection = v.Vehicle.Edition.Brand.VehicleTypeType.VehicleTypeSection.Section,
                     });
                return vehicles;
            }
            throw new NullReferenceException();
        }
        
        public async Task RemoveFromFavouritesAsync(Guid vehicleId, User user)
        {
            var favourite = await this.context.Favourites.Include(f => f.Vehicle)
                .Include(f => f.User)
                .Where(favourite => favourite.VehicleId == vehicleId && favourite.User == user)
                .FirstOrDefaultAsync();

            if (favourite != null)
            {
                this.context.Favourites.Remove(favourite);
                await this.context.SaveChangesAsync();
            }
            else
            {
                throw new ArgumentException();
            }
        }



        public SelectList AddVehicleTypeTypeAsync(Guid typeSectionId)
        {
            return new SelectList(this.context.VehicleTypeTypes.Where(x => x.VehicleTypeSectionId == typeSectionId), "Id", "Type");
        }

        public SelectList AddVehicleTypeSectionAsync()
        {
            return new SelectList(this.context.VehicleTypeSections, "Id", "Section");
        }

		public SelectList AddBrandAsync(Guid typeTypeId)
		{
			return new SelectList(this.context.Brands.Where(x=>x.VehicleTypeTypeId==typeTypeId), "Id", "Name");
		}

		public SelectList AddVehicleEditionAsync(Guid brandId)
		{
			return new SelectList(this.context.Editions.Where(x => x.BrandId == brandId), "Id", "Name");
		}
      
    }
}


