using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OGB.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "_1AStudents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__1AStudents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "_1BStudents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__1BStudents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "_1CStudents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__1CStudents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "_2AStudents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__2AStudents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "_2BStudents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__2BStudents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "_2CStudents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__2CStudents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "_3AStudents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__3AStudents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "_3BStudents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__3BStudents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "_3CStudents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__3CStudents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teacher",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YearsOfTeaching = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teacher", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "_1AGrades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BiologyAvarage = table.Column<double>(type: "float", nullable: false),
                    ChemistryAvarage = table.Column<double>(type: "float", nullable: false),
                    EnglishAvarage = table.Column<double>(type: "float", nullable: false),
                    GeographyAvarage = table.Column<double>(type: "float", nullable: false),
                    GermanAvarage = table.Column<double>(type: "float", nullable: false),
                    HistoryAvarage = table.Column<double>(type: "float", nullable: false),
                    MathAvarage = table.Column<double>(type: "float", nullable: false),
                    StudentRef = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__1AGrades", x => x.Id);
                    table.ForeignKey(
                        name: "FK__1AGrades__1AStudents_StudentRef",
                        column: x => x.StudentRef,
                        principalTable: "_1AStudents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ContactStudentInfo1A",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudentRef = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactStudentInfo1A", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContactStudentInfo1A__1AStudents_StudentRef",
                        column: x => x.StudentRef,
                        principalTable: "_1AStudents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_1BGrades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BiologyAvarage = table.Column<double>(type: "float", nullable: false),
                    ChemistryAvarage = table.Column<double>(type: "float", nullable: false),
                    EnglishAvarage = table.Column<double>(type: "float", nullable: false),
                    GeographyAvarage = table.Column<double>(type: "float", nullable: false),
                    GermanAvarage = table.Column<double>(type: "float", nullable: false),
                    HistoryAvarage = table.Column<double>(type: "float", nullable: false),
                    MathAvarage = table.Column<double>(type: "float", nullable: false),
                    StudentRef = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__1BGrades", x => x.Id);
                    table.ForeignKey(
                        name: "FK__1BGrades__1BStudents_StudentRef",
                        column: x => x.StudentRef,
                        principalTable: "_1BStudents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ContactStudentInfo1B",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudentRef = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactStudentInfo1B", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContactStudentInfo1B__1BStudents_StudentRef",
                        column: x => x.StudentRef,
                        principalTable: "_1BStudents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_1CGrades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BiologyAvarage = table.Column<double>(type: "float", nullable: false),
                    ChemistryAvarage = table.Column<double>(type: "float", nullable: false),
                    EnglishAvarage = table.Column<double>(type: "float", nullable: false),
                    GeographyAvarage = table.Column<double>(type: "float", nullable: false),
                    GermanAvarage = table.Column<double>(type: "float", nullable: false),
                    HistoryAvarage = table.Column<double>(type: "float", nullable: false),
                    MathAvarage = table.Column<double>(type: "float", nullable: false),
                    StudentRef = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__1CGrades", x => x.Id);
                    table.ForeignKey(
                        name: "FK__1CGrades__1CStudents_StudentRef",
                        column: x => x.StudentRef,
                        principalTable: "_1CStudents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ContactStudentInfo1C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudentRef = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactStudentInfo1C", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContactStudentInfo1C__1CStudents_StudentRef",
                        column: x => x.StudentRef,
                        principalTable: "_1CStudents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_2AGrades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BiologyAvarage = table.Column<double>(type: "float", nullable: false),
                    ChemistryAvarage = table.Column<double>(type: "float", nullable: false),
                    EnglishAvarage = table.Column<double>(type: "float", nullable: false),
                    GeographyAvarage = table.Column<double>(type: "float", nullable: false),
                    GermanAvarage = table.Column<double>(type: "float", nullable: false),
                    HistoryAvarage = table.Column<double>(type: "float", nullable: false),
                    MathAvarage = table.Column<double>(type: "float", nullable: false),
                    StudentRef = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__2AGrades", x => x.Id);
                    table.ForeignKey(
                        name: "FK__2AGrades__2AStudents_StudentRef",
                        column: x => x.StudentRef,
                        principalTable: "_2AStudents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ContactStudentInfo2A",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudentRef = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactStudentInfo2A", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContactStudentInfo2A__2AStudents_StudentRef",
                        column: x => x.StudentRef,
                        principalTable: "_2AStudents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_2BGrades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BiologyAvarage = table.Column<double>(type: "float", nullable: false),
                    ChemistryAvarage = table.Column<double>(type: "float", nullable: false),
                    EnglishAvarage = table.Column<double>(type: "float", nullable: false),
                    GeographyAvarage = table.Column<double>(type: "float", nullable: false),
                    GermanAvarage = table.Column<double>(type: "float", nullable: false),
                    HistoryAvarage = table.Column<double>(type: "float", nullable: false),
                    MathAvarage = table.Column<double>(type: "float", nullable: false),
                    StudentRef = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__2BGrades", x => x.Id);
                    table.ForeignKey(
                        name: "FK__2BGrades__2BStudents_StudentRef",
                        column: x => x.StudentRef,
                        principalTable: "_2BStudents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ContactStudentInfo2B",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudentRef = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactStudentInfo2B", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContactStudentInfo2B__2BStudents_StudentRef",
                        column: x => x.StudentRef,
                        principalTable: "_2BStudents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_2CGrades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BiologyAvarage = table.Column<double>(type: "float", nullable: false),
                    ChemistryAvarage = table.Column<double>(type: "float", nullable: false),
                    EnglishAvarage = table.Column<double>(type: "float", nullable: false),
                    GeographyAvarage = table.Column<double>(type: "float", nullable: false),
                    GermanAvarage = table.Column<double>(type: "float", nullable: false),
                    HistoryAvarage = table.Column<double>(type: "float", nullable: false),
                    MathAvarage = table.Column<double>(type: "float", nullable: false),
                    StudentRef = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__2CGrades", x => x.Id);
                    table.ForeignKey(
                        name: "FK__2CGrades__2CStudents_StudentRef",
                        column: x => x.StudentRef,
                        principalTable: "_2CStudents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ContactStudentInfo2C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudentRef = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactStudentInfo2C", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContactStudentInfo2C__2CStudents_StudentRef",
                        column: x => x.StudentRef,
                        principalTable: "_2CStudents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_3AGrades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BiologyAvarage = table.Column<double>(type: "float", nullable: false),
                    ChemistryAvarage = table.Column<double>(type: "float", nullable: false),
                    EnglishAvarage = table.Column<double>(type: "float", nullable: false),
                    GeographyAvarage = table.Column<double>(type: "float", nullable: false),
                    GermanAvarage = table.Column<double>(type: "float", nullable: false),
                    HistoryAvarage = table.Column<double>(type: "float", nullable: false),
                    MathAvarage = table.Column<double>(type: "float", nullable: false),
                    StudentRef = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__3AGrades", x => x.Id);
                    table.ForeignKey(
                        name: "FK__3AGrades__3AStudents_StudentRef",
                        column: x => x.StudentRef,
                        principalTable: "_3AStudents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ContactStudentInfo3A",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudentRef = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactStudentInfo3A", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContactStudentInfo3A__3AStudents_StudentRef",
                        column: x => x.StudentRef,
                        principalTable: "_3AStudents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_3BGrades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BiologyAvarage = table.Column<double>(type: "float", nullable: false),
                    ChemistryAvarage = table.Column<double>(type: "float", nullable: false),
                    EnglishAvarage = table.Column<double>(type: "float", nullable: false),
                    GeographyAvarage = table.Column<double>(type: "float", nullable: false),
                    GermanAvarage = table.Column<double>(type: "float", nullable: false),
                    HistoryAvarage = table.Column<double>(type: "float", nullable: false),
                    MathAvarage = table.Column<double>(type: "float", nullable: false),
                    StudentRef = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__3BGrades", x => x.Id);
                    table.ForeignKey(
                        name: "FK__3BGrades__3BStudents_StudentRef",
                        column: x => x.StudentRef,
                        principalTable: "_3BStudents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ContactStudentInfo3B",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudentRef = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactStudentInfo3B", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContactStudentInfo3B__3BStudents_StudentRef",
                        column: x => x.StudentRef,
                        principalTable: "_3BStudents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_3CGrades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BiologyAvarage = table.Column<double>(type: "float", nullable: false),
                    ChemistryAvarage = table.Column<double>(type: "float", nullable: false),
                    EnglishAvarage = table.Column<double>(type: "float", nullable: false),
                    GeographyAvarage = table.Column<double>(type: "float", nullable: false),
                    GermanAvarage = table.Column<double>(type: "float", nullable: false),
                    HistoryAvarage = table.Column<double>(type: "float", nullable: false),
                    MathAvarage = table.Column<double>(type: "float", nullable: false),
                    StudentRef = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__3CGrades", x => x.Id);
                    table.ForeignKey(
                        name: "FK__3CGrades__3CStudents_StudentRef",
                        column: x => x.StudentRef,
                        principalTable: "_3CStudents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ContactStudentInfo3C",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudentRef = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactStudentInfo3C", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContactStudentInfo3C__3CStudents_StudentRef",
                        column: x => x.StudentRef,
                        principalTable: "_3CStudents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TeacherAddress",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HomeNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TeacherRef = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherAddress", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TeacherAddress_Teacher_TeacherRef",
                        column: x => x.TeacherRef,
                        principalTable: "Teacher",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TeacherContactInfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TeacherRef = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherContactInfo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TeacherContactInfo_Teacher_TeacherRef",
                        column: x => x.TeacherRef,
                        principalTable: "Teacher",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_1ABiology",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestAvarage = table.Column<double>(type: "float", nullable: false),
                    ShortQuizAvarage = table.Column<double>(type: "float", nullable: false),
                    HomeworkAvarage = table.Column<double>(type: "float", nullable: false),
                    GradesRef = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__1ABiology", x => x.Id);
                    table.ForeignKey(
                        name: "FK__1ABiology__1AGrades_GradesRef",
                        column: x => x.GradesRef,
                        principalTable: "_1AGrades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_1AChemistry",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestAvarage = table.Column<double>(type: "float", nullable: false),
                    ShortQuizAvarage = table.Column<double>(type: "float", nullable: false),
                    HomeworkAvarage = table.Column<double>(type: "float", nullable: false),
                    GradesRef = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__1AChemistry", x => x.Id);
                    table.ForeignKey(
                        name: "FK__1AChemistry__1AGrades_GradesRef",
                        column: x => x.GradesRef,
                        principalTable: "_1AGrades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_1AEnglish",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestAvarage = table.Column<double>(type: "float", nullable: false),
                    ShortQuizAvarage = table.Column<double>(type: "float", nullable: false),
                    HomeworkAvarage = table.Column<double>(type: "float", nullable: false),
                    GradesRef = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__1AEnglish", x => x.Id);
                    table.ForeignKey(
                        name: "FK__1AEnglish__1AGrades_GradesRef",
                        column: x => x.GradesRef,
                        principalTable: "_1AGrades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_1AGeography",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestAvarage = table.Column<double>(type: "float", nullable: false),
                    ShortQuizAvarage = table.Column<double>(type: "float", nullable: false),
                    HomeworkAvarage = table.Column<double>(type: "float", nullable: false),
                    GradesRef = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__1AGeography", x => x.Id);
                    table.ForeignKey(
                        name: "FK__1AGeography__1AGrades_GradesRef",
                        column: x => x.GradesRef,
                        principalTable: "_1AGrades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_1AGerman",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestAvarage = table.Column<double>(type: "float", nullable: false),
                    ShortQuizAvarage = table.Column<double>(type: "float", nullable: false),
                    HomeworkAvarage = table.Column<double>(type: "float", nullable: false),
                    GradesRef = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__1AGerman", x => x.Id);
                    table.ForeignKey(
                        name: "FK__1AGerman__1AGrades_GradesRef",
                        column: x => x.GradesRef,
                        principalTable: "_1AGrades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_1AHistory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestAvarage = table.Column<double>(type: "float", nullable: false),
                    ShortQuizAvarage = table.Column<double>(type: "float", nullable: false),
                    HomeworkAvarage = table.Column<double>(type: "float", nullable: false),
                    GradesRef = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__1AHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK__1AHistory__1AGrades_GradesRef",
                        column: x => x.GradesRef,
                        principalTable: "_1AGrades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_1AMath",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestAvarage = table.Column<double>(type: "float", nullable: false),
                    ShortQuizAvarage = table.Column<double>(type: "float", nullable: false),
                    HomeworkAvarage = table.Column<double>(type: "float", nullable: false),
                    GradesRef = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__1AMath", x => x.Id);
                    table.ForeignKey(
                        name: "FK__1AMath__1AGrades_GradesRef",
                        column: x => x.GradesRef,
                        principalTable: "_1AGrades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_1BBiology",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestAvarage = table.Column<double>(type: "float", nullable: false),
                    ShortQuizAvarage = table.Column<double>(type: "float", nullable: false),
                    HomeworkAvarage = table.Column<double>(type: "float", nullable: false),
                    GradesRef = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__1BBiology", x => x.Id);
                    table.ForeignKey(
                        name: "FK__1BBiology__1BGrades_GradesRef",
                        column: x => x.GradesRef,
                        principalTable: "_1BGrades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_1BChemistry",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestAvarage = table.Column<double>(type: "float", nullable: false),
                    ShortQuizAvarage = table.Column<double>(type: "float", nullable: false),
                    HomeworkAvarage = table.Column<double>(type: "float", nullable: false),
                    GradesRef = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__1BChemistry", x => x.Id);
                    table.ForeignKey(
                        name: "FK__1BChemistry__1BGrades_GradesRef",
                        column: x => x.GradesRef,
                        principalTable: "_1BGrades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_1BEnglish",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestAvarage = table.Column<double>(type: "float", nullable: false),
                    ShortQuizAvarage = table.Column<double>(type: "float", nullable: false),
                    HomeworkAvarage = table.Column<double>(type: "float", nullable: false),
                    GradesRef = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__1BEnglish", x => x.Id);
                    table.ForeignKey(
                        name: "FK__1BEnglish__1BGrades_GradesRef",
                        column: x => x.GradesRef,
                        principalTable: "_1BGrades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_1BGeography",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestAvarage = table.Column<double>(type: "float", nullable: false),
                    ShortQuizAvarage = table.Column<double>(type: "float", nullable: false),
                    HomeworkAvarage = table.Column<double>(type: "float", nullable: false),
                    GradesRef = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__1BGeography", x => x.Id);
                    table.ForeignKey(
                        name: "FK__1BGeography__1BGrades_GradesRef",
                        column: x => x.GradesRef,
                        principalTable: "_1BGrades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_1BGerman",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestAvarage = table.Column<double>(type: "float", nullable: false),
                    ShortQuizAvarage = table.Column<double>(type: "float", nullable: false),
                    HomeworkAvarage = table.Column<double>(type: "float", nullable: false),
                    GradesRef = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__1BGerman", x => x.Id);
                    table.ForeignKey(
                        name: "FK__1BGerman__1BGrades_GradesRef",
                        column: x => x.GradesRef,
                        principalTable: "_1BGrades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_1BHistory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestAvarage = table.Column<double>(type: "float", nullable: false),
                    ShortQuizAvarage = table.Column<double>(type: "float", nullable: false),
                    HomeworkAvarage = table.Column<double>(type: "float", nullable: false),
                    GradesRef = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__1BHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK__1BHistory__1BGrades_GradesRef",
                        column: x => x.GradesRef,
                        principalTable: "_1BGrades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_1BMath",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestAvarage = table.Column<double>(type: "float", nullable: false),
                    ShortQuizAvarage = table.Column<double>(type: "float", nullable: false),
                    HomeworkAvarage = table.Column<double>(type: "float", nullable: false),
                    GradesRef = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__1BMath", x => x.Id);
                    table.ForeignKey(
                        name: "FK__1BMath__1BGrades_GradesRef",
                        column: x => x.GradesRef,
                        principalTable: "_1BGrades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_1CBiology",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestAvarage = table.Column<double>(type: "float", nullable: false),
                    ShortQuizAvarage = table.Column<double>(type: "float", nullable: false),
                    HomeworkAvarage = table.Column<double>(type: "float", nullable: false),
                    GradesRef = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__1CBiology", x => x.Id);
                    table.ForeignKey(
                        name: "FK__1CBiology__1CGrades_GradesRef",
                        column: x => x.GradesRef,
                        principalTable: "_1CGrades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_1CChemistry",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestAvarage = table.Column<double>(type: "float", nullable: false),
                    ShortQuizAvarage = table.Column<double>(type: "float", nullable: false),
                    HomeworkAvarage = table.Column<double>(type: "float", nullable: false),
                    GradesRef = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__1CChemistry", x => x.Id);
                    table.ForeignKey(
                        name: "FK__1CChemistry__1CGrades_GradesRef",
                        column: x => x.GradesRef,
                        principalTable: "_1CGrades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_1CEnglish",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestAvarage = table.Column<double>(type: "float", nullable: false),
                    ShortQuizAvarage = table.Column<double>(type: "float", nullable: false),
                    HomeworkAvarage = table.Column<double>(type: "float", nullable: false),
                    GradesRef = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__1CEnglish", x => x.Id);
                    table.ForeignKey(
                        name: "FK__1CEnglish__1CGrades_GradesRef",
                        column: x => x.GradesRef,
                        principalTable: "_1CGrades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_1CGeography",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestAvarage = table.Column<double>(type: "float", nullable: false),
                    ShortQuizAvarage = table.Column<double>(type: "float", nullable: false),
                    HomeworkAvarage = table.Column<double>(type: "float", nullable: false),
                    GradesRef = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__1CGeography", x => x.Id);
                    table.ForeignKey(
                        name: "FK__1CGeography__1CGrades_GradesRef",
                        column: x => x.GradesRef,
                        principalTable: "_1CGrades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_1CGerman",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestAvarage = table.Column<double>(type: "float", nullable: false),
                    ShortQuizAvarage = table.Column<double>(type: "float", nullable: false),
                    HomeworkAvarage = table.Column<double>(type: "float", nullable: false),
                    GradesRef = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__1CGerman", x => x.Id);
                    table.ForeignKey(
                        name: "FK__1CGerman__1CGrades_GradesRef",
                        column: x => x.GradesRef,
                        principalTable: "_1CGrades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_1CHistory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestAvarage = table.Column<double>(type: "float", nullable: false),
                    ShortQuizAvarage = table.Column<double>(type: "float", nullable: false),
                    HomeworkAvarage = table.Column<double>(type: "float", nullable: false),
                    GradesRef = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__1CHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK__1CHistory__1CGrades_GradesRef",
                        column: x => x.GradesRef,
                        principalTable: "_1CGrades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_1CMath",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestAvarage = table.Column<double>(type: "float", nullable: false),
                    ShortQuizAvarage = table.Column<double>(type: "float", nullable: false),
                    HomeworkAvarage = table.Column<double>(type: "float", nullable: false),
                    GradesRef = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__1CMath", x => x.Id);
                    table.ForeignKey(
                        name: "FK__1CMath__1CGrades_GradesRef",
                        column: x => x.GradesRef,
                        principalTable: "_1CGrades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_2ABiology",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestAvarage = table.Column<double>(type: "float", nullable: false),
                    ShortQuizAvarage = table.Column<double>(type: "float", nullable: false),
                    HomeworkAvarage = table.Column<double>(type: "float", nullable: false),
                    GradesRef = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__2ABiology", x => x.Id);
                    table.ForeignKey(
                        name: "FK__2ABiology__2AGrades_GradesRef",
                        column: x => x.GradesRef,
                        principalTable: "_2AGrades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_2AChemistry",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestAvarage = table.Column<double>(type: "float", nullable: false),
                    ShortQuizAvarage = table.Column<double>(type: "float", nullable: false),
                    HomeworkAvarage = table.Column<double>(type: "float", nullable: false),
                    GradesRef = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__2AChemistry", x => x.Id);
                    table.ForeignKey(
                        name: "FK__2AChemistry__2AGrades_GradesRef",
                        column: x => x.GradesRef,
                        principalTable: "_2AGrades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_2AEnglish",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestAvarage = table.Column<double>(type: "float", nullable: false),
                    ShortQuizAvarage = table.Column<double>(type: "float", nullable: false),
                    HomeworkAvarage = table.Column<double>(type: "float", nullable: false),
                    GradesRef = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__2AEnglish", x => x.Id);
                    table.ForeignKey(
                        name: "FK__2AEnglish__2AGrades_GradesRef",
                        column: x => x.GradesRef,
                        principalTable: "_2AGrades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_2AGeography",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestAvarage = table.Column<double>(type: "float", nullable: false),
                    ShortQuizAvarage = table.Column<double>(type: "float", nullable: false),
                    HomeworkAvarage = table.Column<double>(type: "float", nullable: false),
                    GradesRef = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__2AGeography", x => x.Id);
                    table.ForeignKey(
                        name: "FK__2AGeography__2AGrades_GradesRef",
                        column: x => x.GradesRef,
                        principalTable: "_2AGrades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_2AGerman",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestAvarage = table.Column<double>(type: "float", nullable: false),
                    ShortQuizAvarage = table.Column<double>(type: "float", nullable: false),
                    HomeworkAvarage = table.Column<double>(type: "float", nullable: false),
                    GradesRef = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__2AGerman", x => x.Id);
                    table.ForeignKey(
                        name: "FK__2AGerman__2AGrades_GradesRef",
                        column: x => x.GradesRef,
                        principalTable: "_2AGrades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_2AHistory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestAvarage = table.Column<double>(type: "float", nullable: false),
                    ShortQuizAvarage = table.Column<double>(type: "float", nullable: false),
                    HomeworkAvarage = table.Column<double>(type: "float", nullable: false),
                    GradesRef = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__2AHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK__2AHistory__2AGrades_GradesRef",
                        column: x => x.GradesRef,
                        principalTable: "_2AGrades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_2AMath",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestAvarage = table.Column<double>(type: "float", nullable: false),
                    ShortQuizAvarage = table.Column<double>(type: "float", nullable: false),
                    HomeworkAvarage = table.Column<double>(type: "float", nullable: false),
                    GradesRef = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__2AMath", x => x.Id);
                    table.ForeignKey(
                        name: "FK__2AMath__2AGrades_GradesRef",
                        column: x => x.GradesRef,
                        principalTable: "_2AGrades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_2BBiology",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestAvarage = table.Column<double>(type: "float", nullable: false),
                    ShortQuizAvarage = table.Column<double>(type: "float", nullable: false),
                    HomeworkAvarage = table.Column<double>(type: "float", nullable: false),
                    GradesRef = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__2BBiology", x => x.Id);
                    table.ForeignKey(
                        name: "FK__2BBiology__2BGrades_GradesRef",
                        column: x => x.GradesRef,
                        principalTable: "_2BGrades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_2BChemistry",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestAvarage = table.Column<double>(type: "float", nullable: false),
                    ShortQuizAvarage = table.Column<double>(type: "float", nullable: false),
                    HomeworkAvarage = table.Column<double>(type: "float", nullable: false),
                    GradesRef = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__2BChemistry", x => x.Id);
                    table.ForeignKey(
                        name: "FK__2BChemistry__2BGrades_GradesRef",
                        column: x => x.GradesRef,
                        principalTable: "_2BGrades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_2BEnglish",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestAvarage = table.Column<double>(type: "float", nullable: false),
                    ShortQuizAvarage = table.Column<double>(type: "float", nullable: false),
                    HomeworkAvarage = table.Column<double>(type: "float", nullable: false),
                    GradesRef = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__2BEnglish", x => x.Id);
                    table.ForeignKey(
                        name: "FK__2BEnglish__2BGrades_GradesRef",
                        column: x => x.GradesRef,
                        principalTable: "_2BGrades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_2BGeography",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestAvarage = table.Column<double>(type: "float", nullable: false),
                    ShortQuizAvarage = table.Column<double>(type: "float", nullable: false),
                    HomeworkAvarage = table.Column<double>(type: "float", nullable: false),
                    GradesRef = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__2BGeography", x => x.Id);
                    table.ForeignKey(
                        name: "FK__2BGeography__2BGrades_GradesRef",
                        column: x => x.GradesRef,
                        principalTable: "_2BGrades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_2BGerman",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestAvarage = table.Column<double>(type: "float", nullable: false),
                    ShortQuizAvarage = table.Column<double>(type: "float", nullable: false),
                    HomeworkAvarage = table.Column<double>(type: "float", nullable: false),
                    GradesRef = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__2BGerman", x => x.Id);
                    table.ForeignKey(
                        name: "FK__2BGerman__2BGrades_GradesRef",
                        column: x => x.GradesRef,
                        principalTable: "_2BGrades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_2BHistory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestAvarage = table.Column<double>(type: "float", nullable: false),
                    ShortQuizAvarage = table.Column<double>(type: "float", nullable: false),
                    HomeworkAvarage = table.Column<double>(type: "float", nullable: false),
                    GradesRef = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__2BHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK__2BHistory__2BGrades_GradesRef",
                        column: x => x.GradesRef,
                        principalTable: "_2BGrades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_2BMath",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestAvarage = table.Column<double>(type: "float", nullable: false),
                    ShortQuizAvarage = table.Column<double>(type: "float", nullable: false),
                    HomeworkAvarage = table.Column<double>(type: "float", nullable: false),
                    GradesRef = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__2BMath", x => x.Id);
                    table.ForeignKey(
                        name: "FK__2BMath__2BGrades_GradesRef",
                        column: x => x.GradesRef,
                        principalTable: "_2BGrades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_2CBiology",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestAvarage = table.Column<double>(type: "float", nullable: false),
                    ShortQuizAvarage = table.Column<double>(type: "float", nullable: false),
                    HomeworkAvarage = table.Column<double>(type: "float", nullable: false),
                    GradesRef = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__2CBiology", x => x.Id);
                    table.ForeignKey(
                        name: "FK__2CBiology__2CGrades_GradesRef",
                        column: x => x.GradesRef,
                        principalTable: "_2CGrades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_2CChemistry",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestAvarage = table.Column<double>(type: "float", nullable: false),
                    ShortQuizAvarage = table.Column<double>(type: "float", nullable: false),
                    HomeworkAvarage = table.Column<double>(type: "float", nullable: false),
                    GradesRef = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__2CChemistry", x => x.Id);
                    table.ForeignKey(
                        name: "FK__2CChemistry__2CGrades_GradesRef",
                        column: x => x.GradesRef,
                        principalTable: "_2CGrades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_2CEnglish",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestAvarage = table.Column<double>(type: "float", nullable: false),
                    ShortQuizAvarage = table.Column<double>(type: "float", nullable: false),
                    HomeworkAvarage = table.Column<double>(type: "float", nullable: false),
                    GradesRef = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__2CEnglish", x => x.Id);
                    table.ForeignKey(
                        name: "FK__2CEnglish__2CGrades_GradesRef",
                        column: x => x.GradesRef,
                        principalTable: "_2CGrades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_2CGeography",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestAvarage = table.Column<double>(type: "float", nullable: false),
                    ShortQuizAvarage = table.Column<double>(type: "float", nullable: false),
                    HomeworkAvarage = table.Column<double>(type: "float", nullable: false),
                    GradesRef = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__2CGeography", x => x.Id);
                    table.ForeignKey(
                        name: "FK__2CGeography__2CGrades_GradesRef",
                        column: x => x.GradesRef,
                        principalTable: "_2CGrades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_2CGerman",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestAvarage = table.Column<double>(type: "float", nullable: false),
                    ShortQuizAvarage = table.Column<double>(type: "float", nullable: false),
                    HomeworkAvarage = table.Column<double>(type: "float", nullable: false),
                    GradesRef = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__2CGerman", x => x.Id);
                    table.ForeignKey(
                        name: "FK__2CGerman__2CGrades_GradesRef",
                        column: x => x.GradesRef,
                        principalTable: "_2CGrades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_2CHistory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestAvarage = table.Column<double>(type: "float", nullable: false),
                    ShortQuizAvarage = table.Column<double>(type: "float", nullable: false),
                    HomeworkAvarage = table.Column<double>(type: "float", nullable: false),
                    GradesRef = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__2CHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK__2CHistory__2CGrades_GradesRef",
                        column: x => x.GradesRef,
                        principalTable: "_2CGrades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_2CMath",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestAvarage = table.Column<double>(type: "float", nullable: false),
                    ShortQuizAvarage = table.Column<double>(type: "float", nullable: false),
                    HomeworkAvarage = table.Column<double>(type: "float", nullable: false),
                    GradesRef = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__2CMath", x => x.Id);
                    table.ForeignKey(
                        name: "FK__2CMath__2CGrades_GradesRef",
                        column: x => x.GradesRef,
                        principalTable: "_2CGrades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_3ABiology",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestAvarage = table.Column<double>(type: "float", nullable: false),
                    ShortQuizAvarage = table.Column<double>(type: "float", nullable: false),
                    HomeworkAvarage = table.Column<double>(type: "float", nullable: false),
                    GradesRef = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__3ABiology", x => x.Id);
                    table.ForeignKey(
                        name: "FK__3ABiology__3AGrades_GradesRef",
                        column: x => x.GradesRef,
                        principalTable: "_3AGrades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_3AChemistry",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestAvarage = table.Column<double>(type: "float", nullable: false),
                    ShortQuizAvarage = table.Column<double>(type: "float", nullable: false),
                    HomeworkAvarage = table.Column<double>(type: "float", nullable: false),
                    GradesRef = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__3AChemistry", x => x.Id);
                    table.ForeignKey(
                        name: "FK__3AChemistry__3AGrades_GradesRef",
                        column: x => x.GradesRef,
                        principalTable: "_3AGrades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_3AEnglish",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestAvarage = table.Column<double>(type: "float", nullable: false),
                    ShortQuizAvarage = table.Column<double>(type: "float", nullable: false),
                    HomeworkAvarage = table.Column<double>(type: "float", nullable: false),
                    GradesRef = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__3AEnglish", x => x.Id);
                    table.ForeignKey(
                        name: "FK__3AEnglish__3AGrades_GradesRef",
                        column: x => x.GradesRef,
                        principalTable: "_3AGrades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_3AGeography",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestAvarage = table.Column<double>(type: "float", nullable: false),
                    ShortQuizAvarage = table.Column<double>(type: "float", nullable: false),
                    HomeworkAvarage = table.Column<double>(type: "float", nullable: false),
                    GradesRef = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__3AGeography", x => x.Id);
                    table.ForeignKey(
                        name: "FK__3AGeography__3AGrades_GradesRef",
                        column: x => x.GradesRef,
                        principalTable: "_3AGrades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_3AGerman",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestAvarage = table.Column<double>(type: "float", nullable: false),
                    ShortQuizAvarage = table.Column<double>(type: "float", nullable: false),
                    HomeworkAvarage = table.Column<double>(type: "float", nullable: false),
                    GradesRef = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__3AGerman", x => x.Id);
                    table.ForeignKey(
                        name: "FK__3AGerman__3AGrades_GradesRef",
                        column: x => x.GradesRef,
                        principalTable: "_3AGrades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_3AHistory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestAvarage = table.Column<double>(type: "float", nullable: false),
                    ShortQuizAvarage = table.Column<double>(type: "float", nullable: false),
                    HomeworkAvarage = table.Column<double>(type: "float", nullable: false),
                    GradesRef = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__3AHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK__3AHistory__3AGrades_GradesRef",
                        column: x => x.GradesRef,
                        principalTable: "_3AGrades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_3AMath",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestAvarage = table.Column<double>(type: "float", nullable: false),
                    ShortQuizAvarage = table.Column<double>(type: "float", nullable: false),
                    HomeworkAvarage = table.Column<double>(type: "float", nullable: false),
                    GradesRef = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__3AMath", x => x.Id);
                    table.ForeignKey(
                        name: "FK__3AMath__3AGrades_GradesRef",
                        column: x => x.GradesRef,
                        principalTable: "_3AGrades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_3BBiology",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestAvarage = table.Column<double>(type: "float", nullable: false),
                    ShortQuizAvarage = table.Column<double>(type: "float", nullable: false),
                    HomeworkAvarage = table.Column<double>(type: "float", nullable: false),
                    GradesRef = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__3BBiology", x => x.Id);
                    table.ForeignKey(
                        name: "FK__3BBiology__3BGrades_GradesRef",
                        column: x => x.GradesRef,
                        principalTable: "_3BGrades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_3BChemistry",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestAvarage = table.Column<double>(type: "float", nullable: false),
                    ShortQuizAvarage = table.Column<double>(type: "float", nullable: false),
                    HomeworkAvarage = table.Column<double>(type: "float", nullable: false),
                    GradesRef = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__3BChemistry", x => x.Id);
                    table.ForeignKey(
                        name: "FK__3BChemistry__3BGrades_GradesRef",
                        column: x => x.GradesRef,
                        principalTable: "_3BGrades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_3BEnglish",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestAvarage = table.Column<double>(type: "float", nullable: false),
                    ShortQuizAvarage = table.Column<double>(type: "float", nullable: false),
                    HomeworkAvarage = table.Column<double>(type: "float", nullable: false),
                    GradesRef = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__3BEnglish", x => x.Id);
                    table.ForeignKey(
                        name: "FK__3BEnglish__3BGrades_GradesRef",
                        column: x => x.GradesRef,
                        principalTable: "_3BGrades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_3BGeography",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestAvarage = table.Column<double>(type: "float", nullable: false),
                    ShortQuizAvarage = table.Column<double>(type: "float", nullable: false),
                    HomeworkAvarage = table.Column<double>(type: "float", nullable: false),
                    GradesRef = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__3BGeography", x => x.Id);
                    table.ForeignKey(
                        name: "FK__3BGeography__3BGrades_GradesRef",
                        column: x => x.GradesRef,
                        principalTable: "_3BGrades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_3BGerman",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestAvarage = table.Column<double>(type: "float", nullable: false),
                    ShortQuizAvarage = table.Column<double>(type: "float", nullable: false),
                    HomeworkAvarage = table.Column<double>(type: "float", nullable: false),
                    GradesRef = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__3BGerman", x => x.Id);
                    table.ForeignKey(
                        name: "FK__3BGerman__3BGrades_GradesRef",
                        column: x => x.GradesRef,
                        principalTable: "_3BGrades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_3BHistory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestAvarage = table.Column<double>(type: "float", nullable: false),
                    ShortQuizAvarage = table.Column<double>(type: "float", nullable: false),
                    HomeworkAvarage = table.Column<double>(type: "float", nullable: false),
                    GradesRef = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__3BHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK__3BHistory__3BGrades_GradesRef",
                        column: x => x.GradesRef,
                        principalTable: "_3BGrades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_3BMath",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestAvarage = table.Column<double>(type: "float", nullable: false),
                    ShortQuizAvarage = table.Column<double>(type: "float", nullable: false),
                    HomeworkAvarage = table.Column<double>(type: "float", nullable: false),
                    GradesRef = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__3BMath", x => x.Id);
                    table.ForeignKey(
                        name: "FK__3BMath__3BGrades_GradesRef",
                        column: x => x.GradesRef,
                        principalTable: "_3BGrades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_3CBiology",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestAvarage = table.Column<double>(type: "float", nullable: false),
                    ShortQuizAvarage = table.Column<double>(type: "float", nullable: false),
                    HomeworkAvarage = table.Column<double>(type: "float", nullable: false),
                    GradesRef = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__3CBiology", x => x.Id);
                    table.ForeignKey(
                        name: "FK__3CBiology__3CGrades_GradesRef",
                        column: x => x.GradesRef,
                        principalTable: "_3CGrades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_3CChemistry",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestAvarage = table.Column<double>(type: "float", nullable: false),
                    ShortQuizAvarage = table.Column<double>(type: "float", nullable: false),
                    HomeworkAvarage = table.Column<double>(type: "float", nullable: false),
                    GradesRef = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__3CChemistry", x => x.Id);
                    table.ForeignKey(
                        name: "FK__3CChemistry__3CGrades_GradesRef",
                        column: x => x.GradesRef,
                        principalTable: "_3CGrades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_3CEnglish",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestAvarage = table.Column<double>(type: "float", nullable: false),
                    ShortQuizAvarage = table.Column<double>(type: "float", nullable: false),
                    HomeworkAvarage = table.Column<double>(type: "float", nullable: false),
                    GradesRef = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__3CEnglish", x => x.Id);
                    table.ForeignKey(
                        name: "FK__3CEnglish__3CGrades_GradesRef",
                        column: x => x.GradesRef,
                        principalTable: "_3CGrades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_3CGeography",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestAvarage = table.Column<double>(type: "float", nullable: false),
                    ShortQuizAvarage = table.Column<double>(type: "float", nullable: false),
                    HomeworkAvarage = table.Column<double>(type: "float", nullable: false),
                    GradesRef = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__3CGeography", x => x.Id);
                    table.ForeignKey(
                        name: "FK__3CGeography__3CGrades_GradesRef",
                        column: x => x.GradesRef,
                        principalTable: "_3CGrades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_3CGerman",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestAvarage = table.Column<double>(type: "float", nullable: false),
                    ShortQuizAvarage = table.Column<double>(type: "float", nullable: false),
                    HomeworkAvarage = table.Column<double>(type: "float", nullable: false),
                    GradesRef = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__3CGerman", x => x.Id);
                    table.ForeignKey(
                        name: "FK__3CGerman__3CGrades_GradesRef",
                        column: x => x.GradesRef,
                        principalTable: "_3CGrades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_3CHistory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestAvarage = table.Column<double>(type: "float", nullable: false),
                    ShortQuizAvarage = table.Column<double>(type: "float", nullable: false),
                    HomeworkAvarage = table.Column<double>(type: "float", nullable: false),
                    GradesRef = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__3CHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK__3CHistory__3CGrades_GradesRef",
                        column: x => x.GradesRef,
                        principalTable: "_3CGrades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_3CMath",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestAvarage = table.Column<double>(type: "float", nullable: false),
                    ShortQuizAvarage = table.Column<double>(type: "float", nullable: false),
                    HomeworkAvarage = table.Column<double>(type: "float", nullable: false),
                    GradesRef = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__3CMath", x => x.Id);
                    table.ForeignKey(
                        name: "FK__3CMath__3CGrades_GradesRef",
                        column: x => x.GradesRef,
                        principalTable: "_3CGrades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX__1ABiology_GradesRef",
                table: "_1ABiology",
                column: "GradesRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX__1AChemistry_GradesRef",
                table: "_1AChemistry",
                column: "GradesRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX__1AEnglish_GradesRef",
                table: "_1AEnglish",
                column: "GradesRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX__1AGeography_GradesRef",
                table: "_1AGeography",
                column: "GradesRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX__1AGerman_GradesRef",
                table: "_1AGerman",
                column: "GradesRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX__1AGrades_StudentRef",
                table: "_1AGrades",
                column: "StudentRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX__1AHistory_GradesRef",
                table: "_1AHistory",
                column: "GradesRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX__1AMath_GradesRef",
                table: "_1AMath",
                column: "GradesRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX__1BBiology_GradesRef",
                table: "_1BBiology",
                column: "GradesRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX__1BChemistry_GradesRef",
                table: "_1BChemistry",
                column: "GradesRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX__1BEnglish_GradesRef",
                table: "_1BEnglish",
                column: "GradesRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX__1BGeography_GradesRef",
                table: "_1BGeography",
                column: "GradesRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX__1BGerman_GradesRef",
                table: "_1BGerman",
                column: "GradesRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX__1BGrades_StudentRef",
                table: "_1BGrades",
                column: "StudentRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX__1BHistory_GradesRef",
                table: "_1BHistory",
                column: "GradesRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX__1BMath_GradesRef",
                table: "_1BMath",
                column: "GradesRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX__1CBiology_GradesRef",
                table: "_1CBiology",
                column: "GradesRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX__1CChemistry_GradesRef",
                table: "_1CChemistry",
                column: "GradesRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX__1CEnglish_GradesRef",
                table: "_1CEnglish",
                column: "GradesRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX__1CGeography_GradesRef",
                table: "_1CGeography",
                column: "GradesRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX__1CGerman_GradesRef",
                table: "_1CGerman",
                column: "GradesRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX__1CGrades_StudentRef",
                table: "_1CGrades",
                column: "StudentRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX__1CHistory_GradesRef",
                table: "_1CHistory",
                column: "GradesRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX__1CMath_GradesRef",
                table: "_1CMath",
                column: "GradesRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX__2ABiology_GradesRef",
                table: "_2ABiology",
                column: "GradesRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX__2AChemistry_GradesRef",
                table: "_2AChemistry",
                column: "GradesRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX__2AEnglish_GradesRef",
                table: "_2AEnglish",
                column: "GradesRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX__2AGeography_GradesRef",
                table: "_2AGeography",
                column: "GradesRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX__2AGerman_GradesRef",
                table: "_2AGerman",
                column: "GradesRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX__2AGrades_StudentRef",
                table: "_2AGrades",
                column: "StudentRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX__2AHistory_GradesRef",
                table: "_2AHistory",
                column: "GradesRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX__2AMath_GradesRef",
                table: "_2AMath",
                column: "GradesRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX__2BBiology_GradesRef",
                table: "_2BBiology",
                column: "GradesRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX__2BChemistry_GradesRef",
                table: "_2BChemistry",
                column: "GradesRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX__2BEnglish_GradesRef",
                table: "_2BEnglish",
                column: "GradesRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX__2BGeography_GradesRef",
                table: "_2BGeography",
                column: "GradesRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX__2BGerman_GradesRef",
                table: "_2BGerman",
                column: "GradesRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX__2BGrades_StudentRef",
                table: "_2BGrades",
                column: "StudentRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX__2BHistory_GradesRef",
                table: "_2BHistory",
                column: "GradesRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX__2BMath_GradesRef",
                table: "_2BMath",
                column: "GradesRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX__2CBiology_GradesRef",
                table: "_2CBiology",
                column: "GradesRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX__2CChemistry_GradesRef",
                table: "_2CChemistry",
                column: "GradesRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX__2CEnglish_GradesRef",
                table: "_2CEnglish",
                column: "GradesRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX__2CGeography_GradesRef",
                table: "_2CGeography",
                column: "GradesRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX__2CGerman_GradesRef",
                table: "_2CGerman",
                column: "GradesRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX__2CGrades_StudentRef",
                table: "_2CGrades",
                column: "StudentRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX__2CHistory_GradesRef",
                table: "_2CHistory",
                column: "GradesRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX__2CMath_GradesRef",
                table: "_2CMath",
                column: "GradesRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX__3ABiology_GradesRef",
                table: "_3ABiology",
                column: "GradesRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX__3AChemistry_GradesRef",
                table: "_3AChemistry",
                column: "GradesRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX__3AEnglish_GradesRef",
                table: "_3AEnglish",
                column: "GradesRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX__3AGeography_GradesRef",
                table: "_3AGeography",
                column: "GradesRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX__3AGerman_GradesRef",
                table: "_3AGerman",
                column: "GradesRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX__3AGrades_StudentRef",
                table: "_3AGrades",
                column: "StudentRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX__3AHistory_GradesRef",
                table: "_3AHistory",
                column: "GradesRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX__3AMath_GradesRef",
                table: "_3AMath",
                column: "GradesRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX__3BBiology_GradesRef",
                table: "_3BBiology",
                column: "GradesRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX__3BChemistry_GradesRef",
                table: "_3BChemistry",
                column: "GradesRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX__3BEnglish_GradesRef",
                table: "_3BEnglish",
                column: "GradesRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX__3BGeography_GradesRef",
                table: "_3BGeography",
                column: "GradesRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX__3BGerman_GradesRef",
                table: "_3BGerman",
                column: "GradesRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX__3BGrades_StudentRef",
                table: "_3BGrades",
                column: "StudentRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX__3BHistory_GradesRef",
                table: "_3BHistory",
                column: "GradesRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX__3BMath_GradesRef",
                table: "_3BMath",
                column: "GradesRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX__3CBiology_GradesRef",
                table: "_3CBiology",
                column: "GradesRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX__3CChemistry_GradesRef",
                table: "_3CChemistry",
                column: "GradesRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX__3CEnglish_GradesRef",
                table: "_3CEnglish",
                column: "GradesRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX__3CGeography_GradesRef",
                table: "_3CGeography",
                column: "GradesRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX__3CGerman_GradesRef",
                table: "_3CGerman",
                column: "GradesRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX__3CGrades_StudentRef",
                table: "_3CGrades",
                column: "StudentRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX__3CHistory_GradesRef",
                table: "_3CHistory",
                column: "GradesRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX__3CMath_GradesRef",
                table: "_3CMath",
                column: "GradesRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ContactStudentInfo1A_StudentRef",
                table: "ContactStudentInfo1A",
                column: "StudentRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ContactStudentInfo1B_StudentRef",
                table: "ContactStudentInfo1B",
                column: "StudentRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ContactStudentInfo1C_StudentRef",
                table: "ContactStudentInfo1C",
                column: "StudentRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ContactStudentInfo2A_StudentRef",
                table: "ContactStudentInfo2A",
                column: "StudentRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ContactStudentInfo2B_StudentRef",
                table: "ContactStudentInfo2B",
                column: "StudentRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ContactStudentInfo2C_StudentRef",
                table: "ContactStudentInfo2C",
                column: "StudentRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ContactStudentInfo3A_StudentRef",
                table: "ContactStudentInfo3A",
                column: "StudentRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ContactStudentInfo3B_StudentRef",
                table: "ContactStudentInfo3B",
                column: "StudentRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ContactStudentInfo3C_StudentRef",
                table: "ContactStudentInfo3C",
                column: "StudentRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TeacherAddress_TeacherRef",
                table: "TeacherAddress",
                column: "TeacherRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TeacherContactInfo_TeacherRef",
                table: "TeacherContactInfo",
                column: "TeacherRef",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "_1ABiology");

            migrationBuilder.DropTable(
                name: "_1AChemistry");

            migrationBuilder.DropTable(
                name: "_1AEnglish");

            migrationBuilder.DropTable(
                name: "_1AGeography");

            migrationBuilder.DropTable(
                name: "_1AGerman");

            migrationBuilder.DropTable(
                name: "_1AHistory");

            migrationBuilder.DropTable(
                name: "_1AMath");

            migrationBuilder.DropTable(
                name: "_1BBiology");

            migrationBuilder.DropTable(
                name: "_1BChemistry");

            migrationBuilder.DropTable(
                name: "_1BEnglish");

            migrationBuilder.DropTable(
                name: "_1BGeography");

            migrationBuilder.DropTable(
                name: "_1BGerman");

            migrationBuilder.DropTable(
                name: "_1BHistory");

            migrationBuilder.DropTable(
                name: "_1BMath");

            migrationBuilder.DropTable(
                name: "_1CBiology");

            migrationBuilder.DropTable(
                name: "_1CChemistry");

            migrationBuilder.DropTable(
                name: "_1CEnglish");

            migrationBuilder.DropTable(
                name: "_1CGeography");

            migrationBuilder.DropTable(
                name: "_1CGerman");

            migrationBuilder.DropTable(
                name: "_1CHistory");

            migrationBuilder.DropTable(
                name: "_1CMath");

            migrationBuilder.DropTable(
                name: "_2ABiology");

            migrationBuilder.DropTable(
                name: "_2AChemistry");

            migrationBuilder.DropTable(
                name: "_2AEnglish");

            migrationBuilder.DropTable(
                name: "_2AGeography");

            migrationBuilder.DropTable(
                name: "_2AGerman");

            migrationBuilder.DropTable(
                name: "_2AHistory");

            migrationBuilder.DropTable(
                name: "_2AMath");

            migrationBuilder.DropTable(
                name: "_2BBiology");

            migrationBuilder.DropTable(
                name: "_2BChemistry");

            migrationBuilder.DropTable(
                name: "_2BEnglish");

            migrationBuilder.DropTable(
                name: "_2BGeography");

            migrationBuilder.DropTable(
                name: "_2BGerman");

            migrationBuilder.DropTable(
                name: "_2BHistory");

            migrationBuilder.DropTable(
                name: "_2BMath");

            migrationBuilder.DropTable(
                name: "_2CBiology");

            migrationBuilder.DropTable(
                name: "_2CChemistry");

            migrationBuilder.DropTable(
                name: "_2CEnglish");

            migrationBuilder.DropTable(
                name: "_2CGeography");

            migrationBuilder.DropTable(
                name: "_2CGerman");

            migrationBuilder.DropTable(
                name: "_2CHistory");

            migrationBuilder.DropTable(
                name: "_2CMath");

            migrationBuilder.DropTable(
                name: "_3ABiology");

            migrationBuilder.DropTable(
                name: "_3AChemistry");

            migrationBuilder.DropTable(
                name: "_3AEnglish");

            migrationBuilder.DropTable(
                name: "_3AGeography");

            migrationBuilder.DropTable(
                name: "_3AGerman");

            migrationBuilder.DropTable(
                name: "_3AHistory");

            migrationBuilder.DropTable(
                name: "_3AMath");

            migrationBuilder.DropTable(
                name: "_3BBiology");

            migrationBuilder.DropTable(
                name: "_3BChemistry");

            migrationBuilder.DropTable(
                name: "_3BEnglish");

            migrationBuilder.DropTable(
                name: "_3BGeography");

            migrationBuilder.DropTable(
                name: "_3BGerman");

            migrationBuilder.DropTable(
                name: "_3BHistory");

            migrationBuilder.DropTable(
                name: "_3BMath");

            migrationBuilder.DropTable(
                name: "_3CBiology");

            migrationBuilder.DropTable(
                name: "_3CChemistry");

            migrationBuilder.DropTable(
                name: "_3CEnglish");

            migrationBuilder.DropTable(
                name: "_3CGeography");

            migrationBuilder.DropTable(
                name: "_3CGerman");

            migrationBuilder.DropTable(
                name: "_3CHistory");

            migrationBuilder.DropTable(
                name: "_3CMath");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "ContactStudentInfo1A");

            migrationBuilder.DropTable(
                name: "ContactStudentInfo1B");

            migrationBuilder.DropTable(
                name: "ContactStudentInfo1C");

            migrationBuilder.DropTable(
                name: "ContactStudentInfo2A");

            migrationBuilder.DropTable(
                name: "ContactStudentInfo2B");

            migrationBuilder.DropTable(
                name: "ContactStudentInfo2C");

            migrationBuilder.DropTable(
                name: "ContactStudentInfo3A");

            migrationBuilder.DropTable(
                name: "ContactStudentInfo3B");

            migrationBuilder.DropTable(
                name: "ContactStudentInfo3C");

            migrationBuilder.DropTable(
                name: "TeacherAddress");

            migrationBuilder.DropTable(
                name: "TeacherContactInfo");

            migrationBuilder.DropTable(
                name: "_1AGrades");

            migrationBuilder.DropTable(
                name: "_1BGrades");

            migrationBuilder.DropTable(
                name: "_1CGrades");

            migrationBuilder.DropTable(
                name: "_2AGrades");

            migrationBuilder.DropTable(
                name: "_2BGrades");

            migrationBuilder.DropTable(
                name: "_2CGrades");

            migrationBuilder.DropTable(
                name: "_3AGrades");

            migrationBuilder.DropTable(
                name: "_3BGrades");

            migrationBuilder.DropTable(
                name: "_3CGrades");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Teacher");

            migrationBuilder.DropTable(
                name: "_1AStudents");

            migrationBuilder.DropTable(
                name: "_1BStudents");

            migrationBuilder.DropTable(
                name: "_1CStudents");

            migrationBuilder.DropTable(
                name: "_2AStudents");

            migrationBuilder.DropTable(
                name: "_2BStudents");

            migrationBuilder.DropTable(
                name: "_2CStudents");

            migrationBuilder.DropTable(
                name: "_3AStudents");

            migrationBuilder.DropTable(
                name: "_3BStudents");

            migrationBuilder.DropTable(
                name: "_3CStudents");
        }
    }
}
