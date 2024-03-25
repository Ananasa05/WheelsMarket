using Microsoft.AspNetCore.Mvc.Rendering;
using WheelsMarket.Data.Models;
using WheelsMarket.Services.Editions.ViewModel;
using WheelsMarket.Services.Vehicles.ViewModel;
using WheelsMarket.Services.VehicleTypeTypes.ViewModel;

namespace WheelsMarket.Services.Vehicles
{
    public interface IVehicleService
    {
        Task<IEnumerable<AllVehicleViewModel>> ShowAllVehiclesAsync(int? max, int? min, string? transName,string? fuel,string? editionName,string? brandName, string? year, string? location, string? color, int? hoursePowerMin, int? hoursePowerMax);
        Task<AllVehicleViewModel> ShowAllInformationForVehicle(Guid id);
		Task DeleteVehicleAdminAsync(Guid id);
		Task<IEnumerable<AllVehicleViewModel>> ByPriceFilter(int min,int max);
		Task<IEnumerable<AllVehicleViewModel>> ByTransmisionFilter(string name);
        Task AddVehicleAsync(AddVehicleViewModel add);
        SelectList AddVehicleEditionAsync(Guid brandId);
        SelectList AddBrandAsync();
        SelectList AddVehicleTypeTypeAsync(Guid brandId);
        SelectList AddVehicleTypeSectionAsync();
    }
}
