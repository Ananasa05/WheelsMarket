using Microsoft.AspNetCore.Mvc.Rendering;
using WheelsMarket.Data.Models;
using WheelsMarket.Services.Editions.ViewModel;
using WheelsMarket.Services.Vehicles.ViewModel;
using WheelsMarket.Services.VehicleTypeTypes.ViewModel;

namespace WheelsMarket.Services.Vehicles
{
    public interface IVehicleService
    {
        //Task<IEnumerable<AllVehicleViewModel>> ShowAllVehicleAsync();

        Task AddVehicleAsync(AddVehicleViewModel add,User user);
        SelectList AddVehicleEditionAsync();
        SelectList AddVehicleTypeAsync();

    }
}
