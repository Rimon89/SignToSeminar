using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class updateSeminarTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Seminars",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateTime", "active" },
                values: new object[] { new DateTime(2020, 10, 12, 10, 22, 50, 405, DateTimeKind.Local).AddTicks(4680), true });

            migrationBuilder.UpdateData(
                table: "Seminars",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateTime", "active" },
                values: new object[] { new DateTime(2020, 10, 16, 10, 22, 50, 408, DateTimeKind.Local).AddTicks(7662), true });

            migrationBuilder.UpdateData(
                table: "Seminars",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateTime", "active" },
                values: new object[] { new DateTime(2020, 10, 20, 10, 22, 50, 408, DateTimeKind.Local).AddTicks(7758), true });

            migrationBuilder.UpdateData(
                table: "Seminars",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateTime", "active" },
                values: new object[] { new DateTime(2020, 10, 26, 10, 22, 50, 408, DateTimeKind.Local).AddTicks(7765), true });

            migrationBuilder.UpdateData(
                table: "Seminars",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateTime", "active" },
                values: new object[] { new DateTime(2020, 10, 29, 10, 22, 50, 408, DateTimeKind.Local).AddTicks(7770), true });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Seminars",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateTime", "active" },
                values: new object[] { new DateTime(2020, 10, 10, 9, 57, 5, 729, DateTimeKind.Local).AddTicks(8125), false });

            migrationBuilder.UpdateData(
                table: "Seminars",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateTime", "active" },
                values: new object[] { new DateTime(2020, 10, 10, 9, 57, 5, 733, DateTimeKind.Local).AddTicks(593), false });

            migrationBuilder.UpdateData(
                table: "Seminars",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateTime", "active" },
                values: new object[] { new DateTime(2020, 10, 10, 9, 57, 5, 733, DateTimeKind.Local).AddTicks(682), false });

            migrationBuilder.UpdateData(
                table: "Seminars",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateTime", "active" },
                values: new object[] { new DateTime(2020, 10, 10, 9, 57, 5, 733, DateTimeKind.Local).AddTicks(689), false });

            migrationBuilder.UpdateData(
                table: "Seminars",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateTime", "active" },
                values: new object[] { new DateTime(2020, 10, 10, 9, 57, 5, 733, DateTimeKind.Local).AddTicks(694), false });
        }
    }
}
