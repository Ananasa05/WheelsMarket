using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WheelsMarket.Migrations
{
    public partial class addingApprovelInVehicle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsVehicleApproved",
                table: "Vehicles",
                type: "bit",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("06befde8-a6ae-411d-9597-3705449e5bd1"),
                column: "IsVehicleApproved",
                value: false);

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("0a1f1c92-f170-481f-a301-46c8f72c9b82"),
                column: "IsVehicleApproved",
                value: false);

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("2e1506d8-3bf5-44a3-a123-f61b2d8372ba"),
                column: "IsVehicleApproved",
                value: false);

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("30040efe-5fae-4561-a0cc-ddf6c8506fcf"),
                column: "IsVehicleApproved",
                value: false);

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("46e5e670-a3c7-4d9c-ae21-36ea81e7130e"),
                column: "IsVehicleApproved",
                value: false);

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("473c0c59-59b5-4fcb-811d-9ec16be8227b"),
                column: "IsVehicleApproved",
                value: false);

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("cb214956-0b7f-4d4e-954b-ab193df28bcc"),
                column: "IsVehicleApproved",
                value: false);

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("f6a6597e-f73c-46a1-abb2-b448f1883f96"),
                column: "IsVehicleApproved",
                value: false);

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("ff6a5a93-ceff-4ac3-bf26-c321717816cb"),
                column: "IsVehicleApproved",
                value: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsVehicleApproved",
                table: "Vehicles");
        }
    }
}
