using Microsoft.AspNetCore.Mvc.Rendering;
using WheelsMarket.Data.Models;
using WheelsMarket.Services.Editions.ViewModel;
using WheelsMarket.Services.Vehicles.ViewModel;
using WheelsMarket.Services.VehicleTypeTypes.ViewModel;

namespace WheelsMarket.Services.Vehicles
{
    public interface IVehicleService
    {
        Task<IEnumerable<AllVehicleViewModel>> ShowAllVehiclesAsync(int? priceMin, int? priceMax, int? yearMin, int? yearMax, string? transmissionName, string? fuelName, int? horsePowerMin, int? horsePowerMax, string? locationTown, string? locationRegion, string? colorName);
        Task<AllVehicleViewModel> ShowAllInformationForVehicle(Guid id);
		Task DeleteVehicleAdminAsync(Guid id);
		//Task<IEnumerable<AllVehicleViewModel>> ByPriceFilter(int min,int max);
		//Task<IEnumerable<AllVehicleViewModel>> ByTransmisionFilter(string name);
        Task AddVehicleAsync(AddVehicleViewModel add);
        SelectList AddVehicleEditionAsync(Guid brandId);
        SelectList AddBrandAsync(Guid typeTypeId);
        SelectList AddVehicleTypeTypeAsync(Guid typeSectionId);
        SelectList AddVehicleTypeSectionAsync();
		Task FavouritesVehicleAsync(Guid id, User user);
		Task<IEnumerable<AllVehicleViewModel>> VehicleFavouritesAsync(User user);
        Task RemoveFromFavouritesAsync(Guid vehicleId, User user);
        Task<IEnumerable<AllVehicleViewModel>> SearchVehiclesAsync(string brandsName);
        Task<Vehicle> GetEditIsApproved(Guid id);
        Task EditIsApproved(Vehicle vehicle);


        //Task<string?> ShowAllVehiclesAsync();//добавенето чрез visual studeio AI заради catch в поста на Index
    }
}
