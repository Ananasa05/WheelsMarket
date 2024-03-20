using Microsoft.AspNetCore.Mvc.Rendering;
using WheelsMarket.Data.Models;
using WheelsMarket.Services.Editions.ViewModel;
using WheelsMarket.Services.Vehicles.ViewModel;
using WheelsMarket.Services.VehicleTypeTypes.ViewModel;

namespace WheelsMarket.Services.Vehicles
{
    public interface IVehicleService
    {
        Task<IEnumerable<SelectedInformationForVehicle>> ShowAllVehiclesAsync();
        Task<AllVehicleViewModel> ShowAllInformationForVehicle(Guid id);
		Task DeleteVehicleAdminAsync(Guid id);
		Task<IEnumerable<SelectedInformationForVehicle>> ByPriceFilter(int min,int max);

		Task AddVehicleAsync(AddVehicleViewModel add);
        SelectList AddVehicleEditionAsync(Guid brandId);
        SelectList AddBrandAsync();
        SelectList AddVehicleTypeTypeAsync(Guid brandId);
        SelectList AddVehicleTypeSectionAsync();
    }
}
