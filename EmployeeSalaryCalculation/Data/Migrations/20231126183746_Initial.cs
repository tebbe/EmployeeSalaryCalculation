using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EmployeeSalaryCalculation.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
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
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Salary = table.Column<double>(type: "float", nullable: false),
                    SalaryWithBonus = table.Column<double>(type: "float", nullable: false),
                    JoinDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsBonusAdded = table.Column<bool>(type: "bit", nullable: false),
                    ReportingPersonId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "CreateDate", "IsBonusAdded", "JoinDate", "Name", "Position", "ReportingPersonId", "Salary", "SalaryWithBonus", "UpdateDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 27, 0, 37, 46, 719, DateTimeKind.Local).AddTicks(8677), true, new DateTime(2017, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yehfes ", "General Manager", 0, 50000.900000000001, 0.0, new DateTime(2023, 11, 27, 0, 37, 46, 719, DateTimeKind.Local).AddTicks(8678) },
                    { 2, new DateTime(2023, 11, 27, 0, 37, 46, 719, DateTimeKind.Local).AddTicks(8685), true, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "John", "General Manager", 0, 50000.900000000001, 0.0, new DateTime(2023, 11, 27, 0, 37, 46, 719, DateTimeKind.Local).AddTicks(8686) },
                    { 3, new DateTime(2023, 11, 27, 0, 37, 46, 719, DateTimeKind.Local).AddTicks(8689), true, new DateTime(2017, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ron", "Manager", 1, 40000.5, 0.0, new DateTime(2023, 11, 27, 0, 37, 46, 719, DateTimeKind.Local).AddTicks(8690) },
                    { 4, new DateTime(2023, 11, 27, 0, 37, 46, 719, DateTimeKind.Local).AddTicks(8693), true, new DateTime(2018, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jaky", "Manager", 2, 40000.5, 0.0, new DateTime(2023, 11, 27, 0, 37, 46, 719, DateTimeKind.Local).AddTicks(8693) },
                    { 5, new DateTime(2023, 11, 27, 0, 37, 46, 719, DateTimeKind.Local).AddTicks(8696), true, new DateTime(2019, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jack", "Office Executive", 4, 20000.5, 0.0, new DateTime(2023, 11, 27, 0, 37, 46, 719, DateTimeKind.Local).AddTicks(8697) },
                    { 6, new DateTime(2023, 11, 27, 0, 37, 46, 719, DateTimeKind.Local).AddTicks(8700), true, new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jane", "Office Executive", 3, 20000.5, 0.0, new DateTime(2023, 11, 27, 0, 37, 46, 719, DateTimeKind.Local).AddTicks(8701) },
                    { 7, new DateTime(2023, 11, 27, 0, 37, 46, 719, DateTimeKind.Local).AddTicks(8703), false, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hun", "Office Executive", 4, 20000.5, 0.0, new DateTime(2023, 11, 27, 0, 37, 46, 719, DateTimeKind.Local).AddTicks(8704) },
                    { 8, new DateTime(2023, 11, 27, 0, 37, 46, 719, DateTimeKind.Local).AddTicks(8707), true, new DateTime(2019, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Amber", "Office Executive", 3, 20000.5, 0.0, new DateTime(2023, 11, 27, 0, 37, 46, 719, DateTimeKind.Local).AddTicks(8708) },
                    { 9, new DateTime(2023, 11, 27, 0, 37, 46, 719, DateTimeKind.Local).AddTicks(8710), true, new DateTime(2019, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nick", "Office Executive", 4, 20000.5, 0.0, new DateTime(2023, 11, 27, 0, 37, 46, 719, DateTimeKind.Local).AddTicks(8711) },
                    { 10, new DateTime(2023, 11, 27, 0, 37, 46, 719, DateTimeKind.Local).AddTicks(8714), false, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laila", "Office Executive", 4, 20000.5, 0.0, new DateTime(2023, 11, 27, 0, 37, 46, 719, DateTimeKind.Local).AddTicks(8715) },
                    { 11, new DateTime(2023, 11, 27, 0, 37, 46, 719, DateTimeKind.Local).AddTicks(8717), true, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adam", "Office Executive", 3, 20000.5, 0.0, new DateTime(2023, 11, 27, 0, 37, 46, 719, DateTimeKind.Local).AddTicks(8718) },
                    { 12, new DateTime(2023, 11, 27, 0, 37, 46, 719, DateTimeKind.Local).AddTicks(8721), true, new DateTime(2019, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Joss", "Office Executive", 3, 20000.5, 0.0, new DateTime(2023, 11, 27, 0, 37, 46, 719, DateTimeKind.Local).AddTicks(8722) },
                    { 13, new DateTime(2023, 11, 27, 0, 37, 46, 719, DateTimeKind.Local).AddTicks(8724), false, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nissan", "Office Executive", 4, 20000.5, 0.0, new DateTime(2023, 11, 27, 0, 37, 46, 719, DateTimeKind.Local).AddTicks(8725) },
                    { 14, new DateTime(2023, 11, 27, 0, 37, 46, 719, DateTimeKind.Local).AddTicks(8728), true, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adriano", "Office Executive", 4, 20000.5, 0.0, new DateTime(2023, 11, 27, 0, 37, 46, 719, DateTimeKind.Local).AddTicks(8728) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_Id",
                table: "Employees",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
