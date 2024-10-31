using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Labb3_InformationSystem.Migrations
{
    /// <inheritdoc />
    public partial class SeedEvents : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2e1b6c3f-e7ec-457b-ba62-7191a147fb1a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "46700c6b-1e0d-46a1-9cbd-0463170ea0d0");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "242c0cf6-7215-4a24-953b-78a02b10ba32", null, "Admin", "ADMIN" },
                    { "e14f9429-45ac-40ce-b307-71cc06abf5ec", null, "Employee", "EMPLOYEE" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "56e819a4-b09b-40ab-a1b0-7a0262dd9f5d", "AQAAAAIAAYagAAAAEEkNqD02aTDf0yqGfcNOmZZfP0GvuQ6pAllkhHN7/Q7CJ+gD/pWYSQnsGfyMXDIBkg==", "e6555cb3-dbe8-4a88-aabf-3333146b73b1" });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "DriverID",
                keyValue: 1,
                columns: new[] { "NoteDate", "NoteDescription" },
                values: new object[] { new DateTime(2024, 10, 30, 19, 37, 56, 273, DateTimeKind.Utc).AddTicks(5526), "Service på bil" });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "DriverID",
                keyValue: 2,
                columns: new[] { "NoteDate", "NoteDescription" },
                values: new object[] { new DateTime(2024, 10, 29, 19, 37, 56, 273, DateTimeKind.Utc).AddTicks(5537), "Bytte däck" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 1,
                column: "Password",
                value: "AQAAAAIAAYagAAAAEBTUtA3DF/XXonnX4sDm3YCByiNZx2urAoxDm6dsYQzGEfQfham9MQF38/clwPuIjg==");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 2,
                column: "Password",
                value: "AQAAAAIAAYagAAAAEA9BAg+fd/VpBo4fWzWAS5esDbq5aAbzAv/obA/KzDIx9lAG6PZX3KSJ54UjQQ08mw==");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 3,
                column: "Password",
                value: "AQAAAAIAAYagAAAAEMz4Kyjhqj58F9Izfk0SAj1LNMJET+LXhhM3l56AZBT7XsmjPCglYUdbMOG7HYcSJQ==");

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "EventID", "Description", "DriverID", "EventDate" },
                values: new object[,]
                {
                    { 1, "Förare Anton genomförde en service på bilen.", 1, new DateTime(2024, 10, 30, 19, 37, 56, 422, DateTimeKind.Utc).AddTicks(6246) },
                    { 2, "Förare Adam bytte däck.", 2, new DateTime(2024, 10, 29, 19, 37, 56, 422, DateTimeKind.Utc).AddTicks(6252) },
                    { 3, "Förare Anton hade en incident med en annan bil.", 1, new DateTime(2024, 10, 28, 19, 37, 56, 422, DateTimeKind.Utc).AddTicks(6259) },
                    { 4, "Förare Adam genomförde en rutinkontroll.", 2, new DateTime(2024, 10, 27, 19, 37, 56, 422, DateTimeKind.Utc).AddTicks(6261) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "242c0cf6-7215-4a24-953b-78a02b10ba32");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e14f9429-45ac-40ce-b307-71cc06abf5ec");

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 4);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2e1b6c3f-e7ec-457b-ba62-7191a147fb1a", null, "Admin", "ADMIN" },
                    { "46700c6b-1e0d-46a1-9cbd-0463170ea0d0", null, "Employee", "EMPLOYEE" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2be33145-2332-4c2b-85b6-ca4e26b448f8", "AQAAAAIAAYagAAAAEETQ6teCxUI6ZpUyzqdHTpxbmyMrHiysOgLp8P528RoLOHLywdyDytbpcqmrrwHvrQ==", "0cfa9007-720b-4b16-9e25-3e7172f5fcdd" });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "DriverID",
                keyValue: 1,
                columns: new[] { "NoteDate", "NoteDescription" },
                values: new object[] { new DateTime(2024, 10, 30, 19, 9, 15, 291, DateTimeKind.Utc).AddTicks(7256), "Ny bilruta" });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "DriverID",
                keyValue: 2,
                columns: new[] { "NoteDate", "NoteDescription" },
                values: new object[] { new DateTime(2024, 10, 29, 19, 9, 15, 291, DateTimeKind.Utc).AddTicks(7269), "Ny motor" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 1,
                column: "Password",
                value: "AQAAAAIAAYagAAAAEPnVLO2KgHCE+6nXvRCMJSDHyKsFvyEaqHMySB0HyonjSohbxuB9Gdm6P/WuYWgv6A==");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 2,
                column: "Password",
                value: "AQAAAAIAAYagAAAAEHLc1YD3Mr3MJnMFnm1CWCXmksMqDUbiNm6TnUmJABrjPIhhhirWMp6prkvfo3V+oQ==");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 3,
                column: "Password",
                value: "AQAAAAIAAYagAAAAEOMzP6QQ0d2btFxfeByJj3BiJzs1U1k0qEmaFkind6JGxjFHKwEEDlr9n+cd4EzjgQ==");
        }
    }
}
