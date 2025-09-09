using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CrochetLibrary.Migrations
{
    /// <inheritdoc />
    public partial class RatingRequired : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                name: "Requests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ToyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SubscribeToNewsletter = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requests", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Toys",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Price = table.Column<double>(type: "float(18)", precision: 18, scale: 2, nullable: false),
                    Colors = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    CraftingTimeInDays = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Toys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CustomerRating = table.Column<double>(type: "float", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    ReviewDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ToyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_Toys_ToyId",
                        column: x => x.ToyId,
                        principalTable: "Toys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ToyImages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false),
                    ToyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToyImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ToyImages_Toys_ToyId",
                        column: x => x.ToyId,
                        principalTable: "Toys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Toys",
                columns: new[] { "Id", "Colors", "CraftingTimeInDays", "Description", "Name", "Price", "Stock" },
                values: new object[,]
                {
                    { new Guid("2d23265c-86b0-4906-a8e6-bdca192e7303"), "Brown, Beige, Cream", 0, "Soft and cuddly hand-crocheted teddy bear...", "Classic Teddy Bear", 24.989999999999998, 20 },
                    { new Guid("72a973e8-9874-4f71-9993-288e2b8aa652"), "White, Pink, Lavender", 0, "Adorable crochet bunny...", "Amigurumi Bunny", 29.5, 15 },
                    { new Guid("75345eb2-421d-40c4-97e0-fa0d1a9d2b42"), "Green, Blue, Orange", 0, "Playful crochet dinosaur...", "Dinosaur Plushie", 26.75, 18 },
                    { new Guid("e5b98d46-47ad-4e92-92d0-479912b49a80"), "Blue, Teal, Purple", 0, "Soft, huggable octopus...", "Octopus Cuddle Buddy", 22.5, 25 },
                    { new Guid("f5a0017b-f892-4765-90cf-442f8e7dcc86"), "White, Rainbow", 0, "Magical hand-crocheted unicorn...", "Rainbow Unicorn", 34.990000000000002, 12 }
                });

            migrationBuilder.InsertData(
                table: "ToyImages",
                columns: new[] { "Id", "DisplayOrder", "ImageUrl", "ToyId" },
                values: new object[,]
                {
                    { new Guid("166f1406-6d4c-4026-8dbf-046a580c6c2a"), 2, "https://cdn.leonardo.ai/users/ff8f3895-401f-4c98-8ac2-468b47e1f545/generations/06c5c23d-5ab7-44ce-9ec4-e857a8078be4/segments/2:4:1/Flux_Dev_A_soft_cuddly_and_adorable_amigurumi_bunny_sits_uprig_1.jpg", new Guid("72a973e8-9874-4f71-9993-288e2b8aa652") },
                    { new Guid("3f6f0c87-11a4-495f-8508-9ff61df9f736"), 2, "https://cdn.leonardo.ai/users/ff8f3895-401f-4c98-8ac2-468b47e1f545/generations/51b6901d-4b2f-4806-ae6f-bbf0707b2d31/segments/3:4:1/Flux_Dev_A_whimsical_softfocus_illustration_of_an_adorable_oct_2.jpg", new Guid("e5b98d46-47ad-4e92-92d0-479912b49a80") },
                    { new Guid("410bf016-c2fd-475f-8ee4-86b92aa054f5"), 3, "https://cdn.leonardo.ai/users/ff8f3895-401f-4c98-8ac2-468b47e1f545/generations/06c5c23d-5ab7-44ce-9ec4-e857a8078be4/segments/1:4:1/Flux_Dev_A_soft_cuddly_and_adorable_amigurumi_bunny_sits_uprig_0.jpg", new Guid("72a973e8-9874-4f71-9993-288e2b8aa652") },
                    { new Guid("575c845f-fa9b-4ec8-b406-288115acc542"), 2, "https://cdn.leonardo.ai/users/ff8f3895-401f-4c98-8ac2-468b47e1f545/generations/114528bd-c0ef-4219-956f-e29c159224fe/segments/3:4:1/Flux_Dev_A_soft_cuddly_and_endearing_classic_teddy_bear_made_e_2.jpg", new Guid("2d23265c-86b0-4906-a8e6-bdca192e7303") },
                    { new Guid("7d691772-26fa-4907-aec9-0c812589def4"), 3, "https://cdn.leonardo.ai/users/ff8f3895-401f-4c98-8ac2-468b47e1f545/generations/51b6901d-4b2f-4806-ae6f-bbf0707b2d31/segments/2:4:1/Flux_Dev_A_whimsical_softfocus_illustration_of_an_adorable_oct_1.jpg", new Guid("e5b98d46-47ad-4e92-92d0-479912b49a80") },
                    { new Guid("7efa70fd-fe9b-43ee-b98e-15ec57352a50"), 1, "https://cdn.leonardo.ai/users/ff8f3895-401f-4c98-8ac2-468b47e1f545/generations/237f1559-8d57-4502-a8cd-bcaf40029321/segments/4:4:1/Flux_Dev_A_colorful_and_vibrant_illustration_of_a_dinosaur_plu_3.jpg", new Guid("75345eb2-421d-40c4-97e0-fa0d1a9d2b42") },
                    { new Guid("a046d334-f60c-4a21-a0c9-d91f0446fdfe"), 1, "https://cdn.leonardo.ai/users/ff8f3895-401f-4c98-8ac2-468b47e1f545/generations/114528bd-c0ef-4219-956f-e29c159224fe/segments/1:4:1/Flux_Dev_A_soft_cuddly_and_endearing_classic_teddy_bear_made_e_0.jpg", new Guid("2d23265c-86b0-4906-a8e6-bdca192e7303") },
                    { new Guid("ac75e071-178d-4ef4-ae54-b2a867c5eeca"), 2, "https://cdn.leonardo.ai/users/ff8f3895-401f-4c98-8ac2-468b47e1f545/generations/237f1559-8d57-4502-a8cd-bcaf40029321/segments/2:4:1/Flux_Dev_A_colorful_and_vibrant_illustration_of_a_dinosaur_plu_1.jpg", new Guid("75345eb2-421d-40c4-97e0-fa0d1a9d2b42") },
                    { new Guid("b113cdbf-2b0b-4e9b-9b26-8b9f1c312f3d"), 3, "https://cdn.leonardo.ai/users/ff8f3895-401f-4c98-8ac2-468b47e1f545/generations/237f1559-8d57-4502-a8cd-bcaf40029321/segments/1:4:1/Flux_Dev_A_colorful_and_vibrant_illustration_of_a_dinosaur_plu_0.jpg", new Guid("75345eb2-421d-40c4-97e0-fa0d1a9d2b42") },
                    { new Guid("b49cf28d-7afc-425c-8c5a-8274c4ad43cc"), 3, "https://cdn.leonardo.ai/users/ff8f3895-401f-4c98-8ac2-468b47e1f545/generations/114528bd-c0ef-4219-956f-e29c159224fe/segments/4:4:1/Flux_Dev_A_soft_cuddly_and_endearing_classic_teddy_bear_made_e_3.jpg", new Guid("2d23265c-86b0-4906-a8e6-bdca192e7303") },
                    { new Guid("b4c86e43-d355-4f1b-85ce-bfccbbacc94a"), 2, "https://cdn.leonardo.ai/users/ff8f3895-401f-4c98-8ac2-468b47e1f545/generations/46871dcc-53a3-4ae0-994f-c6f35dd47de3/segments/3:4:1/Flux_Dev_A_vibrant_whimsical_illustration_of_a_rainbow_unicorn_2.jpg", new Guid("f5a0017b-f892-4765-90cf-442f8e7dcc86") },
                    { new Guid("c3969b0a-de64-428c-9a74-74ccfe9049aa"), 1, "https://cdn.leonardo.ai/users/ff8f3895-401f-4c98-8ac2-468b47e1f545/generations/06c5c23d-5ab7-44ce-9ec4-e857a8078be4/segments/4:4:1/Flux_Dev_A_soft_cuddly_and_adorable_amigurumi_bunny_sits_uprig_3.jpg", new Guid("72a973e8-9874-4f71-9993-288e2b8aa652") },
                    { new Guid("c485032d-852e-429d-842d-3eac1805596f"), 1, "https://cdn.leonardo.ai/users/ff8f3895-401f-4c98-8ac2-468b47e1f545/generations/51b6901d-4b2f-4806-ae6f-bbf0707b2d31/segments/4:4:1/Flux_Dev_A_whimsical_softfocus_illustration_of_an_adorable_oct_3.jpg", new Guid("e5b98d46-47ad-4e92-92d0-479912b49a80") },
                    { new Guid("eb3be83e-bbcf-477c-a242-aaa968eb52cf"), 3, "https://cdn.leonardo.ai/users/ff8f3895-401f-4c98-8ac2-468b47e1f545/generations/46871dcc-53a3-4ae0-994f-c6f35dd47de3/segments/2:4:1/Flux_Dev_A_vibrant_whimsical_illustration_of_a_rainbow_unicorn_1.jpg", new Guid("f5a0017b-f892-4765-90cf-442f8e7dcc86") },
                    { new Guid("ed1fb5de-cf32-4246-bd4a-03029e403a83"), 1, "https://cdn.leonardo.ai/users/ff8f3895-401f-4c98-8ac2-468b47e1f545/generations/46871dcc-53a3-4ae0-994f-c6f35dd47de3/segments/4:4:1/Flux_Dev_A_vibrant_whimsical_illustration_of_a_rainbow_unicorn_3.jpg", new Guid("f5a0017b-f892-4765-90cf-442f8e7dcc86") }
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
                name: "IX_Reviews_ToyId",
                table: "Reviews",
                column: "ToyId");

            migrationBuilder.CreateIndex(
                name: "IX_ToyImages_ToyId_DisplayOrder",
                table: "ToyImages",
                columns: new[] { "ToyId", "DisplayOrder" });
        }

        /// <inheritdoc />
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
                name: "Requests");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "ToyImages");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Toys");
        }
    }
}
