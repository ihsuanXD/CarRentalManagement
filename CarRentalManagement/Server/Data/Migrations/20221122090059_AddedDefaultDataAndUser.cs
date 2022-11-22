using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedDefaultDataAndUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[] { 1, "System", new DateTime(2022, 11, 22, 17, 0, 58, 752, DateTimeKind.Local).AddTicks(2321), new DateTime(2022, 11, 22, 17, 0, 58, 753, DateTimeKind.Local).AddTicks(3601), "Black", "System" });

            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[] { 2, "System", new DateTime(2022, 11, 22, 17, 0, 58, 753, DateTimeKind.Local).AddTicks(5383), new DateTime(2022, 11, 22, 17, 0, 58, 753, DateTimeKind.Local).AddTicks(5390), "Blue", "System" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "id",
                keyValue: 2);
        }
    }
}
