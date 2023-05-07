using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MauiDatabaseEntity.Migrations
{
    /// <inheritdoc />
    public partial class update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "loggedIn",
                table: "Admins");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "loggedIn",
                table: "Admins",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }
    }
}
