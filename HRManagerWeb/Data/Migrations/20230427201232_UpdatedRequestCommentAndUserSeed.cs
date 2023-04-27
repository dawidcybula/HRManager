using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRManagerWeb.Migrations
{
    public partial class UpdatedRequestCommentAndUserSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComment",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "41c433ae-ffab-1ou1-1abda403efd4",
                column: "ConcurrencyStamp",
                value: "198358ad-7a86-44af-a11b-09c6448a1afb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac433ae-ffab-f791-1addb453ac61",
                column: "ConcurrencyStamp",
                value: "01656dcf-b7c3-408b-b506-e2f11b3f7d18");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19f433ae-aacb-f721-abc57195deab",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d598e444-8e79-4bb4-ad1b-f9e1dfd14bf4", "AQAAAAEAACcQAAAAEOwGT8ywRHWLkPNgaqiQRByRnMJMZ6KB4ueO11u3PkNQOvo2imQeoNHJhpQytr1PnQ==", "93c295c3-2806-4fe1-be0c-fc9491d00337" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateofBirth", "Email", "EmailConfirmed", "FirstName", "JoinDate", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Taxid", "TwoFactorEnabled", "UserName" },
                values: new object[] { "16f433ae-aacb-f721-def57195deab", 0, "0b81de8a-4302-4e6b-8ecb-93c0be28610e", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "normaluser@users.com", false, "Normal", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "User", false, null, "NORMALUSER@USERS.COM", "NORMALUSER@USERS.COM", "AQAAAAEAACcQAAAAEAnnHvqY2Sdf6Zx1nDzOLzLPvys16nU8qMKKz1okvckqQqJZsaxRAUUnYQJS7jSZDA==", null, false, "2459cfc2-1f2c-49bd-bcab-ae93db7d351b", null, false, "normaluser@users.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16f433ae-aacb-f721-def57195deab");

            migrationBuilder.AlterColumn<string>(
                name: "RequestComment",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
        }
    }
}
