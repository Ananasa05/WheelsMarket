using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
using WheelsMarket.Data.Configuration;
using WheelsMarket.Data.Models;

namespace WheelsMarket.Data
{
    public class WheelsMarketDbContext : IdentityDbContext<User, IdentityRole<Guid>, Guid>
    {
        private bool seedDB;
        public WheelsMarketDbContext(DbContextOptions<WheelsMarketDbContext> options, bool seedDB=true)
            : base(options)
        {
            if (this.Database.IsRelational())
            {
                this.Database.Migrate();
            }
            else
            {
                this.Database.EnsureCreated();
            }
            this.seedDB = seedDB;
        }
        public DbSet<Favourite> Favourites { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Edition> Editions { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<VehicleTypeSection> VehicleTypeSections { get; set; }
        public DbSet<VehicleTypeType> VehicleTypeTypes { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            if (seedDB)
            {
                builder.ApplyConfiguration(new BrandConfiguration());
                builder.ApplyConfiguration(new EditionConfiguration());
                builder.ApplyConfiguration(new VehicleTypeSectionConfiguration());
                builder.ApplyConfiguration(new VehicleTypeTypeConfiguration());
                builder.ApplyConfiguration(new VehicleConfiguration());
                builder.ApplyConfiguration(new RoleConfiguration());
                builder.ApplyConfiguration(new UserConfiguration());
                builder.ApplyConfiguration(new UserRoleConfiguration());
            }

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
                .HasKey(x => new { x.UserId, x.VehicleId });
            base.OnModelCreating(builder);
        }


    }
}