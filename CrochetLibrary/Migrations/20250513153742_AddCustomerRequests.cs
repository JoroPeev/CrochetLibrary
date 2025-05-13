using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CrochetLibrary.Migrations
{
    /// <inheritdoc />
    public partial class AddCustomerRequests : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerEmail",
                table: "Requests");

            migrationBuilder.RenameColumn(
                name: "ToyName",
                table: "Requests",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "CustomerName",
                table: "Requests",
                newName: "Email");

            migrationBuilder.AddColumn<int>(
                name: "ToyId",
                table: "Requests",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ToyId",
                table: "Requests");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Requests",
                newName: "ToyName");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Requests",
                newName: "CustomerName");

            migrationBuilder.AddColumn<string>(
                name: "CustomerEmail",
                table: "Requests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
