using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Axis.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addingLeavecomponent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "leavecomponents",
                columns: table => new
                {
                    id = table.Column<string>(type: "text", nullable: false),
                    name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    displayname = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    definition = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: false),
                    color = table.Column<string>(type: "character varying(7)", maxLength: 7, nullable: true),
                    maximumallocationperperiod = table.Column<decimal>(type: "numeric", nullable: true),
                    applicationafterworkingdays = table.Column<int>(type: "integer", nullable: true),
                    maximumconsecutiveleaves = table.Column<int>(type: "integer", nullable: true),
                    unittype = table.Column<int>(type: "integer", nullable: false),
                    isactive = table.Column<bool>(type: "boolean", nullable: false),
                    iscarryforward = table.Column<bool>(type: "boolean", nullable: true),
                    maxcarryforwardedleaves = table.Column<int>(type: "integer", nullable: true),
                    expiryindays = table.Column<int>(type: "integer", nullable: true),
                    isencashment = table.Column<bool>(type: "boolean", nullable: true),
                    maxencashableleaves = table.Column<int>(type: "integer", nullable: true),
                    earningcomponentid = table.Column<string>(type: "text", nullable: true),
                    nonencashableleaves = table.Column<int>(type: "integer", nullable: true),
                    isearnedleave = table.Column<bool>(type: "boolean", nullable: true),
                    frequency = table.Column<int>(type: "integer", nullable: true),
                    allocateonday = table.Column<int>(type: "integer", nullable: true),
                    roundingrule = table.Column<double>(type: "double precision", nullable: true),
                    iswithoutpay = table.Column<bool>(type: "boolean", nullable: true),
                    isoptional = table.Column<bool>(type: "boolean", nullable: true),
                    ispartiallypaid = table.Column<bool>(type: "boolean", nullable: true),
                    allownegativebalance = table.Column<bool>(type: "boolean", nullable: true),
                    allowoverallocation = table.Column<bool>(type: "boolean", nullable: true),
                    includeholidayswithinleaves = table.Column<bool>(type: "boolean", nullable: true),
                    iscompensatory = table.Column<bool>(type: "boolean", nullable: true),
                    fractionofdailysalary = table.Column<decimal>(type: "numeric", nullable: true),
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
                    table.PrimaryKey("pk_leavecomponents", x => x.id);
                    table.ForeignKey(
                        name: "fk_leavecomponents_companies_comid",
                        column: x => x.comid,
                        principalTable: "companies",
                        principalColumn: "comid");
                });

            migrationBuilder.CreateIndex(
                name: "ix_leavecomponents_comid",
                table: "leavecomponents",
                column: "comid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "leavecomponents");
        }
    }
}
