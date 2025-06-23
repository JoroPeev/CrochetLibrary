using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CrochetLibrary.Migrations
{
    /// <inheritdoc />
    public partial class RemovedRelationInRequest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Requests_Toys_ToyId",
                table: "Requests");

            migrationBuilder.DropIndex(
                name: "IX_Requests_ToyId",
                table: "Requests");

            migrationBuilder.DeleteData(
                table: "ToyImages",
                keyColumn: "Id",
                keyValue: new Guid("0e94003a-53fe-4533-8ea8-17f76edc18b5"));

            migrationBuilder.DeleteData(
                table: "ToyImages",
                keyColumn: "Id",
                keyValue: new Guid("1ee7283c-20b9-4fa4-875e-4a8b13e1db6c"));

            migrationBuilder.DeleteData(
                table: "ToyImages",
                keyColumn: "Id",
                keyValue: new Guid("2e6a6d21-d91a-484b-b37b-d70503572d2e"));

            migrationBuilder.DeleteData(
                table: "ToyImages",
                keyColumn: "Id",
                keyValue: new Guid("3ac64125-7eec-4682-aae0-126c173e1797"));

            migrationBuilder.DeleteData(
                table: "ToyImages",
                keyColumn: "Id",
                keyValue: new Guid("4089cd30-dd3c-4bc5-b129-9932643781d7"));

            migrationBuilder.DeleteData(
                table: "ToyImages",
                keyColumn: "Id",
                keyValue: new Guid("42b5f252-09e4-4a43-a0af-3a2315de340f"));

            migrationBuilder.DeleteData(
                table: "ToyImages",
                keyColumn: "Id",
                keyValue: new Guid("591627a4-4879-42c6-816a-48de32d68fce"));

            migrationBuilder.DeleteData(
                table: "ToyImages",
                keyColumn: "Id",
                keyValue: new Guid("721604c7-4e11-45f0-938a-182670425ebd"));

            migrationBuilder.DeleteData(
                table: "ToyImages",
                keyColumn: "Id",
                keyValue: new Guid("91921b8d-df13-4ea4-a41a-99b50ae7ac3b"));

            migrationBuilder.DeleteData(
                table: "ToyImages",
                keyColumn: "Id",
                keyValue: new Guid("9a0dec0c-3a3a-4e5a-a0aa-e3b7e228f7e5"));

            migrationBuilder.DeleteData(
                table: "ToyImages",
                keyColumn: "Id",
                keyValue: new Guid("9dfdf529-d89a-4fa4-bc7c-bbab573989d3"));

            migrationBuilder.DeleteData(
                table: "ToyImages",
                keyColumn: "Id",
                keyValue: new Guid("aec81dda-d7a9-4899-91f2-8196a2117de2"));

            migrationBuilder.DeleteData(
                table: "ToyImages",
                keyColumn: "Id",
                keyValue: new Guid("c9d5436d-a3fe-4389-bcbf-c1e34d8168c2"));

            migrationBuilder.DeleteData(
                table: "ToyImages",
                keyColumn: "Id",
                keyValue: new Guid("f5ed5c0f-4420-4ffb-9673-d3d9f6c0ca4a"));

            migrationBuilder.DeleteData(
                table: "ToyImages",
                keyColumn: "Id",
                keyValue: new Guid("fedb71d7-be33-4fab-abf0-394b28973790"));

            migrationBuilder.DeleteData(
                table: "Toys",
                keyColumn: "Id",
                keyValue: new Guid("c230ca66-a6d7-4d62-8477-303aaddee9ec"));

            migrationBuilder.DeleteData(
                table: "Toys",
                keyColumn: "Id",
                keyValue: new Guid("ce74948f-2b40-4b46-8a37-b455b6f5d39c"));

            migrationBuilder.DeleteData(
                table: "Toys",
                keyColumn: "Id",
                keyValue: new Guid("d92f84f6-65b9-4eb6-98fe-057d65515846"));

            migrationBuilder.DeleteData(
                table: "Toys",
                keyColumn: "Id",
                keyValue: new Guid("dfca9479-fac6-4501-a3f4-1dce69130175"));

            migrationBuilder.DeleteData(
                table: "Toys",
                keyColumn: "Id",
                keyValue: new Guid("f94e39e2-1c8b-487f-9ecf-9940a2e4f273"));

            migrationBuilder.DropColumn(
                name: "ToyId",
                table: "Requests");

            migrationBuilder.AddColumn<string>(
                name: "ToyName",
                table: "Requests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Toys",
                columns: new[] { "Id", "Colors", "Description", "Name", "Price", "Stock" },
                values: new object[,]
                {
                    { new Guid("2805d110-80f9-4a1c-93a2-1c74247e8743"), "Brown, Beige, Cream", "Soft and cuddly hand-crocheted teddy bear...", "Classic Teddy Bear", 24.989999999999998, 20 },
                    { new Guid("330988c9-9544-41b0-9036-33986fe97c56"), "Green, Blue, Orange", "Playful crochet dinosaur...", "Dinosaur Plushie", 26.75, 18 },
                    { new Guid("667caae8-ae1f-4c43-b7ea-caa5f28ef782"), "White, Pink, Lavender", "Adorable crochet bunny...", "Amigurumi Bunny", 29.5, 15 },
                    { new Guid("79f2f51d-4048-404e-98f9-eb3897b4d18e"), "Blue, Teal, Purple", "Soft, huggable octopus...", "Octopus Cuddle Buddy", 22.5, 25 },
                    { new Guid("c7be4500-52df-47de-baff-4f8186745fa5"), "White, Rainbow", "Magical hand-crocheted unicorn...", "Rainbow Unicorn", 34.990000000000002, 12 }
                });

            migrationBuilder.InsertData(
                table: "ToyImages",
                columns: new[] { "Id", "AltText", "CreatedAt", "DisplayOrder", "ImageUrl", "IsPrimary", "ToyId" },
                values: new object[,]
                {
                    { new Guid("07e69e97-24f8-40ef-9bb4-4fc70cbb752c"), "Rainbow Unicorn - Mane Detail", new DateTime(2025, 6, 23, 15, 17, 6, 597, DateTimeKind.Utc).AddTicks(6052), 2, "https://example.com/unicorn-2.jpg", false, new Guid("c7be4500-52df-47de-baff-4f8186745fa5") },
                    { new Guid("0bd11c15-296b-4d32-bad8-b00ffcadc9c7"), "Dinosaur Plushie - Green Version", new DateTime(2025, 6, 23, 15, 17, 6, 597, DateTimeKind.Utc).AddTicks(6039), 1, "https://example.com/dinosaur-1.jpg", true, new Guid("330988c9-9544-41b0-9036-33986fe97c56") },
                    { new Guid("0cbde2ff-a88a-474c-ab22-c95c1d797757"), "Amigurumi Bunny - With Dress", new DateTime(2025, 6, 23, 15, 17, 6, 597, DateTimeKind.Utc).AddTicks(6028), 1, "https://example.com/bunny-1.jpg", true, new Guid("667caae8-ae1f-4c43-b7ea-caa5f28ef782") },
                    { new Guid("4d5a89d0-ad7f-4791-b61d-cd91df02b7d6"), "Octopus Cuddle Buddy - Face Close-up", new DateTime(2025, 6, 23, 15, 17, 6, 597, DateTimeKind.Utc).AddTicks(6065), 3, "https://example.com/octopus-3.jpg", false, new Guid("79f2f51d-4048-404e-98f9-eb3897b4d18e") },
                    { new Guid("690f086a-5827-4bec-b081-0c61f3bec01d"), "Amigurumi Bunny - Without Dress", new DateTime(2025, 6, 23, 15, 17, 6, 597, DateTimeKind.Utc).AddTicks(6030), 2, "https://example.com/bunny-2.jpg", false, new Guid("667caae8-ae1f-4c43-b7ea-caa5f28ef782") },
                    { new Guid("7882c634-c529-484a-b9b5-abdca328c39b"), "Amigurumi Bunny - Close-up Face", new DateTime(2025, 6, 23, 15, 17, 6, 597, DateTimeKind.Utc).AddTicks(6036), 3, "https://example.com/bunny-3.jpg", false, new Guid("667caae8-ae1f-4c43-b7ea-caa5f28ef782") },
                    { new Guid("8dd69f92-32c5-4531-8249-fbbf795d8a07"), "Classic Teddy Bear - Side View", new DateTime(2025, 6, 23, 15, 17, 6, 597, DateTimeKind.Utc).AddTicks(6022), 2, "https://example.com/teddy-bear-2.jpg", false, new Guid("2805d110-80f9-4a1c-93a2-1c74247e8743") },
                    { new Guid("8e6082df-5c87-4510-a1ba-3415d22827d6"), "Octopus Cuddle Buddy - Full View", new DateTime(2025, 6, 23, 15, 17, 6, 597, DateTimeKind.Utc).AddTicks(6057), 1, "https://example.com/octopus-1.jpg", true, new Guid("79f2f51d-4048-404e-98f9-eb3897b4d18e") },
                    { new Guid("91acb3c0-afa4-4931-a198-cbfe4c43d2a6"), "Rainbow Unicorn - Full Body", new DateTime(2025, 6, 23, 15, 17, 6, 597, DateTimeKind.Utc).AddTicks(6049), 1, "https://example.com/unicorn-1.jpg", true, new Guid("c7be4500-52df-47de-baff-4f8186745fa5") },
                    { new Guid("a3b06a42-89d9-4c33-b2a5-582ac7cec9d4"), "Octopus Cuddle Buddy - Tentacles Detail", new DateTime(2025, 6, 23, 15, 17, 6, 597, DateTimeKind.Utc).AddTicks(6062), 2, "https://example.com/octopus-2.jpg", false, new Guid("79f2f51d-4048-404e-98f9-eb3897b4d18e") },
                    { new Guid("c901cd8e-17f5-4f51-a696-06f8135c646b"), "Dinosaur Plushie - Orange Version", new DateTime(2025, 6, 23, 15, 17, 6, 597, DateTimeKind.Utc).AddTicks(6044), 3, "https://example.com/dinosaur-3.jpg", false, new Guid("330988c9-9544-41b0-9036-33986fe97c56") },
                    { new Guid("cc2c316d-9793-4650-a603-851c07de0247"), "Dinosaur Plushie - Blue Version", new DateTime(2025, 6, 23, 15, 17, 6, 597, DateTimeKind.Utc).AddTicks(6041), 2, "https://example.com/dinosaur-2.jpg", false, new Guid("330988c9-9544-41b0-9036-33986fe97c56") },
                    { new Guid("d621eb2a-544f-4ae5-82f8-bf9eadca96df"), "Classic Teddy Bear - Front View", new DateTime(2025, 6, 23, 15, 17, 6, 597, DateTimeKind.Utc).AddTicks(6006), 1, "https://example.com/teddy-bear-1.jpg", true, new Guid("2805d110-80f9-4a1c-93a2-1c74247e8743") },
                    { new Guid("e6b06d3b-6d8c-4b8e-bd97-230ef108bacd"), "Classic Teddy Bear - Back View", new DateTime(2025, 6, 23, 15, 17, 6, 597, DateTimeKind.Utc).AddTicks(6025), 3, "https://example.com/teddy-bear-3.jpg", false, new Guid("2805d110-80f9-4a1c-93a2-1c74247e8743") },
                    { new Guid("ed19cab6-5146-4183-9164-9d0bb415c7cb"), "Rainbow Unicorn - Horn Close-up", new DateTime(2025, 6, 23, 15, 17, 6, 597, DateTimeKind.Utc).AddTicks(6054), 3, "https://example.com/unicorn-3.jpg", false, new Guid("c7be4500-52df-47de-baff-4f8186745fa5") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ToyImages",
                keyColumn: "Id",
                keyValue: new Guid("07e69e97-24f8-40ef-9bb4-4fc70cbb752c"));

            migrationBuilder.DeleteData(
                table: "ToyImages",
                keyColumn: "Id",
                keyValue: new Guid("0bd11c15-296b-4d32-bad8-b00ffcadc9c7"));

            migrationBuilder.DeleteData(
                table: "ToyImages",
                keyColumn: "Id",
                keyValue: new Guid("0cbde2ff-a88a-474c-ab22-c95c1d797757"));

            migrationBuilder.DeleteData(
                table: "ToyImages",
                keyColumn: "Id",
                keyValue: new Guid("4d5a89d0-ad7f-4791-b61d-cd91df02b7d6"));

            migrationBuilder.DeleteData(
                table: "ToyImages",
                keyColumn: "Id",
                keyValue: new Guid("690f086a-5827-4bec-b081-0c61f3bec01d"));

            migrationBuilder.DeleteData(
                table: "ToyImages",
                keyColumn: "Id",
                keyValue: new Guid("7882c634-c529-484a-b9b5-abdca328c39b"));

            migrationBuilder.DeleteData(
                table: "ToyImages",
                keyColumn: "Id",
                keyValue: new Guid("8dd69f92-32c5-4531-8249-fbbf795d8a07"));

            migrationBuilder.DeleteData(
                table: "ToyImages",
                keyColumn: "Id",
                keyValue: new Guid("8e6082df-5c87-4510-a1ba-3415d22827d6"));

            migrationBuilder.DeleteData(
                table: "ToyImages",
                keyColumn: "Id",
                keyValue: new Guid("91acb3c0-afa4-4931-a198-cbfe4c43d2a6"));

            migrationBuilder.DeleteData(
                table: "ToyImages",
                keyColumn: "Id",
                keyValue: new Guid("a3b06a42-89d9-4c33-b2a5-582ac7cec9d4"));

            migrationBuilder.DeleteData(
                table: "ToyImages",
                keyColumn: "Id",
                keyValue: new Guid("c901cd8e-17f5-4f51-a696-06f8135c646b"));

            migrationBuilder.DeleteData(
                table: "ToyImages",
                keyColumn: "Id",
                keyValue: new Guid("cc2c316d-9793-4650-a603-851c07de0247"));

            migrationBuilder.DeleteData(
                table: "ToyImages",
                keyColumn: "Id",
                keyValue: new Guid("d621eb2a-544f-4ae5-82f8-bf9eadca96df"));

            migrationBuilder.DeleteData(
                table: "ToyImages",
                keyColumn: "Id",
                keyValue: new Guid("e6b06d3b-6d8c-4b8e-bd97-230ef108bacd"));

            migrationBuilder.DeleteData(
                table: "ToyImages",
                keyColumn: "Id",
                keyValue: new Guid("ed19cab6-5146-4183-9164-9d0bb415c7cb"));

            migrationBuilder.DeleteData(
                table: "Toys",
                keyColumn: "Id",
                keyValue: new Guid("2805d110-80f9-4a1c-93a2-1c74247e8743"));

            migrationBuilder.DeleteData(
                table: "Toys",
                keyColumn: "Id",
                keyValue: new Guid("330988c9-9544-41b0-9036-33986fe97c56"));

            migrationBuilder.DeleteData(
                table: "Toys",
                keyColumn: "Id",
                keyValue: new Guid("667caae8-ae1f-4c43-b7ea-caa5f28ef782"));

            migrationBuilder.DeleteData(
                table: "Toys",
                keyColumn: "Id",
                keyValue: new Guid("79f2f51d-4048-404e-98f9-eb3897b4d18e"));

            migrationBuilder.DeleteData(
                table: "Toys",
                keyColumn: "Id",
                keyValue: new Guid("c7be4500-52df-47de-baff-4f8186745fa5"));

            migrationBuilder.DropColumn(
                name: "ToyName",
                table: "Requests");

            migrationBuilder.AddColumn<Guid>(
                name: "ToyId",
                table: "Requests",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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
                name: "IX_Requests_ToyId",
                table: "Requests",
                column: "ToyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Requests_Toys_ToyId",
                table: "Requests",
                column: "ToyId",
                principalTable: "Toys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
