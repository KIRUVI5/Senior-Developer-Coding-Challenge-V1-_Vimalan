using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CodingChallenge.SeniorDev.V1.DataAccess.Migrations
{
    public partial class Relationship_added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Courses_CourseID",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_CourseID",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "CourseID",
                table: "Students");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Teachers",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Teachers",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Students",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Students",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "StudentCourses",
                columns: table => new
                {
                    StudentID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CourseID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentCourses", x => new { x.StudentID, x.CourseID });
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseStudentCourses");

            migrationBuilder.DropTable(
                name: "StudentStudentCourses");

            migrationBuilder.DropTable(
                name: "StudentCourses");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Teachers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Teachers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CourseID",
                table: "Students",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Students_CourseID",
                table: "Students",
                column: "CourseID");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Courses_CourseID",
                table: "Students",
                column: "CourseID",
                principalTable: "Courses",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
