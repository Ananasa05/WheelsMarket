using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WheelsMarket.Data;
using WheelsMarket.Data.Models;
using WheelsMarket.Services.VehicleTypeSections.ViewModel;

namespace WheelsMarket.Services.VehicleTypeSections
{
    public class VehicleTypeSectionService:IVehicleTypeSectionService
    {
        private readonly ApplicationDbContext context;

        public VehicleTypeSectionService(ApplicationDbContext dbcontext)
        {
            this.context = dbcontext;
        }

        public async Task<List<AllVehicleTypeSectionViewModel>> ShowAllVehicleTypeSectionAsync()
        {
            var model = await this.context.VehicleTypeSections
                .Select(a => new AllVehicleTypeSectionViewModel()
                {
                    Id = a.Id,
                    Section = a.Section,
                })
                .ToListAsync();

            return model;
        }

        public async Task AddVehicleTypeSectionAsync(AddVehicleTypeSectionViewModel addVehicleTypesViewModel)
        {
            var vehicleType = new VehicleTypeSection()
            {
                Section = addVehicleTypesViewModel.Section,
            };

            await context.VehicleTypeSections.AddAsync(vehicleType);
            await context.SaveChangesAsync();
        }

        public async Task DeleteVehicleTypeSectionAsync(Guid id)
        {
            var model = await this.context.VehicleTypeSections
                .FirstOrDefaultAsync(x => x.Id == id);


            if (model != null)
            {
                context.VehicleTypeSections.Remove(model);
                await context.SaveChangesAsync();
            }
            else
            {
                throw new ArgumentNullException();
            }
        }

		public async Task<VehicleTypeSection> GetVehicleTypeSectionIdAsync(Guid id)
		{
			return await context.VehicleTypeSections.FindAsync(id);
		}

		public async Task EditVehicleTypeSectionAsync(VehicleTypeSection vts)
		{
			context.Update(vts);
			await context.SaveChangesAsync();
		}
	}
}
