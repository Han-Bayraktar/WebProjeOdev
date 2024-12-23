using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebProje.Migrations
{
    /// <inheritdoc />
    public partial class ikincimigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Name", "Specialty", "WorkingHours" },
                values: new object[] { 1, "Mustafa Yılmaz", "Haircut", "9 am-5 pm" });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Duration", "Name", "Price" },
                values: new object[] { 1, 30, "Haircut", 50.0 });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "Id", "AppointmentTime", "EmployeeId", "ServiceId", "Status", "UserId" },
                values: new object[] { 1, new DateTime(2024, 12, 30, 9, 0, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
