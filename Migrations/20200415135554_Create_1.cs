using Microsoft.EntityFrameworkCore.Migrations;

namespace Zoo.Place.Migrations
{
    public partial class Create_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PicPath",
                table: "Zoos",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PicPath",
                table: "Zoos");
        }
    }
}
