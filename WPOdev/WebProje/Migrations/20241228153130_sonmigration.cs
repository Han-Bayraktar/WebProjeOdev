using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebProje.Migrations
{
    /// <inheritdoc />
    public partial class sonmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
    table: "Appointments",
    columns: new[] { "Id", "AppointmentTime", "EmployeeId", "ServiceId", "Status", "UserId" },
    values: new object[,]
    {
        { 1000, new DateTime(2024, 12, 30, 6, 0, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
        { 1001, new DateTime(2024, 12, 30, 6, 30, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
        { 1002, new DateTime(2024, 12, 30, 7, 0, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
        { 1003, new DateTime(2024, 12, 30, 7, 30, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
        { 1004, new DateTime(2024, 12, 30, 8, 0, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
        { 1005, new DateTime(2024, 12, 30, 8, 30, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
        { 1006, new DateTime(2024, 12, 30, 9, 0, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
        { 1007, new DateTime(2024, 12, 30, 9, 30, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
        { 1008, new DateTime(2024, 12, 30, 10, 0, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
        { 1009, new DateTime(2024, 12, 30, 10, 30, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
        { 1010, new DateTime(2024, 12, 30, 11, 0, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
        { 1011, new DateTime(2024, 12, 30, 11, 30, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
        { 1012, new DateTime(2024, 12, 30, 12, 0, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
        { 1013, new DateTime(2024, 12, 30, 12, 30, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
        { 1014, new DateTime(2024, 12, 30, 13, 0, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
        { 1015, new DateTime(2024, 12, 30, 13, 30, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
        { 1016, new DateTime(2024, 12, 31, 6, 0, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
        { 1017, new DateTime(2024, 12, 31, 6, 30, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
        { 1018, new DateTime(2024, 12, 31, 7, 0, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
        { 1019, new DateTime(2024, 12, 31, 7, 30, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
        { 1020, new DateTime(2024, 12, 31, 8, 0, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
        { 1021, new DateTime(2024, 12, 31, 8, 30, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
        { 1022, new DateTime(2024, 12, 31, 9, 0, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
        { 1023, new DateTime(2024, 12, 31, 9, 30, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
        { 1024, new DateTime(2024, 12, 31, 10, 0, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
        { 1025, new DateTime(2024, 12, 31, 10, 30, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
        { 1026, new DateTime(2024, 12, 31, 11, 0, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
        { 1027, new DateTime(2024, 12, 31, 11, 30, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
        { 1028, new DateTime(2024, 12, 31, 12, 0, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
        { 1029, new DateTime(2024, 12, 31, 12, 30, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
        { 1030, new DateTime(2024, 12, 31, 13, 0, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
        { 1031, new DateTime(2024, 12, 31, 13, 30, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
        { 1032, new DateTime(2025, 1, 1, 6, 0, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
        { 1033, new DateTime(2025, 1, 1, 6, 30, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
        { 1034, new DateTime(2025, 1, 1, 7, 0, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
        { 1035, new DateTime(2025, 1, 1, 7, 30, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
        { 1036, new DateTime(2025, 1, 1, 8, 0, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
        { 1037, new DateTime(2025, 1, 1, 8, 30, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
        { 1038, new DateTime(2025, 1, 1, 9, 0, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
        { 1039, new DateTime(2025, 1, 1, 9, 30, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
        { 1040, new DateTime(2025, 1, 1, 10, 0, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
        { 1041, new DateTime(2025, 1, 1, 10, 30, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
        { 1042, new DateTime(2025, 1, 1, 11, 0, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
        { 1043, new DateTime(2025, 1, 1, 11, 30, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
        { 1044, new DateTime(2025, 1, 1, 12, 0, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
        { 1045, new DateTime(2025, 1, 1, 12, 30, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
        { 1046, new DateTime(2025, 1, 1, 13, 0, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
        { 1047, new DateTime(2025, 1, 1, 13, 30, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
        { 1048, new DateTime(2025, 1, 2, 6, 0, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
        { 1049, new DateTime(2025, 1, 2, 6, 30, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
        { 1050, new DateTime(2025, 1, 2, 7, 0, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
        { 1051, new DateTime(2025, 1, 2, 7, 30, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
        { 1052, new DateTime(2025, 1, 2, 8, 0, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
        { 1053, new DateTime(2025, 1, 2, 8, 30, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
        { 1054, new DateTime(2025, 1, 2, 9, 0, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
        { 1055, new DateTime(2025, 1, 2, 9, 30, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
        { 1056, new DateTime(2025, 1, 2, 10, 0, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
        { 1057, new DateTime(2025, 1, 2, 10, 30, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
        { 1058, new DateTime(2025, 1, 2, 11, 0, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
        { 1059, new DateTime(2025, 1, 2, 11, 30, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
        { 1060, new DateTime(2025, 1, 2, 12, 0, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
        { 1061, new DateTime(2025, 1, 2, 12, 30, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
        { 1062, new DateTime(2025, 1, 2, 13, 0, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
        { 1063, new DateTime(2025, 1, 2, 13, 30, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
        { 1064, new DateTime(2025, 1, 3, 6, 0, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
        { 1065, new DateTime(2025, 1, 3, 6, 30, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
        { 1066, new DateTime(2025, 1, 3, 7, 0, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
        { 1067, new DateTime(2025, 1, 3, 7, 30, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
        { 1068, new DateTime(2025, 1, 3, 8, 0, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
        { 1069, new DateTime(2025, 1, 3, 8, 30, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
        { 1070, new DateTime(2025, 1, 3, 9, 0, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
        { 1071, new DateTime(2025, 1, 3, 9, 30, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
        { 1072, new DateTime(2025, 1, 3, 10, 0, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
        { 1073, new DateTime(2025, 1, 3, 10, 30, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
        { 1074, new DateTime(2025, 1, 3, 11, 0, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
        { 1075, new DateTime(2025, 1, 3, 11, 30, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
        { 1076, new DateTime(2025, 1, 3, 12, 0, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
        { 1077, new DateTime(2025, 1, 3, 12, 30, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
        { 1078, new DateTime(2025, 1, 3, 13, 0, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
        { 1079, new DateTime(2025, 1, 3, 13, 30, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
        { 1080, new DateTime(2025, 1, 4, 6, 0, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
        { 1081, new DateTime(2025, 1, 4, 6, 30, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
        { 1082, new DateTime(2025, 1, 4, 7, 0, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
        { 1083, new DateTime(2025, 1, 4, 7, 30, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
        { 1084, new DateTime(2025, 1, 4, 8, 0, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
        { 1085, new DateTime(2025, 1, 4, 8, 30, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
        { 1086, new DateTime(2025, 1, 4, 9, 0, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
        { 1087, new DateTime(2025, 1, 4, 9, 30, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
        { 1088, new DateTime(2025, 1, 4, 10, 0, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
        { 1089, new DateTime(2025, 1, 4, 10, 30, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
        { 1090, new DateTime(2025, 1, 4, 11, 0, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
        { 1091, new DateTime(2025, 1, 4, 11, 30, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
        { 1092, new DateTime(2025, 1, 4, 12, 0, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
        { 1093, new DateTime(2025, 1, 4, 12, 30, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
        { 1094, new DateTime(2025, 1, 4, 13, 0, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 },
        { 1095, new DateTime(2025, 1, 4, 13, 30, 0, 0, DateTimeKind.Utc), 1, 1, false, 1 }
    });
    }
        

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
