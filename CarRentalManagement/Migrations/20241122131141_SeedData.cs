using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
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
                    { 1, "System", new DateTime(2024, 11, 22, 21, 11, 40, 451, DateTimeKind.Local).AddTicks(9802), new DateTime(2024, 11, 22, 21, 11, 40, 451, DateTimeKind.Local).AddTicks(9820), "Black", "System" },
                    { 2, "System", new DateTime(2024, 11, 22, 21, 11, 40, 451, DateTimeKind.Local).AddTicks(9823), new DateTime(2024, 11, 22, 21, 11, 40, 451, DateTimeKind.Local).AddTicks(9824), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 22, 21, 11, 40, 452, DateTimeKind.Local).AddTicks(256), new DateTime(2024, 11, 22, 21, 11, 40, 452, DateTimeKind.Local).AddTicks(258), "BMW", "System" },
                    { 2, "System", new DateTime(2024, 11, 22, 21, 11, 40, 452, DateTimeKind.Local).AddTicks(260), new DateTime(2024, 11, 22, 21, 11, 40, 452, DateTimeKind.Local).AddTicks(261), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 22, 21, 11, 40, 452, DateTimeKind.Local).AddTicks(369), new DateTime(2024, 11, 22, 21, 11, 40, 452, DateTimeKind.Local).AddTicks(370), "i4", "System" },
                    { 2, "System", new DateTime(2024, 11, 22, 21, 11, 40, 452, DateTimeKind.Local).AddTicks(373), new DateTime(2024, 11, 22, 21, 11, 40, 452, DateTimeKind.Local).AddTicks(373), "x5", "System" },
                    { 3, "System", new DateTime(2024, 11, 22, 21, 11, 40, 452, DateTimeKind.Local).AddTicks(375), new DateTime(2024, 11, 22, 21, 11, 40, 452, DateTimeKind.Local).AddTicks(376), "Prius", "System" },
                    { 4, "System", new DateTime(2024, 11, 22, 21, 11, 40, 452, DateTimeKind.Local).AddTicks(378), new DateTime(2024, 11, 22, 21, 11, 40, 452, DateTimeKind.Local).AddTicks(378), "C-HR", "System" }
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
