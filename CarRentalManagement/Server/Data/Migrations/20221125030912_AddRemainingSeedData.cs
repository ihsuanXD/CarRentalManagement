using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddRemainingSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 11, 25, 11, 9, 12, 266, DateTimeKind.Local).AddTicks(1905), new DateTime(2022, 11, 25, 11, 9, 12, 266, DateTimeKind.Local).AddTicks(1916), "BMW", "System" },
                    { 2, "System", new DateTime(2022, 11, 25, 11, 9, 12, 266, DateTimeKind.Local).AddTicks(1920), new DateTime(2022, 11, 25, 11, 9, 12, 266, DateTimeKind.Local).AddTicks(1922), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 11, 25, 11, 9, 12, 266, DateTimeKind.Local).AddTicks(6572), new DateTime(2022, 11, 25, 11, 9, 12, 266, DateTimeKind.Local).AddTicks(6580), "3 Series", "System" },
                    { 2, "System", new DateTime(2022, 11, 25, 11, 9, 12, 266, DateTimeKind.Local).AddTicks(6584), new DateTime(2022, 11, 25, 11, 9, 12, 266, DateTimeKind.Local).AddTicks(6586), "Prius", "System" },
                    { 3, "System", new DateTime(2022, 11, 25, 11, 9, 12, 266, DateTimeKind.Local).AddTicks(6588), new DateTime(2022, 11, 25, 11, 9, 12, 266, DateTimeKind.Local).AddTicks(6589), "X5", "System" },
                    { 4, "System", new DateTime(2022, 11, 25, 11, 9, 12, 266, DateTimeKind.Local).AddTicks(6591), new DateTime(2022, 11, 25, 11, 9, 12, 266, DateTimeKind.Local).AddTicks(6592), "Rav4", "System" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 22, 17, 0, 58, 752, DateTimeKind.Local).AddTicks(2321), new DateTime(2022, 11, 22, 17, 0, 58, 753, DateTimeKind.Local).AddTicks(3601) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 11, 22, 17, 0, 58, 753, DateTimeKind.Local).AddTicks(5383), new DateTime(2022, 11, 22, 17, 0, 58, 753, DateTimeKind.Local).AddTicks(5390) });
        }
    }
}
