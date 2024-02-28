using WheelsMarket.Services.Brands.ViewModel;
using WheelsMarket.Services.VehicleTypeSections.ViewModel;

namespace WheelsMarket.Services.Brands
{
    public interface IBrandService
    {
        Task<List<AllBrandViewModel>> ShowAllBrandAsync();
        Task DeleteBrandAdminAsync(Guid id);
        Task AddBrandAdminAsync(AddBrandViewModel add);
        //Task AddBrandAsync(AddBrandViewModel add);
    }
}
