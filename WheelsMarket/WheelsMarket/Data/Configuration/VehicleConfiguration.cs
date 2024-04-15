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
				ImageURL= "https://s.car.info/image_files/1920/side-1-906746.jpg",
				MoreInformation= "Колата няма никакви забележки, само задната лява седалка е скъсана.",
				LocationRegion= "Стара Загора",
			};
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
				ImageURL = "https://s.car.info/image_files/1920/side-1-906747.jpg",
				MoreInformation = "Перфектно запазен автомобил с пълен сервизен история. Има леки драскотини на предния капак.",
				LocationRegion = "София"
			};
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
				ImageURL = "https://s.car.info/image_files/1920/side-1-906748.jpg",
				MoreInformation = "Добре поддържан семейен автомобил. Нови гуми и спирачни дискове.",
				LocationRegion = "Варна"
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
				ImageURL = "https://s.car.info/image_files/1920/side-1-906749.jpg",
				MoreInformation = "Луксозен седан с пълен пакет от екстри. Идеален за градско и извънградско шофиране.",
				LocationRegion = "Пловдив"
			};
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
				ImageURL = "https://s.car.info/image_files/1920/side-1-906750.jpg",
				MoreInformation = "Изключително икономичен автомобил, подходящ за градско пътуване. Нови амортисьори.",
				LocationRegion = "Бургас"
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
				ImageURL = "https://s.car.info/image_files/1920/side-1-906751.jpg",
				MoreInformation = "Надежден и здрав пикап. Има леки външни забележки.",
				LocationRegion = "Русе"
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
				ImageURL = "https://s.car.info/image_files/1920/side-1-906752.jpg",
				MoreInformation = "Спортен хечбек с елегантен дизайн. Пълен сервизен история в оторизиран сервиз.",
				LocationRegion = "Стара Загора"
			};
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
				ImageURL = "https://s.car.info/image_files/1920/side-1-906753.jpg",
				MoreInformation = "Семеен автомобил с комфортна икономичност. Идеален за пътувания с цялото семейство.",
				LocationRegion = "Плевен"
			};
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
				ImageURL = "https://s.car.info/image_files/1920/side-1-906753.jpg",
				MoreInformation = "Здрав и надежден автомобил.",
				LocationRegion = "Хасково"
			};
			vehicles.Add(vehicle);

			return vehicles;


		}
	}
}
