using Microsoft.EntityFrameworkCore.Migrations;

namespace AASA_Back_End.Migrations
{
    public partial class CreateSlider2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sliders2",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageFirst = table.Column<string>(nullable: true),
                    ImageSecond = table.Column<string>(nullable: true),
                    ImageThird = table.Column<string>(nullable: true),
                    TitleFirst = table.Column<string>(nullable: true),
                    TitleSecond = table.Column<string>(nullable: true),
                    TitleThird = table.Column<string>(nullable: true),
                    DescriptionFirst = table.Column<string>(nullable: true),
                    DescriptionSecond = table.Column<string>(nullable: true),
                    DescriptionThird = table.Column<string>(nullable: true),
                    TextFirst = table.Column<string>(nullable: true),
                    TextSecond = table.Column<string>(nullable: true),
                    TextThird = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sliders2", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sliders2");
        }
    }
}
