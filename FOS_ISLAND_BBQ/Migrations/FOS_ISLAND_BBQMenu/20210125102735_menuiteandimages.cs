using Microsoft.EntityFrameworkCore.Migrations;

namespace FOS_ISLAND_BBQ.Migrations.FOS_ISLAND_BBQMenu
{
    public partial class menuiteandimages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "imageURL",
                table: "MenuModel",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "imageURL",
                table: "MenuModel");
        }
    }
}
