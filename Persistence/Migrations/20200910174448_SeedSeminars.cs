using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class SeedSeminars : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Seminars",
                columns: new[] { "Id", "Address", "City", "DateTime", "Name" },
                values: new object[] { 1, "101 Main St", "Gothenburg", new DateTime(2020, 9, 10, 19, 44, 47, 905, DateTimeKind.Local).AddTicks(1978), "Seminar 101" });

            migrationBuilder.InsertData(
                table: "Seminars",
                columns: new[] { "Id", "Address", "City", "DateTime", "Name" },
                values: new object[] { 2, "101 Main St", "Gothenburg", new DateTime(2020, 9, 10, 19, 44, 47, 915, DateTimeKind.Local).AddTicks(3252), "Seminar 102" });

            migrationBuilder.InsertData(
                table: "Seminars",
                columns: new[] { "Id", "Address", "City", "DateTime", "Name" },
                values: new object[] { 3, "101 Main St", "Gothenburg", new DateTime(2020, 9, 10, 19, 44, 47, 915, DateTimeKind.Local).AddTicks(3329), "Seminar 103" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Seminars",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Seminars",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Seminars",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
