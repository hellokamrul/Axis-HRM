using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Axis.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class holidayleave : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "holidays",
                columns: table => new
                {
                    id = table.Column<string>(type: "text", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false),
                    color = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    fromdate = table.Column<DateTime>(type: "date", nullable: true),
                    todate = table.Column<DateTime>(type: "date", nullable: true),
                    weekday1 = table.Column<string>(type: "text", nullable: true),
                    weekday2 = table.Column<string>(type: "text", nullable: true),
                    weekday3 = table.Column<string>(type: "text", nullable: true),
                    weekday4 = table.Column<string>(type: "text", nullable: true),
                    weekday5 = table.Column<string>(type: "text", nullable: true),
                    weekday6 = table.Column<string>(type: "text", nullable: true),
                    weekday7 = table.Column<string>(type: "text", nullable: true),
                    country = table.Column<string>(type: "text", nullable: true),
                    state = table.Column<string>(type: "text", nullable: true),
                    isactive = table.Column<bool>(type: "boolean", nullable: true),
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
                    table.PrimaryKey("pk_holidays", x => x.id);
                    table.ForeignKey(
                        name: "fk_holidays_companies_comid",
                        column: x => x.comid,
                        principalTable: "companies",
                        principalColumn: "comid");
                });

            migrationBuilder.CreateTable(
                name: "holidaylists",
                columns: table => new
                {
                    id = table.Column<string>(type: "text", nullable: false),
                    serial = table.Column<int>(type: "integer", nullable: true),
                    date = table.Column<DateOnly>(type: "date", nullable: true),
                    type = table.Column<int>(type: "integer", nullable: true),
                    description = table.Column<string>(type: "text", nullable: true),
                    holidayid = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_holidaylists", x => x.id);
                    table.ForeignKey(
                        name: "fk_holidaylists_holidays_holidayid",
                        column: x => x.holidayid,
                        principalTable: "holidays",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "ix_holidaylists_holidayid",
                table: "holidaylists",
                column: "holidayid");

            migrationBuilder.CreateIndex(
                name: "ix_holidays_comid",
                table: "holidays",
                column: "comid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "holidaylists");

            migrationBuilder.DropTable(
                name: "holidays");
        }
    }
}
