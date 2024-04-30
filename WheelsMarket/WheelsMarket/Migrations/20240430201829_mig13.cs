using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WheelsMarket.Migrations
{
    public partial class mig13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("13ead2ca-3577-444c-a1ec-6dce24ad5bae"),
                column: "ConcurrencyStamp",
                value: "103427bc-cbe6-45aa-aa95-2a79aee95617");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("24da8b40-25fa-4fb5-a453-b168ac1a6256"),
                column: "ConcurrencyStamp",
                value: "cd69f879-c6e2-42c5-b1b8-8ebf44b041b0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("58481143-b8f4-4d21-bdec-5b118dd8a15a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "830a9a60-f390-4d14-ba60-63088ecd3ef7", "AQAAAAEAACcQAAAAEIPq/VSO0tBh8TLrSiE9TjCheoHB48ppjHoNDnZDSmgaDa7XN2k1RUFSCeHaRamofw==", "3e733bd9-2e86-47f8-888d-309b0e721be3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d1a1ff64-6926-4a47-a358-ff0f76f634b3"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "53ea7b3d-37a5-415e-931d-407f090f7af8", "AQAAAAEAACcQAAAAEDTwROuWEi/G6YpjHGJ+3RbzC5jAnbCtGxmtoaGJiKPkvG9LgelIG5BibtK64bMQwA==", "bfbe4eae-9119-4516-b3bd-69a8372edf65" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("13ead2ca-3577-444c-a1ec-6dce24ad5bae"),
                column: "ConcurrencyStamp",
                value: "ed3cf670-d522-42ad-ab3d-18659f4b1b89");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("24da8b40-25fa-4fb5-a453-b168ac1a6256"),
                column: "ConcurrencyStamp",
                value: "db096734-548e-4524-ae55-5a47f49db728");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("58481143-b8f4-4d21-bdec-5b118dd8a15a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a32bca90-d97a-4abd-b59c-e9ff5dc7494e", "AQAAAAEAACcQAAAAEGTLxfG+CQ5I3YGo7rYElg6DoKZSLaiyuJWRb4aeXkPMFoQ2DTJ57TJxbXJbjmVSUg==", "13f5e1a8-d855-4cbb-b4a0-48b3abbf5125" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d1a1ff64-6926-4a47-a358-ff0f76f634b3"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4bf914c2-37dd-4e04-84b7-0a3fb8d61b61", "AQAAAAEAACcQAAAAEFjS+oVuF9FNp7p0U0NsFOGWPo0MSk8nwSiYL5fp+1wo/e0iVRai9mP8LH3uY5XVGw==", "c2302783-822c-4114-978e-e1eef28f5621" });
        }
    }
}
