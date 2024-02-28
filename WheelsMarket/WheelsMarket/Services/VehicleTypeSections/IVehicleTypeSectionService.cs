using Microsoft.AspNetCore.Mvc.Rendering;
using WheelsMarket.Services.VehicleTypeSections.ViewModel;

namespace WheelsMarket.Services.VehicleTypeSections
{
    public interface IVehicleTypeSectionService
    {
        Task<List<AllVehicleTypeSectionViewModel>> ShowAllVehicleTypeSectionAsync();
        Task DeleteVehicleTypeSectionAsync(Guid id);
        Task AddVehicleTypeSectionAsync(AddVehicleTypeSectionViewModel add);



    }
}
