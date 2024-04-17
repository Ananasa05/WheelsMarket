using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WheelsMarket.Migrations
{
    public partial class fixedMigrations2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("13ead2ca-3577-444c-a1ec-6dce24ad5bae"),
                column: "ConcurrencyStamp",
                value: "e1b5e66c-62cb-442f-9a3b-542348e36a7e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("24da8b40-25fa-4fb5-a453-b168ac1a6256"),
                column: "ConcurrencyStamp",
                value: "6465a1d8-97a9-4448-89ea-e484ea2921ac");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("58481143-b8f4-4d21-bdec-5b118dd8a15a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "34ac4505-699d-4dc1-97d7-580df4f0b74b", "AQAAAAEAACcQAAAAENQiKvC5ZgYvS1PCMw6IewtH7JLxBsyaih8Y3f+kS72HUIs5CE3U73431WxXmtOqzQ==", "07b1eb8a-d2ce-43d8-979d-e4a590135932" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d1a1ff64-6926-4a47-a358-ff0f76f634b3"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "af0ac38c-3935-4029-87de-7f567f7adcf9", "AQAAAAEAACcQAAAAELbOfevKoM4RPTThUTzzzdyS0jxGuax1Z7NlvVvmuhrn69D8gZAlFVZ9wZuknYdkew==", "2df85017-21dd-40ed-814e-9b5fefbe8b4b" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("06befde8-a6ae-411d-9597-3705449e5bd1"),
                column: "UserId",
                value: new Guid("58481143-b8f4-4d21-bdec-5b118dd8a15a"));

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("0a1f1c92-f170-481f-a301-46c8f72c9b82"),
                column: "UserId",
                value: new Guid("58481143-b8f4-4d21-bdec-5b118dd8a15a"));

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("2e1506d8-3bf5-44a3-a123-f61b2d8372ba"),
                column: "UserId",
                value: new Guid("58481143-b8f4-4d21-bdec-5b118dd8a15a"));

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("30040efe-5fae-4561-a0cc-ddf6c8506fcf"),
                column: "UserId",
                value: new Guid("58481143-b8f4-4d21-bdec-5b118dd8a15a"));

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("46e5e670-a3c7-4d9c-ae21-36ea81e7130e"),
                column: "UserId",
                value: new Guid("58481143-b8f4-4d21-bdec-5b118dd8a15a"));

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("473c0c59-59b5-4fcb-811d-9ec16be8227b"),
                column: "UserId",
                value: new Guid("58481143-b8f4-4d21-bdec-5b118dd8a15a"));

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("cb214956-0b7f-4d4e-954b-ab193df28bcc"),
                column: "UserId",
                value: new Guid("58481143-b8f4-4d21-bdec-5b118dd8a15a"));

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("f6a6597e-f73c-46a1-abb2-b448f1883f96"),
                column: "UserId",
                value: new Guid("58481143-b8f4-4d21-bdec-5b118dd8a15a"));

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("ff6a5a93-ceff-4ac3-bf26-c321717816cb"),
                column: "UserId",
                value: new Guid("58481143-b8f4-4d21-bdec-5b118dd8a15a"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("13ead2ca-3577-444c-a1ec-6dce24ad5bae"),
                column: "ConcurrencyStamp",
                value: "65ad19f5-806e-43ee-8687-8139d9cbe884");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("24da8b40-25fa-4fb5-a453-b168ac1a6256"),
                column: "ConcurrencyStamp",
                value: "48d5aee8-558b-403f-bff0-007f766d946e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("58481143-b8f4-4d21-bdec-5b118dd8a15a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fc821531-60e0-41b0-85d3-23ef9423732b", "AQAAAAEAACcQAAAAELGPfWSguqG/9OZZQGlNIfyM82AfBfXj1kT5IyunR5A8bE8dw8/+15blvmJSQRDWBw==", "ad3660c3-e4f8-404f-9399-d200899888bd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d1a1ff64-6926-4a47-a358-ff0f76f634b3"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1b069de7-5c34-4eba-9e3f-8625eaece52a", "AQAAAAEAACcQAAAAEM4iv4IDwa4x37qZU9vdsBPmtu/YVATB4OnqwalU0fx6fJrSeXiliOFqjnbqdxmzkQ==", "555bcd73-3ce8-4719-a41f-c4a6173e5fc2" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("06befde8-a6ae-411d-9597-3705449e5bd1"),
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("0a1f1c92-f170-481f-a301-46c8f72c9b82"),
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("2e1506d8-3bf5-44a3-a123-f61b2d8372ba"),
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("30040efe-5fae-4561-a0cc-ddf6c8506fcf"),
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("46e5e670-a3c7-4d9c-ae21-36ea81e7130e"),
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("473c0c59-59b5-4fcb-811d-9ec16be8227b"),
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("cb214956-0b7f-4d4e-954b-ab193df28bcc"),
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("f6a6597e-f73c-46a1-abb2-b448f1883f96"),
                column: "UserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("ff6a5a93-ceff-4ac3-bf26-c321717816cb"),
                column: "UserId",
                value: null);
        }
    }
}
