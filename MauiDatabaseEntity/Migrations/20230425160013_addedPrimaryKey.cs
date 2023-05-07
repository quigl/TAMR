using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MauiDatabaseEntity.Migrations
{
    /// <inheritdoc />
    public partial class addedPrimaryKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "name",
                table: "Admins",
                newName: "username");

            migrationBuilder.AddColumn<string>(
                name: "password",
                table: "Admins",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "password",
                table: "Admins");

            migrationBuilder.RenameColumn(
                name: "username",
                table: "Admins",
                newName: "name");
        }
    }
}
