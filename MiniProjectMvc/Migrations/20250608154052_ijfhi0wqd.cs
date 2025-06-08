using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MiniProjectMvc.Migrations
{
    /// <inheritdoc />
    public partial class ijfhi0wqd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2025, 6, 18, 19, 40, 51, 228, DateTimeKind.Local).AddTicks(5661));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 1,
                column: "SubmittedAt",
                value: new DateTime(2025, 6, 8, 19, 40, 51, 228, DateTimeKind.Local).AddTicks(5755));

            migrationBuilder.UpdateData(
                table: "Invitations",
                keyColumn: "Id",
                keyValue: 1,
                column: "SentAt",
                value: new DateTime(2025, 6, 8, 19, 40, 51, 228, DateTimeKind.Local).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "SentAt",
                value: new DateTime(2025, 6, 17, 19, 40, 51, 228, DateTimeKind.Local).AddTicks(5738));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CheckInTime",
                value: new DateTime(2025, 6, 19, 4, 40, 51, 228, DateTimeKind.Local).AddTicks(5720));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2025, 6, 18, 16, 49, 3, 458, DateTimeKind.Local).AddTicks(4764));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 1,
                column: "SubmittedAt",
                value: new DateTime(2025, 6, 8, 16, 49, 3, 458, DateTimeKind.Local).AddTicks(4913));

            migrationBuilder.UpdateData(
                table: "Invitations",
                keyColumn: "Id",
                keyValue: 1,
                column: "SentAt",
                value: new DateTime(2025, 6, 8, 16, 49, 3, 458, DateTimeKind.Local).AddTicks(4809));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "SentAt",
                value: new DateTime(2025, 6, 17, 16, 49, 3, 458, DateTimeKind.Local).AddTicks(4845));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CheckInTime",
                value: new DateTime(2025, 6, 19, 1, 49, 3, 458, DateTimeKind.Local).AddTicks(4828));
        }
    }
}
