using Microsoft.EntityFrameworkCore.Migrations;

namespace Merchandise_Sport_master.Migrations
{
    public partial class Scart3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ShopCartId",
                table: "Product",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ShopCart",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    TotalPrice = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopCart", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShopCart_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Product_ShopCartId",
                table: "Product",
                column: "ShopCartId");

            migrationBuilder.CreateIndex(
                name: "IX_ShopCart_UserId",
                table: "ShopCart",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_ShopCart_ShopCartId",
                table: "Product",
                column: "ShopCartId",
                principalTable: "ShopCart",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_ShopCart_ShopCartId",
                table: "Product");

            migrationBuilder.DropTable(
                name: "ShopCart");

            migrationBuilder.DropIndex(
                name: "IX_Product_ShopCartId",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "ShopCartId",
                table: "Product");
        }
    }
}
