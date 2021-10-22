using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CodingChallenge.SeniorDev.V1.DataAccess.Migrations
{
    public partial class StudentData_Seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "ID", "Birthdate", "Email", "FirstName", "IsDeleted", "LastName", "NICNo", "RegistrationID" },
                values: new object[,]
                {
                    { new Guid("e4f1d5c8-3c6b-469e-b584-4c9aeb7f4e6a"), new DateTimeOffset(new DateTime(1991, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 5, 30, 0, 0)), "kiruvi5@gmail.com", "Vimalan", false, "Kumarakulasingam", "911472325v", "ST001" },
                    { new Guid("e3462baa-cda0-4c17-b02d-f5e28aab83f9"), new DateTimeOffset(new DateTime(1992, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 5, 30, 0, 0)), "Andrew@gmail.com", "hari", false, "Andrew", "921472325v", "ST002" },
                    { new Guid("e6f6a7b4-463d-48ff-a7b2-9e680f5ffa0a"), new DateTimeOffset(new DateTime(1992, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 5, 30, 0, 0)), "Andrew@gmail.com", "nimal", false, "ilanko", "921472325v", "ST003" },
                    { new Guid("36dca186-bd97-4da7-9a3f-877ba9b51c0b"), new DateTimeOffset(new DateTime(1992, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 5, 30, 0, 0)), "Andrew@gmail.com", "venkat", false, "mohan", "921472325v", "ST004" },
                    { new Guid("18fda881-da8c-4cb2-a929-b3b901c9909d"), new DateTimeOffset(new DateTime(1992, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 5, 30, 0, 0)), "Andrew@gmail.com", "raj", false, "theja", "921472325v", "ST005" },
                    { new Guid("df3cedb1-23b4-4759-ac1e-b8237bc5c8d7"), new DateTimeOffset(new DateTime(1992, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 5, 30, 0, 0)), "Andrew@gmail.com", "karan", false, "shan", "921472325v", "ST006" },
                    { new Guid("bc4e0df4-e6f9-486b-b2f2-4f436e51d777"), new DateTimeOffset(new DateTime(1992, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 5, 30, 0, 0)), "Andrew@gmail.com", "ravi", false, "asanka", "921472325v", "ST007" },
                    { new Guid("90217a07-92bc-428b-97c0-5fad0c7ef03c"), new DateTimeOffset(new DateTime(1992, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 5, 30, 0, 0)), "Andrew@gmail.com", "mathan", false, "nisan", "921472325v", "ST008" },
                    { new Guid("5391b718-784a-4c15-a72d-4c5a4c35a488"), new DateTimeOffset(new DateTime(1992, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 5, 30, 0, 0)), "Andrew@gmail.com", "juvi", false, "kannan", "921472325v", "ST009" },
                    { new Guid("709d37b5-685d-4afa-acda-4835c2cfef6d"), new DateTimeOffset(new DateTime(1992, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 5, 30, 0, 0)), "Andrew@gmail.com", "ari", false, "mohan", "921472325v", "ST0010" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: new Guid("18fda881-da8c-4cb2-a929-b3b901c9909d"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: new Guid("36dca186-bd97-4da7-9a3f-877ba9b51c0b"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: new Guid("5391b718-784a-4c15-a72d-4c5a4c35a488"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: new Guid("709d37b5-685d-4afa-acda-4835c2cfef6d"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: new Guid("90217a07-92bc-428b-97c0-5fad0c7ef03c"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: new Guid("bc4e0df4-e6f9-486b-b2f2-4f436e51d777"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: new Guid("df3cedb1-23b4-4759-ac1e-b8237bc5c8d7"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: new Guid("e3462baa-cda0-4c17-b02d-f5e28aab83f9"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: new Guid("e4f1d5c8-3c6b-469e-b584-4c9aeb7f4e6a"));

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: new Guid("e6f6a7b4-463d-48ff-a7b2-9e680f5ffa0a"));
        }
    }
}
