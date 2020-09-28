using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class updateDateInSeminarTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Seminars",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2020, 10, 29, 10, 29, 9, 235, DateTimeKind.Local).AddTicks(3870));

            migrationBuilder.UpdateData(
                table: "Seminars",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2020, 10, 20, 10, 29, 9, 238, DateTimeKind.Local).AddTicks(6259));

            migrationBuilder.UpdateData(
                table: "Seminars",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2020, 10, 26, 10, 29, 9, 238, DateTimeKind.Local).AddTicks(6346));

            migrationBuilder.UpdateData(
                table: "Seminars",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateTime",
                value: new DateTime(2020, 11, 12, 10, 29, 9, 238, DateTimeKind.Local).AddTicks(6356));

            migrationBuilder.UpdateData(
                table: "Seminars",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateTime",
                value: new DateTime(2020, 10, 12, 10, 29, 9, 238, DateTimeKind.Local).AddTicks(6360));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Seminars",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2020, 10, 12, 10, 22, 50, 405, DateTimeKind.Local).AddTicks(4680));

            migrationBuilder.UpdateData(
                table: "Seminars",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2020, 10, 16, 10, 22, 50, 408, DateTimeKind.Local).AddTicks(7662));

            migrationBuilder.UpdateData(
                table: "Seminars",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2020, 10, 20, 10, 22, 50, 408, DateTimeKind.Local).AddTicks(7758));

            migrationBuilder.UpdateData(
                table: "Seminars",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateTime",
                value: new DateTime(2020, 10, 26, 10, 22, 50, 408, DateTimeKind.Local).AddTicks(7765));

            migrationBuilder.UpdateData(
                table: "Seminars",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateTime",
                value: new DateTime(2020, 10, 29, 10, 22, 50, 408, DateTimeKind.Local).AddTicks(7770));
        }
    }
}
