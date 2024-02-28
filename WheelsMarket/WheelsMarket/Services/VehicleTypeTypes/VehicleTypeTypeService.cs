using Microsoft.AspNetCore.Mvc;
using WheelsMarket.Data.Models;
using WheelsMarket.Data;
using WheelsMarket.Services.VehicleTypeSections.ViewModel;
using WheelsMarket.Services.VehicleTypeTypes.ViewModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WheelsMarket.Services.VehicleTypeTypes
{
    public class VehicleTypeTypeService:IVehicleTypeTypeService
    {
        private readonly ApplicationDbContext context;

        public VehicleTypeTypeService(ApplicationDbContext dbcontext)
        {
            this.context = dbcontext;
        }

        public async Task<IEnumerable<AllVehicleTypeTypeViewModel>> ShowAllVehicleTypeTypeAsync()
        {
            var model = await this.context.VehicleTypeTypes
                .Select(a => new AllVehicleTypeTypeViewModel()
                {
                    Id = a.Id,
                    Type = a.Type,
                    VehicleTypeSectionName = a.VehicleTypeSection.Section

                })
                .ToListAsync();

            return model;
        }

        public SelectList AddVehicleTypeTypeAsync()
        {
            return new SelectList(this.context.VehicleTypeSections, "Id", "Section");
        }
        public async Task AddVehicleTypeTypeAsync(AddVehicleTypeTypeViewModel addVehicleTypesViewModel)
        {
            VehicleTypeType model = new VehicleTypeType()
            {
                Id = Guid.NewGuid(),
                Type = addVehicleTypesViewModel.Type,
                VehicleTypeSectionId = addVehicleTypesViewModel.VehicleTypeSectionId
            };
            await this.context.VehicleTypeTypes.AddAsync(model);
            await context.SaveChangesAsync();
        }

        public async Task DeleteVehicleTypeTypeAsync(Guid id)
        {
            var model = await this.context.VehicleTypeTypes
                .FirstOrDefaultAsync(x => x.Id == id);


            if (model != null)
            {
                context.VehicleTypeTypes.Remove(model);
                await context.SaveChangesAsync();
            }
            else
            {
                throw new ArgumentNullException();
            }
        }

    }
}
