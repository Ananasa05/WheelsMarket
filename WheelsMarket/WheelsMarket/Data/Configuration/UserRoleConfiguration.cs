using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace WheelsMarket.Data.Configuration
{
    public class UserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<Guid>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<Guid>> builder)
        {
            builder.HasData(SeedUserRole());
        }

        private static ICollection<IdentityUserRole<Guid>> SeedUserRole()
        {
            return new HashSet<IdentityUserRole<Guid>>
        {
            new()
            {
                UserId = Guid.Parse("d1a1ff64-6926-4a47-a358-ff0f76f634b3"),
                RoleId = Guid.Parse("24da8b40-25fa-4fb5-a453-b168ac1a6256")
            },
            new()
            {
                UserId = Guid.Parse("58481143-b8f4-4d21-bdec-5b118dd8a15a"),
                RoleId = Guid.Parse("13ead2ca-3577-444c-a1ec-6dce24ad5bae")
            }
        };
        }
    }
}
