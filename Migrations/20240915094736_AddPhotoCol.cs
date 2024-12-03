using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EmployeeInfo.Migrations
{
    /// <inheritdoc />
    public partial class AddPhotoCol : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DOB", "Email", "Mobile", "Name", "Photo" },
                values: new object[,]
                {
                    { 1, new DateTime(2000, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "abul@gmail.com", "01714546489", "Abul Kalam", null },
                    { 2, new DateTime(1983, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "jobhaq@gmail.com", "01354748493", "Jobyda Haque", null },
                    { 3, new DateTime(1999, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "tanim@yahoo.com", "015698746312", "Tanim Shariar", null },
                    { 4, new DateTime(2001, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "nondi@hotmail.com", "01845693216", "Shubir Nondi", null },
                    { 5, new DateTime(2000, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "afia@gmail.com", "01752146369", "Afia Khatun", null },
                    { 6, new DateTime(1998, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "tonima@yahoo.com", "017896544123", "Tonima Enam", null }
                });
        }
    }
}
