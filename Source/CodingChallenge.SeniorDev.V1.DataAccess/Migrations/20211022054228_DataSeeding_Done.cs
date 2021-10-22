using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CodingChallenge.SeniorDev.V1.DataAccess.Migrations
{
    public partial class DataSeeding_Done : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Birthdate", "Email", "FirstName", "IsDeleted", "LastName" },
                values: new object[] { new Guid("f55d4e5c-0636-43e1-a770-2e8f170b0500"), new DateTimeOffset(new DateTime(1981, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 5, 30, 0, 0)), "Mano@gmail.com", "Mano", false, "Raj" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Birthdate", "Email", "FirstName", "IsDeleted", "LastName" },
                values: new object[] { new Guid("5db11e34-33ee-4c48-9537-b1e56f33ca01"), new DateTimeOffset(new DateTime(1985, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 5, 30, 0, 0)), "Ragu@gmail.com", "Ragu", false, "Paramesh" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "ID", "Description", "IsDeleted", "MaximumStudentLimit", "Subject", "TeacherID", "Title" },
                values: new object[] { new Guid("97600ec6-fb99-4e0e-a501-6e2ad0de3895"), "Computer Science", false, 15, "AI", new Guid("f55d4e5c-0636-43e1-a770-2e8f170b0500"), "Computer Science" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "ID", "Description", "IsDeleted", "MaximumStudentLimit", "Subject", "TeacherID", "Title" },
                values: new object[] { new Guid("6eced36f-0bcc-4b1e-9f46-1fefa0881cc6"), "Physical Science", false, 15, "Engineering Drawing", new Guid("5db11e34-33ee-4c48-9537-b1e56f33ca01"), "Physical Science" });

            migrationBuilder.InsertData(
                table: "StudentCourses",
                columns: new[] { "CourseID", "StudentID", "IsDeleted" },
                values: new object[] { new Guid("97600ec6-fb99-4e0e-a501-6e2ad0de3895"), new Guid("18fda881-da8c-4cb2-a929-b3b901c9909d"), false });

            migrationBuilder.InsertData(
                table: "StudentCourses",
                columns: new[] { "CourseID", "StudentID", "IsDeleted" },
                values: new object[] { new Guid("6eced36f-0bcc-4b1e-9f46-1fefa0881cc6"), new Guid("709d37b5-685d-4afa-acda-4835c2cfef6d"), false });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentCourses",
                keyColumns: new[] { "CourseID", "StudentID" },
                keyValues: new object[] { new Guid("97600ec6-fb99-4e0e-a501-6e2ad0de3895"), new Guid("18fda881-da8c-4cb2-a929-b3b901c9909d") });

            migrationBuilder.DeleteData(
                table: "StudentCourses",
                keyColumns: new[] { "CourseID", "StudentID" },
                keyValues: new object[] { new Guid("6eced36f-0bcc-4b1e-9f46-1fefa0881cc6"), new Guid("709d37b5-685d-4afa-acda-4835c2cfef6d") });

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: new Guid("6eced36f-0bcc-4b1e-9f46-1fefa0881cc6"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: new Guid("97600ec6-fb99-4e0e-a501-6e2ad0de3895"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "ID",
                keyValue: new Guid("5db11e34-33ee-4c48-9537-b1e56f33ca01"));

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "ID",
                keyValue: new Guid("f55d4e5c-0636-43e1-a770-2e8f170b0500"));
        }
    }
}
