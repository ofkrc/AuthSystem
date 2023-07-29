using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AuthSystem.Migrations
{
    /// <inheritdoc />
    public partial class three : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "About",
                table: "AspNetUsers",
                type: "nvarchar(1000)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "About",
                table: "AspNetUsers",
                type: "nvarchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)");
        }
    }
}
