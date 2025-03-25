using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CrochetLibrary.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Toys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Price = table.Column<double>(type: "float(10)", precision: 10, scale: 2, nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Colors = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Toys", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Toys",
                columns: new[] { "Id", "Colors", "Description", "ImageUrl", "Name", "Price", "Stock" },
                values: new object[,]
                {
                    { 1, "Brown, Beige, Cream", "Soft and cuddly hand-crocheted teddy bear with embroidered details. Perfect for snuggling and as a cherished keepsake.", "https://example.com/classic-teddy-bear.jpg", "Classic Teddy Bear", 24.989999999999998, 20 },
                    { 2, "White, Pink, Lavender", "Adorable crochet bunny with long floppy ears and a sweet embroidered face. Comes with removable dress.", "https://example.com/amigurumi-bunny.jpg", "Amigurumi Bunny", 29.5, 15 },
                    { 3, "Green, Blue, Orange", "Playful crochet dinosaur in vibrant colors. A perfect companion for young adventurers and dinosaur enthusiasts.", "https://example.com/dinosaur-plushie.jpg", "Dinosaur Plushie", 26.75, 18 },
                    { 4, "White, Rainbow", "Magical hand-crocheted unicorn with a shimmering mane and tail. Brings imagination and wonder to playtime.", "https://example.com/rainbow-unicorn.jpg", "Rainbow Unicorn", 34.990000000000002, 12 },
                    { 5, "Blue, Teal, Purple", "Soft, huggable octopus with multiple legs in gradient colors. Great for sensory play and comfort.", "https://example.com/octopus-buddy.jpg", "Octopus Cuddle Buddy", 22.5, 25 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Toys");
        }
    }
}
