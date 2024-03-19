using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WheelsMarket.Migrations
{
    public partial class AddingAlmostEveryThingToVehicle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageURL",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Volume",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Year",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Тransmission",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageURL",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "Volume",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "Year",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "Тransmission",
                table: "Vehicles");
        }
    }
}
