using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WheelsMarket.Migrations
{
    public partial class addVehicleConfigurationsFully : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("06befde8-a6ae-411d-9597-3705449e5bd1"),
                column: "ImageURL",
                value: "https://s1.1zoom.me/b4067/303/Audi_2019_A4_allroad_quattro_Grey_Metallic_Estate_570422_1920x1080.jpg");

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("0a1f1c92-f170-481f-a301-46c8f72c9b82"),
                column: "ImageURL",
                value: "https://wallpapers.com/images/hd/audi-q7-1920-x-1080-wallpaper-ty4995qkcstpam9g.jpg");

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("2e1506d8-3bf5-44a3-a123-f61b2d8372ba"),
                column: "ImageURL",
                value: "https://i.pinimg.com/originals/1a/e6/ef/1ae6efcc6d506cbf6856226e430c4089.webp");

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("30040efe-5fae-4561-a0cc-ddf6c8506fcf"),
                column: "ImageURL",
                value: "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQrnXVaRLhg0-IVMjYYDpNcglt-_gBc6Milsv556WeEdQ&s");

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("46e5e670-a3c7-4d9c-ae21-36ea81e7130e"),
                column: "ImageURL",
                value: "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTgaB8Wc0vQIF1fAdhaeFqEmq88MxsP8jn4JCAK7bwY9A&s");

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("473c0c59-59b5-4fcb-811d-9ec16be8227b"),
                column: "ImageURL",
                value: "https://i.pinimg.com/originals/12/0d/6b/120d6b8793349feb2388eb99bea99fc2.jpg");

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("cb214956-0b7f-4d4e-954b-ab193df28bcc"),
                column: "ImageURL",
                value: "https://cdn.motor1.com/images/mgl/OoeOzl/s1/bmw-i5-edrive40-touring-2024.jpg");

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("f6a6597e-f73c-46a1-abb2-b448f1883f96"),
                column: "ImageURL",
                value: "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQevdE1eAryK9STmDnZYNZhk4j2TA2f4HYutWX_U4zJoA&s");

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("ff6a5a93-ceff-4ac3-bf26-c321717816cb"),
                column: "ImageURL",
                value: "https://wallpapers.com/images/hd/bmw-x5-1920-x-1080-wallpaper-v6n1t0uhafvmg7q3.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("06befde8-a6ae-411d-9597-3705449e5bd1"),
                column: "ImageURL",
                value: "https://s.car.info/image_files/1920/side-1-906746.jpg");

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("0a1f1c92-f170-481f-a301-46c8f72c9b82"),
                column: "ImageURL",
                value: "https://s.car.info/image_files/1920/side-1-906748.jpg");

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("2e1506d8-3bf5-44a3-a123-f61b2d8372ba"),
                column: "ImageURL",
                value: "https://s.car.info/image_files/1920/side-1-906749.jpg");

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("30040efe-5fae-4561-a0cc-ddf6c8506fcf"),
                column: "ImageURL",
                value: "https://s.car.info/image_files/1920/side-1-906750.jpg");

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("46e5e670-a3c7-4d9c-ae21-36ea81e7130e"),
                column: "ImageURL",
                value: "https://s.car.info/image_files/1920/side-1-906753.jpg");

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("473c0c59-59b5-4fcb-811d-9ec16be8227b"),
                column: "ImageURL",
                value: "https://s.car.info/image_files/1920/side-1-906751.jpg");

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("cb214956-0b7f-4d4e-954b-ab193df28bcc"),
                column: "ImageURL",
                value: "https://s.car.info/image_files/1920/side-1-906752.jpg");

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("f6a6597e-f73c-46a1-abb2-b448f1883f96"),
                column: "ImageURL",
                value: "https://s.car.info/image_files/1920/side-1-906747.jpg");

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("ff6a5a93-ceff-4ac3-bf26-c321717816cb"),
                column: "ImageURL",
                value: "https://s.car.info/image_files/1920/side-1-906753.jpg");
        }
    }
}
