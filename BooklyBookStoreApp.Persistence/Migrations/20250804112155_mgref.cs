using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BooklyBookStoreApp.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mgref : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NameSurname2",
                table: "Users");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NameSurname2",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
