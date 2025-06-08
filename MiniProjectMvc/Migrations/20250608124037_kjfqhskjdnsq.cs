using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MiniProjectMvc.Migrations
{
    /// <inheritdoc />
    public partial class kjfqhskjdnsq : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2025, 6, 18, 16, 31, 52, 564, DateTimeKind.Local).AddTicks(7884));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 1,
                column: "SubmittedAt",
                value: new DateTime(2025, 6, 8, 16, 31, 52, 564, DateTimeKind.Local).AddTicks(8057));

            migrationBuilder.UpdateData(
                table: "Invitations",
                keyColumn: "Id",
                keyValue: 1,
                column: "SentAt",
                value: new DateTime(2025, 6, 8, 16, 31, 52, 564, DateTimeKind.Local).AddTicks(7926));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "SentAt",
                value: new DateTime(2025, 6, 17, 16, 31, 52, 564, DateTimeKind.Local).AddTicks(7973));

            migrationBuilder.UpdateData(
                table: "Participations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CheckInTime",
                value: new DateTime(2025, 6, 19, 1, 31, 52, 564, DateTimeKind.Local).AddTicks(7949));
        }
    }
}
