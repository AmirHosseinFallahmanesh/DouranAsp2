using Microsoft.EntityFrameworkCore.Migrations;

namespace Demo1.DAL.Migrations
{
    public partial class addActiveToStudent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Students",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Active",
                table: "Students");
        }
    }
}
