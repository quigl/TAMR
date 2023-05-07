using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MauiDatabaseEntity.Migrations
{
    /// <inheritdoc />
    public partial class newadmindetails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "firstname",
                table: "Admins",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "lastname",
                table: "Admins",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "loggedIn",
                table: "Admins",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "firstname",
                table: "Admins");

            migrationBuilder.DropColumn(
                name: "lastname",
                table: "Admins");

            migrationBuilder.DropColumn(
                name: "loggedIn",
                table: "Admins");
        }
    }
}
