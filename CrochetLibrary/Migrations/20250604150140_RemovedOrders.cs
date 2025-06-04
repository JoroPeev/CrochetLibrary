using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CrochetLibrary.Migrations
{
    /// <inheritdoc />
    public partial class RemovedOrders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderItem");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DeleteData(
                table: "ToyImages",
                keyColumn: "Id",
                keyValue: new Guid("00520e36-0ddc-4b1c-bcda-fc61b2fdcaf3"));

            migrationBuilder.DeleteData(
                table: "ToyImages",
                keyColumn: "Id",
                keyValue: new Guid("038f66be-267a-4e97-b91e-36e8581f9c98"));

            migrationBuilder.DeleteData(
                table: "ToyImages",
                keyColumn: "Id",
                keyValue: new Guid("1acbefc2-b577-42c7-b81c-b6a628262d57"));

            migrationBuilder.DeleteData(
                table: "ToyImages",
                keyColumn: "Id",
                keyValue: new Guid("28c8054c-843d-4f25-80f2-4a63fa0ede4c"));

            migrationBuilder.DeleteData(
                table: "ToyImages",
                keyColumn: "Id",
                keyValue: new Guid("2cc0c1e1-bdbd-4009-a428-e8318a517baf"));

            migrationBuilder.DeleteData(
                table: "ToyImages",
                keyColumn: "Id",
                keyValue: new Guid("373a40b3-f22c-4b43-b2e8-39b3fb732f6d"));

            migrationBuilder.DeleteData(
                table: "ToyImages",
                keyColumn: "Id",
                keyValue: new Guid("60fab9ea-d6f2-4530-9746-20bdd7822b95"));

            migrationBuilder.DeleteData(
                table: "ToyImages",
                keyColumn: "Id",
                keyValue: new Guid("71d64ce1-f26b-48d2-8c56-4f3dbe2f0985"));

            migrationBuilder.DeleteData(
                table: "ToyImages",
                keyColumn: "Id",
                keyValue: new Guid("7584906d-caa6-4448-b64d-29d147526674"));

            migrationBuilder.DeleteData(
                table: "ToyImages",
                keyColumn: "Id",
                keyValue: new Guid("bbaae861-8be9-4075-bb38-1dde85a7d30b"));

            migrationBuilder.DeleteData(
                table: "ToyImages",
                keyColumn: "Id",
                keyValue: new Guid("d343d568-83c0-4a3d-9a88-9818394226ed"));

            migrationBuilder.DeleteData(
                table: "ToyImages",
                keyColumn: "Id",
                keyValue: new Guid("dbdaceef-14c5-46ee-a31d-d21b3b84dc65"));

            migrationBuilder.DeleteData(
                table: "ToyImages",
                keyColumn: "Id",
                keyValue: new Guid("eb7e40b2-7402-4dd6-b2b2-68ec8a86832d"));

            migrationBuilder.DeleteData(
                table: "ToyImages",
                keyColumn: "Id",
                keyValue: new Guid("ef78b5a1-93bd-4f0d-9271-b736398eea3f"));

            migrationBuilder.DeleteData(
                table: "ToyImages",
                keyColumn: "Id",
                keyValue: new Guid("f6ebccfc-b5b2-4151-961f-6a1aa7e306ae"));

            migrationBuilder.DeleteData(
                table: "Toys",
                keyColumn: "Id",
                keyValue: new Guid("41fb5751-35e6-4878-924b-16200b403138"));

            migrationBuilder.DeleteData(
                table: "Toys",
                keyColumn: "Id",
                keyValue: new Guid("58bf0833-b3ee-43c1-ab91-5a6cbe89dac8"));

            migrationBuilder.DeleteData(
                table: "Toys",
                keyColumn: "Id",
                keyValue: new Guid("6738a259-ef84-4919-b219-49abdc606487"));

            migrationBuilder.DeleteData(
                table: "Toys",
                keyColumn: "Id",
                keyValue: new Guid("b90986cf-d94f-467c-bb74-6da1917333d8"));

            migrationBuilder.DeleteData(
                table: "Toys",
                keyColumn: "Id",
                keyValue: new Guid("fcc5b506-08e8-4efa-b874-5dc9e7408ae5"));

            migrationBuilder.InsertData(
                table: "Toys",
                columns: new[] { "Id", "Colors", "Description", "Name", "Price", "Stock" },
                values: new object[,]
                {
                    { new Guid("22c01b9b-3ed3-4d68-8e58-069e97bcd0b2"), "Brown, Beige, Cream", "Soft and cuddly hand-crocheted teddy bear...", "Classic Teddy Bear", 24.989999999999998, 20 },
                    { new Guid("524511ca-4698-4736-a155-87704e92d52a"), "White, Rainbow", "Magical hand-crocheted unicorn...", "Rainbow Unicorn", 34.990000000000002, 12 },
                    { new Guid("93eee0e7-e393-4544-9308-05318f300334"), "White, Pink, Lavender", "Adorable crochet bunny...", "Amigurumi Bunny", 29.5, 15 },
                    { new Guid("9bc72b77-74cc-4363-bb1b-1479ca08fdec"), "Blue, Teal, Purple", "Soft, huggable octopus...", "Octopus Cuddle Buddy", 22.5, 25 },
                    { new Guid("b15cb69e-bc9f-4b4d-a4e2-b5338c50c71d"), "Green, Blue, Orange", "Playful crochet dinosaur...", "Dinosaur Plushie", 26.75, 18 }
                });

            migrationBuilder.InsertData(
                table: "ToyImages",
                columns: new[] { "Id", "AltText", "CreatedAt", "DisplayOrder", "ImageUrl", "IsPrimary", "ToyId" },
                values: new object[,]
                {
                    { new Guid("1364f936-85fb-43e0-ab14-94914491e94d"), "Dinosaur Plushie - Green Version", new DateTime(2025, 6, 4, 15, 1, 39, 230, DateTimeKind.Utc).AddTicks(5402), 1, "https://example.com/dinosaur-1.jpg", true, new Guid("b15cb69e-bc9f-4b4d-a4e2-b5338c50c71d") },
                    { new Guid("154f65d5-e609-433d-96d3-f8790fdf20a0"), "Classic Teddy Bear - Back View", new DateTime(2025, 6, 4, 15, 1, 39, 230, DateTimeKind.Utc).AddTicks(5386), 3, "https://example.com/teddy-bear-3.jpg", false, new Guid("22c01b9b-3ed3-4d68-8e58-069e97bcd0b2") },
                    { new Guid("45c924f8-99d4-492f-8b89-c0ab40a4fce0"), "Octopus Cuddle Buddy - Tentacles Detail", new DateTime(2025, 6, 4, 15, 1, 39, 230, DateTimeKind.Utc).AddTicks(5426), 2, "https://example.com/octopus-2.jpg", false, new Guid("9bc72b77-74cc-4363-bb1b-1479ca08fdec") },
                    { new Guid("4e409849-17ed-4c2d-8ca0-76a7d20f3403"), "Amigurumi Bunny - With Dress", new DateTime(2025, 6, 4, 15, 1, 39, 230, DateTimeKind.Utc).AddTicks(5389), 1, "https://example.com/bunny-1.jpg", true, new Guid("93eee0e7-e393-4544-9308-05318f300334") },
                    { new Guid("51311247-3ab4-43d1-844a-959428ca0f01"), "Rainbow Unicorn - Mane Detail", new DateTime(2025, 6, 4, 15, 1, 39, 230, DateTimeKind.Utc).AddTicks(5415), 2, "https://example.com/unicorn-2.jpg", false, new Guid("524511ca-4698-4736-a155-87704e92d52a") },
                    { new Guid("66796c81-92aa-490b-b422-5570c65839ea"), "Rainbow Unicorn - Full Body", new DateTime(2025, 6, 4, 15, 1, 39, 230, DateTimeKind.Utc).AddTicks(5413), 1, "https://example.com/unicorn-1.jpg", true, new Guid("524511ca-4698-4736-a155-87704e92d52a") },
                    { new Guid("6808b7c5-fb08-4fe3-a9df-aa6df7575cf5"), "Classic Teddy Bear - Side View", new DateTime(2025, 6, 4, 15, 1, 39, 230, DateTimeKind.Utc).AddTicks(5383), 2, "https://example.com/teddy-bear-2.jpg", false, new Guid("22c01b9b-3ed3-4d68-8e58-069e97bcd0b2") },
                    { new Guid("83a18731-0cfd-4de6-b321-b44876783645"), "Classic Teddy Bear - Front View", new DateTime(2025, 6, 4, 15, 1, 39, 230, DateTimeKind.Utc).AddTicks(5370), 1, "https://example.com/teddy-bear-1.jpg", true, new Guid("22c01b9b-3ed3-4d68-8e58-069e97bcd0b2") },
                    { new Guid("92d1bb0f-b200-4ee6-ad2b-cb6308d99b0c"), "Octopus Cuddle Buddy - Full View", new DateTime(2025, 6, 4, 15, 1, 39, 230, DateTimeKind.Utc).AddTicks(5421), 1, "https://example.com/octopus-1.jpg", true, new Guid("9bc72b77-74cc-4363-bb1b-1479ca08fdec") },
                    { new Guid("94da4e0a-aa9b-42c0-aeb7-1985624796a2"), "Dinosaur Plushie - Blue Version", new DateTime(2025, 6, 4, 15, 1, 39, 230, DateTimeKind.Utc).AddTicks(5405), 2, "https://example.com/dinosaur-2.jpg", false, new Guid("b15cb69e-bc9f-4b4d-a4e2-b5338c50c71d") },
                    { new Guid("9aab5b2c-3b50-48a5-9333-3f2d75ba3fa0"), "Dinosaur Plushie - Orange Version", new DateTime(2025, 6, 4, 15, 1, 39, 230, DateTimeKind.Utc).AddTicks(5408), 3, "https://example.com/dinosaur-3.jpg", false, new Guid("b15cb69e-bc9f-4b4d-a4e2-b5338c50c71d") },
                    { new Guid("9bb1b6ec-3d16-4ed3-97e3-fa3bc714c567"), "Amigurumi Bunny - Close-up Face", new DateTime(2025, 6, 4, 15, 1, 39, 230, DateTimeKind.Utc).AddTicks(5399), 3, "https://example.com/bunny-3.jpg", false, new Guid("93eee0e7-e393-4544-9308-05318f300334") },
                    { new Guid("a012f2e0-6f1a-4cfb-84b9-19c8cbed7396"), "Rainbow Unicorn - Horn Close-up", new DateTime(2025, 6, 4, 15, 1, 39, 230, DateTimeKind.Utc).AddTicks(5418), 3, "https://example.com/unicorn-3.jpg", false, new Guid("524511ca-4698-4736-a155-87704e92d52a") },
                    { new Guid("a950714d-c2fc-4696-8356-2987f23c9e0f"), "Amigurumi Bunny - Without Dress", new DateTime(2025, 6, 4, 15, 1, 39, 230, DateTimeKind.Utc).AddTicks(5393), 2, "https://example.com/bunny-2.jpg", false, new Guid("93eee0e7-e393-4544-9308-05318f300334") },
                    { new Guid("cda4c555-f032-4f98-82e5-7985f5bc3129"), "Octopus Cuddle Buddy - Face Close-up", new DateTime(2025, 6, 4, 15, 1, 39, 230, DateTimeKind.Utc).AddTicks(5429), 3, "https://example.com/octopus-3.jpg", false, new Guid("9bc72b77-74cc-4363-bb1b-1479ca08fdec") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ToyImages",
                keyColumn: "Id",
                keyValue: new Guid("1364f936-85fb-43e0-ab14-94914491e94d"));

            migrationBuilder.DeleteData(
                table: "ToyImages",
                keyColumn: "Id",
                keyValue: new Guid("154f65d5-e609-433d-96d3-f8790fdf20a0"));

            migrationBuilder.DeleteData(
                table: "ToyImages",
                keyColumn: "Id",
                keyValue: new Guid("45c924f8-99d4-492f-8b89-c0ab40a4fce0"));

            migrationBuilder.DeleteData(
                table: "ToyImages",
                keyColumn: "Id",
                keyValue: new Guid("4e409849-17ed-4c2d-8ca0-76a7d20f3403"));

            migrationBuilder.DeleteData(
                table: "ToyImages",
                keyColumn: "Id",
                keyValue: new Guid("51311247-3ab4-43d1-844a-959428ca0f01"));

            migrationBuilder.DeleteData(
                table: "ToyImages",
                keyColumn: "Id",
                keyValue: new Guid("66796c81-92aa-490b-b422-5570c65839ea"));

            migrationBuilder.DeleteData(
                table: "ToyImages",
                keyColumn: "Id",
                keyValue: new Guid("6808b7c5-fb08-4fe3-a9df-aa6df7575cf5"));

            migrationBuilder.DeleteData(
                table: "ToyImages",
                keyColumn: "Id",
                keyValue: new Guid("83a18731-0cfd-4de6-b321-b44876783645"));

            migrationBuilder.DeleteData(
                table: "ToyImages",
                keyColumn: "Id",
                keyValue: new Guid("92d1bb0f-b200-4ee6-ad2b-cb6308d99b0c"));

            migrationBuilder.DeleteData(
                table: "ToyImages",
                keyColumn: "Id",
                keyValue: new Guid("94da4e0a-aa9b-42c0-aeb7-1985624796a2"));

            migrationBuilder.DeleteData(
                table: "ToyImages",
                keyColumn: "Id",
                keyValue: new Guid("9aab5b2c-3b50-48a5-9333-3f2d75ba3fa0"));

            migrationBuilder.DeleteData(
                table: "ToyImages",
                keyColumn: "Id",
                keyValue: new Guid("9bb1b6ec-3d16-4ed3-97e3-fa3bc714c567"));

            migrationBuilder.DeleteData(
                table: "ToyImages",
                keyColumn: "Id",
                keyValue: new Guid("a012f2e0-6f1a-4cfb-84b9-19c8cbed7396"));

            migrationBuilder.DeleteData(
                table: "ToyImages",
                keyColumn: "Id",
                keyValue: new Guid("a950714d-c2fc-4696-8356-2987f23c9e0f"));

            migrationBuilder.DeleteData(
                table: "ToyImages",
                keyColumn: "Id",
                keyValue: new Guid("cda4c555-f032-4f98-82e5-7985f5bc3129"));

            migrationBuilder.DeleteData(
                table: "Toys",
                keyColumn: "Id",
                keyValue: new Guid("22c01b9b-3ed3-4d68-8e58-069e97bcd0b2"));

            migrationBuilder.DeleteData(
                table: "Toys",
                keyColumn: "Id",
                keyValue: new Guid("524511ca-4698-4736-a155-87704e92d52a"));

            migrationBuilder.DeleteData(
                table: "Toys",
                keyColumn: "Id",
                keyValue: new Guid("93eee0e7-e393-4544-9308-05318f300334"));

            migrationBuilder.DeleteData(
                table: "Toys",
                keyColumn: "Id",
                keyValue: new Guid("9bc72b77-74cc-4363-bb1b-1479ca08fdec"));

            migrationBuilder.DeleteData(
                table: "Toys",
                keyColumn: "Id",
                keyValue: new Guid("b15cb69e-bc9f-4b4d-a4e2-b5338c50c71d"));

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PaymentMethod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
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
                name: "IX_OrderItem_OrderId",
                table: "OrderItem",
                column: "OrderId");
        }
    }
}
