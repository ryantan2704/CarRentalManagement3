using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement3.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 29, 15, 53, 49, 233, DateTimeKind.Local).AddTicks(2546), new DateTime(2024, 11, 29, 15, 53, 49, 233, DateTimeKind.Local).AddTicks(2559) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 29, 15, 53, 49, 233, DateTimeKind.Local).AddTicks(2561), new DateTime(2024, 11, 29, 15, 53, 49, 233, DateTimeKind.Local).AddTicks(2562) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 29, 15, 53, 49, 233, DateTimeKind.Local).AddTicks(2824), new DateTime(2024, 11, 29, 15, 53, 49, 233, DateTimeKind.Local).AddTicks(2824) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 29, 15, 53, 49, 233, DateTimeKind.Local).AddTicks(2826), new DateTime(2024, 11, 29, 15, 53, 49, 233, DateTimeKind.Local).AddTicks(2827) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 29, 15, 53, 49, 233, DateTimeKind.Local).AddTicks(3042), new DateTime(2024, 11, 29, 15, 53, 49, 233, DateTimeKind.Local).AddTicks(3043) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 29, 15, 53, 49, 233, DateTimeKind.Local).AddTicks(3045), new DateTime(2024, 11, 29, 15, 53, 49, 233, DateTimeKind.Local).AddTicks(3046) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 29, 15, 53, 49, 233, DateTimeKind.Local).AddTicks(3047), new DateTime(2024, 11, 29, 15, 53, 49, 233, DateTimeKind.Local).AddTicks(3048) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 29, 15, 53, 49, 233, DateTimeKind.Local).AddTicks(3049), new DateTime(2024, 11, 29, 15, 53, 49, 233, DateTimeKind.Local).AddTicks(3050) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 29, 15, 47, 58, 537, DateTimeKind.Local).AddTicks(5292), new DateTime(2024, 11, 29, 15, 47, 58, 537, DateTimeKind.Local).AddTicks(5309) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 29, 15, 47, 58, 537, DateTimeKind.Local).AddTicks(5312), new DateTime(2024, 11, 29, 15, 47, 58, 537, DateTimeKind.Local).AddTicks(5313) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 29, 15, 47, 58, 537, DateTimeKind.Local).AddTicks(6921), new DateTime(2024, 11, 29, 15, 47, 58, 537, DateTimeKind.Local).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 29, 15, 47, 58, 537, DateTimeKind.Local).AddTicks(6928), new DateTime(2024, 11, 29, 15, 47, 58, 537, DateTimeKind.Local).AddTicks(6928) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 29, 15, 47, 58, 537, DateTimeKind.Local).AddTicks(7056), new DateTime(2024, 11, 29, 15, 47, 58, 537, DateTimeKind.Local).AddTicks(7057) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 29, 15, 47, 58, 537, DateTimeKind.Local).AddTicks(7059), new DateTime(2024, 11, 29, 15, 47, 58, 537, DateTimeKind.Local).AddTicks(7060) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 29, 15, 47, 58, 537, DateTimeKind.Local).AddTicks(7062), new DateTime(2024, 11, 29, 15, 47, 58, 537, DateTimeKind.Local).AddTicks(7062) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 29, 15, 47, 58, 537, DateTimeKind.Local).AddTicks(7064), new DateTime(2024, 11, 29, 15, 47, 58, 537, DateTimeKind.Local).AddTicks(7065) });
        }
    }
}
