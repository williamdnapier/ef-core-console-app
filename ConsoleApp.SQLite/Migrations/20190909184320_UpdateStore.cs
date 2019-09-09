using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsoleApp.SQLite.Migrations
{
    public partial class UpdateStore : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Stores",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Stores");
        }
    }
}
