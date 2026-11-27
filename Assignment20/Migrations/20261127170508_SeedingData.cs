using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Assignment20.Migrations
{
    /// <inheritdoc />
    public partial class SeedingData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Managers",
                columns: new[] { "Id", "Email", "FullName", "HireDate", "PhoneNumber" },
                values: new object[,]
                {
                    { 202, "john.Tery@bank.com", "John Tery", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "123-456-7890" },
                    { 204, "reece.James@bank.com", "Reece James", new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "098-765-4321" }
                });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "Code", "Address", "ManagerId", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { "ALX-01", "26 El-Horreya Road, Azarita", 204, "Alexandria Branch", "03-486-7291" },
                    { "CAI-01", "12 Talaat Harb Street, Downtown", 202, "Cairo Main Branch", "02-2392-4815" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "Code",
                keyValue: "ALX-01");

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "Code",
                keyValue: "CAI-01");

            migrationBuilder.DeleteData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: 204);
        }
    }
}
