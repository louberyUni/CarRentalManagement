using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRoles : Migration
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
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "c1951309-66f7-4750-b3f6-19d8086c31ad", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAENKiGVnTrpo0W+Of1iWH9In7YX4lzG25jD9YEeuwl7SP/oou7K7Ra72UYpkbNq56yQ==", null, false, "6a794378-2bc9-4dc7-a59e-092bcafe7d9f", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 11, 26, 10, 42, 41, 174, DateTimeKind.Local).AddTicks(9028), new DateTime(2025, 11, 26, 10, 42, 41, 174, DateTimeKind.Local).AddTicks(9040) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 11, 26, 10, 42, 41, 174, DateTimeKind.Local).AddTicks(9042), new DateTime(2025, 11, 26, 10, 42, 41, 174, DateTimeKind.Local).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 11, 26, 10, 42, 41, 174, DateTimeKind.Local).AddTicks(9229), new DateTime(2025, 11, 26, 10, 42, 41, 174, DateTimeKind.Local).AddTicks(9229) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 11, 26, 10, 42, 41, 174, DateTimeKind.Local).AddTicks(9232), new DateTime(2025, 11, 26, 10, 42, 41, 174, DateTimeKind.Local).AddTicks(9232) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 11, 26, 10, 42, 41, 174, DateTimeKind.Local).AddTicks(9355), new DateTime(2025, 11, 26, 10, 42, 41, 174, DateTimeKind.Local).AddTicks(9356) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 11, 26, 10, 42, 41, 174, DateTimeKind.Local).AddTicks(9358), new DateTime(2025, 11, 26, 10, 42, 41, 174, DateTimeKind.Local).AddTicks(9358) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 11, 26, 10, 42, 41, 174, DateTimeKind.Local).AddTicks(9360), new DateTime(2025, 11, 26, 10, 42, 41, 174, DateTimeKind.Local).AddTicks(9360) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 11, 26, 10, 42, 41, 174, DateTimeKind.Local).AddTicks(9363), new DateTime(2025, 11, 26, 10, 42, 41, 174, DateTimeKind.Local).AddTicks(9363) });

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
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 29, 12, 348, DateTimeKind.Local).AddTicks(894), new DateTime(2025, 11, 26, 9, 29, 12, 348, DateTimeKind.Local).AddTicks(911) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 29, 12, 348, DateTimeKind.Local).AddTicks(914), new DateTime(2025, 11, 26, 9, 29, 12, 348, DateTimeKind.Local).AddTicks(915) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 29, 12, 348, DateTimeKind.Local).AddTicks(1156), new DateTime(2025, 11, 26, 9, 29, 12, 348, DateTimeKind.Local).AddTicks(1157) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 29, 12, 348, DateTimeKind.Local).AddTicks(1159), new DateTime(2025, 11, 26, 9, 29, 12, 348, DateTimeKind.Local).AddTicks(1160) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 29, 12, 348, DateTimeKind.Local).AddTicks(1258), new DateTime(2025, 11, 26, 9, 29, 12, 348, DateTimeKind.Local).AddTicks(1259) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 29, 12, 348, DateTimeKind.Local).AddTicks(1261), new DateTime(2025, 11, 26, 9, 29, 12, 348, DateTimeKind.Local).AddTicks(1262) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 29, 12, 348, DateTimeKind.Local).AddTicks(1264), new DateTime(2025, 11, 26, 9, 29, 12, 348, DateTimeKind.Local).AddTicks(1265) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 29, 12, 348, DateTimeKind.Local).AddTicks(1267), new DateTime(2025, 11, 26, 9, 29, 12, 348, DateTimeKind.Local).AddTicks(1267) });
        }
    }
}
