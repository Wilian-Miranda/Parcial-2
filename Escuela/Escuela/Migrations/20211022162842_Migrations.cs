using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Escuela.Migrations
{
    public partial class Migrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tbl_Course",
                columns: table => new
                {
                    courseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    credits = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Course", x => x.courseId);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Student",
                columns: table => new
                {
                    studendId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    lastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    firstMidName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    enrollmentsDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Student", x => x.studendId);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Enrollment",
                columns: table => new
                {
                    enrollmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    courseId = table.Column<int>(type: "int", nullable: false),
                    studentId = table.Column<int>(type: "int", nullable: false),
                    grade = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Enrollment", x => x.enrollmentId);
                    table.ForeignKey(
                        name: "FK_Tbl_Enrollment_Tbl_Course_courseId",
                        column: x => x.courseId,
                        principalTable: "Tbl_Course",
                        principalColumn: "courseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tbl_Enrollment_Tbl_Student_studentId",
                        column: x => x.studentId,
                        principalTable: "Tbl_Student",
                        principalColumn: "studendId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Enrollment_courseId",
                table: "Tbl_Enrollment",
                column: "courseId");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Enrollment_studentId",
                table: "Tbl_Enrollment",
                column: "studentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tbl_Enrollment");

            migrationBuilder.DropTable(
                name: "Tbl_Course");

            migrationBuilder.DropTable(
                name: "Tbl_Student");
        }
    }
}
