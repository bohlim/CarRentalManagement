using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "96856200-9b92-40e8-90c4-3622dff6d334", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEOnBBDyRbdJky4hmdtkIuLwZHaIETbv7FIMrweIzBfT+ueWRWGbcFpI3vMF2qJTDng==", null, false, "41655a62-4486-4cb5-bec8-6a2d65e6b78c", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 22, 22, 51, 53, 236, DateTimeKind.Local).AddTicks(4260), new DateTime(2024, 11, 22, 22, 51, 53, 236, DateTimeKind.Local).AddTicks(4278) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 22, 22, 51, 53, 236, DateTimeKind.Local).AddTicks(4282), new DateTime(2024, 11, 22, 22, 51, 53, 236, DateTimeKind.Local).AddTicks(4283) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 22, 22, 51, 53, 236, DateTimeKind.Local).AddTicks(4718), new DateTime(2024, 11, 22, 22, 51, 53, 236, DateTimeKind.Local).AddTicks(4719) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 22, 22, 51, 53, 236, DateTimeKind.Local).AddTicks(4722), new DateTime(2024, 11, 22, 22, 51, 53, 236, DateTimeKind.Local).AddTicks(4723) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 22, 22, 51, 53, 236, DateTimeKind.Local).AddTicks(4854), new DateTime(2024, 11, 22, 22, 51, 53, 236, DateTimeKind.Local).AddTicks(4855) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 22, 22, 51, 53, 236, DateTimeKind.Local).AddTicks(4858), new DateTime(2024, 11, 22, 22, 51, 53, 236, DateTimeKind.Local).AddTicks(4858) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 22, 22, 51, 53, 236, DateTimeKind.Local).AddTicks(4860), new DateTime(2024, 11, 22, 22, 51, 53, 236, DateTimeKind.Local).AddTicks(4861) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 22, 22, 51, 53, 236, DateTimeKind.Local).AddTicks(4863), new DateTime(2024, 11, 22, 22, 51, 53, 236, DateTimeKind.Local).AddTicks(4864) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

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
                values: new object[] { new DateTime(2024, 11, 22, 22, 1, 26, 644, DateTimeKind.Local).AddTicks(2268), new DateTime(2024, 11, 22, 22, 1, 26, 644, DateTimeKind.Local).AddTicks(2285) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 22, 22, 1, 26, 644, DateTimeKind.Local).AddTicks(2289), new DateTime(2024, 11, 22, 22, 1, 26, 644, DateTimeKind.Local).AddTicks(2290) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 22, 22, 1, 26, 644, DateTimeKind.Local).AddTicks(2763), new DateTime(2024, 11, 22, 22, 1, 26, 644, DateTimeKind.Local).AddTicks(2764) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 22, 22, 1, 26, 644, DateTimeKind.Local).AddTicks(2767), new DateTime(2024, 11, 22, 22, 1, 26, 644, DateTimeKind.Local).AddTicks(2768) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 22, 22, 1, 26, 644, DateTimeKind.Local).AddTicks(2894), new DateTime(2024, 11, 22, 22, 1, 26, 644, DateTimeKind.Local).AddTicks(2895) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 22, 22, 1, 26, 644, DateTimeKind.Local).AddTicks(2897), new DateTime(2024, 11, 22, 22, 1, 26, 644, DateTimeKind.Local).AddTicks(2898) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 22, 22, 1, 26, 644, DateTimeKind.Local).AddTicks(2900), new DateTime(2024, 11, 22, 22, 1, 26, 644, DateTimeKind.Local).AddTicks(2901) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 22, 22, 1, 26, 644, DateTimeKind.Local).AddTicks(2902), new DateTime(2024, 11, 22, 22, 1, 26, 644, DateTimeKind.Local).AddTicks(2903) });
        }
    }
}
