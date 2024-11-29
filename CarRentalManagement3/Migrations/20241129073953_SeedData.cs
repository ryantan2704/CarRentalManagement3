using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement3.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 29, 15, 39, 52, 360, DateTimeKind.Local).AddTicks(4322), new DateTime(2024, 11, 29, 15, 39, 52, 360, DateTimeKind.Local).AddTicks(4338), "Black", "System" },
                    { 2, "System", new DateTime(2024, 11, 29, 15, 39, 52, 360, DateTimeKind.Local).AddTicks(4341), new DateTime(2024, 11, 29, 15, 39, 52, 360, DateTimeKind.Local).AddTicks(4342), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 29, 15, 39, 52, 360, DateTimeKind.Local).AddTicks(4597), new DateTime(2024, 11, 29, 15, 39, 52, 360, DateTimeKind.Local).AddTicks(4598), "BMW", "System" },
                    { 2, "System", new DateTime(2024, 11, 29, 15, 39, 52, 360, DateTimeKind.Local).AddTicks(4601), new DateTime(2024, 11, 29, 15, 39, 52, 360, DateTimeKind.Local).AddTicks(4602), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 29, 15, 39, 52, 360, DateTimeKind.Local).AddTicks(4702), new DateTime(2024, 11, 29, 15, 39, 52, 360, DateTimeKind.Local).AddTicks(4703), "i4", "System" },
                    { 2, "System", new DateTime(2024, 11, 29, 15, 39, 52, 360, DateTimeKind.Local).AddTicks(4706), new DateTime(2024, 11, 29, 15, 39, 52, 360, DateTimeKind.Local).AddTicks(4706), "X5", "System" },
                    { 3, "System", new DateTime(2024, 11, 29, 15, 39, 52, 360, DateTimeKind.Local).AddTicks(4708), new DateTime(2024, 11, 29, 15, 39, 52, 360, DateTimeKind.Local).AddTicks(4709), "Prius", "System" },
                    { 4, "System", new DateTime(2024, 11, 29, 15, 39, 52, 360, DateTimeKind.Local).AddTicks(4711), new DateTime(2024, 11, 29, 15, 39, 52, 360, DateTimeKind.Local).AddTicks(4712), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
