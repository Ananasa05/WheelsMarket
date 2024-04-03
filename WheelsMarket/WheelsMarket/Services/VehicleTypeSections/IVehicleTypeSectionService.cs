using Microsoft.AspNetCore.Mvc.Rendering;
using WheelsMarket.Data.Models;
using WheelsMarket.Services.VehicleTypeSections.ViewModel;

namespace WheelsMarket.Services.VehicleTypeSections
{
    public interface IVehicleTypeSectionService
    {
        Task<List<AllVehicleTypeSectionViewModel>> ShowAllVehicleTypeSectionAsync();
        Task DeleteVehicleTypeSectionAsync(Guid id);
        Task<VehicleTypeSection> GetVehicleTypeSectionIdAsync(Guid id);
        Task EditVehicleTypeSectionAsync(VehicleTypeSection vts);
        Task AddVehicleTypeSectionAsync(AddVehicleTypeSectionViewModel add);



    }
}
