using Microsoft.EntityFrameworkCore.Migrations;

namespace AASA_Back_End.Migrations
{
    public partial class PortfolioVersion4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PriceEighth",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "PriceFifth",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "PriceFirst",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "PriceFourth",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "PriceNinth",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "PriceSecond",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "PriceSeventh",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "PriceSixth",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "PriceThird",
                table: "Portfolios");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "PriceEighth",
                table: "Portfolios",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PriceFifth",
                table: "Portfolios",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PriceFirst",
                table: "Portfolios",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PriceFourth",
                table: "Portfolios",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PriceNinth",
                table: "Portfolios",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PriceSecond",
                table: "Portfolios",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PriceSeventh",
                table: "Portfolios",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PriceSixth",
                table: "Portfolios",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PriceThird",
                table: "Portfolios",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
