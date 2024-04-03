using Microsoft.AspNetCore.Mvc.Rendering;
using WheelsMarket.Data.Models;
using WheelsMarket.Services.Editions.ViewModel;
using WheelsMarket.Services.VehicleTypeTypes.ViewModel;

namespace WheelsMarket.Services.Editions
{
    public interface IEditionService
    {
        Task AddEditionAsync(AddEditionViewModel add);
        SelectList AddEditionAsync();
        Task DeleteEditionAsync(Guid id);//
        Task<IEnumerable<AllEditionViewModel>> ShowAllEditionAsync();
        Task<Edition> GetEditionIdAsync(Guid id);
        Task EditEditionAsync(Edition edition);
    }
}
