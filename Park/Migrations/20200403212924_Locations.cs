using Microsoft.EntityFrameworkCore.Migrations;

namespace Park.Migrations
{
    public partial class Locations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "States",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Nationals",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Location",
                table: "States");

            migrationBuilder.DropColumn(
                name: "Location",
                table: "Nationals");
        }
    }
}
