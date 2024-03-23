﻿using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WheelsMarket.Data;
using WheelsMarket.Data.Models;
using WheelsMarket.Services.Brands.ViewModel;
using WheelsMarket.Services.Editions.ViewModel;
using WheelsMarket.Services.Vehicles.ViewModel;
using WheelsMarket.Services.VehicleTypeTypes.ViewModel;

namespace WheelsMarket.Services.Vehicles
{
    public class VehicleService : IVehicleService
    {

        private readonly ApplicationDbContext context;

        public VehicleService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task DeleteVehicleAdminAsync(Guid id)
        {
            var model = await this.context.Vehicles
                .FirstOrDefaultAsync(x => x.Id == id);


            if (model != null)
            {
                context.Vehicles.Remove(model);
                await context.SaveChangesAsync();
            }
            else
            {
                throw new ArgumentNullException();
            }
        }

        public async Task<IEnumerable<AllVehicleViewModel>> ByPriceFilter(int min, int max)
        {
            IEnumerable<AllVehicleViewModel> model =
                await this.context.Vehicles.Where(x => x.Price >= min && x.Price <= max)
                .Select(b => new AllVehicleViewModel()
                {
                    Id = b.Id,
                    Distance = Convert.ToInt32(b.Distance),
                    Fuel = b.Fuel,
                    ImageURL = b.ImageURL,
                    Price = Convert.ToInt32(b.Price),
                    Volume = Convert.ToInt32(b.Volume),
                    Year = Convert.ToInt32(b.Year),
                    EditionName = b.Edition.Name,
                    BrandName = b.Edition.Brand.Name,
                })
                .ToListAsync();
            return model;
        }

        public async Task<IEnumerable<AllVehicleViewModel>> ByTransmisionFilter(string name)
        {
            IEnumerable<AllVehicleViewModel> model =
                await this.context.Vehicles.Where(x => x.Тransmission == name)
                .Select(b => new AllVehicleViewModel()
                {
                    Id = b.Id,
                    Distance = Convert.ToInt32(b.Distance),
                    Fuel = b.Fuel,
                    ImageURL = b.ImageURL,
                    Price = Convert.ToInt32(b.Price),
                    Volume = Convert.ToInt32(b.Volume),
                    Year = Convert.ToInt32(b.Year),
                    EditionName = b.Edition.Name,
                    BrandName = b.Edition.Brand.Name,
                })
                .ToListAsync();
            return model;
        }

        public async Task<AllVehicleViewModel> ShowAllInformationForVehicle(Guid id)
        {
            var model = await this.context.Vehicles
                 .Include(x => x.Edition)
                 .ThenInclude(x => x.Brand)
                .FirstOrDefaultAsync(x => x.Id == id);

            if (model != null)
            {
                var vehicle = new AllVehicleViewModel()
                {
                    Id = model.Id,
                    Distance = Convert.ToInt32(model.Distance),
                    Fuel = model.Fuel,
                    ImageURL = model.ImageURL,
                    Price = Convert.ToInt32(model.Price),
                    Volume = Convert.ToInt32(model.Volume),
                    Year = Convert.ToInt32(model.Year),
                    //EditionName = model.Edition,

                };

                return vehicle;
            }
            else
            {
                throw new ArgumentNullException();
            }
        }


        public async Task<IEnumerable<AllVehicleViewModel>> ShowAllVehiclesAsync(int? min, int? max, string? transName,string? fuel)
        {
            var entitiesDb = context.Vehicles.AsQueryable();

            if (min != null && max != null)
            {
                entitiesDb = entitiesDb.Where(x => x.Year >= min && x.Year <= max);
            }
            if (transName != null)
            {
                entitiesDb = entitiesDb.Where(x => x.Тransmission == transName);
            }
            if (fuel != null)
            {
                entitiesDb = entitiesDb.Where(x => x.Fuel== fuel);
            }

            var entities = await entitiesDb
                .Include(v => v.Edition)
                .ThenInclude(e => e.Brand)
                .ToListAsync();

            return entities
                .Select(b => new AllVehicleViewModel
                {
                    Id = b.Id,
                    Distance = Convert.ToInt32(b.Distance),
                    Fuel = b.Fuel,
                    ImageURL = b.ImageURL,
                    Price = Convert.ToInt32(b.Price),
                    Volume = Convert.ToInt32(b.Volume),
                    Year = Convert.ToInt32(b.Year),
                    EditionName = b.Edition.Name,
                    BrandName = b.Edition.Brand.Name,
                });
        }


        public SelectList AddVehicleEditionAsync(Guid brandId)
        {
            return new SelectList(this.context.Editions.Where(x => x.BrandId == brandId), "Id", "Name");
        }

        public SelectList AddBrandAsync()
        {
            return new SelectList(this.context.Brands, "Id", "Name");
        }

        public async Task AddVehicleAsync(AddVehicleViewModel addVehicleViewModel)
        {
            Vehicle model = new Vehicle()
            {
                Id = Guid.NewGuid(),
                Color = addVehicleViewModel.Color,
                Distance = addVehicleViewModel.Distance,
                Fuel = addVehicleViewModel.Fuel,
                Condition = addVehicleViewModel.Condition,
                ImageURL = addVehicleViewModel.ImageURL,
                Price = addVehicleViewModel.Price,
                Volume = addVehicleViewModel.Volume,
                Year = addVehicleViewModel.Year,
                Тransmission = addVehicleViewModel.Тransmission,
                EditionId = addVehicleViewModel.EditionId,
                VehicleTypeTypeId = addVehicleViewModel.VehicleTypeTypeId
            };

            await this.context.Vehicles.AddAsync(model);
            await context.SaveChangesAsync();
        }
        public SelectList AddVehicleTypeTypeAsync(Guid typeSectionId)
        {
            return new SelectList(this.context.VehicleTypeTypes.Where(x => x.VehicleTypeSectionId == typeSectionId), "Id", "Type");
        }

        public SelectList AddVehicleTypeSectionAsync()
        {
            return new SelectList(this.context.VehicleTypeSections, "Id", "Section");
        }


    }
}


