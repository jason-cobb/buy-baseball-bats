using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopBaseballBats.Migrations
{
    public partial class seeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Weight",
                table: "BatBrands",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "BatBrands",
                type: "float",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "ModelNames",
                table: "BatBrands",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<bool>(
                name: "Cart",
                table: "BatBrands",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.InsertData(
                table: "BatBrands",
                columns: new[] { "Id", "BaseballBatsId", "BrandName", "Cart", "DescriptionHtml", "Length", "ModelNames", "Price", "Weight" },
                values: new object[,]
                {
                    { 1, null, "Louisville Slugger", null, null, 28, "LXT", null, null },
                    { 4, null, "Louisville Slugger", null, null, 29, "LXT", null, null },
                    { 7, null, "Louisville Slugger", null, null, 30, "LXT", null, null },
                    { 10, null, "Louisville Slugger", null, null, 31, "LXT", null, null },
                    { 13, null, "Louisville Slugger", null, null, 32, "LXT", null, null },
                    { 16, null, "Louisville Slugger", null, null, 33, "LXT", null, null },
                    { 19, null, "Louisville Slugger", null, null, 28, "Meta", null, null },
                    { 22, null, "Louisville Slugger", null, null, 29, "Meta", null, null },
                    { 25, null, "Louisville Slugger", null, null, 30, "Meta", null, null },
                    { 28, null, "Louisville Slugger", null, null, 31, "Meta", null, null },
                    { 31, null, "Louisville Slugger", null, null, 32, "Meta", null, null },
                    { 34, null, "Louisville Slugger", null, null, 33, "Meta", null, null },
                    { 37, null, "Louisville Slugger", null, null, 28, "Xeno", null, null },
                    { 40, null, "Louisville Slugger", null, null, 29, "Xeno", null, null },
                    { 43, null, "Louisville Slugger", null, null, 30, "Xeno", null, null },
                    { 46, null, "Louisville Slugger", null, null, 31, "Xeno", null, null },
                    { 49, null, "Louisville Slugger", null, null, 32, "Xeno", null, null },
                    { 52, null, "Louisville Slugger", null, null, 33, "Xeno", null, null },
                    { 56, null, "Easton", null, null, 28, "Ghost", null, null },
                    { 59, null, "Easton", null, null, 29, "Ghost", null, null },
                    { 62, null, "Easton", null, null, 30, "Ghost", null, null },
                    { 65, null, "Easton", null, null, 31, "Ghost", null, null },
                    { 68, null, "Easton", null, null, 32, "Ghost", null, null },
                    { 71, null, "Easton", null, null, 33, "Ghost", null, null },
                    { 74, null, "Easton", null, null, 28, "Fire Fly", null, null },
                    { 77, null, "Easton", null, null, 29, "Fire Fly", null, null },
                    { 80, null, "Easton", null, null, 30, "Fire Fly", null, null },
                    { 83, null, "Easton", null, null, 31, "Fire Fly", null, null },
                    { 86, null, "Easton", null, null, 32, "Fire Fly", null, null },
                    { 89, null, "Easton", null, null, 33, "Fire Fly", null, null },
                    { 93, null, "Rawlings", null, null, 28, "Mantra", null, null },
                    { 96, null, "Rawlings", null, null, 29, "Mantra", null, null },
                    { 99, null, "Rawlings", null, null, 30, "Mantra", null, null },
                    { 102, null, "Rawlings", null, null, 31, "Mantra", null, null },
                    { 105, null, "Rawlings", null, null, 32, "Mantra", null, null },
                    { 108, null, "Rawlings", null, null, 33, "Mantra", null, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BatBrands",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BatBrands",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "BatBrands",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "BatBrands",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "BatBrands",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "BatBrands",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "BatBrands",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "BatBrands",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "BatBrands",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "BatBrands",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "BatBrands",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "BatBrands",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "BatBrands",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "BatBrands",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "BatBrands",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "BatBrands",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "BatBrands",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "BatBrands",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "BatBrands",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "BatBrands",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "BatBrands",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "BatBrands",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "BatBrands",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "BatBrands",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "BatBrands",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "BatBrands",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "BatBrands",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "BatBrands",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "BatBrands",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "BatBrands",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "BatBrands",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "BatBrands",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "BatBrands",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "BatBrands",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "BatBrands",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "BatBrands",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.AlterColumn<int>(
                name: "Weight",
                table: "BatBrands",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "BatBrands",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ModelNames",
                table: "BatBrands",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Cart",
                table: "BatBrands",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);
        }
    }
}
