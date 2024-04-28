using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UserGeneratorApp.Migrations
{
    /// <inheritdoc />
    public partial class AddColumnBirthDay : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Users");

            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDay",
                table: "Users",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BirthDay",
                table: "Users");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Users",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
