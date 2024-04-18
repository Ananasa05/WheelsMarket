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

        private readonly WheelsMarketDbContext context;

        public VehicleService(WheelsMarketDbContext context)
        {
            this.context = context;
        }
        public async Task<Vehicle> GetEditIsApproved(Guid id)
        {
            return await context.Vehicles.FindAsync(id);
        }

        public async Task EditIsApproved(Vehicle vehicle)
        {
            context.Update(vehicle);
            await context.SaveChangesAsync();
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

        public async Task<AllVehicleViewModel> ShowAllInformationForVehicle(Guid id)
        {
            var model = await this.context.Vehicles
                 .Include(x => x.Edition)
                 .ThenInclude(x => x.Brand)
                 //.Include(x=>x.VehicleTypeType)
                 //.ThenInclude(x=>x.VehicleTypeSection)
                .FirstOrDefaultAsync(x => x.Id == id);

            var vehicleId = await this.context.Vehicles
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync();

            var model2 = await this.context.User
                .Where(x=>x.Id==vehicleId.UserId)
                .FirstOrDefaultAsync();

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
                    MoreInformation = model.MoreInformation,//
                    Currency = model.Currency,//
                    VinNumber = Convert.ToInt32(model.VinNumber),
                    HoursePower = Convert.ToInt32(model.HoursePower),
                    LocationRegion = model.LocationRegion,
                    LocationTown = model.LocationTown,
                    EditionName= model.Edition.Name,
                    BrandName= model.Edition.Brand.Name,
                    
                    UserFirstName = model2.FirstName,
                    UserLastName = model2.LastName,
                    PhoneNumber = model2.PhoneNumber
                };

                return vehicle;
            }
            else
            {
                throw new ArgumentNullException();
            }
        }


        public async Task<IEnumerable<AllVehicleViewModel>> ShowAllVehiclesAsync(string? condition, int? priceMin, int? priceMax, int? yearMin, int? yearMax, string? transmissionName, string? fuelName, int? horsePowerMin, int? horsePowerMax, string? locationTown, string? locationRegion, string? colorName)
        {
            var entitiesDb = context.Vehicles.Include(x=>x.Edition).ThenInclude(b=>b.Brand)./*Where(x=>x.IsVehicleApproved==fal)*/AsQueryable();

            if (yearMin != null && yearMax != null)
            {
                entitiesDb = entitiesDb.Where(x => x.Year >= yearMin && x.Year <= yearMax);
            }
            if (priceMin!= null && priceMax != null)
            {
                entitiesDb = entitiesDb.Where(x => x.Price >= priceMin&& x.Price <= priceMax);
            }
            if (transmissionName != null)
            {
                entitiesDb = entitiesDb.Where(x => x.Тransmission == transmissionName);
            }
            if (fuelName != null)
            {
                entitiesDb = entitiesDb.Where(x => x.Fuel== fuelName);
            }
            if (colorName!=null)
            {
				entitiesDb = entitiesDb.Where(x => x.Color == colorName);
			}
            if (horsePowerMin != null && horsePowerMax!= null)
            {
                entitiesDb = entitiesDb.Where(x => x.HoursePower >= horsePowerMin && x.HoursePower <= horsePowerMax);
            }
			if (locationRegion != null&&locationTown!=null)
			{
				entitiesDb = entitiesDb.Where(x => x.LocationRegion == locationRegion&&x.LocationTown==locationTown);
			}
			if (condition != null)
			{
				entitiesDb = entitiesDb.Where(x => x.Condition== condition);
			}

			var entities = await entitiesDb
                .ToListAsync();

            return entities
                .Select(b => new AllVehicleViewModel
                {
                    Id = b.Id,
                    Distance = Convert.ToInt32(b.Distance),
                    Fuel = b.Fuel,
                    LocationTown = b.LocationTown,
                    LocationRegion = b.LocationRegion,
                    ImageURL = b.ImageURL,
                    Price = Convert.ToInt32(b.Price),
                    Volume = Convert.ToInt32(b.Volume),
                    Year = Convert.ToInt32(b.Year),
                    IsApproved = b.IsVehicleApproved,
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
                IsVehicleApproved = addVehicleViewModel.IsApproved,
                UserId = addVehicleViewModel.UserId
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

        public async Task<Vehicle> GetVehicleId(Guid id)
        {
            return await context.Vehicles.FindAsync(id);
        }
        public async Task EditVehicleAsync(Vehicle vehicle)
        {
            context.Update(vehicle);
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

		public SelectList AddBrandAsync(Guid typeTypeId)
		{
			return new SelectList(this.context.Brands.Where(x=>x.VehicleTypeTypeId==typeTypeId), "Id", "Name");
		}

		public SelectList AddVehicleEditionAsync(Guid brandId)
		{
			return new SelectList(this.context.Editions.Where(x => x.BrandId == brandId), "Id", "Name");
		}

        public async Task<IEnumerable<AllVehicleViewModel>> SearchVehiclesAsync(string brandsName)
        {
            if (String.IsNullOrEmpty(brandsName))
            {
                throw new ArgumentNullException();
            }
            else
            {
                var brandIds = await this.context.Brands
                    .Where(brand => brand.Name == brandsName)
                    .Select(brand => brand.Id)
                    .ToListAsync();

                var vehicles = await this.context.Vehicles.Include(x=>x.Edition)
                    .ThenInclude(x=>x.Brand)
                    .ThenInclude(x=>x.VehicleTypeType)
                    .ThenInclude(x=>x.VehicleTypeSection)
                    .Where(vehicle => brandIds.Contains(
                        this.context.Editions
                            .Where(edition => edition.Id == vehicle.EditionId)
                            .Select(edition => edition.BrandId)
                            .FirstOrDefault()
                    ))
                    .ToListAsync();



                return vehicles.Select(v => new AllVehicleViewModel
                {
                    Id = v.Id,
                    Color = v.Color,
                    Distance = v.Distance,
                    Fuel = v.Fuel,
                    Condition = v.Condition,
                    ImageURL = v.ImageURL,
                    Price = v.Price,
                    Volume = v.Volume,
                    Year = v.Year,
                    Тransmission = v.Тransmission,
                    EuroStandart = v.EuroStandard,
                    VinNumber = v.VinNumber,
                    HoursePower = v.HoursePower,
                    LocationRegion = v.LocationRegion,
                    LocationTown = v.LocationTown,
                    MoreInformation = v.MoreInformation,
                    Currency = v.Currency,
                    EditionName = v.Edition.Name,
                    BrandName = v.Edition.Brand.Name,
                    TypeType = v.Edition.Brand.VehicleTypeType.Type,
                    TypeSection = v.Edition.Brand.VehicleTypeType.VehicleTypeSection.Section,
                });
            }
        }

	}
}


