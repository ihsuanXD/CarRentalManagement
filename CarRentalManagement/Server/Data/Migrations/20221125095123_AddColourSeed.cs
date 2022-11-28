using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddColourSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 25, 17, 51, 23, 293, DateTimeKind.Local).AddTicks(2153), new DateTime(2022, 11, 25, 17, 51, 23, 294, DateTimeKind.Local).AddTicks(2488) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 25, 17, 51, 23, 294, DateTimeKind.Local).AddTicks(3674), new DateTime(2022, 11, 25, 17, 51, 23, 294, DateTimeKind.Local).AddTicks(3681) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 25, 17, 51, 23, 295, DateTimeKind.Local).AddTicks(7448), new DateTime(2022, 11, 25, 17, 51, 23, 295, DateTimeKind.Local).AddTicks(7458) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 25, 17, 51, 23, 295, DateTimeKind.Local).AddTicks(7462), new DateTime(2022, 11, 25, 17, 51, 23, 295, DateTimeKind.Local).AddTicks(7463) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 25, 17, 51, 23, 296, DateTimeKind.Local).AddTicks(1833), new DateTime(2022, 11, 25, 17, 51, 23, 296, DateTimeKind.Local).AddTicks(1842) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 25, 17, 51, 23, 296, DateTimeKind.Local).AddTicks(1846), new DateTime(2022, 11, 25, 17, 51, 23, 296, DateTimeKind.Local).AddTicks(1847) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 25, 17, 51, 23, 296, DateTimeKind.Local).AddTicks(1849), new DateTime(2022, 11, 25, 17, 51, 23, 296, DateTimeKind.Local).AddTicks(1850) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 25, 17, 51, 23, 296, DateTimeKind.Local).AddTicks(1852), new DateTime(2022, 11, 25, 17, 51, 23, 296, DateTimeKind.Local).AddTicks(1853) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 25, 11, 9, 12, 263, DateTimeKind.Local).AddTicks(5549), new DateTime(2022, 11, 25, 11, 9, 12, 264, DateTimeKind.Local).AddTicks(6156) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 25, 11, 9, 12, 264, DateTimeKind.Local).AddTicks(7365), new DateTime(2022, 11, 25, 11, 9, 12, 264, DateTimeKind.Local).AddTicks(7371) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 25, 11, 9, 12, 266, DateTimeKind.Local).AddTicks(1905), new DateTime(2022, 11, 25, 11, 9, 12, 266, DateTimeKind.Local).AddTicks(1916) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 25, 11, 9, 12, 266, DateTimeKind.Local).AddTicks(1920), new DateTime(2022, 11, 25, 11, 9, 12, 266, DateTimeKind.Local).AddTicks(1922) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 25, 11, 9, 12, 266, DateTimeKind.Local).AddTicks(6572), new DateTime(2022, 11, 25, 11, 9, 12, 266, DateTimeKind.Local).AddTicks(6580) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 25, 11, 9, 12, 266, DateTimeKind.Local).AddTicks(6584), new DateTime(2022, 11, 25, 11, 9, 12, 266, DateTimeKind.Local).AddTicks(6586) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 25, 11, 9, 12, 266, DateTimeKind.Local).AddTicks(6588), new DateTime(2022, 11, 25, 11, 9, 12, 266, DateTimeKind.Local).AddTicks(6589) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 25, 11, 9, 12, 266, DateTimeKind.Local).AddTicks(6591), new DateTime(2022, 11, 25, 11, 9, 12, 266, DateTimeKind.Local).AddTicks(6592) });
        }
    }
}
