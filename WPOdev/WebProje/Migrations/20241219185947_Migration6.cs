using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebProje.Migrations
{
    /// <inheritdoc />
    public partial class Migration6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "8b035688-ad0f-41cb-b2bc-42d7d96b4556");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Name", "Password", "Role", "Surname" },
                values: new object[] { "1ccf3d32-1454-401d-b2b8-4460b9a868ba", "b22121210034@gmail.com", "Admin", "sau", "admin", "User" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "1ccf3d32-1454-401d-b2b8-4460b9a868ba");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Name", "Password", "Role", "Surname" },
                values: new object[] { "8b035688-ad0f-41cb-b2bc-42d7d96b4556", "b22121210034@gmail.com", "Admin", "sau", "admin", "User" });
        }
    }
}
