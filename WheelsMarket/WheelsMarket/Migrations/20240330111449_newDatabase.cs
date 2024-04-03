using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WheelsMarket.Migrations
{
    public partial class newDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VehicleTypeSections",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Section = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleTypeSections", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VehicleTypeTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VehicleTypeSectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleTypeTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VehicleTypeTypes_VehicleTypeSections_VehicleTypeSectionId",
                        column: x => x.VehicleTypeSectionId,
                        principalTable: "VehicleTypeSections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VehicleTypeTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Brands_VehicleTypeTypes_VehicleTypeTypeId",
                        column: x => x.VehicleTypeTypeId,
                        principalTable: "VehicleTypeTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Editions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BrandId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Editions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Editions_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Тransmission = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Volume = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: true),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Distance = table.Column<int>(type: "int", nullable: true),
                    Fuel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Condition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Year = table.Column<int>(type: "int", nullable: true),
                    EuroStandard = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VinNumber = table.Column<int>(type: "int", nullable: true),
                    Currency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HoursePower = table.Column<int>(type: "int", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MoreInformation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EditionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vehicles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Vehicles_Editions_EditionId",
                        column: x => x.EditionId,
                        principalTable: "Editions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Favourites",
                columns: table => new
                {
                    VehicleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsFavourite = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Favourites", x => new { x.UserId, x.VehicleId });
                    table.ForeignKey(
                        name: "FK_Favourites_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Favourites_Vehicles_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicles",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "VehicleTypeSections",
                columns: new[] { "Id", "Section" },
                values: new object[] { new Guid("213a952a-30ff-4e56-b256-1cfb795c7a01"), "Камиони" });

            migrationBuilder.InsertData(
                table: "VehicleTypeSections",
                columns: new[] { "Id", "Section" },
                values: new object[] { new Guid("631cbfed-14b6-4350-a5cf-9f9980501428"), "Автомобили и джипове" });

            migrationBuilder.InsertData(
                table: "VehicleTypeSections",
                columns: new[] { "Id", "Section" },
                values: new object[] { new Guid("f2ad3170-37d5-483d-a4f2-26b933c67118"), "Бусове" });

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

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Brands_VehicleTypeTypeId",
                table: "Brands",
                column: "VehicleTypeTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Editions_BrandId",
                table: "Editions",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Favourites_VehicleId",
                table: "Favourites",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_EditionId",
                table: "Vehicles",
                column: "EditionId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_UserId",
                table: "Vehicles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleTypeTypes_VehicleTypeSectionId",
                table: "VehicleTypeTypes",
                column: "VehicleTypeSectionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Favourites");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Vehicles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Editions");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "VehicleTypeTypes");

            migrationBuilder.DropTable(
                name: "VehicleTypeSections");
        }
    }
}
