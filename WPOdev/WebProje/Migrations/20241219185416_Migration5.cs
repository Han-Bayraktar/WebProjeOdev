using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace WebProje.Migrations
{
    /// <inheritdoc />
    public partial class Migration5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Users",
                type: "text",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "Users",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Appointments",
                type: "text",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Name", "Password", "Role", "Surname" },
                values: new object[] { "8b035688-ad0f-41cb-b2bc-42d7d96b4556", "b22121210034@gmail.com", "Admin", "sau", "admin", "User" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "8b035688-ad0f-41cb-b2bc-42d7d96b4556");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "Users");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Users",
                type: "integer",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

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

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Appointments",
                type: "integer",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "IsAdmin", "Name", "Password", "Surname", "isAdmin" },
                values: new object[] { 1, "b22121210034@gmail.com", false, "Admin", "sau", "User", true });
        }
    }
}
