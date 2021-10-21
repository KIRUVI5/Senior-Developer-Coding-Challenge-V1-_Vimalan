using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CodingChallenge.SeniorDev.V1.DataAccess.Migrations
{
    public partial class Relationship_added2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseStudentCourses");

            migrationBuilder.DropTable(
                name: "StudentStudentCourses");

            migrationBuilder.AddColumn<Guid>(
                name: "StudentCoursesCourseID",
                table: "Students",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "StudentCoursesStudentID",
                table: "Students",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "StudentCoursesCourseID",
                table: "Courses",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "StudentCoursesStudentID",
                table: "Courses",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Students_StudentCoursesStudentID_StudentCoursesCourseID",
                table: "Students",
                columns: new[] { "StudentCoursesStudentID", "StudentCoursesCourseID" });

            migrationBuilder.CreateIndex(
                name: "IX_Courses_StudentCoursesStudentID_StudentCoursesCourseID",
                table: "Courses",
                columns: new[] { "StudentCoursesStudentID", "StudentCoursesCourseID" });

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_StudentCourses_StudentCoursesStudentID_StudentCoursesCourseID",
                table: "Courses",
                columns: new[] { "StudentCoursesStudentID", "StudentCoursesCourseID" },
                principalTable: "StudentCourses",
                principalColumns: new[] { "StudentID", "CourseID" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_StudentCourses_StudentCoursesStudentID_StudentCoursesCourseID",
                table: "Students",
                columns: new[] { "StudentCoursesStudentID", "StudentCoursesCourseID" },
                principalTable: "StudentCourses",
                principalColumns: new[] { "StudentID", "CourseID" },
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_StudentCourses_StudentCoursesStudentID_StudentCoursesCourseID",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_StudentCourses_StudentCoursesStudentID_StudentCoursesCourseID",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_StudentCoursesStudentID_StudentCoursesCourseID",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Courses_StudentCoursesStudentID_StudentCoursesCourseID",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "StudentCoursesCourseID",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "StudentCoursesStudentID",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "StudentCoursesCourseID",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "StudentCoursesStudentID",
                table: "Courses");

            migrationBuilder.CreateTable(
                name: "CourseStudentCourses",
                columns: table => new
                {
                    CoursesID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StudentCoursesStudentID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StudentCoursesCourseID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseStudentCourses", x => new { x.CoursesID, x.StudentCoursesStudentID, x.StudentCoursesCourseID });
                    table.ForeignKey(
                        name: "FK_CourseStudentCourses_Courses_CoursesID",
                        column: x => x.CoursesID,
                        principalTable: "Courses",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseStudentCourses_StudentCourses_StudentCoursesStudentID_StudentCoursesCourseID",
                        columns: x => new { x.StudentCoursesStudentID, x.StudentCoursesCourseID },
                        principalTable: "StudentCourses",
                        principalColumns: new[] { "StudentID", "CourseID" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentStudentCourses",
                columns: table => new
                {
                    StudentsID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StudentCoursesStudentID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StudentCoursesCourseID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentStudentCourses", x => new { x.StudentsID, x.StudentCoursesStudentID, x.StudentCoursesCourseID });
                    table.ForeignKey(
                        name: "FK_StudentStudentCourses_StudentCourses_StudentCoursesStudentID_StudentCoursesCourseID",
                        columns: x => new { x.StudentCoursesStudentID, x.StudentCoursesCourseID },
                        principalTable: "StudentCourses",
                        principalColumns: new[] { "StudentID", "CourseID" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentStudentCourses_Students_StudentsID",
                        column: x => x.StudentsID,
                        principalTable: "Students",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CourseStudentCourses_StudentCoursesStudentID_StudentCoursesCourseID",
                table: "CourseStudentCourses",
                columns: new[] { "StudentCoursesStudentID", "StudentCoursesCourseID" });

            migrationBuilder.CreateIndex(
                name: "IX_StudentStudentCourses_StudentCoursesStudentID_StudentCoursesCourseID",
                table: "StudentStudentCourses",
                columns: new[] { "StudentCoursesStudentID", "StudentCoursesCourseID" });
        }
    }
}
