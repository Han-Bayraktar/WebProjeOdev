using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebProje.Migrations
{
    /// <inheritdoc />
    public partial class dorduncumigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "Id", "AppointmentTime", "EmployeeId", "ServiceId", "Status", "UserId" },
                values: new object[,]
                {
                    { 1000, new DateTime(2024, 12, 30, 9, 0, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
                    { 1001, new DateTime(2024, 12, 30, 9, 30, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
                    { 1002, new DateTime(2024, 12, 30, 10, 0, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
                    { 1003, new DateTime(2024, 12, 30, 10, 30, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
                    { 1004, new DateTime(2024, 12, 30, 11, 0, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
                    { 1005, new DateTime(2024, 12, 30, 11, 30, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
                    { 1006, new DateTime(2024, 12, 30, 12, 0, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
                    { 1007, new DateTime(2024, 12, 30, 12, 30, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
                    { 1008, new DateTime(2024, 12, 30, 13, 0, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
                    { 1009, new DateTime(2024, 12, 30, 13, 30, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
                    { 1010, new DateTime(2024, 12, 30, 14, 0, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
                    { 1011, new DateTime(2024, 12, 30, 14, 30, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
                    { 1012, new DateTime(2024, 12, 30, 15, 0, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
                    { 1013, new DateTime(2024, 12, 30, 15, 30, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
                    { 1014, new DateTime(2024, 12, 30, 16, 0, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
                    { 1015, new DateTime(2024, 12, 30, 16, 30, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
                    { 1016, new DateTime(2024, 12, 31, 9, 0, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
                    { 1017, new DateTime(2024, 12, 31, 9, 30, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
                    { 1018, new DateTime(2024, 12, 31, 10, 0, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
                    { 1019, new DateTime(2024, 12, 31, 10, 30, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
                    { 1020, new DateTime(2024, 12, 31, 11, 0, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
                    { 1021, new DateTime(2024, 12, 31, 11, 30, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
                    { 1022, new DateTime(2024, 12, 31, 12, 0, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
                    { 1023, new DateTime(2024, 12, 31, 12, 30, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
                    { 1024, new DateTime(2024, 12, 31, 13, 0, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
                    { 1025, new DateTime(2024, 12, 31, 13, 30, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
                    { 1026, new DateTime(2024, 12, 31, 14, 0, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
                    { 1027, new DateTime(2024, 12, 31, 14, 30, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
                    { 1028, new DateTime(2024, 12, 31, 15, 0, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
                    { 1029, new DateTime(2024, 12, 31, 15, 30, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
                    { 1030, new DateTime(2024, 12, 31, 16, 0, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
                    { 1031, new DateTime(2024, 12, 31, 16, 30, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
                    { 1032, new DateTime(2025, 1, 1, 9, 0, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
                    { 1033, new DateTime(2025, 1, 1, 9, 30, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
                    { 1034, new DateTime(2025, 1, 1, 10, 0, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
                    { 1035, new DateTime(2025, 1, 1, 10, 30, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
                    { 1036, new DateTime(2025, 1, 1, 11, 0, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
                    { 1037, new DateTime(2025, 1, 1, 11, 30, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
                    { 1038, new DateTime(2025, 1, 1, 12, 0, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
                    { 1039, new DateTime(2025, 1, 1, 12, 30, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
                    { 1040, new DateTime(2025, 1, 1, 13, 0, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
                    { 1041, new DateTime(2025, 1, 1, 13, 30, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
                    { 1042, new DateTime(2025, 1, 1, 14, 0, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
                    { 1043, new DateTime(2025, 1, 1, 14, 30, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
                    { 1044, new DateTime(2025, 1, 1, 15, 0, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
                    { 1045, new DateTime(2025, 1, 1, 15, 30, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
                    { 1046, new DateTime(2025, 1, 1, 16, 0, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
                    { 1047, new DateTime(2025, 1, 1, 16, 30, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
                    { 1048, new DateTime(2025, 1, 2, 9, 0, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
                    { 1049, new DateTime(2025, 1, 2, 9, 30, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
                    { 1050, new DateTime(2025, 1, 2, 10, 0, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
                    { 1051, new DateTime(2025, 1, 2, 10, 30, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
                    { 1052, new DateTime(2025, 1, 2, 11, 0, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
                    { 1053, new DateTime(2025, 1, 2, 11, 30, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
                    { 1054, new DateTime(2025, 1, 2, 12, 0, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
                    { 1055, new DateTime(2025, 1, 2, 12, 30, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
                    { 1056, new DateTime(2025, 1, 2, 13, 0, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
                    { 1057, new DateTime(2025, 1, 2, 13, 30, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
                    { 1058, new DateTime(2025, 1, 2, 14, 0, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
                    { 1059, new DateTime(2025, 1, 2, 14, 30, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
                    { 1060, new DateTime(2025, 1, 2, 15, 0, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
                    { 1061, new DateTime(2025, 1, 2, 15, 30, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
                    { 1062, new DateTime(2025, 1, 2, 16, 0, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
                    { 1063, new DateTime(2025, 1, 2, 16, 30, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
                    { 1064, new DateTime(2025, 1, 3, 9, 0, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
                    { 1065, new DateTime(2025, 1, 3, 9, 30, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
                    { 1066, new DateTime(2025, 1, 3, 10, 0, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
                    { 1067, new DateTime(2025, 1, 3, 10, 30, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
                    { 1068, new DateTime(2025, 1, 3, 11, 0, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
                    { 1069, new DateTime(2025, 1, 3, 11, 30, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
                    { 1070, new DateTime(2025, 1, 3, 12, 0, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
                    { 1071, new DateTime(2025, 1, 3, 12, 30, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
                    { 1072, new DateTime(2025, 1, 3, 13, 0, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
                    { 1073, new DateTime(2025, 1, 3, 13, 30, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
                    { 1074, new DateTime(2025, 1, 3, 14, 0, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
                    { 1075, new DateTime(2025, 1, 3, 14, 30, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
                    { 1076, new DateTime(2025, 1, 3, 15, 0, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
                    { 1077, new DateTime(2025, 1, 3, 15, 30, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
                    { 1078, new DateTime(2025, 1, 3, 16, 0, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
                    { 1079, new DateTime(2025, 1, 3, 16, 30, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
                    { 1080, new DateTime(2025, 1, 4, 9, 0, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
                    { 1081, new DateTime(2025, 1, 4, 9, 30, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
                    { 1082, new DateTime(2025, 1, 4, 10, 0, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
                    { 1083, new DateTime(2025, 1, 4, 10, 30, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
                    { 1084, new DateTime(2025, 1, 4, 11, 0, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
                    { 1085, new DateTime(2025, 1, 4, 11, 30, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
                    { 1086, new DateTime(2025, 1, 4, 12, 0, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
                    { 1087, new DateTime(2025, 1, 4, 12, 30, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
                    { 1088, new DateTime(2025, 1, 4, 13, 0, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
                    { 1089, new DateTime(2025, 1, 4, 13, 30, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
                    { 1090, new DateTime(2025, 1, 4, 14, 0, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
                    { 1091, new DateTime(2025, 1, 4, 14, 30, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
                    { 1092, new DateTime(2025, 1, 4, 15, 0, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
                    { 1093, new DateTime(2025, 1, 4, 15, 30, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
                    { 1094, new DateTime(2025, 1, 4, 16, 0, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
                    { 1095, new DateTime(2025, 1, 4, 16, 30, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1000);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1001);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1002);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1003);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1004);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1005);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1006);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1007);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1008);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1009);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1010);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1011);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1012);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1013);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1014);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1015);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1016);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1017);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1018);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1019);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1020);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1021);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1022);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1023);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1024);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1025);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1026);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1027);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1028);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1029);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1030);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1031);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1032);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1033);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1034);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1035);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1036);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1037);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1038);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1039);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1040);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1041);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1042);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1043);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1044);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1045);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1046);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1047);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1048);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1049);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1050);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1051);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1052);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1053);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1054);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1055);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1056);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1057);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1058);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1059);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1060);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1061);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1062);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1063);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1064);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1065);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1066);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1067);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1068);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1069);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1070);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1071);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1072);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1073);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1074);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1075);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1076);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1077);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1078);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1079);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1080);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1081);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1082);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1083);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1084);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1085);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1086);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1087);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1088);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1089);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1090);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1091);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1092);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1093);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1094);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1095);
        }
    }
}
