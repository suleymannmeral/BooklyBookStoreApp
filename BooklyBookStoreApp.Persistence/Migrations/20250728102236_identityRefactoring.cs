using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BooklyBookStoreApp.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class identityRefactoring : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Baskets_AspNetUsers_AppUserID",
                table: "Baskets");

            migrationBuilder.DropForeignKey(
                name: "FK_BookComment_AspNetUsers_AppUserID",
                table: "BookComment");

            migrationBuilder.DropForeignKey(
                name: "FK_Favorites_AspNetUsers_AppUserID",
                table: "Favorites");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_AspNetUsers_AppUserID",
                table: "Order");

            migrationBuilder.RenameColumn(
                name: "AppUserID",
                table: "Order",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Order_AppUserID",
                table: "Order",
                newName: "IX_Order_UserId");

            migrationBuilder.RenameColumn(
                name: "AppUserID",
                table: "Favorites",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Favorites_AppUserID",
                table: "Favorites",
                newName: "IX_Favorites_UserId");

            migrationBuilder.RenameColumn(
                name: "AppUserID",
                table: "BookComment",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_BookComment_AppUserID",
                table: "BookComment",
                newName: "IX_BookComment_UserId");

            migrationBuilder.RenameColumn(
                name: "AppUserID",
                table: "Baskets",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Baskets_AppUserID",
                table: "Baskets",
                newName: "IX_Baskets_UserId");

            migrationBuilder.AddColumn<string>(
                name: "NameSurname",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Baskets_AspNetUsers_UserId",
                table: "Baskets",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookComment_AspNetUsers_UserId",
                table: "BookComment",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Favorites_AspNetUsers_UserId",
                table: "Favorites",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_AspNetUsers_UserId",
                table: "Order",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Baskets_AspNetUsers_UserId",
                table: "Baskets");

            migrationBuilder.DropForeignKey(
                name: "FK_BookComment_AspNetUsers_UserId",
                table: "BookComment");

            migrationBuilder.DropForeignKey(
                name: "FK_Favorites_AspNetUsers_UserId",
                table: "Favorites");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_AspNetUsers_UserId",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "NameSurname",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Order",
                newName: "AppUserID");

            migrationBuilder.RenameIndex(
                name: "IX_Order_UserId",
                table: "Order",
                newName: "IX_Order_AppUserID");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Favorites",
                newName: "AppUserID");

            migrationBuilder.RenameIndex(
                name: "IX_Favorites_UserId",
                table: "Favorites",
                newName: "IX_Favorites_AppUserID");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "BookComment",
                newName: "AppUserID");

            migrationBuilder.RenameIndex(
                name: "IX_BookComment_UserId",
                table: "BookComment",
                newName: "IX_BookComment_AppUserID");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Baskets",
                newName: "AppUserID");

            migrationBuilder.RenameIndex(
                name: "IX_Baskets_UserId",
                table: "Baskets",
                newName: "IX_Baskets_AppUserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Baskets_AspNetUsers_AppUserID",
                table: "Baskets",
                column: "AppUserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookComment_AspNetUsers_AppUserID",
                table: "BookComment",
                column: "AppUserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Favorites_AspNetUsers_AppUserID",
                table: "Favorites",
                column: "AppUserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_AspNetUsers_AppUserID",
                table: "Order",
                column: "AppUserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
