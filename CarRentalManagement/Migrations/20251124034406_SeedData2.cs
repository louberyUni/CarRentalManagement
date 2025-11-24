using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Model",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "Model",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "Model",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Model",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 11, 24, 11, 44, 5, 723, DateTimeKind.Local).AddTicks(715), new DateTime(2025, 11, 24, 11, 44, 5, 723, DateTimeKind.Local).AddTicks(727) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 11, 24, 11, 44, 5, 723, DateTimeKind.Local).AddTicks(730), new DateTime(2025, 11, 24, 11, 44, 5, 723, DateTimeKind.Local).AddTicks(731) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedBy", "CreationDate", "UpdateDate", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2025, 11, 24, 11, 44, 5, 723, DateTimeKind.Local).AddTicks(1139), new DateTime(2025, 11, 24, 11, 44, 5, 723, DateTimeKind.Local).AddTicks(1141), "System" });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedBy", "CreationDate", "UpdateDate", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2025, 11, 24, 11, 44, 5, 723, DateTimeKind.Local).AddTicks(1144), new DateTime(2025, 11, 24, 11, 44, 5, 723, DateTimeKind.Local).AddTicks(1145), "System" });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedBy", "CreationDate", "UpdateDate", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2025, 11, 24, 11, 44, 5, 723, DateTimeKind.Local).AddTicks(1234), new DateTime(2025, 11, 24, 11, 44, 5, 723, DateTimeKind.Local).AddTicks(1235), "System" });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedBy", "CreationDate", "UpdateDate", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2025, 11, 24, 11, 44, 5, 723, DateTimeKind.Local).AddTicks(1237), new DateTime(2025, 11, 24, 11, 44, 5, 723, DateTimeKind.Local).AddTicks(1238), "System" });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedBy", "CreationDate", "UpdateDate", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2025, 11, 24, 11, 44, 5, 723, DateTimeKind.Local).AddTicks(1240), new DateTime(2025, 11, 24, 11, 44, 5, 723, DateTimeKind.Local).AddTicks(1241), "System" });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedBy", "CreationDate", "UpdateDate", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2025, 11, 24, 11, 44, 5, 723, DateTimeKind.Local).AddTicks(1243), new DateTime(2025, 11, 24, 11, 44, 5, 723, DateTimeKind.Local).AddTicks(1243), "System" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Model");

            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "Model");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "Model");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Model");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 11, 24, 11, 40, 12, 923, DateTimeKind.Local).AddTicks(2334), new DateTime(2025, 11, 24, 11, 40, 12, 923, DateTimeKind.Local).AddTicks(2346) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 11, 24, 11, 40, 12, 923, DateTimeKind.Local).AddTicks(2349), new DateTime(2025, 11, 24, 11, 40, 12, 923, DateTimeKind.Local).AddTicks(2350) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedBy", "CreationDate", "UpdateDate", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedBy", "CreationDate", "UpdateDate", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });
        }
    }
}
