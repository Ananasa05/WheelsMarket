using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WheelsMarket.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("13ead2ca-3577-444c-a1ec-6dce24ad5bae"), "8d2083ca-3275-4b2b-a12f-76f44c337972", "Client", "CLIENT" },
                    { new Guid("24da8b40-25fa-4fb5-a453-b168ac1a6256"), "dd3edad8-bcb4-4436-a4a2-6fd7b0a1951c", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("58481143-b8f4-4d21-bdec-5b118dd8a15a"), 0, "6cfd64ac-99cc-49c4-a0a1-4ea7f0cef37e", "client@gmail.com", false, "Иван", "Иванов", false, null, "CLIENT@GMAIL.COM", "CLIENT_1", "AQAAAAEAACcQAAAAEF/Mfq057BXIRpZ6Y3mSCyndeD5Umcj4B1pIaVuKSa3+YXvhP1CW22+lx1ErhXLMRw==", "1234567891", false, "368cd1ad-2343-45b9-a40a-b32f57ad305e", false, "Client 1" },
                    { new Guid("d1a1ff64-6926-4a47-a358-ff0f76f634b3"), 0, "d7f3dcdb-7e60-43ea-8e1c-fd54f798f2c7", "admin@gmail.com", false, "Lyudmil", "Atanasov", false, null, "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAEKljz7jt4Kpg/AvZREOVAIG4OWWReSk1RxEh1ABUybRFKrycLOfXr0xVO7p5RkVRMQ==", "1234567890", false, "2765c00b-ea54-4a3b-8fb1-3337ccc58a37", false, "Admin" }
                });

            migrationBuilder.InsertData(
                table: "VehicleTypeSections",
                columns: new[] { "Id", "Section" },
                values: new object[,]
                {
                    { new Guid("213a952a-30ff-4e56-b256-1cfb795c7a01"), "Камиони" },
                    { new Guid("631cbfed-14b6-4350-a5cf-9f9980501428"), "Автомобили и джипове" },
                    { new Guid("f2ad3170-37d5-483d-a4f2-26b933c67118"), "Бусове" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("13ead2ca-3577-444c-a1ec-6dce24ad5bae"), new Guid("58481143-b8f4-4d21-bdec-5b118dd8a15a") },
                    { new Guid("24da8b40-25fa-4fb5-a453-b168ac1a6256"), new Guid("d1a1ff64-6926-4a47-a358-ff0f76f634b3") }
                });

            migrationBuilder.InsertData(
                table: "VehicleTypeTypes",
                columns: new[] { "Id", "Type", "VehicleTypeSectionId" },
                values: new object[,]
                {
                    { new Guid("14690830-faee-4cb9-84ca-8234a0696e8a"), "Влекач", new Guid("213a952a-30ff-4e56-b256-1cfb795c7a01") },
                    { new Guid("2300898e-6b6f-41fd-a753-02a23634f764"), "Самосвал", new Guid("f2ad3170-37d5-483d-a4f2-26b933c67118") },
                    { new Guid("31347551-d8ce-48b8-8d73-9338163cd56f"), "Кран", new Guid("213a952a-30ff-4e56-b256-1cfb795c7a01") },
                    { new Guid("481e996e-febd-4d6d-a552-df039180948e"), "Снегорин", new Guid("213a952a-30ff-4e56-b256-1cfb795c7a01") },
                    { new Guid("5e07a858-09c8-4653-9603-e59dcc1aea23"), "Джип", new Guid("631cbfed-14b6-4350-a5cf-9f9980501428") },
                    { new Guid("ad5fbbce-fb6c-4e13-92ca-2f4b97911f49"), "Комби", new Guid("631cbfed-14b6-4350-a5cf-9f9980501428") },
                    { new Guid("ae578a5d-e436-4458-a851-b0007d9d30bf"), "Бордови", new Guid("f2ad3170-37d5-483d-a4f2-26b933c67118") },
                    { new Guid("c2235044-8910-4cbe-ac12-a5f8ecc0b4d6"), "Товарен", new Guid("f2ad3170-37d5-483d-a4f2-26b933c67118") },
                    { new Guid("c80fdbba-9d3d-485c-bb9d-085da4e9b69e"), "Ван", new Guid("631cbfed-14b6-4350-a5cf-9f9980501428") },
                    { new Guid("ef5f6c10-a42e-4fe9-8f7a-5170d0b40f14"), "Кабрио", new Guid("631cbfed-14b6-4350-a5cf-9f9980501428") },
                    { new Guid("faba9024-217b-45f5-b1d4-45f1036a0995"), "Товаропътнически", new Guid("f2ad3170-37d5-483d-a4f2-26b933c67118") }
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "Name", "VehicleTypeTypeId" },
                values: new object[,]
                {
                    { new Guid("0b3f1df4-5ebb-4b92-b79b-2f0bb89d2eb2"), "BMW", new Guid("ad5fbbce-fb6c-4e13-92ca-2f4b97911f49") },
                    { new Guid("5c20260c-1fe0-4f09-87d1-9fecab63bb93"), "Ford", new Guid("5e07a858-09c8-4653-9603-e59dcc1aea23") },
                    { new Guid("6adf767f-a026-4bac-81c7-407a379a745d"), "Lexus", new Guid("5e07a858-09c8-4653-9603-e59dcc1aea23") },
                    { new Guid("7a0ccdd0-847f-45bc-bf56-baac3fafbd37"), "Ferrari", new Guid("5e07a858-09c8-4653-9603-e59dcc1aea23") },
                    { new Guid("8e139c5f-3f01-4b8b-9471-4a87a2253db2"), "Alfa Romeo", new Guid("5e07a858-09c8-4653-9603-e59dcc1aea23") },
                    { new Guid("a45d4356-b783-4063-af85-ecb0287b682c"), "Mercedes-Benz", new Guid("5e07a858-09c8-4653-9603-e59dcc1aea23") },
                    { new Guid("adcf7fdf-46aa-4c40-a38a-61b4047d590f"), "Jeep", new Guid("ef5f6c10-a42e-4fe9-8f7a-5170d0b40f14") },
                    { new Guid("b53d3c4b-2227-482a-846d-e528bfe4d6f5"), "BMW", new Guid("ef5f6c10-a42e-4fe9-8f7a-5170d0b40f14") },
                    { new Guid("bccfe962-c5f7-41d6-b6c2-f32577cb47de"), "Audi", new Guid("5e07a858-09c8-4653-9603-e59dcc1aea23") },
                    { new Guid("c16d7e37-2017-46b1-bf0e-7dce36674ce4"), "Jeep", new Guid("5e07a858-09c8-4653-9603-e59dcc1aea23") },
                    { new Guid("da6e5a3a-79c5-4ffb-926d-b1fb055688c1"), "BMW", new Guid("5e07a858-09c8-4653-9603-e59dcc1aea23") },
                    { new Guid("ef196c35-750e-4904-bb67-eb9df6831267"), "Lada", new Guid("5e07a858-09c8-4653-9603-e59dcc1aea23") },
                    { new Guid("fa3de5c8-07c7-44f8-882d-ff87d51f5ad0"), "Audi", new Guid("ad5fbbce-fb6c-4e13-92ca-2f4b97911f49") }
                });

            migrationBuilder.InsertData(
                table: "Editions",
                columns: new[] { "Id", "BrandId", "Name" },
                values: new object[,]
                {
                    { new Guid("05109622-9b86-40c7-8b2b-89bafa09fc21"), new Guid("8e139c5f-3f01-4b8b-9471-4a87a2253db2"), "Spider" },
                    { new Guid("15e67473-da39-433b-8c24-50ae8344a48a"), new Guid("fa3de5c8-07c7-44f8-882d-ff87d51f5ad0"), "RS 6" },
                    { new Guid("1e9ade8f-9650-43cd-9cb9-cf167e53d61e"), new Guid("0b3f1df4-5ebb-4b92-b79b-2f0bb89d2eb2"), "i5 Touring" },
                    { new Guid("22656d2b-e20e-48d9-bee0-dd5e0c661dc3"), new Guid("b53d3c4b-2227-482a-846d-e528bfe4d6f5"), "430i Convertible" },
                    { new Guid("236ebe94-b13a-423a-97f4-9caed0519b90"), new Guid("adcf7fdf-46aa-4c40-a38a-61b4047d590f"), "Wrangler" },
                    { new Guid("2e89ffec-aae1-4620-b5f9-81b3fd59b04d"), new Guid("bccfe962-c5f7-41d6-b6c2-f32577cb47de"), "RSQ8" },
                    { new Guid("30160a51-800f-4e7f-88b0-6ba7cd352190"), new Guid("c16d7e37-2017-46b1-bf0e-7dce36674ce4"), "Avenger" },
                    { new Guid("71545e27-d6f3-41c6-ad01-d422b733c252"), new Guid("c16d7e37-2017-46b1-bf0e-7dce36674ce4"), "Jeep Grand Cherokee" },
                    { new Guid("94187284-2cdf-4d3c-8ae3-47c266122a26"), new Guid("fa3de5c8-07c7-44f8-882d-ff87d51f5ad0"), "А4 Allroad" },
                    { new Guid("9b5026f5-a2da-4fd1-9d64-adfbd1e1034e"), new Guid("da6e5a3a-79c5-4ffb-926d-b1fb055688c1"), "X6" },
                    { new Guid("a0eac45a-9df8-4307-9ecf-f9301e76bf02"), new Guid("7a0ccdd0-847f-45bc-bf56-baac3fafbd37"), "F12" },
                    { new Guid("a5c1ff08-a57c-49b7-80a9-7d5804e1b4ef"), new Guid("8e139c5f-3f01-4b8b-9471-4a87a2253db2"), "GT" },
                    { new Guid("aa7212f8-75b8-474a-91e2-dda3bc404caf"), new Guid("da6e5a3a-79c5-4ffb-926d-b1fb055688c1"), "X5" },
                    { new Guid("addca70a-f8e1-4165-9ad6-ead636411b65"), new Guid("0b3f1df4-5ebb-4b92-b79b-2f0bb89d2eb2"), "M3 Touring" },
                    { new Guid("be74fb89-0291-475c-9995-1982714d8b4d"), new Guid("5c20260c-1fe0-4f09-87d1-9fecab63bb93"), "Focus" },
                    { new Guid("c65b36c2-2eae-4908-83c0-3d0f2f773e6c"), new Guid("b53d3c4b-2227-482a-846d-e528bfe4d6f5"), "M3 Convertible" },
                    { new Guid("d06fd2a8-60f9-44fe-9484-5358855851b8"), new Guid("bccfe962-c5f7-41d6-b6c2-f32577cb47de"), "Q7" },
                    { new Guid("de1bafe4-18a6-404c-bef6-734f8bedd697"), new Guid("5c20260c-1fe0-4f09-87d1-9fecab63bb93"), "Fiesta" },
                    { new Guid("de5f924e-3139-4025-9156-929beed960b7"), new Guid("7a0ccdd0-847f-45bc-bf56-baac3fafbd37"), "Enzo" }
                });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "Color", "Condition", "Currency", "Distance", "EditionId", "EuroStandard", "Fuel", "HoursePower", "ImageURL", "IsVehicleApproved", "LocationRegion", "LocationTown", "MoreInformation", "Price", "UserId", "VinNumber", "Volume", "Year", "Тransmission" },
                values: new object[,]
                {
                    { new Guid("06befde8-a6ae-411d-9597-3705449e5bd1"), "Зелен", "Нов", "лв", 185639, new Guid("94187284-2cdf-4d3c-8ae3-47c266122a26"), "Euro 5", "Дизел", 170, "https://s1.1zoom.me/b4067/303/Audi_2019_A4_allroad_quattro_Grey_Metallic_Estate_570422_1920x1080.jpg", false, "Стара Загора", "Казанлък", "Колата няма никакви забележки, само задната лява седалка е скъсана.", 15399, new Guid("58481143-b8f4-4d21-bdec-5b118dd8a15a"), 10001, 2500, 2009, "Ръчна" },
                    { new Guid("0a1f1c92-f170-481f-a301-46c8f72c9b82"), "Син", "Употребяван", "лв", 128000, new Guid("d06fd2a8-60f9-44fe-9484-5358855851b8"), "Euro 4", "Дизел", 120, "https://wallpapers.com/images/hd/audi-q7-1920-x-1080-wallpaper-ty4995qkcstpam9g.jpg", false, "Варна", "Звездица", "Добре поддържан семейен автомобил. Нови гуми и спирачни дискове.", 13500, new Guid("58481143-b8f4-4d21-bdec-5b118dd8a15a"), 10003, 2200, 2012, "Ръчна" },
                    { new Guid("2e1506d8-3bf5-44a3-a123-f61b2d8372ba"), "Сив", "Употребяван", "лв", 75000, new Guid("2e89ffec-aae1-4620-b5f9-81b3fd59b04d"), "Euro 6", "Хибрид", 200, "https://i.pinimg.com/originals/1a/e6/ef/1ae6efcc6d506cbf6856226e430c4089.webp", false, "Пловдив", "Хисаря", "Луксозен седан с пълен пакет от екстри. Идеален за градско и извънградско шофиране.", 28900, new Guid("58481143-b8f4-4d21-bdec-5b118dd8a15a"), 10004, 3000, 2018, "Автоматична" },
                    { new Guid("30040efe-5fae-4561-a0cc-ddf6c8506fcf"), "Бял", "Употребяван", "лв", 105000, new Guid("addca70a-f8e1-4165-9ad6-ead636411b65"), "Euro 5", "Бензин", 90, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQrnXVaRLhg0-IVMjYYDpNcglt-_gBc6Milsv556WeEdQ&s", false, "Бургас", "Айтос", "Изключително икономичен автомобил, подходящ за градско пътуване. Нови амортисьори.", 8500, new Guid("58481143-b8f4-4d21-bdec-5b118dd8a15a"), 10005, 1600, 2010, "Ръчна" },
                    { new Guid("46e5e670-a3c7-4d9c-ae21-36ea81e7130e"), "Син", "Употребяван", "лв", 98000, new Guid("9b5026f5-a2da-4fd1-9d64-adfbd1e1034e"), "Euro 5", "Дизел", 120, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTgaB8Wc0vQIF1fAdhaeFqEmq88MxsP8jn4JCAK7bwY9A&s", false, "Плевен", "Плевен", "Семеен автомобил с комфортна икономичност. Идеален за пътувания с цялото семейство.", 10500, new Guid("58481143-b8f4-4d21-bdec-5b118dd8a15a"), 10008, 1800, 2013, "Ръчна" },
                    { new Guid("473c0c59-59b5-4fcb-811d-9ec16be8227b"), "Черен", "Употребяван", "лв", 185000, new Guid("71545e27-d6f3-41c6-ad01-d422b733c252"), "Euro 4", "Дизел", 140, "https://i.pinimg.com/originals/12/0d/6b/120d6b8793349feb2388eb99bea99fc2.jpg", false, "Русе", "Мартен", "Надежден и здрав пикап. Има леки външни забележки.", 12300, new Guid("58481143-b8f4-4d21-bdec-5b118dd8a15a"), 10006, 2500, 2011, "Ръчна" },
                    { new Guid("cb214956-0b7f-4d4e-954b-ab193df28bcc"), "Сребрист", "Употребяван", "лв", 67000, new Guid("1e9ade8f-9650-43cd-9cb9-cf167e53d61e"), "Euro 6", "Бензин", 160, "https://cdn.motor1.com/images/mgl/OoeOzl/s1/bmw-i5-edrive40-touring-2024.jpg", false, "Стара Загора", "Раднево", "Спортен хечбек с елегантен дизайн. Пълен сервизен история в оторизиран сервиз.", 18900, new Guid("58481143-b8f4-4d21-bdec-5b118dd8a15a"), 10007, 2000, 2017, "Автоматична" },
                    { new Guid("f6a6597e-f73c-46a1-abb2-b448f1883f96"), "Червен", "Употребяван", "USD", 95000, new Guid("15e67473-da39-433b-8c24-50ae8344a48a"), "Euro 6", "Бензин", 150, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQevdE1eAryK9STmDnZYNZhk4j2TA2f4HYutWX_U4zJoA&s", false, "София", "София", "Перфектно запазен автомобил с пълен сервизен история. Има леки драскотини на предния капак.", 21999, new Guid("58481143-b8f4-4d21-bdec-5b118dd8a15a"), 10002, 1800, 2015, "Автоматична" },
                    { new Guid("ff6a5a93-ceff-4ac3-bf26-c321717816cb"), "Червен", "Употребяван", "лв", 74000, new Guid("aa7212f8-75b8-474a-91e2-dda3bc404caf"), "Euro 6", "Бензин", 130, "https://wallpapers.com/images/hd/bmw-x5-1920-x-1080-wallpaper-v6n1t0uhafvmg7q3.jpg", false, "Хасково", "Харманли", "Здрав и надежден автомобил.", 14999, new Guid("58481143-b8f4-4d21-bdec-5b118dd8a15a"), 10009, 2200, 2016, "Автоматична" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("13ead2ca-3577-444c-a1ec-6dce24ad5bae"), new Guid("58481143-b8f4-4d21-bdec-5b118dd8a15a") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("24da8b40-25fa-4fb5-a453-b168ac1a6256"), new Guid("d1a1ff64-6926-4a47-a358-ff0f76f634b3") });

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("6adf767f-a026-4bac-81c7-407a379a745d"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("a45d4356-b783-4063-af85-ecb0287b682c"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("ef196c35-750e-4904-bb67-eb9df6831267"));

            migrationBuilder.DeleteData(
                table: "Editions",
                keyColumn: "Id",
                keyValue: new Guid("05109622-9b86-40c7-8b2b-89bafa09fc21"));

            migrationBuilder.DeleteData(
                table: "Editions",
                keyColumn: "Id",
                keyValue: new Guid("22656d2b-e20e-48d9-bee0-dd5e0c661dc3"));

            migrationBuilder.DeleteData(
                table: "Editions",
                keyColumn: "Id",
                keyValue: new Guid("236ebe94-b13a-423a-97f4-9caed0519b90"));

            migrationBuilder.DeleteData(
                table: "Editions",
                keyColumn: "Id",
                keyValue: new Guid("30160a51-800f-4e7f-88b0-6ba7cd352190"));

            migrationBuilder.DeleteData(
                table: "Editions",
                keyColumn: "Id",
                keyValue: new Guid("a0eac45a-9df8-4307-9ecf-f9301e76bf02"));

            migrationBuilder.DeleteData(
                table: "Editions",
                keyColumn: "Id",
                keyValue: new Guid("a5c1ff08-a57c-49b7-80a9-7d5804e1b4ef"));

            migrationBuilder.DeleteData(
                table: "Editions",
                keyColumn: "Id",
                keyValue: new Guid("be74fb89-0291-475c-9995-1982714d8b4d"));

            migrationBuilder.DeleteData(
                table: "Editions",
                keyColumn: "Id",
                keyValue: new Guid("c65b36c2-2eae-4908-83c0-3d0f2f773e6c"));

            migrationBuilder.DeleteData(
                table: "Editions",
                keyColumn: "Id",
                keyValue: new Guid("de1bafe4-18a6-404c-bef6-734f8bedd697"));

            migrationBuilder.DeleteData(
                table: "Editions",
                keyColumn: "Id",
                keyValue: new Guid("de5f924e-3139-4025-9156-929beed960b7"));

            migrationBuilder.DeleteData(
                table: "VehicleTypeTypes",
                keyColumn: "Id",
                keyValue: new Guid("14690830-faee-4cb9-84ca-8234a0696e8a"));

            migrationBuilder.DeleteData(
                table: "VehicleTypeTypes",
                keyColumn: "Id",
                keyValue: new Guid("2300898e-6b6f-41fd-a753-02a23634f764"));

            migrationBuilder.DeleteData(
                table: "VehicleTypeTypes",
                keyColumn: "Id",
                keyValue: new Guid("31347551-d8ce-48b8-8d73-9338163cd56f"));

            migrationBuilder.DeleteData(
                table: "VehicleTypeTypes",
                keyColumn: "Id",
                keyValue: new Guid("481e996e-febd-4d6d-a552-df039180948e"));

            migrationBuilder.DeleteData(
                table: "VehicleTypeTypes",
                keyColumn: "Id",
                keyValue: new Guid("ae578a5d-e436-4458-a851-b0007d9d30bf"));

            migrationBuilder.DeleteData(
                table: "VehicleTypeTypes",
                keyColumn: "Id",
                keyValue: new Guid("c2235044-8910-4cbe-ac12-a5f8ecc0b4d6"));

            migrationBuilder.DeleteData(
                table: "VehicleTypeTypes",
                keyColumn: "Id",
                keyValue: new Guid("c80fdbba-9d3d-485c-bb9d-085da4e9b69e"));

            migrationBuilder.DeleteData(
                table: "VehicleTypeTypes",
                keyColumn: "Id",
                keyValue: new Guid("faba9024-217b-45f5-b1d4-45f1036a0995"));

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

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("13ead2ca-3577-444c-a1ec-6dce24ad5bae"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("24da8b40-25fa-4fb5-a453-b168ac1a6256"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("58481143-b8f4-4d21-bdec-5b118dd8a15a"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d1a1ff64-6926-4a47-a358-ff0f76f634b3"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("5c20260c-1fe0-4f09-87d1-9fecab63bb93"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("7a0ccdd0-847f-45bc-bf56-baac3fafbd37"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("8e139c5f-3f01-4b8b-9471-4a87a2253db2"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("adcf7fdf-46aa-4c40-a38a-61b4047d590f"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("b53d3c4b-2227-482a-846d-e528bfe4d6f5"));

            migrationBuilder.DeleteData(
                table: "Editions",
                keyColumn: "Id",
                keyValue: new Guid("15e67473-da39-433b-8c24-50ae8344a48a"));

            migrationBuilder.DeleteData(
                table: "Editions",
                keyColumn: "Id",
                keyValue: new Guid("1e9ade8f-9650-43cd-9cb9-cf167e53d61e"));

            migrationBuilder.DeleteData(
                table: "Editions",
                keyColumn: "Id",
                keyValue: new Guid("2e89ffec-aae1-4620-b5f9-81b3fd59b04d"));

            migrationBuilder.DeleteData(
                table: "Editions",
                keyColumn: "Id",
                keyValue: new Guid("71545e27-d6f3-41c6-ad01-d422b733c252"));

            migrationBuilder.DeleteData(
                table: "Editions",
                keyColumn: "Id",
                keyValue: new Guid("94187284-2cdf-4d3c-8ae3-47c266122a26"));

            migrationBuilder.DeleteData(
                table: "Editions",
                keyColumn: "Id",
                keyValue: new Guid("9b5026f5-a2da-4fd1-9d64-adfbd1e1034e"));

            migrationBuilder.DeleteData(
                table: "Editions",
                keyColumn: "Id",
                keyValue: new Guid("aa7212f8-75b8-474a-91e2-dda3bc404caf"));

            migrationBuilder.DeleteData(
                table: "Editions",
                keyColumn: "Id",
                keyValue: new Guid("addca70a-f8e1-4165-9ad6-ead636411b65"));

            migrationBuilder.DeleteData(
                table: "Editions",
                keyColumn: "Id",
                keyValue: new Guid("d06fd2a8-60f9-44fe-9484-5358855851b8"));

            migrationBuilder.DeleteData(
                table: "VehicleTypeSections",
                keyColumn: "Id",
                keyValue: new Guid("213a952a-30ff-4e56-b256-1cfb795c7a01"));

            migrationBuilder.DeleteData(
                table: "VehicleTypeSections",
                keyColumn: "Id",
                keyValue: new Guid("f2ad3170-37d5-483d-a4f2-26b933c67118"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("0b3f1df4-5ebb-4b92-b79b-2f0bb89d2eb2"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("bccfe962-c5f7-41d6-b6c2-f32577cb47de"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("c16d7e37-2017-46b1-bf0e-7dce36674ce4"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("da6e5a3a-79c5-4ffb-926d-b1fb055688c1"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("fa3de5c8-07c7-44f8-882d-ff87d51f5ad0"));

            migrationBuilder.DeleteData(
                table: "VehicleTypeTypes",
                keyColumn: "Id",
                keyValue: new Guid("ef5f6c10-a42e-4fe9-8f7a-5170d0b40f14"));

            migrationBuilder.DeleteData(
                table: "VehicleTypeTypes",
                keyColumn: "Id",
                keyValue: new Guid("5e07a858-09c8-4653-9603-e59dcc1aea23"));

            migrationBuilder.DeleteData(
                table: "VehicleTypeTypes",
                keyColumn: "Id",
                keyValue: new Guid("ad5fbbce-fb6c-4e13-92ca-2f4b97911f49"));

            migrationBuilder.DeleteData(
                table: "VehicleTypeSections",
                keyColumn: "Id",
                keyValue: new Guid("631cbfed-14b6-4350-a5cf-9f9980501428"));
        }
    }
}
