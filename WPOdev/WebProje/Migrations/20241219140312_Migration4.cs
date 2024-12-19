using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebProje.Migrations
{
    /// <inheritdoc />
    public partial class Migration4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Role",
                table: "Users");

            migrationBuilder.AddColumn<bool>(
                name: "IsAdmin",
                table: "Users",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isAdmin",
                table: "Users",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "WorkingHours",
                table: "Employees",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "IsAdmin", "Name", "Password", "Surname", "isAdmin" },
                values: new object[] { 1, "b22121210034@gmail.com", false, "Admin", "sau", "User", true });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "IsAdmin",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "isAdmin",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "WorkingHours",
                table: "Employees");

            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "Users",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
