using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MauiDatabaseEntity.Migrations
{
    /// <inheritdoc />
    public partial class itemPic : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ItemPic",
                table: "CustomerOrder",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ItemPic",
                table: "CustomerOrder");
        }
    }
}
