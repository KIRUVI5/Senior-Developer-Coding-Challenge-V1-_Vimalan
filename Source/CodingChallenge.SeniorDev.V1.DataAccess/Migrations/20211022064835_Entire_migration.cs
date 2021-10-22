using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CodingChallenge.SeniorDev.V1.DataAccess.Migrations
{
    public partial class Entire_migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RegistrationID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Birthdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    NICNo = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Birthdate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TeacherID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaximumStudentLimit = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Courses_Teachers_TeacherID",
                        column: x => x.TeacherID,
                        principalTable: "Teachers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentCourses",
                columns: table => new
                {
                    StudentID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CourseID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentCourses", x => new { x.StudentID, x.CourseID });
                    table.ForeignKey(
                        name: "FK_StudentCourses_Courses_CourseID",
                        column: x => x.CourseID,
                        principalTable: "Courses",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentCourses_Students_StudentID",
                        column: x => x.StudentID,
                        principalTable: "Students",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "ID", "Birthdate", "Email", "FirstName", "IsDeleted", "LastName", "NICNo", "RegistrationID" },
                values: new object[,]
                {
                    { new Guid("e4f1d5c8-3c6b-469e-b584-4c9aeb7f4e6a"), new DateTimeOffset(new DateTime(1991, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 5, 30, 0, 0)), "kiruvi5@gmail.com", "Vimalan", false, "Kumarakulasingam", "91781472325v", "ST001" },
                    { new Guid("e3462baa-cda0-4c17-b02d-f5e28aab83f9"), new DateTimeOffset(new DateTime(1992, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 5, 30, 0, 0)), "Andrew@gmail.com", "hari", false, "Andrew", "92147872325v", "ST002" },
                    { new Guid("e6f6a7b4-463d-48ff-a7b2-9e680f5ffa0a"), new DateTimeOffset(new DateTime(1992, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 5, 30, 0, 0)), "ilanko@gmail.com", "nimal", false, "ilanko", "93671472325v", "ST003" },
                    { new Guid("36dca186-bd97-4da7-9a3f-877ba9b51c0b"), new DateTimeOffset(new DateTime(1992, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 5, 30, 0, 0)), "mohan@gmail.com", "venkat", false, "mohan", "941478972325v", "ST004" },
                    { new Guid("18fda881-da8c-4cb2-a929-b3b901c9909d"), new DateTimeOffset(new DateTime(1992, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 5, 30, 0, 0)), "theja@gmail.com", "raj", false, "theja", "96146772325v", "ST005" },
                    { new Guid("df3cedb1-23b4-4759-ac1e-b8237bc5c8d7"), new DateTimeOffset(new DateTime(1992, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 5, 30, 0, 0)), "shan@gmail.com", "karan", false, "shan", "971454372325v", "ST006" },
                    { new Guid("bc4e0df4-e6f9-486b-b2f2-4f436e51d777"), new DateTimeOffset(new DateTime(1992, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 5, 30, 0, 0)), "asanka@gmail.com", "ravi", false, "asanka", "9561472325v", "ST007" },
                    { new Guid("90217a07-92bc-428b-97c0-5fad0c7ef03c"), new DateTimeOffset(new DateTime(1992, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 5, 30, 0, 0)), "nisan@gmail.com", "mathan", false, "nisan", "926781472325v", "ST008" },
                    { new Guid("5391b718-784a-4c15-a72d-4c5a4c35a488"), new DateTimeOffset(new DateTime(1992, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 5, 30, 0, 0)), "kannan@gmail.com", "juvi", false, "kannan", "95764621472325v", "ST009" },
                    { new Guid("709d37b5-685d-4afa-acda-4835c2cfef6d"), new DateTimeOffset(new DateTime(1992, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 5, 30, 0, 0)), "ari@gmail.com", "ari", false, "mohan", "921897472325v", "ST0010" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "ID", "Birthdate", "Email", "FirstName", "IsDeleted", "LastName" },
                values: new object[,]
                {
                    { new Guid("f55d4e5c-0636-43e1-a770-2e8f170b0500"), new DateTimeOffset(new DateTime(1981, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 5, 30, 0, 0)), "Mano@gmail.com", "Mano", false, "Raj" },
                    { new Guid("5db11e34-33ee-4c48-9537-b1e56f33ca01"), new DateTimeOffset(new DateTime(1985, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 5, 30, 0, 0)), "Ragu@gmail.com", "Ragu", false, "Paramesh" }
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Courses_TeacherID",
                table: "Courses",
                column: "TeacherID");

            migrationBuilder.CreateIndex(
                name: "IX_StudentCourses_CourseID",
                table: "StudentCourses",
                column: "CourseID");

            migrationBuilder.CreateIndex(
                name: "IX_Students_Email",
                table: "Students",
                column: "Email",
                unique: true,
                filter: "[Email] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Students_NICNo",
                table: "Students",
                column: "NICNo",
                unique: true,
                filter: "[NICNo] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_Email",
                table: "Teachers",
                column: "Email",
                unique: true,
                filter: "[Email] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentCourses");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Teachers");
        }
    }
}
