using Microsoft.EntityFrameworkCore.Migrations;

namespace AASA_Back_End.Migrations
{
    public partial class CreatePortfolios : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Portfolios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageFirst = table.Column<string>(nullable: true),
                    ImageSecond = table.Column<string>(nullable: true),
                    ImageThird = table.Column<string>(nullable: true),
                    ImageFourth = table.Column<string>(nullable: true),
                    ImageFifth = table.Column<string>(nullable: true),
                    ImageSixth = table.Column<string>(nullable: true),
                    ImageSeventh = table.Column<string>(nullable: true),
                    ImageEighth = table.Column<string>(nullable: true),
                    ImageNinth = table.Column<string>(nullable: true),
                    TitleFirst = table.Column<string>(nullable: true),
                    TitleSecond = table.Column<string>(nullable: true),
                    TitleThird = table.Column<string>(nullable: true),
                    TitleFourth = table.Column<string>(nullable: true),
                    TitleFifth = table.Column<string>(nullable: true),
                    TitleSixth = table.Column<string>(nullable: true),
                    TitleSeventh = table.Column<string>(nullable: true),
                    TitleEighth = table.Column<string>(nullable: true),
                    TitleNinth = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Portfolios", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Portfolios");
        }
    }
}
