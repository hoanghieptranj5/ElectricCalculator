using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repositories.Migrations
{
    public partial class ChangedModelName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "CalculatedItems");

            migrationBuilder.RenameColumn(
                name: "Usage",
                table: "CalculatedItems",
                newName: "To");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "To",
                table: "CalculatedItems",
                newName: "Usage");

            migrationBuilder.AddColumn<float>(
                name: "Price",
                table: "CalculatedItems",
                type: "real",
                nullable: false,
                defaultValue: 0f);
        }
    }
}
