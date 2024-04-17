using WheelsMarket.Data.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace WheelsMarket.Data.Configuration
{
	public class VehicleConfiguration : IEntityTypeConfiguration<Vehicle>
	{
		public void Configure(EntityTypeBuilder<Vehicle> builder)
		{
			builder.HasData(CreateEdition());
		}

		private List<Vehicle> CreateEdition()
		{
			List<Vehicle> vehicles = new List<Vehicle>();
			Vehicle vehicle = new Vehicle()
			{
				Id = Guid.Parse("06befde8-a6ae-411d-9597-3705449e5bd1"),
				Тransmission = "Ръчна",
				Volume = 2500,
				Price = 15399,
				Color= "Зелен",
				Distance= 185639,
				Fuel= "Дизел",
				Condition= "Нов",
				Year= 2009,
				EuroStandard= "Euro 5",
				VinNumber = 10001,
				Currency= "лв",
				HoursePower= 170,
				LocationTown= "Казанлък",
				ImageURL= "https://s1.1zoom.me/b4067/303/Audi_2019_A4_allroad_quattro_Grey_Metallic_Estate_570422_1920x1080.jpg",
				MoreInformation= "Колата няма никакви забележки, само задната лява седалка е скъсана.",
				LocationRegion= "Стара Загора",
				EditionId = Guid.Parse("94187284-2cdf-4d3c-8ae3-47c266122a26"),
				UserId = Guid.Parse("58481143-B8F4-4D21-BDEC-5B118DD8A15A")
			};//
			vehicles.Add(vehicle);

			vehicle = new Vehicle()
			{
				Id = Guid.Parse("f6a6597e-f73c-46a1-abb2-b448f1883f96"),
				Тransmission = "Автоматична",
				Volume = 1800,
				Price = 21999,
				Color = "Червен",
				Distance = 95000,
				Fuel = "Бензин",
				Condition = "Употребяван",
				Year = 2015,
				EuroStandard = "Euro 6",
				VinNumber = 10002,
				Currency = "USD",
				HoursePower = 150,
				LocationTown = "София",
				ImageURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQevdE1eAryK9STmDnZYNZhk4j2TA2f4HYutWX_U4zJoA&s",
				MoreInformation = "Перфектно запазен автомобил с пълен сервизен история. Има леки драскотини на предния капак.",
				LocationRegion = "София",
				EditionId = Guid.Parse("15e67473-da39-433b-8c24-50ae8344a48a"),
				UserId = Guid.Parse("58481143-B8F4-4D21-BDEC-5B118DD8A15A")
			};//
			vehicles.Add(vehicle);

			vehicle = new Vehicle()
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
			};//
			vehicles.Add(vehicle);

			vehicle = new Vehicle()
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
			};//
			vehicles.Add(vehicle);

			vehicle = new Vehicle()
			{
				Id = Guid.Parse("30040efe-5fae-4561-a0cc-ddf6c8506fcf"),
				Тransmission = "Ръчна",
				Volume = 1600,
				Price = 8500,
				Color = "Бял",
				Distance = 105000,
				Fuel = "Бензин",
				Condition = "Употребяван",
				Year = 2010,
				EuroStandard = "Euro 5",
				VinNumber = 10005,
				Currency = "лв",
				HoursePower = 90,
				LocationTown = "Айтос",
				ImageURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQrnXVaRLhg0-IVMjYYDpNcglt-_gBc6Milsv556WeEdQ&s",
				MoreInformation = "Изключително икономичен автомобил, подходящ за градско пътуване. Нови амортисьори.",
				LocationRegion = "Бургас",
				EditionId = Guid.Parse("addca70a-f8e1-4165-9ad6-ead636411b65"),
				UserId = Guid.Parse("58481143-B8F4-4D21-BDEC-5B118DD8A15A")
			};//
			vehicles.Add(vehicle);

			vehicle = new Vehicle()
			{
				Id = Guid.Parse("473c0c59-59b5-4fcb-811d-9ec16be8227b"),
				Тransmission = "Ръчна",
				Volume = 2500,
				Price = 12300,
				Color = "Черен",
				Distance = 185000,
				Fuel = "Дизел",
				Condition = "Употребяван",
				Year = 2011,
				EuroStandard = "Euro 4",
				VinNumber = 10006,
				Currency = "лв",
				HoursePower = 140,
				LocationTown = "Мартен",
				ImageURL = "https://i.pinimg.com/originals/12/0d/6b/120d6b8793349feb2388eb99bea99fc2.jpg",
				MoreInformation = "Надежден и здрав пикап. Има леки външни забележки.",
				LocationRegion = "Русе",
				EditionId = Guid.Parse("71545e27-d6f3-41c6-ad01-d422b733c252"),
				UserId = Guid.Parse("58481143-B8F4-4D21-BDEC-5B118DD8A15A")
			};//
			vehicles.Add(vehicle);

			vehicle = new Vehicle()
			{
				Id = Guid.Parse("cb214956-0b7f-4d4e-954b-ab193df28bcc"),
				Тransmission = "Автоматична",
				Volume = 2000,
				Price = 18900,
				Color = "Сребрист",
				Distance = 67000,
				Fuel = "Бензин",
				Condition = "Употребяван",
				Year = 2017,
				EuroStandard = "Euro 6",
				VinNumber = 10007,
				Currency = "лв",
				HoursePower = 160,
				LocationTown = "Раднево",
				ImageURL = "https://cdn.motor1.com/images/mgl/OoeOzl/s1/bmw-i5-edrive40-touring-2024.jpg",
				MoreInformation = "Спортен хечбек с елегантен дизайн. Пълен сервизен история в оторизиран сервиз.",
				LocationRegion = "Стара Загора",
				EditionId = Guid.Parse("1e9ade8f-9650-43cd-9cb9-cf167e53d61e"),
				UserId = Guid.Parse("58481143-B8F4-4D21-BDEC-5B118DD8A15A")
			};//
			vehicles.Add(vehicle);

			vehicle = new Vehicle()
			{
				Id = Guid.Parse("46e5e670-a3c7-4d9c-ae21-36ea81e7130e"),
				Тransmission = "Ръчна",
				Volume = 1800,
				Price = 10500,
				Color = "Син",
				Distance = 98000,
				Fuel = "Дизел",
				Condition = "Употребяван",
				Year = 2013,
				EuroStandard = "Euro 5",
				VinNumber = 10008,
				Currency = "лв",
				HoursePower = 120,
				LocationTown = "Плевен",
				ImageURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTgaB8Wc0vQIF1fAdhaeFqEmq88MxsP8jn4JCAK7bwY9A&s",
				MoreInformation = "Семеен автомобил с комфортна икономичност. Идеален за пътувания с цялото семейство.",
				LocationRegion = "Плевен",
				EditionId = Guid.Parse("9b5026f5-a2da-4fd1-9d64-adfbd1e1034e"),
				UserId = Guid.Parse("58481143-B8F4-4D21-BDEC-5B118DD8A15A")
			};//
			vehicles.Add(vehicle);

			vehicle = new Vehicle()
			{
				Id = Guid.Parse("ff6a5a93-ceff-4ac3-bf26-c321717816cb"),
				Тransmission = "Автоматична",
				Volume = 2200,
				Price = 14999,
				Color = "Червен",
				Distance = 74000,
				Fuel = "Бензин",
				Condition = "Употребяван",
				Year = 2016,
				EuroStandard = "Euro 6",
				VinNumber = 10009,
				Currency = "лв",
				HoursePower = 130,
				LocationTown = "Харманли",
				ImageURL = "https://wallpapers.com/images/hd/bmw-x5-1920-x-1080-wallpaper-v6n1t0uhafvmg7q3.jpg",
				MoreInformation = "Здрав и надежден автомобил.",
				LocationRegion = "Хасково",
				EditionId = Guid.Parse("aa7212f8-75b8-474a-91e2-dda3bc404caf"),
				UserId = Guid.Parse("58481143-B8F4-4D21-BDEC-5B118DD8A15A")
			};//
			vehicles.Add(vehicle);

			return vehicles;


		}
	}
}
