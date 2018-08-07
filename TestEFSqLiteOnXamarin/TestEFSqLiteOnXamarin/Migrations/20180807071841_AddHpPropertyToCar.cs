using Microsoft.EntityFrameworkCore.Migrations;

namespace TestEFSqLiteOnXamarin.Migrations
{
    public partial class AddHpPropertyToCar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HP",
                table: "Cars",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HP",
                table: "Cars");
        }
    }
}
