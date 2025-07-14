using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CrochetLibrary.Migrations
{
    /// <inheritdoc />
    public partial class CustomerRequestAddedSubscribeForNewsLetter : Migration
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
                    Stock = table.Column<int>(type: "int", nullable: false)
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
                columns: new[] { "Id", "Colors", "Description", "Name", "Price", "Stock" },
                values: new object[,]
                {
                    { new Guid("55c7ba09-7b14-42b1-8c4a-6c9f7f4c9ac6"), "Blue, Teal, Purple", "Soft, huggable octopus...", "Octopus Cuddle Buddy", 22.5, 25 },
                    { new Guid("a7bf1da4-f96d-4f61-b50d-9fb8e8901c87"), "White, Pink, Lavender", "Adorable crochet bunny...", "Amigurumi Bunny", 29.5, 15 },
                    { new Guid("a8803abd-c894-4935-92a1-f62c90391f9d"), "Brown, Beige, Cream", "Soft and cuddly hand-crocheted teddy bear...", "Classic Teddy Bear", 24.989999999999998, 20 },
                    { new Guid("b6c30898-ffeb-493b-a277-cec43a68dfe5"), "White, Rainbow", "Magical hand-crocheted unicorn...", "Rainbow Unicorn", 34.990000000000002, 12 },
                    { new Guid("d75aa1b1-7943-4551-b176-eff045e1e372"), "Green, Blue, Orange", "Playful crochet dinosaur...", "Dinosaur Plushie", 26.75, 18 }
                });

            migrationBuilder.InsertData(
                table: "ToyImages",
                columns: new[] { "Id", "DisplayOrder", "ImageUrl", "ToyId" },
                values: new object[,]
                {
                    { new Guid("276ce0eb-4b8c-4317-9f7e-62ff27ff34f6"), 1, "https://cdn.leonardo.ai/users/ff8f3895-401f-4c98-8ac2-468b47e1f545/generations/237f1559-8d57-4502-a8cd-bcaf40029321/segments/4:4:1/Flux_Dev_A_colorful_and_vibrant_illustration_of_a_dinosaur_plu_3.jpg", new Guid("d75aa1b1-7943-4551-b176-eff045e1e372") },
                    { new Guid("29df9167-cd74-42d3-889c-3eac88e38e41"), 2, "https://cdn.leonardo.ai/users/ff8f3895-401f-4c98-8ac2-468b47e1f545/generations/06c5c23d-5ab7-44ce-9ec4-e857a8078be4/segments/2:4:1/Flux_Dev_A_soft_cuddly_and_adorable_amigurumi_bunny_sits_uprig_1.jpg", new Guid("a7bf1da4-f96d-4f61-b50d-9fb8e8901c87") },
                    { new Guid("2a67ca87-1c56-4d45-913c-aaade3246f4e"), 2, "https://cdn.leonardo.ai/users/ff8f3895-401f-4c98-8ac2-468b47e1f545/generations/237f1559-8d57-4502-a8cd-bcaf40029321/segments/2:4:1/Flux_Dev_A_colorful_and_vibrant_illustration_of_a_dinosaur_plu_1.jpg", new Guid("d75aa1b1-7943-4551-b176-eff045e1e372") },
                    { new Guid("7673460a-fed0-4698-aa1a-b45e013de283"), 2, "https://cdn.leonardo.ai/users/ff8f3895-401f-4c98-8ac2-468b47e1f545/generations/114528bd-c0ef-4219-956f-e29c159224fe/segments/3:4:1/Flux_Dev_A_soft_cuddly_and_endearing_classic_teddy_bear_made_e_2.jpg", new Guid("a8803abd-c894-4935-92a1-f62c90391f9d") },
                    { new Guid("7dc0442c-9952-4c45-b0cc-863137356ced"), 3, "https://cdn.leonardo.ai/users/ff8f3895-401f-4c98-8ac2-468b47e1f545/generations/06c5c23d-5ab7-44ce-9ec4-e857a8078be4/segments/1:4:1/Flux_Dev_A_soft_cuddly_and_adorable_amigurumi_bunny_sits_uprig_0.jpg", new Guid("a7bf1da4-f96d-4f61-b50d-9fb8e8901c87") },
                    { new Guid("7e5ecae3-d0b0-4031-a997-b469c6d6937f"), 1, "https://cdn.leonardo.ai/users/ff8f3895-401f-4c98-8ac2-468b47e1f545/generations/114528bd-c0ef-4219-956f-e29c159224fe/segments/1:4:1/Flux_Dev_A_soft_cuddly_and_endearing_classic_teddy_bear_made_e_0.jpg", new Guid("a8803abd-c894-4935-92a1-f62c90391f9d") },
                    { new Guid("8163a52a-ecf8-488b-b107-537975162397"), 2, "https://cdn.leonardo.ai/users/ff8f3895-401f-4c98-8ac2-468b47e1f545/generations/46871dcc-53a3-4ae0-994f-c6f35dd47de3/segments/3:4:1/Flux_Dev_A_vibrant_whimsical_illustration_of_a_rainbow_unicorn_2.jpg", new Guid("b6c30898-ffeb-493b-a277-cec43a68dfe5") },
                    { new Guid("84895622-67d5-4fa6-9270-c8cb755ff481"), 1, "https://cdn.leonardo.ai/users/ff8f3895-401f-4c98-8ac2-468b47e1f545/generations/06c5c23d-5ab7-44ce-9ec4-e857a8078be4/segments/4:4:1/Flux_Dev_A_soft_cuddly_and_adorable_amigurumi_bunny_sits_uprig_3.jpg", new Guid("a7bf1da4-f96d-4f61-b50d-9fb8e8901c87") },
                    { new Guid("90b5fe49-d070-4907-94ee-87903a361f8f"), 3, "https://cdn.leonardo.ai/users/ff8f3895-401f-4c98-8ac2-468b47e1f545/generations/46871dcc-53a3-4ae0-994f-c6f35dd47de3/segments/2:4:1/Flux_Dev_A_vibrant_whimsical_illustration_of_a_rainbow_unicorn_1.jpg", new Guid("b6c30898-ffeb-493b-a277-cec43a68dfe5") },
                    { new Guid("9e50f65c-fff3-4dc1-8c14-38c3bdf9ce3b"), 3, "https://cdn.leonardo.ai/users/ff8f3895-401f-4c98-8ac2-468b47e1f545/generations/114528bd-c0ef-4219-956f-e29c159224fe/segments/4:4:1/Flux_Dev_A_soft_cuddly_and_endearing_classic_teddy_bear_made_e_3.jpg", new Guid("a8803abd-c894-4935-92a1-f62c90391f9d") },
                    { new Guid("a9538b9f-4a8f-4030-a83a-73d8cc890bb3"), 1, "https://cdn.leonardo.ai/users/ff8f3895-401f-4c98-8ac2-468b47e1f545/generations/51b6901d-4b2f-4806-ae6f-bbf0707b2d31/segments/4:4:1/Flux_Dev_A_whimsical_softfocus_illustration_of_an_adorable_oct_3.jpg", new Guid("55c7ba09-7b14-42b1-8c4a-6c9f7f4c9ac6") },
                    { new Guid("c813527c-507c-4f4c-aa27-8d6a7fc807b5"), 2, "https://cdn.leonardo.ai/users/ff8f3895-401f-4c98-8ac2-468b47e1f545/generations/51b6901d-4b2f-4806-ae6f-bbf0707b2d31/segments/3:4:1/Flux_Dev_A_whimsical_softfocus_illustration_of_an_adorable_oct_2.jpg", new Guid("55c7ba09-7b14-42b1-8c4a-6c9f7f4c9ac6") },
                    { new Guid("cd96d11a-f7b9-49d3-a8d9-9f0cd1e86913"), 3, "https://cdn.leonardo.ai/users/ff8f3895-401f-4c98-8ac2-468b47e1f545/generations/51b6901d-4b2f-4806-ae6f-bbf0707b2d31/segments/2:4:1/Flux_Dev_A_whimsical_softfocus_illustration_of_an_adorable_oct_1.jpg", new Guid("55c7ba09-7b14-42b1-8c4a-6c9f7f4c9ac6") },
                    { new Guid("d903ba64-f6be-4a0f-91e9-38dc9533a0be"), 3, "https://cdn.leonardo.ai/users/ff8f3895-401f-4c98-8ac2-468b47e1f545/generations/237f1559-8d57-4502-a8cd-bcaf40029321/segments/1:4:1/Flux_Dev_A_colorful_and_vibrant_illustration_of_a_dinosaur_plu_0.jpg", new Guid("d75aa1b1-7943-4551-b176-eff045e1e372") },
                    { new Guid("f2b8f8e4-0310-47b0-ab94-10afd49e6992"), 1, "https://cdn.leonardo.ai/users/ff8f3895-401f-4c98-8ac2-468b47e1f545/generations/46871dcc-53a3-4ae0-994f-c6f35dd47de3/segments/4:4:1/Flux_Dev_A_vibrant_whimsical_illustration_of_a_rainbow_unicorn_3.jpg", new Guid("b6c30898-ffeb-493b-a277-cec43a68dfe5") }
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
