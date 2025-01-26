using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Axis.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class add_hr_model : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_bankinfo_company_comid",
                table: "bankinfo");

            migrationBuilder.DropForeignKey(
                name: "fk_company_country_countryid",
                table: "company");

            migrationBuilder.DropForeignKey(
                name: "fk_contactinfo_company_comid",
                table: "contactinfo");

            migrationBuilder.DropForeignKey(
                name: "fk_contactinfo_employees_empid",
                table: "contactinfo");

            migrationBuilder.DropForeignKey(
                name: "fk_department_company_comid",
                table: "department");

            migrationBuilder.DropForeignKey(
                name: "fk_designation_company_comid",
                table: "designation");

            migrationBuilder.DropForeignKey(
                name: "fk_educations_company_comid",
                table: "educations");

            migrationBuilder.DropForeignKey(
                name: "fk_empcertificate_company_comid",
                table: "empcertificate");

            migrationBuilder.DropForeignKey(
                name: "fk_empcertificate_employees_empid",
                table: "empcertificate");

            migrationBuilder.DropForeignKey(
                name: "fk_employeeaddresses_company_comid",
                table: "employeeaddresses");

            migrationBuilder.DropForeignKey(
                name: "fk_employeefiles_company_comid",
                table: "employeefiles");

            migrationBuilder.DropForeignKey(
                name: "fk_employees_company_comid",
                table: "employees");

            migrationBuilder.DropForeignKey(
                name: "fk_emptaxinfos_company_comid",
                table: "emptaxinfos");

            migrationBuilder.DropForeignKey(
                name: "fk_familyinfos_company_comid",
                table: "familyinfos");

            migrationBuilder.DropForeignKey(
                name: "fk_floor_company_comid",
                table: "floor");

            migrationBuilder.DropForeignKey(
                name: "fk_grade_company_comid",
                table: "grade");

            migrationBuilder.DropForeignKey(
                name: "fk_jobinformations_company_comid",
                table: "jobinformations");

            migrationBuilder.DropForeignKey(
                name: "fk_line_company_comid",
                table: "line");

            migrationBuilder.DropForeignKey(
                name: "fk_section_company_comid",
                table: "section");

            migrationBuilder.DropForeignKey(
                name: "fk_shift_company_comid",
                table: "shift");

            migrationBuilder.DropForeignKey(
                name: "fk_unit_company_comid",
                table: "unit");

            migrationBuilder.DropForeignKey(
                name: "fk_workexperiences_company_comid",
                table: "workexperiences");

            migrationBuilder.DropPrimaryKey(
                name: "pk_unit",
                table: "unit");

            migrationBuilder.DropPrimaryKey(
                name: "pk_shift",
                table: "shift");

            migrationBuilder.DropPrimaryKey(
                name: "pk_section",
                table: "section");

            migrationBuilder.DropPrimaryKey(
                name: "pk_line",
                table: "line");

            migrationBuilder.DropPrimaryKey(
                name: "pk_grade",
                table: "grade");

            migrationBuilder.DropPrimaryKey(
                name: "pk_floor",
                table: "floor");

            migrationBuilder.DropPrimaryKey(
                name: "pk_empcertificate",
                table: "empcertificate");

            migrationBuilder.DropPrimaryKey(
                name: "pk_designation",
                table: "designation");

            migrationBuilder.DropPrimaryKey(
                name: "pk_department",
                table: "department");

            migrationBuilder.DropPrimaryKey(
                name: "pk_country",
                table: "country");

            migrationBuilder.DropPrimaryKey(
                name: "pk_contactinfo",
                table: "contactinfo");

            migrationBuilder.DropPrimaryKey(
                name: "pk_company",
                table: "company");

            migrationBuilder.RenameTable(
                name: "unit",
                newName: "units");

            migrationBuilder.RenameTable(
                name: "shift",
                newName: "shifts");

            migrationBuilder.RenameTable(
                name: "section",
                newName: "sections");

            migrationBuilder.RenameTable(
                name: "line",
                newName: "lines");

            migrationBuilder.RenameTable(
                name: "grade",
                newName: "grades");

            migrationBuilder.RenameTable(
                name: "floor",
                newName: "floors");

            migrationBuilder.RenameTable(
                name: "empcertificate",
                newName: "empcertificates");

            migrationBuilder.RenameTable(
                name: "designation",
                newName: "designations");

            migrationBuilder.RenameTable(
                name: "department",
                newName: "departments");

            migrationBuilder.RenameTable(
                name: "country",
                newName: "countries");

            migrationBuilder.RenameTable(
                name: "contactinfo",
                newName: "contactinfos");

            migrationBuilder.RenameTable(
                name: "company",
                newName: "companies");

            migrationBuilder.RenameIndex(
                name: "ix_unit_comid",
                table: "units",
                newName: "ix_units_comid");

            migrationBuilder.RenameIndex(
                name: "ix_shift_comid",
                table: "shifts",
                newName: "ix_shifts_comid");

            migrationBuilder.RenameIndex(
                name: "ix_section_comid",
                table: "sections",
                newName: "ix_sections_comid");

            migrationBuilder.RenameIndex(
                name: "ix_line_comid",
                table: "lines",
                newName: "ix_lines_comid");

            migrationBuilder.RenameIndex(
                name: "ix_grade_comid",
                table: "grades",
                newName: "ix_grades_comid");

            migrationBuilder.RenameIndex(
                name: "ix_floor_comid",
                table: "floors",
                newName: "ix_floors_comid");

            migrationBuilder.RenameIndex(
                name: "ix_empcertificate_empid",
                table: "empcertificates",
                newName: "ix_empcertificates_empid");

            migrationBuilder.RenameIndex(
                name: "ix_empcertificate_comid",
                table: "empcertificates",
                newName: "ix_empcertificates_comid");

            migrationBuilder.RenameIndex(
                name: "ix_designation_comid",
                table: "designations",
                newName: "ix_designations_comid");

            migrationBuilder.RenameIndex(
                name: "ix_department_comid",
                table: "departments",
                newName: "ix_departments_comid");

            migrationBuilder.RenameIndex(
                name: "ix_contactinfo_empid",
                table: "contactinfos",
                newName: "ix_contactinfos_empid");

            migrationBuilder.RenameIndex(
                name: "ix_contactinfo_comid",
                table: "contactinfos",
                newName: "ix_contactinfos_comid");

            migrationBuilder.RenameIndex(
                name: "ix_company_countryid",
                table: "companies",
                newName: "ix_companies_countryid");

            migrationBuilder.AddPrimaryKey(
                name: "pk_units",
                table: "units",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_shifts",
                table: "shifts",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_sections",
                table: "sections",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_lines",
                table: "lines",
                column: "lineid");

            migrationBuilder.AddPrimaryKey(
                name: "pk_grades",
                table: "grades",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_floors",
                table: "floors",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_empcertificates",
                table: "empcertificates",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_designations",
                table: "designations",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_departments",
                table: "departments",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_countries",
                table: "countries",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_contactinfos",
                table: "contactinfos",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_companies",
                table: "companies",
                column: "comid");

            migrationBuilder.CreateTable(
                name: "bloodgroups",
                columns: table => new
                {
                    id = table.Column<string>(type: "text", nullable: false),
                    bloodname = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    bloodlocalname = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    comid = table.Column<string>(type: "text", nullable: true),
                    createdbyuserid = table.Column<string>(type: "text", nullable: true),
                    updatebyuserid = table.Column<string>(type: "text", nullable: true),
                    isdelete = table.Column<bool>(type: "boolean", nullable: true),
                    dateadded = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createdate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    modifieddate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_bloodgroups", x => x.id);
                    table.ForeignKey(
                        name: "fk_bloodgroups_companies_comid",
                        column: x => x.comid,
                        principalTable: "companies",
                        principalColumn: "comid");
                });

            migrationBuilder.CreateTable(
                name: "religiones",
                columns: table => new
                {
                    id = table.Column<string>(type: "text", nullable: false),
                    religionname = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    religionlocalname = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    comid = table.Column<string>(type: "text", nullable: true),
                    createdbyuserid = table.Column<string>(type: "text", nullable: true),
                    updatebyuserid = table.Column<string>(type: "text", nullable: true),
                    isdelete = table.Column<bool>(type: "boolean", nullable: true),
                    dateadded = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    createdate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    modifieddate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_religiones", x => x.id);
                    table.ForeignKey(
                        name: "fk_religiones_companies_comid",
                        column: x => x.comid,
                        principalTable: "companies",
                        principalColumn: "comid");
                });

            migrationBuilder.CreateIndex(
                name: "ix_bloodgroups_comid",
                table: "bloodgroups",
                column: "comid");

            migrationBuilder.CreateIndex(
                name: "ix_religiones_comid",
                table: "religiones",
                column: "comid");

            migrationBuilder.AddForeignKey(
                name: "fk_bankinfo_companies_comid",
                table: "bankinfo",
                column: "comid",
                principalTable: "companies",
                principalColumn: "comid");

            migrationBuilder.AddForeignKey(
                name: "fk_companies_countries_countryid",
                table: "companies",
                column: "countryid",
                principalTable: "countries",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "fk_contactinfos_companies_comid",
                table: "contactinfos",
                column: "comid",
                principalTable: "companies",
                principalColumn: "comid");

            migrationBuilder.AddForeignKey(
                name: "fk_contactinfos_employees_empid",
                table: "contactinfos",
                column: "empid",
                principalTable: "employees",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "fk_departments_companies_comid",
                table: "departments",
                column: "comid",
                principalTable: "companies",
                principalColumn: "comid");

            migrationBuilder.AddForeignKey(
                name: "fk_designations_companies_comid",
                table: "designations",
                column: "comid",
                principalTable: "companies",
                principalColumn: "comid");

            migrationBuilder.AddForeignKey(
                name: "fk_educations_companies_comid",
                table: "educations",
                column: "comid",
                principalTable: "companies",
                principalColumn: "comid");

            migrationBuilder.AddForeignKey(
                name: "fk_empcertificates_companies_comid",
                table: "empcertificates",
                column: "comid",
                principalTable: "companies",
                principalColumn: "comid");

            migrationBuilder.AddForeignKey(
                name: "fk_empcertificates_employees_empid",
                table: "empcertificates",
                column: "empid",
                principalTable: "employees",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "fk_employeeaddresses_companies_comid",
                table: "employeeaddresses",
                column: "comid",
                principalTable: "companies",
                principalColumn: "comid");

            migrationBuilder.AddForeignKey(
                name: "fk_employeefiles_companies_comid",
                table: "employeefiles",
                column: "comid",
                principalTable: "companies",
                principalColumn: "comid");

            migrationBuilder.AddForeignKey(
                name: "fk_employees_companies_comid",
                table: "employees",
                column: "comid",
                principalTable: "companies",
                principalColumn: "comid");

            migrationBuilder.AddForeignKey(
                name: "fk_emptaxinfos_companies_comid",
                table: "emptaxinfos",
                column: "comid",
                principalTable: "companies",
                principalColumn: "comid");

            migrationBuilder.AddForeignKey(
                name: "fk_familyinfos_companies_comid",
                table: "familyinfos",
                column: "comid",
                principalTable: "companies",
                principalColumn: "comid");

            migrationBuilder.AddForeignKey(
                name: "fk_floors_companies_comid",
                table: "floors",
                column: "comid",
                principalTable: "companies",
                principalColumn: "comid");

            migrationBuilder.AddForeignKey(
                name: "fk_grades_companies_comid",
                table: "grades",
                column: "comid",
                principalTable: "companies",
                principalColumn: "comid");

            migrationBuilder.AddForeignKey(
                name: "fk_jobinformations_companies_comid",
                table: "jobinformations",
                column: "comid",
                principalTable: "companies",
                principalColumn: "comid");

            migrationBuilder.AddForeignKey(
                name: "fk_lines_companies_comid",
                table: "lines",
                column: "comid",
                principalTable: "companies",
                principalColumn: "comid");

            migrationBuilder.AddForeignKey(
                name: "fk_sections_companies_comid",
                table: "sections",
                column: "comid",
                principalTable: "companies",
                principalColumn: "comid");

            migrationBuilder.AddForeignKey(
                name: "fk_shifts_companies_comid",
                table: "shifts",
                column: "comid",
                principalTable: "companies",
                principalColumn: "comid");

            migrationBuilder.AddForeignKey(
                name: "fk_units_companies_comid",
                table: "units",
                column: "comid",
                principalTable: "companies",
                principalColumn: "comid");

            migrationBuilder.AddForeignKey(
                name: "fk_workexperiences_companies_comid",
                table: "workexperiences",
                column: "comid",
                principalTable: "companies",
                principalColumn: "comid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_bankinfo_companies_comid",
                table: "bankinfo");

            migrationBuilder.DropForeignKey(
                name: "fk_companies_countries_countryid",
                table: "companies");

            migrationBuilder.DropForeignKey(
                name: "fk_contactinfos_companies_comid",
                table: "contactinfos");

            migrationBuilder.DropForeignKey(
                name: "fk_contactinfos_employees_empid",
                table: "contactinfos");

            migrationBuilder.DropForeignKey(
                name: "fk_departments_companies_comid",
                table: "departments");

            migrationBuilder.DropForeignKey(
                name: "fk_designations_companies_comid",
                table: "designations");

            migrationBuilder.DropForeignKey(
                name: "fk_educations_companies_comid",
                table: "educations");

            migrationBuilder.DropForeignKey(
                name: "fk_empcertificates_companies_comid",
                table: "empcertificates");

            migrationBuilder.DropForeignKey(
                name: "fk_empcertificates_employees_empid",
                table: "empcertificates");

            migrationBuilder.DropForeignKey(
                name: "fk_employeeaddresses_companies_comid",
                table: "employeeaddresses");

            migrationBuilder.DropForeignKey(
                name: "fk_employeefiles_companies_comid",
                table: "employeefiles");

            migrationBuilder.DropForeignKey(
                name: "fk_employees_companies_comid",
                table: "employees");

            migrationBuilder.DropForeignKey(
                name: "fk_emptaxinfos_companies_comid",
                table: "emptaxinfos");

            migrationBuilder.DropForeignKey(
                name: "fk_familyinfos_companies_comid",
                table: "familyinfos");

            migrationBuilder.DropForeignKey(
                name: "fk_floors_companies_comid",
                table: "floors");

            migrationBuilder.DropForeignKey(
                name: "fk_grades_companies_comid",
                table: "grades");

            migrationBuilder.DropForeignKey(
                name: "fk_jobinformations_companies_comid",
                table: "jobinformations");

            migrationBuilder.DropForeignKey(
                name: "fk_lines_companies_comid",
                table: "lines");

            migrationBuilder.DropForeignKey(
                name: "fk_sections_companies_comid",
                table: "sections");

            migrationBuilder.DropForeignKey(
                name: "fk_shifts_companies_comid",
                table: "shifts");

            migrationBuilder.DropForeignKey(
                name: "fk_units_companies_comid",
                table: "units");

            migrationBuilder.DropForeignKey(
                name: "fk_workexperiences_companies_comid",
                table: "workexperiences");

            migrationBuilder.DropTable(
                name: "bloodgroups");

            migrationBuilder.DropTable(
                name: "religiones");

            migrationBuilder.DropPrimaryKey(
                name: "pk_units",
                table: "units");

            migrationBuilder.DropPrimaryKey(
                name: "pk_shifts",
                table: "shifts");

            migrationBuilder.DropPrimaryKey(
                name: "pk_sections",
                table: "sections");

            migrationBuilder.DropPrimaryKey(
                name: "pk_lines",
                table: "lines");

            migrationBuilder.DropPrimaryKey(
                name: "pk_grades",
                table: "grades");

            migrationBuilder.DropPrimaryKey(
                name: "pk_floors",
                table: "floors");

            migrationBuilder.DropPrimaryKey(
                name: "pk_empcertificates",
                table: "empcertificates");

            migrationBuilder.DropPrimaryKey(
                name: "pk_designations",
                table: "designations");

            migrationBuilder.DropPrimaryKey(
                name: "pk_departments",
                table: "departments");

            migrationBuilder.DropPrimaryKey(
                name: "pk_countries",
                table: "countries");

            migrationBuilder.DropPrimaryKey(
                name: "pk_contactinfos",
                table: "contactinfos");

            migrationBuilder.DropPrimaryKey(
                name: "pk_companies",
                table: "companies");

            migrationBuilder.RenameTable(
                name: "units",
                newName: "unit");

            migrationBuilder.RenameTable(
                name: "shifts",
                newName: "shift");

            migrationBuilder.RenameTable(
                name: "sections",
                newName: "section");

            migrationBuilder.RenameTable(
                name: "lines",
                newName: "line");

            migrationBuilder.RenameTable(
                name: "grades",
                newName: "grade");

            migrationBuilder.RenameTable(
                name: "floors",
                newName: "floor");

            migrationBuilder.RenameTable(
                name: "empcertificates",
                newName: "empcertificate");

            migrationBuilder.RenameTable(
                name: "designations",
                newName: "designation");

            migrationBuilder.RenameTable(
                name: "departments",
                newName: "department");

            migrationBuilder.RenameTable(
                name: "countries",
                newName: "country");

            migrationBuilder.RenameTable(
                name: "contactinfos",
                newName: "contactinfo");

            migrationBuilder.RenameTable(
                name: "companies",
                newName: "company");

            migrationBuilder.RenameIndex(
                name: "ix_units_comid",
                table: "unit",
                newName: "ix_unit_comid");

            migrationBuilder.RenameIndex(
                name: "ix_shifts_comid",
                table: "shift",
                newName: "ix_shift_comid");

            migrationBuilder.RenameIndex(
                name: "ix_sections_comid",
                table: "section",
                newName: "ix_section_comid");

            migrationBuilder.RenameIndex(
                name: "ix_lines_comid",
                table: "line",
                newName: "ix_line_comid");

            migrationBuilder.RenameIndex(
                name: "ix_grades_comid",
                table: "grade",
                newName: "ix_grade_comid");

            migrationBuilder.RenameIndex(
                name: "ix_floors_comid",
                table: "floor",
                newName: "ix_floor_comid");

            migrationBuilder.RenameIndex(
                name: "ix_empcertificates_empid",
                table: "empcertificate",
                newName: "ix_empcertificate_empid");

            migrationBuilder.RenameIndex(
                name: "ix_empcertificates_comid",
                table: "empcertificate",
                newName: "ix_empcertificate_comid");

            migrationBuilder.RenameIndex(
                name: "ix_designations_comid",
                table: "designation",
                newName: "ix_designation_comid");

            migrationBuilder.RenameIndex(
                name: "ix_departments_comid",
                table: "department",
                newName: "ix_department_comid");

            migrationBuilder.RenameIndex(
                name: "ix_contactinfos_empid",
                table: "contactinfo",
                newName: "ix_contactinfo_empid");

            migrationBuilder.RenameIndex(
                name: "ix_contactinfos_comid",
                table: "contactinfo",
                newName: "ix_contactinfo_comid");

            migrationBuilder.RenameIndex(
                name: "ix_companies_countryid",
                table: "company",
                newName: "ix_company_countryid");

            migrationBuilder.AddPrimaryKey(
                name: "pk_unit",
                table: "unit",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_shift",
                table: "shift",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_section",
                table: "section",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_line",
                table: "line",
                column: "lineid");

            migrationBuilder.AddPrimaryKey(
                name: "pk_grade",
                table: "grade",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_floor",
                table: "floor",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_empcertificate",
                table: "empcertificate",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_designation",
                table: "designation",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_department",
                table: "department",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_country",
                table: "country",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_contactinfo",
                table: "contactinfo",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_company",
                table: "company",
                column: "comid");

            migrationBuilder.AddForeignKey(
                name: "fk_bankinfo_company_comid",
                table: "bankinfo",
                column: "comid",
                principalTable: "company",
                principalColumn: "comid");

            migrationBuilder.AddForeignKey(
                name: "fk_company_country_countryid",
                table: "company",
                column: "countryid",
                principalTable: "country",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "fk_contactinfo_company_comid",
                table: "contactinfo",
                column: "comid",
                principalTable: "company",
                principalColumn: "comid");

            migrationBuilder.AddForeignKey(
                name: "fk_contactinfo_employees_empid",
                table: "contactinfo",
                column: "empid",
                principalTable: "employees",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "fk_department_company_comid",
                table: "department",
                column: "comid",
                principalTable: "company",
                principalColumn: "comid");

            migrationBuilder.AddForeignKey(
                name: "fk_designation_company_comid",
                table: "designation",
                column: "comid",
                principalTable: "company",
                principalColumn: "comid");

            migrationBuilder.AddForeignKey(
                name: "fk_educations_company_comid",
                table: "educations",
                column: "comid",
                principalTable: "company",
                principalColumn: "comid");

            migrationBuilder.AddForeignKey(
                name: "fk_empcertificate_company_comid",
                table: "empcertificate",
                column: "comid",
                principalTable: "company",
                principalColumn: "comid");

            migrationBuilder.AddForeignKey(
                name: "fk_empcertificate_employees_empid",
                table: "empcertificate",
                column: "empid",
                principalTable: "employees",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "fk_employeeaddresses_company_comid",
                table: "employeeaddresses",
                column: "comid",
                principalTable: "company",
                principalColumn: "comid");

            migrationBuilder.AddForeignKey(
                name: "fk_employeefiles_company_comid",
                table: "employeefiles",
                column: "comid",
                principalTable: "company",
                principalColumn: "comid");

            migrationBuilder.AddForeignKey(
                name: "fk_employees_company_comid",
                table: "employees",
                column: "comid",
                principalTable: "company",
                principalColumn: "comid");

            migrationBuilder.AddForeignKey(
                name: "fk_emptaxinfos_company_comid",
                table: "emptaxinfos",
                column: "comid",
                principalTable: "company",
                principalColumn: "comid");

            migrationBuilder.AddForeignKey(
                name: "fk_familyinfos_company_comid",
                table: "familyinfos",
                column: "comid",
                principalTable: "company",
                principalColumn: "comid");

            migrationBuilder.AddForeignKey(
                name: "fk_floor_company_comid",
                table: "floor",
                column: "comid",
                principalTable: "company",
                principalColumn: "comid");

            migrationBuilder.AddForeignKey(
                name: "fk_grade_company_comid",
                table: "grade",
                column: "comid",
                principalTable: "company",
                principalColumn: "comid");

            migrationBuilder.AddForeignKey(
                name: "fk_jobinformations_company_comid",
                table: "jobinformations",
                column: "comid",
                principalTable: "company",
                principalColumn: "comid");

            migrationBuilder.AddForeignKey(
                name: "fk_line_company_comid",
                table: "line",
                column: "comid",
                principalTable: "company",
                principalColumn: "comid");

            migrationBuilder.AddForeignKey(
                name: "fk_section_company_comid",
                table: "section",
                column: "comid",
                principalTable: "company",
                principalColumn: "comid");

            migrationBuilder.AddForeignKey(
                name: "fk_shift_company_comid",
                table: "shift",
                column: "comid",
                principalTable: "company",
                principalColumn: "comid");

            migrationBuilder.AddForeignKey(
                name: "fk_unit_company_comid",
                table: "unit",
                column: "comid",
                principalTable: "company",
                principalColumn: "comid");

            migrationBuilder.AddForeignKey(
                name: "fk_workexperiences_company_comid",
                table: "workexperiences",
                column: "comid",
                principalTable: "company",
                principalColumn: "comid");
        }
    }
}
