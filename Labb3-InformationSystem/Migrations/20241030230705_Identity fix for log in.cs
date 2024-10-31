using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Labb3_InformationSystem.Migrations
{
    /// <inheritdoc />
    public partial class Identityfixforlogin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "242c0cf6-7215-4a24-953b-78a02b10ba32");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e14f9429-45ac-40ce-b307-71cc06abf5ec");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Employees");

            migrationBuilder.AddColumn<string>(
                name: "IdentityUserId",
                table: "Employees",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "admin-role-id", null, "Admin", "ADMIN" },
                    { "employee-role-id", null, "Employee", "EMPLOYEE" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "43750c02-1017-401a-b888-66f9a0fad865", "AQAAAAIAAYagAAAAEJ2oItbdXdNSW7GNqXAsE5h+JdufPxzvBrA+CMEqbgfROZ1rZnoGGC2TjA3Bes4Tbw==", "ee753269-db66-4c37-b0a2-3c99f944f549" });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "DriverID",
                keyValue: 1,
                column: "NoteDate",
                value: new DateTime(2024, 10, 30, 23, 7, 4, 856, DateTimeKind.Utc).AddTicks(2314));

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "DriverID",
                keyValue: 2,
                column: "NoteDate",
                value: new DateTime(2024, 10, 29, 23, 7, 4, 856, DateTimeKind.Utc).AddTicks(2324));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 1,
                columns: new[] { "IdentityUserId", "Role" },
                values: new object[] { null, "Employee" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 2,
                columns: new[] { "IdentityUserId", "Role" },
                values: new object[] { null, "Employee" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 3,
                columns: new[] { "IdentityUserId", "Role" },
                values: new object[] { null, "Admin" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 1,
                column: "EventDate",
                value: new DateTime(2024, 10, 30, 23, 7, 4, 856, DateTimeKind.Utc).AddTicks(2405));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 2,
                column: "EventDate",
                value: new DateTime(2024, 10, 29, 23, 7, 4, 856, DateTimeKind.Utc).AddTicks(2408));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 3,
                column: "EventDate",
                value: new DateTime(2024, 10, 28, 23, 7, 4, 856, DateTimeKind.Utc).AddTicks(2409));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 4,
                column: "EventDate",
                value: new DateTime(2024, 10, 27, 23, 7, 4, 856, DateTimeKind.Utc).AddTicks(2410));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "admin-role-id", "admin-id" });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_IdentityUserId",
                table: "Employees",
                column: "IdentityUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_AspNetUsers_IdentityUserId",
                table: "Employees",
                column: "IdentityUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_AspNetUsers_IdentityUserId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_IdentityUserId",
                table: "Employees");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "employee-role-id");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "admin-role-id", "admin-id" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin-role-id");

            migrationBuilder.DropColumn(
                name: "IdentityUserId",
                table: "Employees");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Employees",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

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
                column: "NoteDate",
                value: new DateTime(2024, 10, 30, 19, 37, 56, 273, DateTimeKind.Utc).AddTicks(5526));

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "DriverID",
                keyValue: 2,
                column: "NoteDate",
                value: new DateTime(2024, 10, 29, 19, 37, 56, 273, DateTimeKind.Utc).AddTicks(5537));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 1,
                columns: new[] { "Password", "Role" },
                values: new object[] { "AQAAAAIAAYagAAAAEBTUtA3DF/XXonnX4sDm3YCByiNZx2urAoxDm6dsYQzGEfQfham9MQF38/clwPuIjg==", "Föraransvarig" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 2,
                columns: new[] { "Password", "Role" },
                values: new object[] { "AQAAAAIAAYagAAAAEA9BAg+fd/VpBo4fWzWAS5esDbq5aAbzAv/obA/KzDIx9lAG6PZX3KSJ54UjQQ08mw==", "Bilansvarig" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 3,
                columns: new[] { "Password", "Role" },
                values: new object[] { "AQAAAAIAAYagAAAAEMz4Kyjhqj58F9Izfk0SAj1LNMJET+LXhhM3l56AZBT7XsmjPCglYUdbMOG7HYcSJQ==", "Administratör" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 1,
                column: "EventDate",
                value: new DateTime(2024, 10, 30, 19, 37, 56, 422, DateTimeKind.Utc).AddTicks(6246));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 2,
                column: "EventDate",
                value: new DateTime(2024, 10, 29, 19, 37, 56, 422, DateTimeKind.Utc).AddTicks(6252));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 3,
                column: "EventDate",
                value: new DateTime(2024, 10, 28, 19, 37, 56, 422, DateTimeKind.Utc).AddTicks(6259));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 4,
                column: "EventDate",
                value: new DateTime(2024, 10, 27, 19, 37, 56, 422, DateTimeKind.Utc).AddTicks(6261));
        }
    }
}
