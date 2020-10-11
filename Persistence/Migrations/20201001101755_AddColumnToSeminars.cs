using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddColumnToSeminars : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "availableSeats",
                table: "Seminars",
                newName: "AvailableSeats");

            migrationBuilder.RenameColumn(
                name: "active",
                table: "Seminars",
                newName: "Active");

            migrationBuilder.AddColumn<string>(
                name: "HostedBy",
                table: "Seminars",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Seminars",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2020, 11, 1, 22, 17, 54, 502, DateTimeKind.Local).AddTicks(7631));

            migrationBuilder.UpdateData(
                table: "Seminars",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2020, 10, 23, 22, 17, 54, 510, DateTimeKind.Local).AddTicks(58));

            migrationBuilder.UpdateData(
                table: "Seminars",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2020, 10, 29, 22, 17, 54, 510, DateTimeKind.Local).AddTicks(262));

            migrationBuilder.UpdateData(
                table: "Seminars",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateTime",
                value: new DateTime(2020, 11, 15, 22, 17, 54, 510, DateTimeKind.Local).AddTicks(278));

            migrationBuilder.UpdateData(
                table: "Seminars",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateTime",
                value: new DateTime(2020, 10, 15, 22, 17, 54, 510, DateTimeKind.Local).AddTicks(290));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HostedBy",
                table: "Seminars");

            migrationBuilder.RenameColumn(
                name: "AvailableSeats",
                table: "Seminars",
                newName: "availableSeats");

            migrationBuilder.RenameColumn(
                name: "Active",
                table: "Seminars",
                newName: "active");

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
    }
}
