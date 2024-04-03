using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WheelsMarket.Migrations
{
    public partial class fixedFavourites : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Favourites_Vehicles_VehicleId",
                table: "Favourites");

            migrationBuilder.DropColumn(
                name: "IsFavourite",
                table: "Favourites");

            migrationBuilder.AddForeignKey(
                name: "FK_Favourites_Vehicles_VehicleId",
                table: "Favourites",
                column: "VehicleId",
                principalTable: "Vehicles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Favourites_Vehicles_VehicleId",
                table: "Favourites");

            migrationBuilder.AddColumn<bool>(
                name: "IsFavourite",
                table: "Favourites",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddForeignKey(
                name: "FK_Favourites_Vehicles_VehicleId",
                table: "Favourites",
                column: "VehicleId",
                principalTable: "Vehicles",
                principalColumn: "Id");
        }
    }
}
