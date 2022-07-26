using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopBaseballBats.Migrations
{
    public partial class InitialCreateSqlite : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BaseballBats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ModelYear = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaseballBats", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EmailAddress = table.Column<string>(type: "TEXT", nullable: true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    LastName = table.Column<string>(type: "TEXT", maxLength: 60, nullable: true),
                    Phone = table.Column<string>(type: "TEXT", maxLength: 13, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "BatBrands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Length = table.Column<int>(type: "INTEGER", nullable: false),
                    Weight = table.Column<int>(type: "INTEGER", nullable: true),
                    Price = table.Column<double>(type: "REAL", nullable: true),
                    BrandName = table.Column<string>(type: "TEXT", nullable: true),
                    ModelNames = table.Column<string>(type: "TEXT", nullable: true),
                    DescriptionHtml = table.Column<string>(type: "TEXT", nullable: true),
                    Cart = table.Column<bool>(type: "INTEGER", nullable: true),
                    BaseballBatsId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BatBrands", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BatBrands_BaseballBats_BaseballBatsId",
                        column: x => x.BaseballBatsId,
                        principalTable: "BaseballBats",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "BatBrands",
                columns: new[] { "Id", "BaseballBatsId", "BrandName", "Cart", "DescriptionHtml", "Length", "ModelNames", "Price", "Weight" },
                values: new object[] { 1, null, "Louisville Slugger", null, null, 28, "LXT", null, null });

            migrationBuilder.InsertData(
                table: "BatBrands",
                columns: new[] { "Id", "BaseballBatsId", "BrandName", "Cart", "DescriptionHtml", "Length", "ModelNames", "Price", "Weight" },
                values: new object[] { 4, null, "Louisville Slugger", null, null, 29, "LXT", null, null });

            migrationBuilder.InsertData(
                table: "BatBrands",
                columns: new[] { "Id", "BaseballBatsId", "BrandName", "Cart", "DescriptionHtml", "Length", "ModelNames", "Price", "Weight" },
                values: new object[] { 7, null, "Louisville Slugger", null, null, 30, "LXT", null, null });

            migrationBuilder.InsertData(
                table: "BatBrands",
                columns: new[] { "Id", "BaseballBatsId", "BrandName", "Cart", "DescriptionHtml", "Length", "ModelNames", "Price", "Weight" },
                values: new object[] { 10, null, "Louisville Slugger", null, null, 31, "LXT", null, null });

            migrationBuilder.InsertData(
                table: "BatBrands",
                columns: new[] { "Id", "BaseballBatsId", "BrandName", "Cart", "DescriptionHtml", "Length", "ModelNames", "Price", "Weight" },
                values: new object[] { 13, null, "Louisville Slugger", null, null, 32, "LXT", null, null });

            migrationBuilder.InsertData(
                table: "BatBrands",
                columns: new[] { "Id", "BaseballBatsId", "BrandName", "Cart", "DescriptionHtml", "Length", "ModelNames", "Price", "Weight" },
                values: new object[] { 16, null, "Louisville Slugger", null, null, 33, "LXT", null, null });

            migrationBuilder.InsertData(
                table: "BatBrands",
                columns: new[] { "Id", "BaseballBatsId", "BrandName", "Cart", "DescriptionHtml", "Length", "ModelNames", "Price", "Weight" },
                values: new object[] { 19, null, "Louisville Slugger", null, null, 28, "Meta", null, null });

            migrationBuilder.InsertData(
                table: "BatBrands",
                columns: new[] { "Id", "BaseballBatsId", "BrandName", "Cart", "DescriptionHtml", "Length", "ModelNames", "Price", "Weight" },
                values: new object[] { 22, null, "Louisville Slugger", null, null, 29, "Meta", null, null });

            migrationBuilder.InsertData(
                table: "BatBrands",
                columns: new[] { "Id", "BaseballBatsId", "BrandName", "Cart", "DescriptionHtml", "Length", "ModelNames", "Price", "Weight" },
                values: new object[] { 25, null, "Louisville Slugger", null, null, 30, "Meta", null, null });

            migrationBuilder.InsertData(
                table: "BatBrands",
                columns: new[] { "Id", "BaseballBatsId", "BrandName", "Cart", "DescriptionHtml", "Length", "ModelNames", "Price", "Weight" },
                values: new object[] { 28, null, "Louisville Slugger", null, null, 31, "Meta", null, null });

            migrationBuilder.InsertData(
                table: "BatBrands",
                columns: new[] { "Id", "BaseballBatsId", "BrandName", "Cart", "DescriptionHtml", "Length", "ModelNames", "Price", "Weight" },
                values: new object[] { 31, null, "Louisville Slugger", null, null, 32, "Meta", null, null });

            migrationBuilder.InsertData(
                table: "BatBrands",
                columns: new[] { "Id", "BaseballBatsId", "BrandName", "Cart", "DescriptionHtml", "Length", "ModelNames", "Price", "Weight" },
                values: new object[] { 34, null, "Louisville Slugger", null, null, 33, "Meta", null, null });

            migrationBuilder.InsertData(
                table: "BatBrands",
                columns: new[] { "Id", "BaseballBatsId", "BrandName", "Cart", "DescriptionHtml", "Length", "ModelNames", "Price", "Weight" },
                values: new object[] { 37, null, "Louisville Slugger", null, null, 28, "Xeno", null, null });

            migrationBuilder.InsertData(
                table: "BatBrands",
                columns: new[] { "Id", "BaseballBatsId", "BrandName", "Cart", "DescriptionHtml", "Length", "ModelNames", "Price", "Weight" },
                values: new object[] { 40, null, "Louisville Slugger", null, null, 29, "Xeno", null, null });

            migrationBuilder.InsertData(
                table: "BatBrands",
                columns: new[] { "Id", "BaseballBatsId", "BrandName", "Cart", "DescriptionHtml", "Length", "ModelNames", "Price", "Weight" },
                values: new object[] { 43, null, "Louisville Slugger", null, null, 30, "Xeno", null, null });

            migrationBuilder.InsertData(
                table: "BatBrands",
                columns: new[] { "Id", "BaseballBatsId", "BrandName", "Cart", "DescriptionHtml", "Length", "ModelNames", "Price", "Weight" },
                values: new object[] { 46, null, "Louisville Slugger", null, null, 31, "Xeno", null, null });

            migrationBuilder.InsertData(
                table: "BatBrands",
                columns: new[] { "Id", "BaseballBatsId", "BrandName", "Cart", "DescriptionHtml", "Length", "ModelNames", "Price", "Weight" },
                values: new object[] { 49, null, "Louisville Slugger", null, null, 32, "Xeno", null, null });

            migrationBuilder.InsertData(
                table: "BatBrands",
                columns: new[] { "Id", "BaseballBatsId", "BrandName", "Cart", "DescriptionHtml", "Length", "ModelNames", "Price", "Weight" },
                values: new object[] { 52, null, "Louisville Slugger", null, null, 33, "Xeno", null, null });

            migrationBuilder.InsertData(
                table: "BatBrands",
                columns: new[] { "Id", "BaseballBatsId", "BrandName", "Cart", "DescriptionHtml", "Length", "ModelNames", "Price", "Weight" },
                values: new object[] { 56, null, "Easton", null, null, 28, "Ghost", null, null });

            migrationBuilder.InsertData(
                table: "BatBrands",
                columns: new[] { "Id", "BaseballBatsId", "BrandName", "Cart", "DescriptionHtml", "Length", "ModelNames", "Price", "Weight" },
                values: new object[] { 59, null, "Easton", null, null, 29, "Ghost", null, null });

            migrationBuilder.InsertData(
                table: "BatBrands",
                columns: new[] { "Id", "BaseballBatsId", "BrandName", "Cart", "DescriptionHtml", "Length", "ModelNames", "Price", "Weight" },
                values: new object[] { 62, null, "Easton", null, null, 30, "Ghost", null, null });

            migrationBuilder.InsertData(
                table: "BatBrands",
                columns: new[] { "Id", "BaseballBatsId", "BrandName", "Cart", "DescriptionHtml", "Length", "ModelNames", "Price", "Weight" },
                values: new object[] { 65, null, "Easton", null, null, 31, "Ghost", null, null });

            migrationBuilder.InsertData(
                table: "BatBrands",
                columns: new[] { "Id", "BaseballBatsId", "BrandName", "Cart", "DescriptionHtml", "Length", "ModelNames", "Price", "Weight" },
                values: new object[] { 68, null, "Easton", null, null, 32, "Ghost", null, null });

            migrationBuilder.InsertData(
                table: "BatBrands",
                columns: new[] { "Id", "BaseballBatsId", "BrandName", "Cart", "DescriptionHtml", "Length", "ModelNames", "Price", "Weight" },
                values: new object[] { 71, null, "Easton", null, null, 33, "Ghost", null, null });

            migrationBuilder.InsertData(
                table: "BatBrands",
                columns: new[] { "Id", "BaseballBatsId", "BrandName", "Cart", "DescriptionHtml", "Length", "ModelNames", "Price", "Weight" },
                values: new object[] { 74, null, "Easton", null, null, 28, "Fire Fly", null, null });

            migrationBuilder.InsertData(
                table: "BatBrands",
                columns: new[] { "Id", "BaseballBatsId", "BrandName", "Cart", "DescriptionHtml", "Length", "ModelNames", "Price", "Weight" },
                values: new object[] { 77, null, "Easton", null, null, 29, "Fire Fly", null, null });

            migrationBuilder.InsertData(
                table: "BatBrands",
                columns: new[] { "Id", "BaseballBatsId", "BrandName", "Cart", "DescriptionHtml", "Length", "ModelNames", "Price", "Weight" },
                values: new object[] { 80, null, "Easton", null, null, 30, "Fire Fly", null, null });

            migrationBuilder.InsertData(
                table: "BatBrands",
                columns: new[] { "Id", "BaseballBatsId", "BrandName", "Cart", "DescriptionHtml", "Length", "ModelNames", "Price", "Weight" },
                values: new object[] { 83, null, "Easton", null, null, 31, "Fire Fly", null, null });

            migrationBuilder.InsertData(
                table: "BatBrands",
                columns: new[] { "Id", "BaseballBatsId", "BrandName", "Cart", "DescriptionHtml", "Length", "ModelNames", "Price", "Weight" },
                values: new object[] { 86, null, "Easton", null, null, 32, "Fire Fly", null, null });

            migrationBuilder.InsertData(
                table: "BatBrands",
                columns: new[] { "Id", "BaseballBatsId", "BrandName", "Cart", "DescriptionHtml", "Length", "ModelNames", "Price", "Weight" },
                values: new object[] { 89, null, "Easton", null, null, 33, "Fire Fly", null, null });

            migrationBuilder.InsertData(
                table: "BatBrands",
                columns: new[] { "Id", "BaseballBatsId", "BrandName", "Cart", "DescriptionHtml", "Length", "ModelNames", "Price", "Weight" },
                values: new object[] { 93, null, "Rawlings", null, null, 28, "Mantra", null, null });

            migrationBuilder.InsertData(
                table: "BatBrands",
                columns: new[] { "Id", "BaseballBatsId", "BrandName", "Cart", "DescriptionHtml", "Length", "ModelNames", "Price", "Weight" },
                values: new object[] { 96, null, "Rawlings", null, null, 29, "Mantra", null, null });

            migrationBuilder.InsertData(
                table: "BatBrands",
                columns: new[] { "Id", "BaseballBatsId", "BrandName", "Cart", "DescriptionHtml", "Length", "ModelNames", "Price", "Weight" },
                values: new object[] { 99, null, "Rawlings", null, null, 30, "Mantra", null, null });

            migrationBuilder.InsertData(
                table: "BatBrands",
                columns: new[] { "Id", "BaseballBatsId", "BrandName", "Cart", "DescriptionHtml", "Length", "ModelNames", "Price", "Weight" },
                values: new object[] { 102, null, "Rawlings", null, null, 31, "Mantra", null, null });

            migrationBuilder.InsertData(
                table: "BatBrands",
                columns: new[] { "Id", "BaseballBatsId", "BrandName", "Cart", "DescriptionHtml", "Length", "ModelNames", "Price", "Weight" },
                values: new object[] { 105, null, "Rawlings", null, null, 32, "Mantra", null, null });

            migrationBuilder.InsertData(
                table: "BatBrands",
                columns: new[] { "Id", "BaseballBatsId", "BrandName", "Cart", "DescriptionHtml", "Length", "ModelNames", "Price", "Weight" },
                values: new object[] { 108, null, "Rawlings", null, null, 33, "Mantra", null, null });

            migrationBuilder.CreateIndex(
                name: "IX_BatBrands_BaseballBatsId",
                table: "BatBrands",
                column: "BaseballBatsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BatBrands");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "BaseballBats");
        }
    }
}
