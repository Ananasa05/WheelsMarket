using Microsoft.AspNetCore.Mvc.Rendering;
using WheelsMarket.Data.Models;
using WheelsMarket.Data;
using WheelsMarket.Services.VehicleTypeTypes.ViewModel;
using WheelsMarket.Services.Editions.ViewModel;
using Microsoft.EntityFrameworkCore;

namespace WheelsMarket.Services.Editions
{
    public class EditionService : IEditionService
    {
        private readonly ApplicationDbContext context;

        public EditionService(ApplicationDbContext dbcontext)
        {
            this.context = dbcontext;
        }

        public async Task<IEnumerable<AllEditionViewModel>> ShowAllEditionAsync()
        {
            var entities = await context.Editions.Include(book => book.Brand).ToListAsync();
            return entities
                .Select(b => new AllEditionViewModel
                {
                    Id = b.Id,
                    Name = b.Name,
                    BrandName = b.Brand.Name,
                });
        }

        public SelectList AddEditionAsync()
        {
            return new SelectList(this.context.Brands, "Id", "Name");
        }
        public async Task AddEditionAsync(AddEditionViewModel addEditionViewModelk)
        {
            Edition model = new Edition()
            {
                Id = Guid.NewGuid(),
                Name = addEditionViewModelk.Name,
                BrandId = addEditionViewModelk.BrandId
            };
            await this.context.Editions.AddAsync(model);
            await context.SaveChangesAsync();
        }

        public async Task DeleteEditionAsync(Guid id)
        {
            var model = await this.context.Editions
                .FirstOrDefaultAsync(x => x.Id == id);


            if (model != null)
            {
                context.Editions.Remove(model);
                await context.SaveChangesAsync();
            }
            else
            {
                throw new ArgumentNullException();
            }
        }
    }
}
