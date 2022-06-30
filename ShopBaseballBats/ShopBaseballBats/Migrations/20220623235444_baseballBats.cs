using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopBaseballBats.Migrations
{
    public partial class BaseballBats : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BaseballBats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BatBrand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DescriptionHtml = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Favorite = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaseballBats", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BatModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Length = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    BaseballBatId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BatModels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BatModels_BaseballBats_BaseballBatId",
                        column: x => x.BaseballBatId,
                        principalTable: "BaseballBats",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_BatModels_BaseballBatId",
                table: "BatModels",
                column: "BaseballBatId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BatModels");

            migrationBuilder.DropTable(
                name: "BaseballBats");
        }
    }
}
