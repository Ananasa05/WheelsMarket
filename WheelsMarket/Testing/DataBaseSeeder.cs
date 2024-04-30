using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WheelsMarket.Data;
using WheelsMarket.Data.Models;

namespace Testing
{
    public static class DataBaseSeeder
    {
        public static void SeedDatabase(WheelsMarketDbContext context)
        {
            SeedVehicle(context);
            SeedBrand(context);
            SeedEdition(context);
            SeedVehicleTypeSection(context);
            SeedVehicleTypeType(context);
            SeedUser(context);

            context.SaveChanges();
        }
       
        public static void SeedVehicleTypeSection(WheelsMarketDbContext context)
        {
            var section1 = new VehicleTypeSection()
            {
                Id = Guid.Parse("631cbfed-14b6-4350-a5cf-9f9980501428"),
                Section = "Автомобили и джипове"
            };
            var section2 = new VehicleTypeSection()
            {
                Id = Guid.Parse("f2ad3170-37d5-483d-a4f2-26b933c67118"),
                Section = "Бусове"
            };
            var section3 = new VehicleTypeSection()
            {
                Id = Guid.Parse("213a952a-30ff-4e56-b256-1cfb795c7a01"),
                Section = "Камиони"
            };
            context.VehicleTypeSections.Add(section1);
            context.VehicleTypeSections.Add(section2);
            context.VehicleTypeSections.Add(section3);
        }

        public static void SeedVehicleTypeType(WheelsMarketDbContext context)
        {
            var type1 = new VehicleTypeType()
            {
                Id = Guid.Parse("c80fdbba-9d3d-485c-bb9d-085da4e9b69e"),
                Type = "Ван",
                VehicleTypeSectionId = Guid.Parse("631cbfed-14b6-4350-a5cf-9f9980501428")
            };

            var type2 = new VehicleTypeType()
            {
                Id = Guid.Parse("5e07a858-09c8-4653-9603-e59dcc1aea23"),
                Type = "Джип",
                VehicleTypeSectionId = Guid.Parse("631cbfed-14b6-4350-a5cf-9f9980501428")

            };

            var type3 = new VehicleTypeType()
            {
                Id = Guid.Parse("ef5f6c10-a42e-4fe9-8f7a-5170d0b40f14"),
                Type = "Кабрио",
                VehicleTypeSectionId = Guid.Parse("631cbfed-14b6-4350-a5cf-9f9980501428")

            };

            var type4 = new VehicleTypeType()
            {
                Id = Guid.Parse("ad5fbbce-fb6c-4e13-92ca-2f4b97911f49"),
                Type = "Комби",
                VehicleTypeSectionId = Guid.Parse("631cbfed-14b6-4350-a5cf-9f9980501428")

            };

            context.VehicleTypeTypes.Add(type1);
            context.VehicleTypeTypes.Add(type2);
            context.VehicleTypeTypes.Add(type3);
            context.VehicleTypeTypes.Add(type4);
        }


        public static void SeedBrand(WheelsMarketDbContext context)
        {
            var brand1 = new Brand()
            {
                Id = Guid.Parse("8e139c5f-3f01-4b8b-9471-4a87a2253db2"),
                Name = "Alfa Romeo",
                VehicleTypeTypeId = Guid.Parse("5e07a858-09c8-4653-9603-e59dcc1aea23")
            };

            var brand2 = new Brand()
            {
                Id = Guid.Parse("bccfe962-c5f7-41d6-b6c2-f32577cb47de"),
                Name = "Audi",
                VehicleTypeTypeId = Guid.Parse("5e07a858-09c8-4653-9603-e59dcc1aea23")

            };

            var brand3= new Brand()
            {
                Id = Guid.Parse("da6e5a3a-79c5-4ffb-926d-b1fb055688c1"),
                Name = "BMW",
                VehicleTypeTypeId = Guid.Parse("5e07a858-09c8-4653-9603-e59dcc1aea23")

            };

            context.Brands.Add(brand1);
            context.Brands.Add(brand2);
            context.Brands.Add(brand3);
        }

        public static void SeedEdition(WheelsMarketDbContext context)
        {
            var edition1 = new Edition()
            {
                Id = Guid.Parse("d06fd2a8-60f9-44fe-9484-5358855851b8"),
                Name = "Q7",
                BrandId = Guid.Parse("bccfe962-c5f7-41d6-b6c2-f32577cb47de")
            };

            var edition2 = new Edition()
            {
                Id = Guid.Parse("2e89ffec-aae1-4620-b5f9-81b3fd59b04d"),
                Name = "RSQ8",
                BrandId = Guid.Parse("bccfe962-c5f7-41d6-b6c2-f32577cb47de")

            };

            context.Editions.Add(edition1);
            context.Editions.Add(edition2);
        }

        public static void SeedVehicle(WheelsMarketDbContext context)
        {
            var vehicle1 = new Vehicle()
            {
                Id = Guid.Parse("0a1f1c92-f170-481f-a301-46c8f72c9b82"),
                Тransmission = "Ръчна",
                Volume = 2200,
                Price = 13500,
                Color = "Син",
                Distance = 128000,
                Fuel = "Дизел",
                Condition = "Употребяван",
                Year = 2012,
                EuroStandard = "Euro 4",
                VinNumber = 10003,
                Currency = "лв",
                HoursePower = 120,
                LocationTown = "Звездица",
                ImageURL = "https://wallpapers.com/images/hd/audi-q7-1920-x-1080-wallpaper-ty4995qkcstpam9g.jpg",
                MoreInformation = "Добре поддържан семейен автомобил. Нови гуми и спирачни дискове.",
                LocationRegion = "Варна",
                EditionId = Guid.Parse("d06fd2a8-60f9-44fe-9484-5358855851b8"),
                UserId = Guid.Parse("58481143-B8F4-4D21-BDEC-5B118DD8A15A")
            };

            var vehicle2 = new Vehicle()
            {
                Id = Guid.Parse("2e1506d8-3bf5-44a3-a123-f61b2d8372ba"),
                Тransmission = "Автоматична",
                Volume = 3000,
                Price = 28900,
                Color = "Сив",
                Distance = 75000,
                Fuel = "Хибрид",
                Condition = "Употребяван",
                Year = 2018,
                EuroStandard = "Euro 6",
                VinNumber = 10004,
                Currency = "лв",
                HoursePower = 200,
                LocationTown = "Хисаря",
                ImageURL = "https://i.pinimg.com/originals/1a/e6/ef/1ae6efcc6d506cbf6856226e430c4089.webp",
                MoreInformation = "Луксозен седан с пълен пакет от екстри. Идеален за градско и извънградско шофиране.",
                LocationRegion = "Пловдив",
                EditionId = Guid.Parse("2e89ffec-aae1-4620-b5f9-81b3fd59b04d"),
                UserId = Guid.Parse("58481143-B8F4-4D21-BDEC-5B118DD8A15A")
            };

            context.Vehicles.Add(vehicle1);
            context.Vehicles.Add(vehicle2);
        }

        public static void SeedFavourites(WheelsMarketDbContext context)
        {
            var favourite1 = new Favourite()
            {
                VehicleId = Guid.Parse("0a1f1c92-f170-481f-a301-46c8f72c9b82"),
                UserId = Guid.Parse("d1a1ff64-6926-4a47-a358-ff0f76f634b3")
            };

            var favourite2 = new Favourite()
            {
                VehicleId = Guid.Parse("2e1506d8-3bf5-44a3-a123-f61b2d8372ba"),
                UserId = Guid.Parse("58481143-b8f4-4d21-bdec-5b118dd8a15a")

            };

            context.Favourites.Add(favourite1);
            context.Favourites.Add(favourite2);
        }

        public static void SeedUser(WheelsMarketDbContext context)
        {
            var user1 = new User()
            {
                Id = Guid.Parse("d1a1ff64-6926-4a47-a358-ff0f76f634b3"),
                UserName = "Admin",
                NormalizedUserName = "ADMIN",
                Email = "admin@gmail.com",
                FirstName = "Lyudmil",
                LastName = "Atanasov",
                PhoneNumber = "1234567890",
                NormalizedEmail = "ADMIN@GMAIL.COM",
                SecurityStamp = Guid.NewGuid().ToString(),
            };

            var user2 = new User()
            {
                Id = Guid.Parse("58481143-b8f4-4d21-bdec-5b118dd8a15a"),
                UserName = "Client 1",
                NormalizedUserName = "CLIENT_1",
                Email = "client@gmail.com",
                FirstName = "Иван",
                LastName = "Иванов",
                PhoneNumber = "1234567891",
                NormalizedEmail = "CLIENT@GMAIL.COM",
                SecurityStamp = Guid.NewGuid().ToString(),

            };

            context.User.Add(user1);
            context.User.Add(user2);
        }
    }
}
