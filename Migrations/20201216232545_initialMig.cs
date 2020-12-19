using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentSystem.Migrations
{
    public partial class initialMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "activity",
                columns: table => new
                {
                    act_code = table.Column<string>(unicode: false, maxLength: 8, nullable: false),
                    act_name = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    act_fee = table.Column<decimal>(type: "decimal(6, 2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("activity_act_code_pk", x => x.act_code);
                });

            migrationBuilder.CreateTable(
                name: "school",
                columns: table => new
                {
                    sch_code = table.Column<string>(unicode: false, maxLength: 8, nullable: false),
                    sch_name = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    sch_phone = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    sch_dean_name = table.Column<string>(unicode: false, maxLength: 35, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("school_sch_code_pk", x => x.sch_code);
                });

            migrationBuilder.CreateTable(
                name: "advisor",
                columns: table => new
                {
                    adv_code = table.Column<string>(unicode: false, maxLength: 8, nullable: false),
                    adv_fname = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    adv_lname = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    adv_phone = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    sch_code = table.Column<string>(unicode: false, maxLength: 8, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("advisor_adv_code_pk", x => x.adv_code);
                    table.ForeignKey(
                        name: "advisor_sch_code_fk",
                        column: x => x.sch_code,
                        principalTable: "school",
                        principalColumn: "sch_code",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "faculty",
                columns: table => new
                {
                    fac_code = table.Column<string>(unicode: false, maxLength: 8, nullable: false),
                    fac_fname = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    fac_lname = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    fac_gend = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    fac_phone = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    sch_code = table.Column<string>(unicode: false, maxLength: 8, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("faculty_fac_code_pk", x => x.fac_code);
                    table.ForeignKey(
                        name: "faculty_sch_code_fk",
                        column: x => x.sch_code,
                        principalTable: "school",
                        principalColumn: "sch_code",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "major",
                columns: table => new
                {
                    maj_code = table.Column<string>(unicode: false, maxLength: 10, nullable: false),
                    maj_desc = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    sch_code = table.Column<string>(unicode: false, maxLength: 8, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("major_maj_code_pk", x => x.maj_code);
                    table.ForeignKey(
                        name: "major_sch_code_fk",
                        column: x => x.sch_code,
                        principalTable: "school",
                        principalColumn: "sch_code",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "department",
                columns: table => new
                {
                    dept_code = table.Column<string>(unicode: false, maxLength: 8, nullable: false),
                    dept_name = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    dept_phone = table.Column<string>(unicode: false, maxLength: 12, nullable: true),
                    fac_code = table.Column<string>(unicode: false, maxLength: 8, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("department_dept_code_pk", x => x.dept_code);
                    table.ForeignKey(
                        name: "department_fac_code_fk",
                        column: x => x.fac_code,
                        principalTable: "faculty",
                        principalColumn: "fac_code",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "maj_adv",
                columns: table => new
                {
                    maj_code = table.Column<string>(unicode: false, maxLength: 10, nullable: false),
                    adv_code = table.Column<string>(unicode: false, maxLength: 8, nullable: false),
                    maj_adv_level = table.Column<string>(unicode: false, maxLength: 12, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("maj_adv_maj_code_adv_code_cpk", x => new { x.maj_code, x.adv_code });
                    table.ForeignKey(
                        name: "maj_adv_adv_code_fk",
                        column: x => x.adv_code,
                        principalTable: "advisor",
                        principalColumn: "adv_code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "maj_adv_maj_code_fk",
                        column: x => x.maj_code,
                        principalTable: "major",
                        principalColumn: "maj_code",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "student",
                columns: table => new
                {
                    std_code = table.Column<string>(unicode: false, maxLength: 8, nullable: false),
                    std_fname = table.Column<string>(unicode: false, maxLength: 15, nullable: false),
                    std_lname = table.Column<string>(unicode: false, maxLength: 15, nullable: false),
                    std_gend = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    maj_code = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    std_dob = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("student_std_code_pk", x => x.std_code);
                    table.ForeignKey(
                        name: "student_maj_code_fk",
                        column: x => x.maj_code,
                        principalTable: "major",
                        principalColumn: "maj_code",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "grade",
                columns: table => new
                {
                    std_code = table.Column<string>(unicode: false, maxLength: 8, nullable: false),
                    std_fname = table.Column<string>(unicode: false, maxLength: 15, nullable: false),
                    std_lname = table.Column<string>(unicode: false, maxLength: 15, nullable: false),
                    gr_t1 = table.Column<int>(nullable: true),
                    gr_t2 = table.Column<int>(nullable: true),
                    gr_hw = table.Column<int>(nullable: true),
                    gr_pr = table.Column<int>(nullable: true),
                    gr_avg = table.Column<int>(nullable: true),
                    gr_lg = table.Column<string>(unicode: false, maxLength: 5, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("grade_std_code_pk", x => x.std_code);
                    table.ForeignKey(
                        name: "grade_std_code_fk",
                        column: x => x.std_code,
                        principalTable: "student",
                        principalColumn: "std_code",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "std_act",
                columns: table => new
                {
                    std_code = table.Column<string>(unicode: false, maxLength: 8, nullable: false),
                    act_code = table.Column<string>(unicode: false, maxLength: 8, nullable: false),
                    std_act_num = table.Column<int>(nullable: true),
                    std_act_joined = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("std_act_std_code_act_code_cpk", x => new { x.std_code, x.act_code });
                    table.ForeignKey(
                        name: "std_act_act_code_fk",
                        column: x => x.act_code,
                        principalTable: "activity",
                        principalColumn: "act_code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "std_act_std_code_fk",
                        column: x => x.std_code,
                        principalTable: "student",
                        principalColumn: "std_code",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_advisor_sch_code",
                table: "advisor",
                column: "sch_code");

            migrationBuilder.CreateIndex(
                name: "IX_department_fac_code",
                table: "department",
                column: "fac_code");

            migrationBuilder.CreateIndex(
                name: "IX_faculty_sch_code",
                table: "faculty",
                column: "sch_code");

            migrationBuilder.CreateIndex(
                name: "IX_maj_adv_adv_code",
                table: "maj_adv",
                column: "adv_code");

            migrationBuilder.CreateIndex(
                name: "IX_major_sch_code",
                table: "major",
                column: "sch_code");

            migrationBuilder.CreateIndex(
                name: "IX_std_act_act_code",
                table: "std_act",
                column: "act_code");

            migrationBuilder.CreateIndex(
                name: "IX_student_maj_code",
                table: "student",
                column: "maj_code");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "department");

            migrationBuilder.DropTable(
                name: "grade");

            migrationBuilder.DropTable(
                name: "maj_adv");

            migrationBuilder.DropTable(
                name: "std_act");

            migrationBuilder.DropTable(
                name: "faculty");

            migrationBuilder.DropTable(
                name: "advisor");

            migrationBuilder.DropTable(
                name: "activity");

            migrationBuilder.DropTable(
                name: "student");

            migrationBuilder.DropTable(
                name: "major");

            migrationBuilder.DropTable(
                name: "school");
        }
    }
}
