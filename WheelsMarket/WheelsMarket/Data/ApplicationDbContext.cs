using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
using WheelsMarket.Data.Models;

namespace WheelsMarket.Data
{
    public class ApplicationDbContext : IdentityDbContext<User, IdentityRole<Guid>, Guid>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Favourite> Favourites { get; set; } = null!;
        public DbSet<Vehicle> Vehicles { get; set; } = null!;
        public DbSet<Edition> Editions { get; set; } = null!;
        public DbSet<Brand> Brands { get; set; } = null!;
        public DbSet<VehicleTypeSection> VehicleTypeSections { get; set; } = null!;
        public DbSet<VehicleTypeType> VehicleTypeTypes { get; set; } = null!;
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Favourite>().HasKey(x => new
            {
                x.UserId,
                x.VehicleId
            });

            builder.Entity<Favourite>()
                .HasOne<User>(f => f.User)
                .WithMany(u => u.Favourites)
                .HasForeignKey(f => f.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<Favourite>()
               .HasOne<Vehicle>(f => f.Vehicle)
               .WithMany(v => v.FavouritesBy)
               .HasForeignKey(f => f.VehicleId)
               .OnDelete(DeleteBehavior.NoAction);


            //builder.Entity<VehicleTypeSection>()
            //   .HasData(new VehicleTypeSection()
            //   {
            //       Id = Guid.NewGuid(),
            //       Section = "Автомобили и джипове",
            //       Type = "Ван"
            //   },
            //   new VehicleTypeSection()
            //   {
            //       Id = Guid.NewGuid(),
            //       Section = "Автомобили и джипове",
            //       Type = "Джип"
            //   },
            //    new VehicleTypeSection()
            //    {
            //        Id = Guid.NewGuid(),
            //        Section = "Автомобили и джипове",
            //        Type = "Кабрио"
            //    },
            //    new VehicleTypeSection()
            //    {
            //        Id = Guid.NewGuid(),
            //        Section = "Автомобили и джипове",
            //        Type = "Купе"
            //    },
            //    new VehicleTypeSection()
            //    {
            //        Id = Guid.NewGuid(),
            //        Section = "Автомобили и джипове",
            //        Type = "Миниван"
            //    },
            //    new VehicleTypeSection()
            //    {
            //        Id = Guid.NewGuid(),
            //        Section = "Автомобили и джипове",
            //        Type = "Пикап"
            //    },
            //    new VehicleTypeSection()
            //    {
            //        Id = Guid.NewGuid(),
            //        Section = "Автомобили и джипове",
            //        Type = "Седан"
            //    },
            //    new VehicleTypeSection()
            //    {
            //        Id = Guid.NewGuid(),
            //        Section = "Автомобили и джипове",
            //        Type = "Стреч лимузина"
            //    },
            //    new VehicleTypeSection()
            //    {
            //        Id = Guid.NewGuid(),
            //        Section = "Автомобили и джипове",
            //        Type = "Хечбек"
            //    },
            //    new VehicleTypeSection()
            //    {
            //        Id = Guid.NewGuid(),
            //        Section = "Бусове",
            //        Type = "Хечбек"
            //    },
            //    new VehicleTypeSection()
            //    {
            //        Id = Guid.NewGuid(),
            //        Section = "Бусове",
            //        Type = "Катафалка"
            //    },
            //    new VehicleTypeSection()
            //    {
            //        Id = Guid.NewGuid(),
            //        Section = "Бусове",
            //        Type = "Линейка"
            //    },
            //    new VehicleTypeSection()
            //    {
            //        Id = Guid.NewGuid(),
            //        Section = "Бусове",
            //        Type = "Пътнически"
            //    },
            //    new VehicleTypeSection()
            //    {
            //        Id = Guid.NewGuid(),
            //        Section = "Бусове",
            //        Type = "Самосвал"
            //    },
            //    new VehicleTypeSection()
            //    {
            //        Id = Guid.NewGuid(),
            //        Section = "Бусове",
            //        Type = "Самосвал с кран"
            //    },
            //    new VehicleTypeSection()
            //    {
            //        Id = Guid.NewGuid(),
            //        Section = "Бусове",
            //        Type = "Товарен"
            //    },
            //    new VehicleTypeSection()
            //    {
            //        Id = Guid.NewGuid(),
            //        Section = "Бусове",
            //        Type = "Товаропътнически"
            //    },
            //    new VehicleTypeSection()
            //    {
            //        Id = Guid.NewGuid(),
            //        Section = "Бусове",
            //        Type = "Фургон"
            //    });

            //builder.Entity<Brand>()
            //   .HasData(new Brand()
            //   {
            //       Id = Guid.NewGuid(),
            //       Name = "Audi",
            //   },
            //   new Brand()
            //   {
            //       Id = Guid.NewGuid(),
            //       Name = "BMW"
            //   },
            //   new Brand()
            //   {
            //       Id = Guid.NewGuid(),
            //       Name = "Citroen"
            //   },
            //   new Brand()
            //   {
            //       Id = Guid.NewGuid(),
            //       Name = "Fiat"
            //   },
            //   new Brand()
            //   {
            //       Id = Guid.NewGuid(),
            //       Name = "Honda"
            //   },
            //   new Brand()
            //   {
            //       Id = Guid.NewGuid(),
            //       Name = "Hyundai"
            //   },
            //   new Brand()
            //   {
            //       Id = Guid.NewGuid(),
            //       Name = "Kia"
            //   },
            //   new Brand()
            //   {
            //       Id = Guid.NewGuid(),
            //       Name = "Mazda"
            //   },
            //   new Brand()
            //   {
            //       Id = Guid.NewGuid(),
            //       Name = "Mercedes Benz"
            //   },
            //   new Brand()
            //   {
            //       Id = Guid.NewGuid(),
            //       Name = "Mitsubishi"
            //   },
            //   new Brand()
            //   {
            //       Id = Guid.NewGuid(),
            //       Name = "Nissan"
            //   },
            //   new Brand()
            //   {
            //       Id = Guid.NewGuid(),
            //       Name = "Opel"
            //   },
            //   new Brand()
            //   {
            //       Id = Guid.NewGuid(),
            //       Name = "Peugeot"
            //   },
            //   new Brand()
            //   {
            //       Id = Guid.NewGuid(),
            //       Name = "Renault"
            //   },
            //   new Brand()
            //   {
            //       Id = Guid.NewGuid(),
            //       Name = "Seat"
            //   },
            //   new Brand()
            //   {
            //       Id = Guid.NewGuid(),
            //       Name = "Skoda"
            //   },
            //   new Brand()
            //   {
            //       Id = Guid.NewGuid(),
            //       Name = "Toyota"
            //   },
            //   new Brand()
            //   {
            //       Id = Guid.NewGuid(),
            //       Name = "VW"
            //   });



           base.OnModelCreating(builder);
        }


    }
}