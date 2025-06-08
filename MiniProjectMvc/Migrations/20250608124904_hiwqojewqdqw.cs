using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MiniProjectMvc.Migrations
{
    /// <inheritdoc />
    public partial class hiwqojewqdqw : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2025, 6, 18, 16, 40, 36, 354, DateTimeKind.Local).AddTicks(6279));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 1,
                column: "SubmittedAt",
                value: new DateTime(2025, 6, 8, 16, 40, 36, 354, DateTimeKind.Local).AddTicks(6378));

            migrationBuilder.UpdateData(
                table: "Invitations",
                keyColumn: "Id",
                keyValue: 1,
                column: "SentAt",
                value: new DateTime(2025, 6, 8, 16, 40, 36, 354, DateTimeKind.Local).AddTicks(6322));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "SentAt",
                value: new DateTime(2025, 6, 17, 16, 40, 36, 354, DateTimeKind.Local).AddTicks(6358));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CheckInTime",
                value: new DateTime(2025, 6, 19, 1, 40, 36, 354, DateTimeKind.Local).AddTicks(6340));
        }
    }
}
