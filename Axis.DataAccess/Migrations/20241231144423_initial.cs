using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Axis.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "country",
                columns: table => new
                {
                    id = table.Column<string>(type: "text", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false),
                    code = table.Column<string>(type: "text", nullable: false),
                    shortname = table.Column<string>(type: "text", nullable: false),
                    phonecode = table.Column<string>(type: "text", nullable: false),
                    localname = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_country", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "company",
                columns: table => new
                {
                    comid = table.Column<string>(type: "text", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false),
                    countryid = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_company", x => x.comid);
                    table.ForeignKey(
                        name: "fk_company_country_countryid",
                        column: x => x.countryid,
                        principalTable: "country",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "department",
                columns: table => new
                {
                    id = table.Column<string>(type: "text", nullable: false),
                    deptcode = table.Column<string>(type: "text", nullable: false),
                    deptname = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    deptlocalname = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    slno = table.Column<short>(type: "smallint", nullable: true),
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
                    table.PrimaryKey("pk_department", x => x.id);
                    table.ForeignKey(
                        name: "fk_department_company_comid",
                        column: x => x.comid,
                        principalTable: "company",
                        principalColumn: "comid");
                });

            migrationBuilder.CreateTable(
                name: "designation",
                columns: table => new
                {
                    id = table.Column<string>(type: "text", nullable: false),
                    designame = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    desiglocalname = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    salaryrange = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    slno = table.Column<int>(type: "integer", nullable: true),
                    gsmin = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    attbonus = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    holidaybonus = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    nightallow = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    ttlmanpower = table.Column<int>(type: "integer", nullable: true),
                    proposedmanpower = table.Column<int>(type: "integer", nullable: true),
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
                    table.PrimaryKey("pk_designation", x => x.id);
                    table.ForeignKey(
                        name: "fk_designation_company_comid",
                        column: x => x.comid,
                        principalTable: "company",
                        principalColumn: "comid");
                });

            migrationBuilder.CreateTable(
                name: "employees",
                columns: table => new
                {
                    id = table.Column<string>(type: "text", nullable: false),
                    empcode = table.Column<string>(type: "text", nullable: true),
                    firstname = table.Column<string>(type: "text", nullable: true),
                    lastname = table.Column<string>(type: "text", nullable: true),
                    middlename = table.Column<string>(type: "text", nullable: true),
                    gender = table.Column<string>(type: "text", nullable: true),
                    dateofbirth = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    socialsecuritynumber = table.Column<string>(type: "text", nullable: true),
                    email = table.Column<string>(type: "text", nullable: false),
                    phonenumber = table.Column<string>(type: "text", nullable: false),
                    emergencycontactname = table.Column<string>(type: "text", nullable: false),
                    emergencycontactrelationship = table.Column<string>(type: "text", nullable: false),
                    emergencycontactphone = table.Column<string>(type: "text", nullable: false),
                    iseligibleforbenefits = table.Column<bool>(type: "boolean", nullable: false),
                    healthinsuranceprovider = table.Column<string>(type: "text", nullable: false),
                    retirementplan = table.Column<string>(type: "text", nullable: false),
                    nationality = table.Column<string>(type: "text", nullable: false),
                    maritalstatus = table.Column<string>(type: "text", nullable: false),
                    skills = table.Column<List<string>>(type: "text[]", nullable: false),
                    certifications = table.Column<List<string>>(type: "text[]", nullable: false),
                    notes = table.Column<string>(type: "text", nullable: false),
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
                    table.PrimaryKey("pk_employees", x => x.id);
                    table.ForeignKey(
                        name: "fk_employees_company_comid",
                        column: x => x.comid,
                        principalTable: "company",
                        principalColumn: "comid");
                });

            migrationBuilder.CreateTable(
                name: "floor",
                columns: table => new
                {
                    id = table.Column<string>(type: "text", nullable: false),
                    floorname = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    floorlocalname = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
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
                    table.PrimaryKey("pk_floor", x => x.id);
                    table.ForeignKey(
                        name: "fk_floor_company_comid",
                        column: x => x.comid,
                        principalTable: "company",
                        principalColumn: "comid");
                });

            migrationBuilder.CreateTable(
                name: "grade",
                columns: table => new
                {
                    id = table.Column<string>(type: "text", nullable: false),
                    gradename = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: false),
                    gradelocalname = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: false),
                    mings = table.Column<double>(type: "double precision", nullable: true),
                    ttlmanpower = table.Column<int>(type: "integer", nullable: true),
                    salaryrange = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    ttlmanpowerworker = table.Column<int>(type: "integer", nullable: true),
                    slno = table.Column<int>(type: "integer", nullable: true),
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
                    table.PrimaryKey("pk_grade", x => x.id);
                    table.ForeignKey(
                        name: "fk_grade_company_comid",
                        column: x => x.comid,
                        principalTable: "company",
                        principalColumn: "comid");
                });

            migrationBuilder.CreateTable(
                name: "line",
                columns: table => new
                {
                    lineid = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    linename = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    linelocalname = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    id = table.Column<string>(type: "text", nullable: true),
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
                    table.PrimaryKey("pk_line", x => x.lineid);
                    table.ForeignKey(
                        name: "fk_line_company_comid",
                        column: x => x.comid,
                        principalTable: "company",
                        principalColumn: "comid");
                });

            migrationBuilder.CreateTable(
                name: "section",
                columns: table => new
                {
                    id = table.Column<string>(type: "text", nullable: false),
                    sectname = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    sectlocalname = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    slno = table.Column<int>(type: "integer", nullable: true),
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
                    table.PrimaryKey("pk_section", x => x.id);
                    table.ForeignKey(
                        name: "fk_section_company_comid",
                        column: x => x.comid,
                        principalTable: "company",
                        principalColumn: "comid");
                });

            migrationBuilder.CreateTable(
                name: "shift",
                columns: table => new
                {
                    id = table.Column<string>(type: "text", nullable: false),
                    shiftname = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: false),
                    shiftcode = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: false),
                    shiftdesc = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    shiftin = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    shiftout = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    shiftlate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    lunchtime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    lunchin = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    lunchout = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    tiffintime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    tiffinin = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    tiffinout = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    reghour = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    shifttype = table.Column<string>(type: "text", nullable: false),
                    shiftcat = table.Column<string>(type: "text", nullable: false),
                    isinactive = table.Column<bool>(type: "boolean", nullable: true),
                    tiffintime1 = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    tiffintimein1 = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    tiffintime2 = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    tiffintimein2 = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
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
                    table.PrimaryKey("pk_shift", x => x.id);
                    table.ForeignKey(
                        name: "fk_shift_company_comid",
                        column: x => x.comid,
                        principalTable: "company",
                        principalColumn: "comid");
                });

            migrationBuilder.CreateTable(
                name: "unit",
                columns: table => new
                {
                    id = table.Column<string>(type: "text", nullable: false),
                    unitname = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    unitshortname = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    unitlocalname = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
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
                    table.PrimaryKey("pk_unit", x => x.id);
                    table.ForeignKey(
                        name: "fk_unit_company_comid",
                        column: x => x.comid,
                        principalTable: "company",
                        principalColumn: "comid");
                });

            migrationBuilder.CreateTable(
                name: "bankinfo",
                columns: table => new
                {
                    id = table.Column<string>(type: "text", nullable: false),
                    bankname = table.Column<string>(type: "text", nullable: false),
                    bankbranch = table.Column<string>(type: "text", nullable: false),
                    accountnumber = table.Column<string>(type: "text", nullable: false),
                    accountname = table.Column<string>(type: "text", nullable: false),
                    accounttype = table.Column<string>(type: "text", nullable: false),
                    swiftcode = table.Column<string>(type: "text", nullable: false),
                    iban = table.Column<string>(type: "text", nullable: false),
                    currency = table.Column<string>(type: "text", nullable: false),
                    bankaddress = table.Column<string>(type: "text", nullable: false),
                    bankcity = table.Column<string>(type: "text", nullable: false),
                    bankcountry = table.Column<string>(type: "text", nullable: false),
                    bankphone = table.Column<string>(type: "text", nullable: false),
                    bankfax = table.Column<string>(type: "text", nullable: false),
                    bankemail = table.Column<string>(type: "text", nullable: false),
                    bankwebsite = table.Column<string>(type: "text", nullable: false),
                    bankcontactperson = table.Column<string>(type: "text", nullable: false),
                    bankcontactpersonphone = table.Column<string>(type: "text", nullable: false),
                    empid = table.Column<string>(type: "text", nullable: true),
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
                    table.PrimaryKey("pk_bankinfo", x => x.id);
                    table.ForeignKey(
                        name: "fk_bankinfo_company_comid",
                        column: x => x.comid,
                        principalTable: "company",
                        principalColumn: "comid");
                    table.ForeignKey(
                        name: "fk_bankinfo_employees_empid",
                        column: x => x.empid,
                        principalTable: "employees",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "contactinfo",
                columns: table => new
                {
                    id = table.Column<string>(type: "text", nullable: false),
                    fullname = table.Column<string>(type: "text", nullable: false),
                    relationship = table.Column<string>(type: "text", nullable: false),
                    primarycontactnumber = table.Column<string>(type: "text", nullable: false),
                    secondarycontactnumber = table.Column<string>(type: "text", nullable: false),
                    email = table.Column<string>(type: "text", nullable: false),
                    address = table.Column<string>(type: "text", nullable: false),
                    isprimary = table.Column<bool>(type: "boolean", nullable: false),
                    notes = table.Column<string>(type: "text", nullable: false),
                    empid = table.Column<string>(type: "text", nullable: true),
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
                    table.PrimaryKey("pk_contactinfo", x => x.id);
                    table.ForeignKey(
                        name: "fk_contactinfo_company_comid",
                        column: x => x.comid,
                        principalTable: "company",
                        principalColumn: "comid");
                    table.ForeignKey(
                        name: "fk_contactinfo_employees_empid",
                        column: x => x.empid,
                        principalTable: "employees",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "educations",
                columns: table => new
                {
                    id = table.Column<string>(type: "text", nullable: false),
                    institutionname = table.Column<string>(type: "text", nullable: false),
                    degree = table.Column<string>(type: "text", nullable: false),
                    major = table.Column<string>(type: "text", nullable: false),
                    graduationdate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    city = table.Column<string>(type: "text", nullable: false),
                    state = table.Column<string>(type: "text", nullable: false),
                    country = table.Column<string>(type: "text", nullable: false),
                    region = table.Column<string>(type: "text", nullable: false),
                    postalcode = table.Column<string>(type: "text", nullable: false),
                    countrycode = table.Column<string>(type: "text", nullable: false),
                    empid = table.Column<string>(type: "text", nullable: true),
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
                    table.PrimaryKey("pk_educations", x => x.id);
                    table.ForeignKey(
                        name: "fk_educations_company_comid",
                        column: x => x.comid,
                        principalTable: "company",
                        principalColumn: "comid");
                    table.ForeignKey(
                        name: "fk_educations_employees_empid",
                        column: x => x.empid,
                        principalTable: "employees",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "empcertificate",
                columns: table => new
                {
                    id = table.Column<string>(type: "text", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    certificatenumber = table.Column<string>(type: "text", nullable: false),
                    dateissued = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    expirationdate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    empid = table.Column<string>(type: "text", nullable: true),
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
                    table.PrimaryKey("pk_empcertificate", x => x.id);
                    table.ForeignKey(
                        name: "fk_empcertificate_company_comid",
                        column: x => x.comid,
                        principalTable: "company",
                        principalColumn: "comid");
                    table.ForeignKey(
                        name: "fk_empcertificate_employees_empid",
                        column: x => x.empid,
                        principalTable: "employees",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "employeeaddresses",
                columns: table => new
                {
                    id = table.Column<string>(type: "text", nullable: false),
                    street = table.Column<string>(type: "text", nullable: false),
                    city = table.Column<string>(type: "text", nullable: false),
                    state = table.Column<string>(type: "text", nullable: false),
                    zipcode = table.Column<string>(type: "text", nullable: false),
                    country = table.Column<string>(type: "text", nullable: false),
                    empid = table.Column<string>(type: "text", nullable: true),
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
                    table.PrimaryKey("pk_employeeaddresses", x => x.id);
                    table.ForeignKey(
                        name: "fk_employeeaddresses_company_comid",
                        column: x => x.comid,
                        principalTable: "company",
                        principalColumn: "comid");
                    table.ForeignKey(
                        name: "fk_employeeaddresses_employees_empid",
                        column: x => x.empid,
                        principalTable: "employees",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "employeefiles",
                columns: table => new
                {
                    id = table.Column<string>(type: "text", nullable: false),
                    filename = table.Column<string>(type: "text", nullable: false),
                    filepath = table.Column<string>(type: "text", nullable: false),
                    filetype = table.Column<string>(type: "text", nullable: false),
                    dateuploaded = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    empid = table.Column<string>(type: "text", nullable: true),
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
                    table.PrimaryKey("pk_employeefiles", x => x.id);
                    table.ForeignKey(
                        name: "fk_employeefiles_company_comid",
                        column: x => x.comid,
                        principalTable: "company",
                        principalColumn: "comid");
                    table.ForeignKey(
                        name: "fk_employeefiles_employees_empid",
                        column: x => x.empid,
                        principalTable: "employees",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "emptaxinfos",
                columns: table => new
                {
                    id = table.Column<string>(type: "text", nullable: false),
                    employeeid = table.Column<string>(type: "text", nullable: false),
                    taxidentificationnumber = table.Column<string>(type: "text", nullable: false),
                    socialsecuritynumber = table.Column<string>(type: "text", nullable: false),
                    taxfilingstatus = table.Column<string>(type: "text", nullable: false),
                    allowances = table.Column<int>(type: "integer", nullable: false),
                    additionalwithholding = table.Column<decimal>(type: "numeric", nullable: false),
                    statetaxidentification = table.Column<string>(type: "text", nullable: false),
                    localtaxidentification = table.Column<string>(type: "text", nullable: false),
                    isexempt = table.Column<bool>(type: "boolean", nullable: false),
                    notes = table.Column<string>(type: "text", nullable: false),
                    empid = table.Column<string>(type: "text", nullable: true),
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
                    table.PrimaryKey("pk_emptaxinfos", x => x.id);
                    table.ForeignKey(
                        name: "fk_emptaxinfos_company_comid",
                        column: x => x.comid,
                        principalTable: "company",
                        principalColumn: "comid");
                    table.ForeignKey(
                        name: "fk_emptaxinfos_employees_empid",
                        column: x => x.empid,
                        principalTable: "employees",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "familyinfos",
                columns: table => new
                {
                    id = table.Column<string>(type: "text", nullable: false),
                    fullname = table.Column<string>(type: "text", nullable: false),
                    dateofbirth = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    relationship = table.Column<string>(type: "text", nullable: false),
                    gender = table.Column<string>(type: "text", nullable: false),
                    occupation = table.Column<string>(type: "text", nullable: false),
                    isdependent = table.Column<bool>(type: "boolean", nullable: false),
                    contactnumber = table.Column<string>(type: "text", nullable: false),
                    notes = table.Column<string>(type: "text", nullable: false),
                    empid = table.Column<string>(type: "text", nullable: true),
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
                    table.PrimaryKey("pk_familyinfos", x => x.id);
                    table.ForeignKey(
                        name: "fk_familyinfos_company_comid",
                        column: x => x.comid,
                        principalTable: "company",
                        principalColumn: "comid");
                    table.ForeignKey(
                        name: "fk_familyinfos_employees_empid",
                        column: x => x.empid,
                        principalTable: "employees",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "jobinformations",
                columns: table => new
                {
                    id = table.Column<string>(type: "text", nullable: false),
                    jobtitle = table.Column<string>(type: "text", nullable: false),
                    employeeid = table.Column<string>(type: "text", nullable: false),
                    department = table.Column<string>(type: "text", nullable: false),
                    dateofhire = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    employmenttype = table.Column<string>(type: "text", nullable: false),
                    salary = table.Column<decimal>(type: "numeric", nullable: false),
                    joblocation = table.Column<string>(type: "text", nullable: false),
                    currency = table.Column<string>(type: "text", nullable: false),
                    contractperiod = table.Column<string>(type: "text", nullable: false),
                    contractstartdate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    contractenddate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    status = table.Column<string>(type: "text", nullable: false),
                    empid = table.Column<string>(type: "text", nullable: true),
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
                    table.PrimaryKey("pk_jobinformations", x => x.id);
                    table.ForeignKey(
                        name: "fk_jobinformations_company_comid",
                        column: x => x.comid,
                        principalTable: "company",
                        principalColumn: "comid");
                    table.ForeignKey(
                        name: "fk_jobinformations_employees_empid",
                        column: x => x.empid,
                        principalTable: "employees",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "workexperiences",
                columns: table => new
                {
                    id = table.Column<string>(type: "text", nullable: false),
                    companyname = table.Column<string>(type: "text", nullable: false),
                    jobtitle = table.Column<string>(type: "text", nullable: false),
                    startdate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    enddate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    responsibilities = table.Column<string>(type: "text", nullable: false),
                    achievements = table.Column<string>(type: "text", nullable: false),
                    empid = table.Column<string>(type: "text", nullable: true),
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
                    table.PrimaryKey("pk_workexperiences", x => x.id);
                    table.ForeignKey(
                        name: "fk_workexperiences_company_comid",
                        column: x => x.comid,
                        principalTable: "company",
                        principalColumn: "comid");
                    table.ForeignKey(
                        name: "fk_workexperiences_employees_empid",
                        column: x => x.empid,
                        principalTable: "employees",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "ix_bankinfo_comid",
                table: "bankinfo",
                column: "comid");

            migrationBuilder.CreateIndex(
                name: "ix_bankinfo_empid",
                table: "bankinfo",
                column: "empid");

            migrationBuilder.CreateIndex(
                name: "ix_company_countryid",
                table: "company",
                column: "countryid");

            migrationBuilder.CreateIndex(
                name: "ix_contactinfo_comid",
                table: "contactinfo",
                column: "comid");

            migrationBuilder.CreateIndex(
                name: "ix_contactinfo_empid",
                table: "contactinfo",
                column: "empid");

            migrationBuilder.CreateIndex(
                name: "ix_department_comid",
                table: "department",
                column: "comid");

            migrationBuilder.CreateIndex(
                name: "ix_designation_comid",
                table: "designation",
                column: "comid");

            migrationBuilder.CreateIndex(
                name: "ix_educations_comid",
                table: "educations",
                column: "comid");

            migrationBuilder.CreateIndex(
                name: "ix_educations_empid",
                table: "educations",
                column: "empid");

            migrationBuilder.CreateIndex(
                name: "ix_empcertificate_comid",
                table: "empcertificate",
                column: "comid");

            migrationBuilder.CreateIndex(
                name: "ix_empcertificate_empid",
                table: "empcertificate",
                column: "empid");

            migrationBuilder.CreateIndex(
                name: "ix_employeeaddresses_comid",
                table: "employeeaddresses",
                column: "comid");

            migrationBuilder.CreateIndex(
                name: "ix_employeeaddresses_empid",
                table: "employeeaddresses",
                column: "empid");

            migrationBuilder.CreateIndex(
                name: "ix_employeefiles_comid",
                table: "employeefiles",
                column: "comid");

            migrationBuilder.CreateIndex(
                name: "ix_employeefiles_empid",
                table: "employeefiles",
                column: "empid");

            migrationBuilder.CreateIndex(
                name: "ix_employees_comid",
                table: "employees",
                column: "comid");

            migrationBuilder.CreateIndex(
                name: "ix_emptaxinfos_comid",
                table: "emptaxinfos",
                column: "comid");

            migrationBuilder.CreateIndex(
                name: "ix_emptaxinfos_empid",
                table: "emptaxinfos",
                column: "empid");

            migrationBuilder.CreateIndex(
                name: "ix_familyinfos_comid",
                table: "familyinfos",
                column: "comid");

            migrationBuilder.CreateIndex(
                name: "ix_familyinfos_empid",
                table: "familyinfos",
                column: "empid");

            migrationBuilder.CreateIndex(
                name: "ix_floor_comid",
                table: "floor",
                column: "comid");

            migrationBuilder.CreateIndex(
                name: "ix_grade_comid",
                table: "grade",
                column: "comid");

            migrationBuilder.CreateIndex(
                name: "ix_jobinformations_comid",
                table: "jobinformations",
                column: "comid");

            migrationBuilder.CreateIndex(
                name: "ix_jobinformations_empid",
                table: "jobinformations",
                column: "empid");

            migrationBuilder.CreateIndex(
                name: "ix_line_comid",
                table: "line",
                column: "comid");

            migrationBuilder.CreateIndex(
                name: "ix_section_comid",
                table: "section",
                column: "comid");

            migrationBuilder.CreateIndex(
                name: "ix_shift_comid",
                table: "shift",
                column: "comid");

            migrationBuilder.CreateIndex(
                name: "ix_unit_comid",
                table: "unit",
                column: "comid");

            migrationBuilder.CreateIndex(
                name: "ix_workexperiences_comid",
                table: "workexperiences",
                column: "comid");

            migrationBuilder.CreateIndex(
                name: "ix_workexperiences_empid",
                table: "workexperiences",
                column: "empid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "bankinfo");

            migrationBuilder.DropTable(
                name: "contactinfo");

            migrationBuilder.DropTable(
                name: "department");

            migrationBuilder.DropTable(
                name: "designation");

            migrationBuilder.DropTable(
                name: "educations");

            migrationBuilder.DropTable(
                name: "empcertificate");

            migrationBuilder.DropTable(
                name: "employeeaddresses");

            migrationBuilder.DropTable(
                name: "employeefiles");

            migrationBuilder.DropTable(
                name: "emptaxinfos");

            migrationBuilder.DropTable(
                name: "familyinfos");

            migrationBuilder.DropTable(
                name: "floor");

            migrationBuilder.DropTable(
                name: "grade");

            migrationBuilder.DropTable(
                name: "jobinformations");

            migrationBuilder.DropTable(
                name: "line");

            migrationBuilder.DropTable(
                name: "section");

            migrationBuilder.DropTable(
                name: "shift");

            migrationBuilder.DropTable(
                name: "unit");

            migrationBuilder.DropTable(
                name: "workexperiences");

            migrationBuilder.DropTable(
                name: "employees");

            migrationBuilder.DropTable(
                name: "company");

            migrationBuilder.DropTable(
                name: "country");
        }
    }
}
