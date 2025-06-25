using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BooklyBookStoreApp.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mgtest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Books_BookID",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Order_BookID",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "BookID",
                table: "Order");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BookID",
                table: "Order",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Order_BookID",
                table: "Order",
                column: "BookID");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Books_BookID",
                table: "Order",
                column: "BookID",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
