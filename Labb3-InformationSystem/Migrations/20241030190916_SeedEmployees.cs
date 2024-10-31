using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Labb3_InformationSystem.Migrations
{
    /// <inheritdoc />
    public partial class SeedEmployees : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2533bd4e-9edc-4add-aa2d-308130a96e91");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44444251-0b3c-4f86-953d-80100a364b06");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "employee-id-1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "employee-id-2");

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

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeID", "Email", "Name", "Password", "Role" },
                values: new object[,]
                {
                    { 1, "petter.svensson@example.com", "Petter Svensson", "AQAAAAIAAYagAAAAEPnVLO2KgHCE+6nXvRCMJSDHyKsFvyEaqHMySB0HyonjSohbxuB9Gdm6P/WuYWgv6A==", "Föraransvarig" },
                    { 2, "simon.karlsson@example.com", "Simon Karlsson", "AQAAAAIAAYagAAAAEHLc1YD3Mr3MJnMFnm1CWCXmksMqDUbiNm6TnUmJABrjPIhhhirWMp6prkvfo3V+oQ==", "Bilansvarig" },
                    { 3, "jessica.andersson@example.com", "Jessica Andersson", "AQAAAAIAAYagAAAAEOMzP6QQ0d2btFxfeByJj3BiJzs1U1k0qEmaFkind6JGxjFHKwEEDlr9n+cd4EzjgQ==", "Administratör" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2e1b6c3f-e7ec-457b-ba62-7191a147fb1a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "46700c6b-1e0d-46a1-9cbd-0463170ea0d0");

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeID",
                keyValue: 3);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2533bd4e-9edc-4add-aa2d-308130a96e91", null, "Admin", "ADMIN" },
                    { "44444251-0b3c-4f86-953d-80100a364b06", null, "Employee", "EMPLOYEE" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "69647260-1ef8-458a-982e-91d81d5c1ebc", "AQAAAAIAAYagAAAAEIQNHPl9Y3M1D3BROfvxEtgAPi0k1rMraF6z5toQn9udz7tU1MZ6nt+0Qy2THslJXg==", "bf535854-f864-45c4-8c20-9733ad34cdc9" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "employee-id-1", 0, "d9a28ad8-708b-4633-b8af-0d21d53a0b67", "petter@example.com", true, false, null, "PETTER@EXAMPLE.COM", "PETTER@EXAMPLE.COM", "AQAAAAIAAYagAAAAEARlbzxsHowudR/dEH71aT/OgKv6MPKH3gH2fmYSoIU5LHmQU5wT/HRIhSKvok+FsQ==", null, false, "549bf36f-b7a3-4653-9267-8619418681c0", false, "petter@example.com" },
                    { "employee-id-2", 0, "a4f7d50c-48dd-417c-a144-2d869c6d7fa8", "simon@example.com", true, false, null, "SIMON@EXAMPLE.COM", "SIMON@EXAMPLE.COM", "AQAAAAIAAYagAAAAEGa8K3KO/5aBTsPrCAn99T7lkwmHYn1QQ0Sd1ORRa7lTPXh9jhIOObfy4Lv++og5WA==", null, false, "3be82d8d-15ae-4b38-be2b-0832591cf313", false, "simon@example.com" }
                });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "DriverID",
                keyValue: 1,
                columns: new[] { "NoteDate", "NoteDescription" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 58, 10, 781, DateTimeKind.Utc).AddTicks(4461), "Första registreringen" });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "DriverID",
                keyValue: 2,
                columns: new[] { "NoteDate", "NoteDescription" },
                values: new object[] { new DateTime(2024, 10, 29, 2, 58, 10, 781, DateTimeKind.Utc).AddTicks(4471), "Andra registreringen" });
        }
    }
}
