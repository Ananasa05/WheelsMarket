using Microsoft.AspNetCore.Mvc.Rendering;
using WheelsMarket.Data.Models;
using WheelsMarket.Services.VehicleTypeSections.ViewModel;
using WheelsMarket.Services.VehicleTypeTypes.ViewModel;

namespace WheelsMarket.Services.VehicleTypeTypes
{
    public interface IVehicleTypeTypeService
    {
        Task AddVehicleTypeTypeAsync(AddVehicleTypeTypeViewModel add);
        SelectList AddVehicleTypeTypeAsync();
        Task DeleteVehicleTypeTypeAsync(Guid id);//
        Task<IEnumerable<AllVehicleTypeTypeViewModel>> ShowAllVehicleTypeTypeAsync();
        Task<VehicleTypeType> GetVehicleTypeTypeIdAsync(Guid id);
        Task EditVehicleTypeTypeAsync(VehicleTypeType vts);

    }
}
