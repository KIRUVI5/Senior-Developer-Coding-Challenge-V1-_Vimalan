using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CodingChallenge.SeniorDev.V1.DataAccess.Migrations
{
    public partial class Relationship_added3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateIndex(
                name: "IX_StudentCourses_CourseID",
                table: "StudentCourses",
                column: "CourseID");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentCourses_Courses_CourseID",
                table: "StudentCourses",
                column: "CourseID",
                principalTable: "Courses",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentCourses_Students_StudentID",
                table: "StudentCourses",
                column: "StudentID",
                principalTable: "Students",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentCourses_Courses_CourseID",
                table: "StudentCourses");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentCourses_Students_StudentID",
                table: "StudentCourses");

            migrationBuilder.DropIndex(
                name: "IX_StudentCourses_CourseID",
                table: "StudentCourses");

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
    }
}
