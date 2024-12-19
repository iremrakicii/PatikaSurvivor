using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PatikaSurvivor.Migrations
{
    /// <inheritdoc />
    public partial class surv : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 19, 11, 15, 18, 31, DateTimeKind.Local).AddTicks(9322));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 19, 11, 15, 18, 31, DateTimeKind.Local).AddTicks(9552));

            migrationBuilder.UpdateData(
                table: "Competitors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 19, 11, 15, 18, 27, DateTimeKind.Local).AddTicks(7372));

            migrationBuilder.UpdateData(
                table: "Competitors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 19, 11, 15, 18, 31, DateTimeKind.Local).AddTicks(4073));

            migrationBuilder.UpdateData(
                table: "Competitors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 19, 11, 15, 18, 31, DateTimeKind.Local).AddTicks(4089));

            migrationBuilder.UpdateData(
                table: "Competitors",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 19, 11, 15, 18, 31, DateTimeKind.Local).AddTicks(4091));

            migrationBuilder.UpdateData(
                table: "Competitors",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 19, 11, 15, 18, 31, DateTimeKind.Local).AddTicks(4092));

            migrationBuilder.UpdateData(
                table: "Competitors",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 19, 11, 15, 18, 31, DateTimeKind.Local).AddTicks(4095));

            migrationBuilder.UpdateData(
                table: "Competitors",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 19, 11, 15, 18, 31, DateTimeKind.Local).AddTicks(4096));

            migrationBuilder.UpdateData(
                table: "Competitors",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 19, 11, 15, 18, 31, DateTimeKind.Local).AddTicks(4097));

            migrationBuilder.UpdateData(
                table: "Competitors",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 19, 11, 15, 18, 31, DateTimeKind.Local).AddTicks(4098));

            migrationBuilder.UpdateData(
                table: "Competitors",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 19, 11, 15, 18, 31, DateTimeKind.Local).AddTicks(4099));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 19, 11, 11, 19, 800, DateTimeKind.Local).AddTicks(3513));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 19, 11, 11, 19, 800, DateTimeKind.Local).AddTicks(3762));

            migrationBuilder.UpdateData(
                table: "Competitors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 19, 11, 11, 19, 795, DateTimeKind.Local).AddTicks(1731));

            migrationBuilder.UpdateData(
                table: "Competitors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 19, 11, 11, 19, 799, DateTimeKind.Local).AddTicks(7292));

            migrationBuilder.UpdateData(
                table: "Competitors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 19, 11, 11, 19, 799, DateTimeKind.Local).AddTicks(7310));

            migrationBuilder.UpdateData(
                table: "Competitors",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 19, 11, 11, 19, 799, DateTimeKind.Local).AddTicks(7312));

            migrationBuilder.UpdateData(
                table: "Competitors",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 19, 11, 11, 19, 799, DateTimeKind.Local).AddTicks(7313));

            migrationBuilder.UpdateData(
                table: "Competitors",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 19, 11, 11, 19, 799, DateTimeKind.Local).AddTicks(7314));

            migrationBuilder.UpdateData(
                table: "Competitors",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 19, 11, 11, 19, 799, DateTimeKind.Local).AddTicks(7315));

            migrationBuilder.UpdateData(
                table: "Competitors",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 19, 11, 11, 19, 799, DateTimeKind.Local).AddTicks(7316));

            migrationBuilder.UpdateData(
                table: "Competitors",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 19, 11, 11, 19, 799, DateTimeKind.Local).AddTicks(7317));

            migrationBuilder.UpdateData(
                table: "Competitors",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 19, 11, 11, 19, 799, DateTimeKind.Local).AddTicks(7318));
        }
    }
}
