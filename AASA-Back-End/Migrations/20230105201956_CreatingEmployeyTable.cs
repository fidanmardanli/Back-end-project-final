using Microsoft.EntityFrameworkCore.Migrations;

namespace AASA_Back_End.Migrations
{
    public partial class CreatingEmployeyTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Employees",
                table: "Employees");

            migrationBuilder.RenameTable(
                name: "Employees",
                newName: "Employeees");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employeees",
                table: "Employeees",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Employeees",
                table: "Employeees");

            migrationBuilder.RenameTable(
                name: "Employeees",
                newName: "Employees");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employees",
                table: "Employees",
                column: "Id");
        }
    }
}
