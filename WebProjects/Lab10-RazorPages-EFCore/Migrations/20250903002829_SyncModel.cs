using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace lab_10_albertspencer.Migrations
{
    /// <inheritdoc />
    public partial class SyncModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ImageURL",
                table: "Products",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 1,
                column: "ImageURL",
                value: "sentinel7.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 2,
                column: "ImageURL",
                value: "cerebralnexus.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 3,
                column: "ImageURL",
                value: "omnimind.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 4,
                column: "ImageURL",
                value: "dreamweaver.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ImageURL",
                table: "Products",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 1,
                column: "ImageURL",
                value: "img/sentinel7.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 2,
                column: "ImageURL",
                value: "img/cerebralnexus.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 3,
                column: "ImageURL",
                value: "img/omnimind.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 4,
                column: "ImageURL",
                value: "img/dreamweaver.jpg");
        }
    }
}
