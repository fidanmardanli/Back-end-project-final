using Microsoft.EntityFrameworkCore.Migrations;

namespace AASA_Back_End.Migrations
{
    public partial class UpdatingPortfolio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Sliders",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Portfolios",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsMain",
                table: "Portfolios",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<decimal>(
                name: "PriceEighth",
                table: "Portfolios",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PriceFifth",
                table: "Portfolios",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PriceFirst",
                table: "Portfolios",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PriceFourth",
                table: "Portfolios",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PriceNinth",
                table: "Portfolios",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PriceSecond",
                table: "Portfolios",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PriceSeventh",
                table: "Portfolios",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PriceSixth",
                table: "Portfolios",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PriceThird",
                table: "Portfolios",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Categories",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Sliders");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "IsMain",
                table: "Portfolios");

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

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Categories");
        }
    }
}
