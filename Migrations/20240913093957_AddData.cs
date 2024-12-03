using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EmployeeInfo.Migrations
{
    /// <inheritdoc />
    public partial class AddData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mobile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DOB", "Email", "Mobile", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2000, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "abul@gmail.com", "01714546489", "Abul Kalam" },
                    { 2, new DateTime(1983, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "jobhaq@gmail.com", "01354748493", "Jobyda Haque" },
                    { 3, new DateTime(1999, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "tanim@yahoo.com", "015698746312", "Tanim Shariar" },
                    { 4, new DateTime(2001, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "nondi@hotmail.com", "01845693216", "Shubir Nondi" },
                    { 5, new DateTime(2000, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "afia@gmail.com", "01752146369", "Afia Khatun" },
                    { 6, new DateTime(1998, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "tonima@yahoo.com", "017896544123", "Tonima Enam" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
