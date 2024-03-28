using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WheelsMarket.Migrations
{
    public partial class rewire2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_VehicleTypeTypes_VehicleTypeTypeId",
                table: "Vehicles");

            migrationBuilder.DropIndex(
                name: "IX_Vehicles_VehicleTypeTypeId",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "VehicleTypeTypeId",
                table: "Vehicles");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "VehicleTypeTypeId",
                table: "Vehicles",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_VehicleTypeTypeId",
                table: "Vehicles",
                column: "VehicleTypeTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_VehicleTypeTypes_VehicleTypeTypeId",
                table: "Vehicles",
                column: "VehicleTypeTypeId",
                principalTable: "VehicleTypeTypes",
                principalColumn: "Id");
        }
    }
}
