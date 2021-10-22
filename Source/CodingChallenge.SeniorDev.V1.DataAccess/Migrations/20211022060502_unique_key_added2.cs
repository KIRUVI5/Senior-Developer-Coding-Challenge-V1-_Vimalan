using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CodingChallenge.SeniorDev.V1.DataAccess.Migrations
{
    public partial class unique_key_added2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: new Guid("18fda881-da8c-4cb2-a929-b3b901c9909d"),
                column: "Email",
                value: "theja@gmail.com");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: new Guid("36dca186-bd97-4da7-9a3f-877ba9b51c0b"),
                column: "Email",
                value: "mohan@gmail.com");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: new Guid("5391b718-784a-4c15-a72d-4c5a4c35a488"),
                column: "Email",
                value: "kannan@gmail.com");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: new Guid("709d37b5-685d-4afa-acda-4835c2cfef6d"),
                column: "Email",
                value: "mohan@gmail.com");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: new Guid("90217a07-92bc-428b-97c0-5fad0c7ef03c"),
                column: "Email",
                value: "nisan@gmail.com");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: new Guid("bc4e0df4-e6f9-486b-b2f2-4f436e51d777"),
                column: "Email",
                value: "asanka@gmail.com");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: new Guid("df3cedb1-23b4-4759-ac1e-b8237bc5c8d7"),
                column: "Email",
                value: "shan@gmail.com");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: new Guid("e6f6a7b4-463d-48ff-a7b2-9e680f5ffa0a"),
                column: "Email",
                value: "ilanko@gmail.com");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: new Guid("18fda881-da8c-4cb2-a929-b3b901c9909d"),
                column: "Email",
                value: "Andrew@gmail.com");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: new Guid("36dca186-bd97-4da7-9a3f-877ba9b51c0b"),
                column: "Email",
                value: "Andrew@gmail.com");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: new Guid("5391b718-784a-4c15-a72d-4c5a4c35a488"),
                column: "Email",
                value: "Andrew@gmail.com");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: new Guid("709d37b5-685d-4afa-acda-4835c2cfef6d"),
                column: "Email",
                value: "Andrew@gmail.com");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: new Guid("90217a07-92bc-428b-97c0-5fad0c7ef03c"),
                column: "Email",
                value: "Andrew@gmail.com");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: new Guid("bc4e0df4-e6f9-486b-b2f2-4f436e51d777"),
                column: "Email",
                value: "Andrew@gmail.com");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: new Guid("df3cedb1-23b4-4759-ac1e-b8237bc5c8d7"),
                column: "Email",
                value: "Andrew@gmail.com");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: new Guid("e6f6a7b4-463d-48ff-a7b2-9e680f5ffa0a"),
                column: "Email",
                value: "Andrew@gmail.com");
        }
    }
}
