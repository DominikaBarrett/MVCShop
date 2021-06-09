using Microsoft.EntityFrameworkCore.Migrations;

namespace Sklep.Migrations
{
    public partial class ShoppingCartItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ShoppingCartItems",
                columns: table => new
                {
                    ShoppingCartItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShoppingCartId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: true),
                    Amount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCartItems", x => x.ShoppingCartItemId);
                    table.ForeignKey(
                        name: "FK_ShoppingCartItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "ImageUrl", "ImgThumbnailUrl" },
                values: new object[] { "\\img\\ipad.jpg", "\\img\\ipad.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "ImageUrl", "ImgThumbnailUrl" },
                values: new object[] { "\\img\\iphone.jpg", "\\img\\iphone.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "ImageUrl", "ImgThumbnailUrl" },
                values: new object[] { "\\img\\watch.jpg", "\\img\\watch.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "ImageUrl", "ImgThumbnailUrl" },
                values: new object[] { "\\img\\Quad.jpg", "\\img\\watch.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "ImageUrl", "ImgThumbnailUrl" },
                values: new object[] { "\\img\\apple.jpg", "\\img\\watch.jpg" });

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems_ProductId",
                table: "ShoppingCartItems",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShoppingCartItems");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "ImageUrl", "ImgThumbnailUrl" },
                values: new object[] { "~\\Img\\ipad.jpg", "~\\Img\\ipad.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "ImageUrl", "ImgThumbnailUrl" },
                values: new object[] { "~\\Img\\iphone.jpg", "~\\Img\\iphone.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "ImageUrl", "ImgThumbnailUrl" },
                values: new object[] { "~\\Img\\watch.jpg", "~\\Img\\watch.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "ImageUrl", "ImgThumbnailUrl" },
                values: new object[] { "~\\Img\\Quad.jpg", "~\\Img\\watch.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "ImageUrl", "ImgThumbnailUrl" },
                values: new object[] { "~\\Img\\apple.jpg", "~\\Img\\watch.jpg" });
        }
    }
}
