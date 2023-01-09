using Microsoft.EntityFrameworkCore.Migrations;

namespace AASA_Back_End.Migrations
{
    public partial class CreateCategoryTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Header = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ImageFirst = table.Column<string>(nullable: true),
                    ImageSecond = table.Column<string>(nullable: true),
                    ImageThird = table.Column<string>(nullable: true),
                    TitleFirst = table.Column<string>(nullable: true),
                    TitleSecond = table.Column<string>(nullable: true),
                    TitleThird = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoriesDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoriesHeader = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoriesImageFirst = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoriesImageSecond = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoriesImageThird = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoriesTitleFirst = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoriesTitleSecond = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoriesTitleThird = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });
        }
    }
}
