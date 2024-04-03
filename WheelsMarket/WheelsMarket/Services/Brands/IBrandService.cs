using Microsoft.AspNetCore.Mvc.Rendering;
using WheelsMarket.Data.Models;
using WheelsMarket.Services.Brands.ViewModel;
using WheelsMarket.Services.VehicleTypeSections.ViewModel;
using WheelsMarket.Services.VehicleTypeTypes.ViewModel;

namespace WheelsMarket.Services.Brands
{
    public interface IBrandService
    {
        Task<List<AllBrandViewModel>> ShowAllBrandAsync();
        Task DeleteBrandAdminAsync(Guid id);
        //Task AddBrandAdminAsync(AddBrandViewModel add);
        //Task AddBrandAsync(AddBrandViewModel add);

        Task AddBrandAdminAsync(AddBrandViewModel add);
        SelectList AddBrandAdminAsync();
        Task<Brand> GetBrandIdAsync(Guid id);
        Task EditBrandAsync(Brand vts);

    }
}
