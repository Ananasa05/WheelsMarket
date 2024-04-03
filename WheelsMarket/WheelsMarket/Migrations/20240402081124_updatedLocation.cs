using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WheelsMarket.Migrations
{
    public partial class updatedLocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Location",
                table: "Vehicles",
                newName: "LocationTown");

            migrationBuilder.AddColumn<string>(
                name: "LocationRegion",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LocationRegion",
                table: "Vehicles");

            migrationBuilder.RenameColumn(
                name: "LocationTown",
                table: "Vehicles",
                newName: "Location");
        }
    }
}
