using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace WheelsMarket.Data.Configuration
{
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole<Guid>>
    {
        public void Configure(EntityTypeBuilder<IdentityRole<Guid>> builder)
        {
            builder.HasData(SeedRoles());
        }

        private static ICollection<IdentityRole<Guid>> SeedRoles()
        {
            return new HashSet<IdentityRole<Guid>>
        {
            new()
            {
                Id = Guid.Parse("24da8b40-25fa-4fb5-a453-b168ac1a6256"),
                Name = "Administrator",
                NormalizedName= "ADMINISTRATOR",
            },
            new()
            {
                Id = Guid.Parse("13ead2ca-3577-444c-a1ec-6dce24ad5bae"),
                Name = "Client",
                NormalizedName= "CLIENT",
            }
        };
        }
    }
}
