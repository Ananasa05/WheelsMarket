using Microsoft.AspNetCore.Mvc.Rendering;
using WheelsMarket.Data.Models;
using WheelsMarket.Services.Editions.ViewModel;
using WheelsMarket.Services.Vehicles.ViewModel;
using WheelsMarket.Services.VehicleTypeTypes.ViewModel;

namespace WheelsMarket.Services.Vehicles
{
    public interface IVehicleService
    {
        Task<IEnumerable<AllVehicleViewModel>> ShowAllVehiclesAsync(int? max, int? min, string? transName,string? fuel, string? editionId, string? brandId, string? typeTypeId, string? typeSectionId, string? year, string? location, string? color, int? hoursePowerMin, int? hoursePowerMax, string? locationRegion, string? locationTown);
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
		Task UpdateVehicleIsApproved(Vehicle vehicle);
		Task<Vehicle> GetVehicleIdAsync(Guid id);


		//Task<string?> ShowAllVehiclesAsync();//добавенето чрез visual studeio AI заради catch в поста на Index
	}
}
