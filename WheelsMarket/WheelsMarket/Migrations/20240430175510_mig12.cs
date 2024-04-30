using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WheelsMarket.Migrations
{
    public partial class mig12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("13ead2ca-3577-444c-a1ec-6dce24ad5bae"),
                column: "ConcurrencyStamp",
                value: "8d2083ca-3275-4b2b-a12f-76f44c337972");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("24da8b40-25fa-4fb5-a453-b168ac1a6256"),
                column: "ConcurrencyStamp",
                value: "dd3edad8-bcb4-4436-a4a2-6fd7b0a1951c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("58481143-b8f4-4d21-bdec-5b118dd8a15a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6cfd64ac-99cc-49c4-a0a1-4ea7f0cef37e", "AQAAAAEAACcQAAAAEF/Mfq057BXIRpZ6Y3mSCyndeD5Umcj4B1pIaVuKSa3+YXvhP1CW22+lx1ErhXLMRw==", "368cd1ad-2343-45b9-a40a-b32f57ad305e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d1a1ff64-6926-4a47-a358-ff0f76f634b3"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d7f3dcdb-7e60-43ea-8e1c-fd54f798f2c7", "AQAAAAEAACcQAAAAEKljz7jt4Kpg/AvZREOVAIG4OWWReSk1RxEh1ABUybRFKrycLOfXr0xVO7p5RkVRMQ==", "2765c00b-ea54-4a3b-8fb1-3337ccc58a37" });
        }
    }
}
