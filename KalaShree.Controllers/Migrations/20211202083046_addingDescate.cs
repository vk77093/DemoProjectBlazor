using Microsoft.EntityFrameworkCore.Migrations;

namespace KalaShree.Controllers.Migrations
{
    public partial class addingDescate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CategoryDesc",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryDesc",
                table: "Categories");
        }
    }
}
