using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Demo1.DAL.Migrations
{
    public partial class udpate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "Ads");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "News",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "HotNews",
                table: "News",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "News",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "InsertTime",
                table: "News",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Text",
                table: "News",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Ads",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "News");

            migrationBuilder.DropColumn(
                name: "HotNews",
                table: "News");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "News");

            migrationBuilder.DropColumn(
                name: "InsertTime",
                table: "News");

            migrationBuilder.DropColumn(
                name: "Text",
                table: "News");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Ads");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Ads",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
