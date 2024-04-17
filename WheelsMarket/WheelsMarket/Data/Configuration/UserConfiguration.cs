using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using WheelsMarket.Data.Models;

namespace WheelsMarket.Data.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(SeedUsers());
        }

        private static ICollection<User> SeedUsers()
        {
            var users = new HashSet<User>();
            var hasher = new PasswordHasher<User>();

            var admin = new User()
            {
                Id = Guid.Parse("d1a1ff64-6926-4a47-a358-ff0f76f634b3"),
                UserName = "Admin",
                NormalizedUserName = "ADMIN",
                Email = "admin@gmail.com",
                FirstName = "Lyudmil",
                LastName = "Atanasov",
                NormalizedEmail = "ADMIN@GMAIL.COM",
                SecurityStamp = Guid.NewGuid().ToString(),
            };

            admin.PasswordHash = hasher.HashPassword(admin, "Aa7810254597Bb@@");
            users.Add(admin);

            var client = new User()
            {
                Id = Guid.Parse("58481143-b8f4-4d21-bdec-5b118dd8a15a"),
                UserName = "Client 1",
                NormalizedUserName = "CLIENT_1",
                Email = "client@gmail.com",
                FirstName = "Иван",
                LastName = "Иванов",
                NormalizedEmail = "CLIENT@GMAIL.COM",
                SecurityStamp = Guid.NewGuid().ToString(),
            };

            client.PasswordHash = hasher.HashPassword(client, "Aa7810254597Bb@@");
            users.Add(client);

            return users;
        }
    }
}
