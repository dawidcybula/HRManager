using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRManagerWeb.Migrations
{
    public partial class LeaveRequest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LeaveRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LeaveTypeId = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateRequested = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestComment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Approved = table.Column<bool>(type: "bit", nullable: true),
                    Canceled = table.Column<bool>(type: "bit", nullable: false),
                    RequestingEmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_LeaveTypes_LeaveTypeId",
                        column: x => x.LeaveTypeId,
                        principalTable: "LeaveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "41c433ae-ffab-1ou1-1abda403efd4",
                column: "ConcurrencyStamp",
                value: "0a3ecc90-de4e-489c-8a68-6a9353f5e495");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac433ae-ffab-f791-1addb453ac61",
                column: "ConcurrencyStamp",
                value: "e03380e4-9fd9-49de-b2d3-13ea92cb95f6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19f433ae-aacb-f721-abc57195deab",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "58a2230e-7cc0-4db3-822b-22eb6cfa752a", "AQAAAAEAACcQAAAAEJK6lF42uzvXi/UbZESthIjW3wjNnkEkcyUfb0fdJtGkZSHmpNoGTSFVxCNH23Lpdw==", "87a7cd70-17ef-4dba-9245-5eb85247be50" });

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_LeaveTypeId",
                table: "LeaveRequests",
                column: "LeaveTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveRequests");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "41c433ae-ffab-1ou1-1abda403efd4",
                column: "ConcurrencyStamp",
                value: "1a9ecbc7-faf3-40ab-be23-bdb34c22feb6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac433ae-ffab-f791-1addb453ac61",
                column: "ConcurrencyStamp",
                value: "c733bdbb-e6c1-4124-be5a-2ccd5df058e8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19f433ae-aacb-f721-abc57195deab",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "22a88a70-0009-4a1d-abbe-a25d8180a1cb", "AQAAAAEAACcQAAAAEO3wB/P69eg+3obMYwvbJHARbq4WN3LoR34mnRC08peyuYFkxNlrczPxYK1TilVFXA==", "12cfa1ac-ddd3-4b41-b0db-012415fec073" });
        }
    }
}
