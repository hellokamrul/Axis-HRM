using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Axis.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDepartmentclass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "deptid",
                table: "designations",
                type: "text",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "ix_designations_deptid",
                table: "designations",
                column: "deptid");

            migrationBuilder.AddForeignKey(
                name: "fk_designations_departments_deptid",
                table: "designations",
                column: "deptid",
                principalTable: "departments",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_designations_departments_deptid",
                table: "designations");

            migrationBuilder.DropIndex(
                name: "ix_designations_deptid",
                table: "designations");

            migrationBuilder.DropColumn(
                name: "deptid",
                table: "designations");
        }
    }
}
