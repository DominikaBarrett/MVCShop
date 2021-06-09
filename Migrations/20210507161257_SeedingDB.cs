using Microsoft.EntityFrameworkCore.Migrations;

namespace Sklep.Migrations
{
    public partial class SeedingDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[,]
                {
                    { 1, "Tablet", null },
                    { 2, "Telefon", null },
                    { 3, "Watch", null },
                    { 4, "Vehicle", null },
                    { 5, "Surprise", null }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "Description", "ImageUrl", "ImgThumbnailUrl", "IsInStock", "IsOnSale", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit,  +\r\n                sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.\r\n                Ut enim ad minim veniam, quis nostrud exercitation \r\n                ullamco laboris nisi ut aliquip ex ea commodo consequat.", "~\\Img\\ipad.jpg", "~\\Img\\ipad.jpg", true, true, "IPad", 499.99m },
                    { 2, 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit,  +\r\n                sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.\r\n                Ut enim ad minim veniam, quis nostrud exercitation \r\n                ullamco laboris nisi ut aliquip ex ea commodo consequat.", "~\\Img\\iphone.jpg", "~\\Img\\iphone.jpg", true, true, "IPhone", 499.99m },
                    { 3, 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit,  +\r\n                sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.\r\n                Ut enim ad minim veniam, quis nostrud exercitation \r\n                ullamco laboris nisi ut aliquip ex ea commodo consequat.", "~\\Img\\watch.jpg", "~\\Img\\watch.jpg", true, false, "Smart watch", 499.99m },
                    { 4, 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit,  +\r\n                sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.\r\n                Ut enim ad minim veniam, quis nostrud exercitation \r\n                ullamco laboris nisi ut aliquip ex ea commodo consequat.", "~\\Img\\Quad.jpg", "~\\Img\\watch.jpg", true, false, "Vehicle", 499.99m },
                    { 5, 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit,  +\r\n                sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.\r\n                Ut enim ad minim veniam, quis nostrud exercitation \r\n                ullamco laboris nisi ut aliquip ex ea commodo consequat.", "~\\Img\\apple.jpg", "~\\Img\\watch.jpg", true, true, "Surprise", 499.99m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5);
        }
    }
}
