using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CrochetLibrary.Migrations
{
    /// <inheritdoc />
    public partial class ToyGuidMultipleImages : Migration
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
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaymentMethod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Requests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ToyId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                name: "OrderItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItem_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id");
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
                    { new Guid("41fb5751-35e6-4878-924b-16200b403138"), "Green, Blue, Orange", "Playful crochet dinosaur...", "Dinosaur Plushie", 26.75, 18 },
                    { new Guid("58bf0833-b3ee-43c1-ab91-5a6cbe89dac8"), "Blue, Teal, Purple", "Soft, huggable octopus...", "Octopus Cuddle Buddy", 22.5, 25 },
                    { new Guid("6738a259-ef84-4919-b219-49abdc606487"), "White, Rainbow", "Magical hand-crocheted unicorn...", "Rainbow Unicorn", 34.990000000000002, 12 },
                    { new Guid("b90986cf-d94f-467c-bb74-6da1917333d8"), "Brown, Beige, Cream", "Soft and cuddly hand-crocheted teddy bear...", "Classic Teddy Bear", 24.989999999999998, 20 },
                    { new Guid("fcc5b506-08e8-4efa-b874-5dc9e7408ae5"), "White, Pink, Lavender", "Adorable crochet bunny...", "Amigurumi Bunny", 29.5, 15 }
                });

            migrationBuilder.InsertData(
                table: "ToyImages",
                columns: new[] { "Id", "AltText", "CreatedAt", "DisplayOrder", "ImageUrl", "IsPrimary", "ToyId" },
                values: new object[,]
                {
                    { new Guid("00520e36-0ddc-4b1c-bcda-fc61b2fdcaf3"), "Octopus Cuddle Buddy - Full View", new DateTime(2025, 6, 3, 14, 47, 17, 991, DateTimeKind.Utc).AddTicks(2332), 1, "https://example.com/octopus-1.jpg", true, new Guid("58bf0833-b3ee-43c1-ab91-5a6cbe89dac8") },
                    { new Guid("038f66be-267a-4e97-b91e-36e8581f9c98"), "Rainbow Unicorn - Mane Detail", new DateTime(2025, 6, 3, 14, 47, 17, 991, DateTimeKind.Utc).AddTicks(2326), 2, "https://example.com/unicorn-2.jpg", false, new Guid("6738a259-ef84-4919-b219-49abdc606487") },
                    { new Guid("1acbefc2-b577-42c7-b81c-b6a628262d57"), "Amigurumi Bunny - Close-up Face", new DateTime(2025, 6, 3, 14, 47, 17, 991, DateTimeKind.Utc).AddTicks(2310), 3, "https://example.com/bunny-3.jpg", false, new Guid("fcc5b506-08e8-4efa-b874-5dc9e7408ae5") },
                    { new Guid("28c8054c-843d-4f25-80f2-4a63fa0ede4c"), "Classic Teddy Bear - Side View", new DateTime(2025, 6, 3, 14, 47, 17, 991, DateTimeKind.Utc).AddTicks(2295), 2, "https://example.com/teddy-bear-2.jpg", false, new Guid("b90986cf-d94f-467c-bb74-6da1917333d8") },
                    { new Guid("2cc0c1e1-bdbd-4009-a428-e8318a517baf"), "Octopus Cuddle Buddy - Tentacles Detail", new DateTime(2025, 6, 3, 14, 47, 17, 991, DateTimeKind.Utc).AddTicks(2337), 2, "https://example.com/octopus-2.jpg", false, new Guid("58bf0833-b3ee-43c1-ab91-5a6cbe89dac8") },
                    { new Guid("373a40b3-f22c-4b43-b2e8-39b3fb732f6d"), "Classic Teddy Bear - Back View", new DateTime(2025, 6, 3, 14, 47, 17, 991, DateTimeKind.Utc).AddTicks(2299), 3, "https://example.com/teddy-bear-3.jpg", false, new Guid("b90986cf-d94f-467c-bb74-6da1917333d8") },
                    { new Guid("60fab9ea-d6f2-4530-9746-20bdd7822b95"), "Rainbow Unicorn - Full Body", new DateTime(2025, 6, 3, 14, 47, 17, 991, DateTimeKind.Utc).AddTicks(2324), 1, "https://example.com/unicorn-1.jpg", true, new Guid("6738a259-ef84-4919-b219-49abdc606487") },
                    { new Guid("71d64ce1-f26b-48d2-8c56-4f3dbe2f0985"), "Classic Teddy Bear - Front View", new DateTime(2025, 6, 3, 14, 47, 17, 991, DateTimeKind.Utc).AddTicks(2282), 1, "https://example.com/teddy-bear-1.jpg", true, new Guid("b90986cf-d94f-467c-bb74-6da1917333d8") },
                    { new Guid("7584906d-caa6-4448-b64d-29d147526674"), "Dinosaur Plushie - Orange Version", new DateTime(2025, 6, 3, 14, 47, 17, 991, DateTimeKind.Utc).AddTicks(2319), 3, "https://example.com/dinosaur-3.jpg", false, new Guid("41fb5751-35e6-4878-924b-16200b403138") },
                    { new Guid("bbaae861-8be9-4075-bb38-1dde85a7d30b"), "Dinosaur Plushie - Blue Version", new DateTime(2025, 6, 3, 14, 47, 17, 991, DateTimeKind.Utc).AddTicks(2316), 2, "https://example.com/dinosaur-2.jpg", false, new Guid("41fb5751-35e6-4878-924b-16200b403138") },
                    { new Guid("d343d568-83c0-4a3d-9a88-9818394226ed"), "Dinosaur Plushie - Green Version", new DateTime(2025, 6, 3, 14, 47, 17, 991, DateTimeKind.Utc).AddTicks(2313), 1, "https://example.com/dinosaur-1.jpg", true, new Guid("41fb5751-35e6-4878-924b-16200b403138") },
                    { new Guid("dbdaceef-14c5-46ee-a31d-d21b3b84dc65"), "Octopus Cuddle Buddy - Face Close-up", new DateTime(2025, 6, 3, 14, 47, 17, 991, DateTimeKind.Utc).AddTicks(2340), 3, "https://example.com/octopus-3.jpg", false, new Guid("58bf0833-b3ee-43c1-ab91-5a6cbe89dac8") },
                    { new Guid("eb7e40b2-7402-4dd6-b2b2-68ec8a86832d"), "Rainbow Unicorn - Horn Close-up", new DateTime(2025, 6, 3, 14, 47, 17, 991, DateTimeKind.Utc).AddTicks(2329), 3, "https://example.com/unicorn-3.jpg", false, new Guid("6738a259-ef84-4919-b219-49abdc606487") },
                    { new Guid("ef78b5a1-93bd-4f0d-9271-b736398eea3f"), "Amigurumi Bunny - Without Dress", new DateTime(2025, 6, 3, 14, 47, 17, 991, DateTimeKind.Utc).AddTicks(2305), 2, "https://example.com/bunny-2.jpg", false, new Guid("fcc5b506-08e8-4efa-b874-5dc9e7408ae5") },
                    { new Guid("f6ebccfc-b5b2-4151-961f-6a1aa7e306ae"), "Amigurumi Bunny - With Dress", new DateTime(2025, 6, 3, 14, 47, 17, 991, DateTimeKind.Utc).AddTicks(2302), 1, "https://example.com/bunny-1.jpg", true, new Guid("fcc5b506-08e8-4efa-b874-5dc9e7408ae5") }
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
                name: "IX_OrderItem_OrderId",
                table: "OrderItem",
                column: "OrderId");

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
                name: "OrderItem");

            migrationBuilder.DropTable(
                name: "Requests");

            migrationBuilder.DropTable(
                name: "ToyImages");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Toys");
        }
    }
}
