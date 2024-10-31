using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Labb3_InformationSystem.Migrations
{
    /// <inheritdoc />
    public partial class Passwordforemployee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "99de4a9c-271f-4096-ad67-bf9198a59d8c", "AQAAAAIAAYagAAAAEAF7K8D7UM/D96vC1PJHZvTxPpttc+WWebAdkyh58I0ulVs6vmYyG7LkDkq+wjcs0Q==", "156dbf08-241a-4209-b0e0-8ee05024c26f" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "employee-id", 0, "56b8e970-22c5-41e6-8564-7d9676da8963", "employee@example.com", true, false, null, "EMPLOYEE@EXAMPLE.COM", "EMPLOYEE@EXAMPLE.COM", "AQAAAAIAAYagAAAAEAGOFKyp02rLeQJ7s4epmS2JZ8yCNwtC7b/yiMn8tc71ssGnHrYjJ4va0zuu3zK1Gg==", null, false, "41a1992f-ba13-4883-82c1-6ed59290fa8a", false, "employee@example.com" });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "DriverID",
                keyValue: 1,
                column: "NoteDate",
                value: new DateTime(2024, 10, 31, 0, 28, 32, 525, DateTimeKind.Utc).AddTicks(2731));

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "DriverID",
                keyValue: 2,
                column: "NoteDate",
                value: new DateTime(2024, 10, 30, 0, 28, 32, 525, DateTimeKind.Utc).AddTicks(2742));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 1,
                column: "IdentityUserId",
                value: "employee-id");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 2,
                column: "IdentityUserId",
                value: "employee-id");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 3,
                column: "IdentityUserId",
                value: "admin-id");

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 1,
                column: "EventDate",
                value: new DateTime(2024, 10, 31, 0, 28, 32, 525, DateTimeKind.Utc).AddTicks(2847));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 2,
                column: "EventDate",
                value: new DateTime(2024, 10, 30, 0, 28, 32, 525, DateTimeKind.Utc).AddTicks(2851));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 3,
                column: "EventDate",
                value: new DateTime(2024, 10, 29, 0, 28, 32, 525, DateTimeKind.Utc).AddTicks(2852));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 4,
                column: "EventDate",
                value: new DateTime(2024, 10, 28, 0, 28, 32, 525, DateTimeKind.Utc).AddTicks(2853));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "employee-role-id", "employee-id" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "employee-role-id", "employee-id" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "employee-id");

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
                column: "IdentityUserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 2,
                column: "IdentityUserId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 3,
                column: "IdentityUserId",
                value: null);

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
        }
    }
}
