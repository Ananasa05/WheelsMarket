using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WheelsMarket.Migrations
{
    public partial class addVehicleConfigurations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "Color", "Condition", "Currency", "Distance", "EditionId", "EuroStandard", "Fuel", "HoursePower", "ImageURL", "LocationRegion", "LocationTown", "MoreInformation", "Price", "UserId", "VinNumber", "Volume", "Year", "Тransmission" },
                values: new object[,]
                {
                    { new Guid("06befde8-a6ae-411d-9597-3705449e5bd1"), "Зелен", "Нов", "лв", 185639, new Guid("94187284-2cdf-4d3c-8ae3-47c266122a26"), "Euro 5", "Дизел", 170, "https://s.car.info/image_files/1920/side-1-906746.jpg", "Стара Загора", "Казанлък", "Колата няма никакви забележки, само задната лява седалка е скъсана.", 15399, null, 10001, 2500, 2009, "Ръчна" },
                    { new Guid("0a1f1c92-f170-481f-a301-46c8f72c9b82"), "Син", "Употребяван", "лв", 128000, new Guid("d06fd2a8-60f9-44fe-9484-5358855851b8"), "Euro 4", "Дизел", 120, "https://s.car.info/image_files/1920/side-1-906748.jpg", "Варна", "Звездица", "Добре поддържан семейен автомобил. Нови гуми и спирачни дискове.", 13500, null, 10003, 2200, 2012, "Ръчна" },
                    { new Guid("2e1506d8-3bf5-44a3-a123-f61b2d8372ba"), "Сив", "Употребяван", "лв", 75000, new Guid("2e89ffec-aae1-4620-b5f9-81b3fd59b04d"), "Euro 6", "Хибрид", 200, "https://s.car.info/image_files/1920/side-1-906749.jpg", "Пловдив", "Хисаря", "Луксозен седан с пълен пакет от екстри. Идеален за градско и извънградско шофиране.", 28900, null, 10004, 3000, 2018, "Автоматична" },
                    { new Guid("30040efe-5fae-4561-a0cc-ddf6c8506fcf"), "Бял", "Употребяван", "лв", 105000, new Guid("addca70a-f8e1-4165-9ad6-ead636411b65"), "Euro 5", "Бензин", 90, "https://s.car.info/image_files/1920/side-1-906750.jpg", "Бургас", "Айтос", "Изключително икономичен автомобил, подходящ за градско пътуване. Нови амортисьори.", 8500, null, 10005, 1600, 2010, "Ръчна" },
                    { new Guid("46e5e670-a3c7-4d9c-ae21-36ea81e7130e"), "Син", "Употребяван", "лв", 98000, new Guid("9b5026f5-a2da-4fd1-9d64-adfbd1e1034e"), "Euro 5", "Дизел", 120, "https://s.car.info/image_files/1920/side-1-906753.jpg", "Плевен", "Плевен", "Семеен автомобил с комфортна икономичност. Идеален за пътувания с цялото семейство.", 10500, null, 10008, 1800, 2013, "Ръчна" },
                    { new Guid("473c0c59-59b5-4fcb-811d-9ec16be8227b"), "Черен", "Употребяван", "лв", 185000, new Guid("71545e27-d6f3-41c6-ad01-d422b733c252"), "Euro 4", "Дизел", 140, "https://s.car.info/image_files/1920/side-1-906751.jpg", "Русе", "Мартен", "Надежден и здрав пикап. Има леки външни забележки.", 12300, null, 10006, 2500, 2011, "Ръчна" },
                    { new Guid("cb214956-0b7f-4d4e-954b-ab193df28bcc"), "Сребрист", "Употребяван", "лв", 67000, new Guid("1e9ade8f-9650-43cd-9cb9-cf167e53d61e"), "Euro 6", "Бензин", 160, "https://s.car.info/image_files/1920/side-1-906752.jpg", "Стара Загора", "Раднево", "Спортен хечбек с елегантен дизайн. Пълен сервизен история в оторизиран сервиз.", 18900, null, 10007, 2000, 2017, "Автоматична" },
                    { new Guid("f6a6597e-f73c-46a1-abb2-b448f1883f96"), "Червен", "Употребяван", "USD", 95000, new Guid("15e67473-da39-433b-8c24-50ae8344a48a"), "Euro 6", "Бензин", 150, "https://s.car.info/image_files/1920/side-1-906747.jpg", "София", "София", "Перфектно запазен автомобил с пълен сервизен история. Има леки драскотини на предния капак.", 21999, null, 10002, 1800, 2015, "Автоматична" },
                    { new Guid("ff6a5a93-ceff-4ac3-bf26-c321717816cb"), "Червен", "Употребяван", "лв", 74000, new Guid("aa7212f8-75b8-474a-91e2-dda3bc404caf"), "Euro 6", "Бензин", 130, "https://s.car.info/image_files/1920/side-1-906753.jpg", "Хасково", "Харманли", "Здрав и надежден автомобил.", 14999, null, 10009, 2200, 2016, "Автоматична" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("06befde8-a6ae-411d-9597-3705449e5bd1"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("0a1f1c92-f170-481f-a301-46c8f72c9b82"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("2e1506d8-3bf5-44a3-a123-f61b2d8372ba"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("30040efe-5fae-4561-a0cc-ddf6c8506fcf"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("46e5e670-a3c7-4d9c-ae21-36ea81e7130e"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("473c0c59-59b5-4fcb-811d-9ec16be8227b"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("cb214956-0b7f-4d4e-954b-ab193df28bcc"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("f6a6597e-f73c-46a1-abb2-b448f1883f96"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("ff6a5a93-ceff-4ac3-bf26-c321717816cb"));
        }
    }
}
