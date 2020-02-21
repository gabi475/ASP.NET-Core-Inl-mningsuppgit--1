using Microsoft.EntityFrameworkCore.Migrations;

namespace FreakyFashion1.Migrations
{
    public partial class AddUrlSlug : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UrlSlug",
                table: "Product",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UrlSlug",
                table: "Category",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                column: "UrlSlug",
                value: "red hoodie");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                column: "UrlSlug",
                value: "green jacket");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                column: "UrlSlug",
                value: "hoodie");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                column: "UrlSlug",
                value: "jacket");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5,
                column: "UrlSlug",
                value: "hoodie");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Name", "UrlSlug" },
                values: new object[] { "Suit", "suit" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                column: "UrlSlug",
                value: "dress");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                column: "UrlSlug",
                value: "jeans");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                column: "UrlSlug",
                value: "sko");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                column: "UrlSlug",
                value: "t-skirt");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                column: "UrlSlug",
                value: "black jacket");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                column: "UrlSlug",
                value: "jeans for kid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UrlSlug",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "UrlSlug",
                table: "Category");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "Pantd");
        }
    }
}
