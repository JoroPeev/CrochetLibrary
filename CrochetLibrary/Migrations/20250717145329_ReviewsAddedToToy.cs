using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CrochetLibrary.Migrations
{
    /// <inheritdoc />
    public partial class ReviewsAddedToToy : Migration
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
                    CraftingTimeInDays = table.Column<int>(type: "int", nullable: false),
                    CustomerRating = table.Column<double>(type: "float", nullable: true)
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
                columns: new[] { "Id", "Colors", "CraftingTimeInDays", "CustomerRating", "Description", "Name", "Price", "Stock" },
                values: new object[,]
                {
                    { new Guid("0c983bc2-517c-4a1a-8868-648470f40479"), "White, Pink, Lavender", 0, null, "Adorable crochet bunny...", "Amigurumi Bunny", 29.5, 15 },
                    { new Guid("21f85996-213f-4709-9505-4a3275fd7c57"), "Brown, Beige, Cream", 0, null, "Soft and cuddly hand-crocheted teddy bear...", "Classic Teddy Bear", 24.989999999999998, 20 },
                    { new Guid("a74b26e9-774e-4b9f-859e-c7515f3983de"), "White, Rainbow", 0, null, "Magical hand-crocheted unicorn...", "Rainbow Unicorn", 34.990000000000002, 12 },
                    { new Guid("e1d30af1-50f7-4a21-af44-ef20e8eef5ff"), "Green, Blue, Orange", 0, null, "Playful crochet dinosaur...", "Dinosaur Plushie", 26.75, 18 },
                    { new Guid("e4c44e1a-cb58-426f-b3d0-b8b1a6ca03fa"), "Blue, Teal, Purple", 0, null, "Soft, huggable octopus...", "Octopus Cuddle Buddy", 22.5, 25 }
                });

            migrationBuilder.InsertData(
                table: "ToyImages",
                columns: new[] { "Id", "DisplayOrder", "ImageUrl", "ToyId" },
                values: new object[,]
                {
                    { new Guid("2397ce27-0642-4424-84f3-87ce79d60fcf"), 1, "https://cdn.leonardo.ai/users/ff8f3895-401f-4c98-8ac2-468b47e1f545/generations/46871dcc-53a3-4ae0-994f-c6f35dd47de3/segments/4:4:1/Flux_Dev_A_vibrant_whimsical_illustration_of_a_rainbow_unicorn_3.jpg", new Guid("a74b26e9-774e-4b9f-859e-c7515f3983de") },
                    { new Guid("32939437-92b4-4e09-8da6-5e5ce0b2f8be"), 1, "https://cdn.leonardo.ai/users/ff8f3895-401f-4c98-8ac2-468b47e1f545/generations/114528bd-c0ef-4219-956f-e29c159224fe/segments/1:4:1/Flux_Dev_A_soft_cuddly_and_endearing_classic_teddy_bear_made_e_0.jpg", new Guid("21f85996-213f-4709-9505-4a3275fd7c57") },
                    { new Guid("3650833f-78cc-4395-8914-92893de99afa"), 3, "https://cdn.leonardo.ai/users/ff8f3895-401f-4c98-8ac2-468b47e1f545/generations/114528bd-c0ef-4219-956f-e29c159224fe/segments/4:4:1/Flux_Dev_A_soft_cuddly_and_endearing_classic_teddy_bear_made_e_3.jpg", new Guid("21f85996-213f-4709-9505-4a3275fd7c57") },
                    { new Guid("36ad4d89-564e-40d4-aadc-fd8b5a0434fa"), 1, "https://cdn.leonardo.ai/users/ff8f3895-401f-4c98-8ac2-468b47e1f545/generations/237f1559-8d57-4502-a8cd-bcaf40029321/segments/4:4:1/Flux_Dev_A_colorful_and_vibrant_illustration_of_a_dinosaur_plu_3.jpg", new Guid("e1d30af1-50f7-4a21-af44-ef20e8eef5ff") },
                    { new Guid("52ff511a-756d-4faa-bcfc-b5cc4dec2b54"), 2, "https://cdn.leonardo.ai/users/ff8f3895-401f-4c98-8ac2-468b47e1f545/generations/06c5c23d-5ab7-44ce-9ec4-e857a8078be4/segments/2:4:1/Flux_Dev_A_soft_cuddly_and_adorable_amigurumi_bunny_sits_uprig_1.jpg", new Guid("0c983bc2-517c-4a1a-8868-648470f40479") },
                    { new Guid("5f69c218-069b-4a77-8ce4-5e3eae5436b5"), 2, "https://cdn.leonardo.ai/users/ff8f3895-401f-4c98-8ac2-468b47e1f545/generations/114528bd-c0ef-4219-956f-e29c159224fe/segments/3:4:1/Flux_Dev_A_soft_cuddly_and_endearing_classic_teddy_bear_made_e_2.jpg", new Guid("21f85996-213f-4709-9505-4a3275fd7c57") },
                    { new Guid("8116a819-13c3-4a9c-890b-705a1e259fdf"), 3, "https://cdn.leonardo.ai/users/ff8f3895-401f-4c98-8ac2-468b47e1f545/generations/237f1559-8d57-4502-a8cd-bcaf40029321/segments/1:4:1/Flux_Dev_A_colorful_and_vibrant_illustration_of_a_dinosaur_plu_0.jpg", new Guid("e1d30af1-50f7-4a21-af44-ef20e8eef5ff") },
                    { new Guid("9050d456-47b3-4fe4-a78b-47ee4b70c797"), 1, "https://cdn.leonardo.ai/users/ff8f3895-401f-4c98-8ac2-468b47e1f545/generations/51b6901d-4b2f-4806-ae6f-bbf0707b2d31/segments/4:4:1/Flux_Dev_A_whimsical_softfocus_illustration_of_an_adorable_oct_3.jpg", new Guid("e4c44e1a-cb58-426f-b3d0-b8b1a6ca03fa") },
                    { new Guid("a18f5bf2-d90a-4716-a273-21ceae23805e"), 3, "https://cdn.leonardo.ai/users/ff8f3895-401f-4c98-8ac2-468b47e1f545/generations/46871dcc-53a3-4ae0-994f-c6f35dd47de3/segments/2:4:1/Flux_Dev_A_vibrant_whimsical_illustration_of_a_rainbow_unicorn_1.jpg", new Guid("a74b26e9-774e-4b9f-859e-c7515f3983de") },
                    { new Guid("a1ccd1e8-e328-4959-a0e9-c8deed16e2c2"), 2, "https://cdn.leonardo.ai/users/ff8f3895-401f-4c98-8ac2-468b47e1f545/generations/51b6901d-4b2f-4806-ae6f-bbf0707b2d31/segments/3:4:1/Flux_Dev_A_whimsical_softfocus_illustration_of_an_adorable_oct_2.jpg", new Guid("e4c44e1a-cb58-426f-b3d0-b8b1a6ca03fa") },
                    { new Guid("a45d3080-203c-439c-b2fe-31113887976c"), 3, "https://cdn.leonardo.ai/users/ff8f3895-401f-4c98-8ac2-468b47e1f545/generations/06c5c23d-5ab7-44ce-9ec4-e857a8078be4/segments/1:4:1/Flux_Dev_A_soft_cuddly_and_adorable_amigurumi_bunny_sits_uprig_0.jpg", new Guid("0c983bc2-517c-4a1a-8868-648470f40479") },
                    { new Guid("b80f05e5-dabb-4977-ab80-568c0d9cf273"), 2, "https://cdn.leonardo.ai/users/ff8f3895-401f-4c98-8ac2-468b47e1f545/generations/237f1559-8d57-4502-a8cd-bcaf40029321/segments/2:4:1/Flux_Dev_A_colorful_and_vibrant_illustration_of_a_dinosaur_plu_1.jpg", new Guid("e1d30af1-50f7-4a21-af44-ef20e8eef5ff") },
                    { new Guid("c4ebc081-9bc6-484a-8a74-484ab988b052"), 2, "https://cdn.leonardo.ai/users/ff8f3895-401f-4c98-8ac2-468b47e1f545/generations/46871dcc-53a3-4ae0-994f-c6f35dd47de3/segments/3:4:1/Flux_Dev_A_vibrant_whimsical_illustration_of_a_rainbow_unicorn_2.jpg", new Guid("a74b26e9-774e-4b9f-859e-c7515f3983de") },
                    { new Guid("e76b5eec-fdef-4297-9ea7-bf777a1485db"), 1, "https://cdn.leonardo.ai/users/ff8f3895-401f-4c98-8ac2-468b47e1f545/generations/06c5c23d-5ab7-44ce-9ec4-e857a8078be4/segments/4:4:1/Flux_Dev_A_soft_cuddly_and_adorable_amigurumi_bunny_sits_uprig_3.jpg", new Guid("0c983bc2-517c-4a1a-8868-648470f40479") },
                    { new Guid("ef5f927d-c815-476d-8d9b-68e3b9b7088f"), 3, "https://cdn.leonardo.ai/users/ff8f3895-401f-4c98-8ac2-468b47e1f545/generations/51b6901d-4b2f-4806-ae6f-bbf0707b2d31/segments/2:4:1/Flux_Dev_A_whimsical_softfocus_illustration_of_an_adorable_oct_1.jpg", new Guid("e4c44e1a-cb58-426f-b3d0-b8b1a6ca03fa") }
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
