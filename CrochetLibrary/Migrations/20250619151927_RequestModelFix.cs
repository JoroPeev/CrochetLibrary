using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CrochetLibrary.Migrations
{
    /// <inheritdoc />
    public partial class RequestModelFix : Migration
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
                name: "Requests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ToyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Requests_Toys_ToyId",
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
                    AltText = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false),
                    IsPrimary = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                    { new Guid("c230ca66-a6d7-4d62-8477-303aaddee9ec"), "White, Rainbow", "Magical hand-crocheted unicorn...", "Rainbow Unicorn", 34.990000000000002, 12 },
                    { new Guid("ce74948f-2b40-4b46-8a37-b455b6f5d39c"), "Brown, Beige, Cream", "Soft and cuddly hand-crocheted teddy bear...", "Classic Teddy Bear", 24.989999999999998, 20 },
                    { new Guid("d92f84f6-65b9-4eb6-98fe-057d65515846"), "White, Pink, Lavender", "Adorable crochet bunny...", "Amigurumi Bunny", 29.5, 15 },
                    { new Guid("dfca9479-fac6-4501-a3f4-1dce69130175"), "Blue, Teal, Purple", "Soft, huggable octopus...", "Octopus Cuddle Buddy", 22.5, 25 },
                    { new Guid("f94e39e2-1c8b-487f-9ecf-9940a2e4f273"), "Green, Blue, Orange", "Playful crochet dinosaur...", "Dinosaur Plushie", 26.75, 18 }
                });

            migrationBuilder.InsertData(
                table: "ToyImages",
                columns: new[] { "Id", "AltText", "CreatedAt", "DisplayOrder", "ImageUrl", "IsPrimary", "ToyId" },
                values: new object[,]
                {
                    { new Guid("0e94003a-53fe-4533-8ea8-17f76edc18b5"), "Amigurumi Bunny - Close-up Face", new DateTime(2025, 6, 19, 15, 19, 27, 232, DateTimeKind.Utc).AddTicks(4094), 3, "https://example.com/bunny-3.jpg", false, new Guid("d92f84f6-65b9-4eb6-98fe-057d65515846") },
                    { new Guid("1ee7283c-20b9-4fa4-875e-4a8b13e1db6c"), "Octopus Cuddle Buddy - Tentacles Detail", new DateTime(2025, 6, 19, 15, 19, 27, 232, DateTimeKind.Utc).AddTicks(4122), 2, "https://example.com/octopus-2.jpg", false, new Guid("dfca9479-fac6-4501-a3f4-1dce69130175") },
                    { new Guid("2e6a6d21-d91a-484b-b37b-d70503572d2e"), "Dinosaur Plushie - Green Version", new DateTime(2025, 6, 19, 15, 19, 27, 232, DateTimeKind.Utc).AddTicks(4100), 1, "https://example.com/dinosaur-1.jpg", true, new Guid("f94e39e2-1c8b-487f-9ecf-9940a2e4f273") },
                    { new Guid("3ac64125-7eec-4682-aae0-126c173e1797"), "Dinosaur Plushie - Blue Version", new DateTime(2025, 6, 19, 15, 19, 27, 232, DateTimeKind.Utc).AddTicks(4103), 2, "https://example.com/dinosaur-2.jpg", false, new Guid("f94e39e2-1c8b-487f-9ecf-9940a2e4f273") },
                    { new Guid("4089cd30-dd3c-4bc5-b129-9932643781d7"), "Classic Teddy Bear - Front View", new DateTime(2025, 6, 19, 15, 19, 27, 232, DateTimeKind.Utc).AddTicks(4067), 1, "https://example.com/teddy-bear-1.jpg", true, new Guid("ce74948f-2b40-4b46-8a37-b455b6f5d39c") },
                    { new Guid("42b5f252-09e4-4a43-a0af-3a2315de340f"), "Octopus Cuddle Buddy - Full View", new DateTime(2025, 6, 19, 15, 19, 27, 232, DateTimeKind.Utc).AddTicks(4119), 1, "https://example.com/octopus-1.jpg", true, new Guid("dfca9479-fac6-4501-a3f4-1dce69130175") },
                    { new Guid("591627a4-4879-42c6-816a-48de32d68fce"), "Amigurumi Bunny - Without Dress", new DateTime(2025, 6, 19, 15, 19, 27, 232, DateTimeKind.Utc).AddTicks(4091), 2, "https://example.com/bunny-2.jpg", false, new Guid("d92f84f6-65b9-4eb6-98fe-057d65515846") },
                    { new Guid("721604c7-4e11-45f0-938a-182670425ebd"), "Dinosaur Plushie - Orange Version", new DateTime(2025, 6, 19, 15, 19, 27, 232, DateTimeKind.Utc).AddTicks(4105), 3, "https://example.com/dinosaur-3.jpg", false, new Guid("f94e39e2-1c8b-487f-9ecf-9940a2e4f273") },
                    { new Guid("91921b8d-df13-4ea4-a41a-99b50ae7ac3b"), "Octopus Cuddle Buddy - Face Close-up", new DateTime(2025, 6, 19, 15, 19, 27, 232, DateTimeKind.Utc).AddTicks(4127), 3, "https://example.com/octopus-3.jpg", false, new Guid("dfca9479-fac6-4501-a3f4-1dce69130175") },
                    { new Guid("9a0dec0c-3a3a-4e5a-a0aa-e3b7e228f7e5"), "Rainbow Unicorn - Full Body", new DateTime(2025, 6, 19, 15, 19, 27, 232, DateTimeKind.Utc).AddTicks(4108), 1, "https://example.com/unicorn-1.jpg", true, new Guid("c230ca66-a6d7-4d62-8477-303aaddee9ec") },
                    { new Guid("9dfdf529-d89a-4fa4-bc7c-bbab573989d3"), "Rainbow Unicorn - Mane Detail", new DateTime(2025, 6, 19, 15, 19, 27, 232, DateTimeKind.Utc).AddTicks(4114), 2, "https://example.com/unicorn-2.jpg", false, new Guid("c230ca66-a6d7-4d62-8477-303aaddee9ec") },
                    { new Guid("aec81dda-d7a9-4899-91f2-8196a2117de2"), "Classic Teddy Bear - Side View", new DateTime(2025, 6, 19, 15, 19, 27, 232, DateTimeKind.Utc).AddTicks(4075), 2, "https://example.com/teddy-bear-2.jpg", false, new Guid("ce74948f-2b40-4b46-8a37-b455b6f5d39c") },
                    { new Guid("c9d5436d-a3fe-4389-bcbf-c1e34d8168c2"), "Classic Teddy Bear - Back View", new DateTime(2025, 6, 19, 15, 19, 27, 232, DateTimeKind.Utc).AddTicks(4085), 3, "https://example.com/teddy-bear-3.jpg", false, new Guid("ce74948f-2b40-4b46-8a37-b455b6f5d39c") },
                    { new Guid("f5ed5c0f-4420-4ffb-9673-d3d9f6c0ca4a"), "Amigurumi Bunny - With Dress", new DateTime(2025, 6, 19, 15, 19, 27, 232, DateTimeKind.Utc).AddTicks(4088), 1, "https://example.com/bunny-1.jpg", true, new Guid("d92f84f6-65b9-4eb6-98fe-057d65515846") },
                    { new Guid("fedb71d7-be33-4fab-abf0-394b28973790"), "Rainbow Unicorn - Horn Close-up", new DateTime(2025, 6, 19, 15, 19, 27, 232, DateTimeKind.Utc).AddTicks(4116), 3, "https://example.com/unicorn-3.jpg", false, new Guid("c230ca66-a6d7-4d62-8477-303aaddee9ec") }
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
                name: "IX_Requests_ToyId",
                table: "Requests",
                column: "ToyId");

            migrationBuilder.CreateIndex(
                name: "IX_ToyImages_ToyId_DisplayOrder",
                table: "ToyImages",
                columns: new[] { "ToyId", "DisplayOrder" });

            migrationBuilder.CreateIndex(
                name: "IX_ToyImages_ToyId_IsPrimary",
                table: "ToyImages",
                columns: new[] { "ToyId", "IsPrimary" },
                unique: true,
                filter: "[IsPrimary] = 1");
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
