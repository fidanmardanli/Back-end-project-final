using Microsoft.EntityFrameworkCore.Migrations;

namespace AASA_Back_End.Migrations
{
    public partial class UpdateDatabse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Employeees");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Employeees",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
