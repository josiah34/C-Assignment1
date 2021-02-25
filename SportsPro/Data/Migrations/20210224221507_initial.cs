using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SportsPro.Data.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Incident",
                keyColumn: "IncidentId",
                keyValue: 1,
                column: "DateOpened",
                value: new DateTime(2021, 2, 24, 17, 15, 7, 407, DateTimeKind.Local).AddTicks(8433));

            migrationBuilder.UpdateData(
                table: "Incident",
                keyColumn: "IncidentId",
                keyValue: 2,
                column: "DateOpened",
                value: new DateTime(2021, 2, 24, 17, 15, 7, 407, DateTimeKind.Local).AddTicks(8914));

            migrationBuilder.UpdateData(
                table: "Incident",
                keyColumn: "IncidentId",
                keyValue: 3,
                column: "DateOpened",
                value: new DateTime(2021, 2, 24, 17, 15, 7, 407, DateTimeKind.Local).AddTicks(8937));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "ReleaseDate",
                value: new DateTime(2021, 2, 24, 17, 15, 7, 402, DateTimeKind.Local).AddTicks(506));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "ReleaseDate",
                value: new DateTime(2021, 2, 24, 17, 15, 7, 407, DateTimeKind.Local).AddTicks(2867));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "ReleaseDate",
                value: new DateTime(2021, 2, 24, 17, 15, 7, 407, DateTimeKind.Local).AddTicks(2914));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Incident",
                keyColumn: "IncidentId",
                keyValue: 1,
                column: "DateOpened",
                value: new DateTime(2021, 2, 20, 15, 39, 0, 930, DateTimeKind.Local).AddTicks(123));

            migrationBuilder.UpdateData(
                table: "Incident",
                keyColumn: "IncidentId",
                keyValue: 2,
                column: "DateOpened",
                value: new DateTime(2021, 2, 20, 15, 39, 0, 930, DateTimeKind.Local).AddTicks(839));

            migrationBuilder.UpdateData(
                table: "Incident",
                keyColumn: "IncidentId",
                keyValue: 3,
                column: "DateOpened",
                value: new DateTime(2021, 2, 20, 15, 39, 0, 930, DateTimeKind.Local).AddTicks(870));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "ReleaseDate",
                value: new DateTime(2021, 2, 20, 15, 39, 0, 924, DateTimeKind.Local).AddTicks(5224));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "ReleaseDate",
                value: new DateTime(2021, 2, 20, 15, 39, 0, 929, DateTimeKind.Local).AddTicks(1950));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "ReleaseDate",
                value: new DateTime(2021, 2, 20, 15, 39, 0, 929, DateTimeKind.Local).AddTicks(1995));
        }
    }
}
