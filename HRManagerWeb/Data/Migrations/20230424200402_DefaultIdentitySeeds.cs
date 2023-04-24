using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRManagerWeb.Data.Migrations
{
    public partial class DefaultIdentitySeeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "41c433ae-ffab-1ou1-1abda403efd4", "7f716cea-06f4-4105-8d99-8b838982d435", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cac433ae-ffab-f791-1addb453ac61", "bffb70b4-e879-43ef-b43e-05377c4cc59d", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateofBirth", "Email", "EmailConfirmed", "FirstName", "JoinDate", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Taxid", "TwoFactorEnabled", "UserName" },
                values: new object[] { "19f433ae-aacb-f721-abc57195deab", 0, "44025bac-6004-4ff8-afb9-21fb961cec26", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@users.com", false, "System", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", false, null, "ADMIN@USERS.COM", null, "AQAAAAEAACcQAAAAEIStotH8OvPJG1ZLrXQHSU5kPB2vlFCXXmZmGJULRIaSdGsgaXx/4FajaA/0kIEqoQ==", null, false, "d0bccf12-1c94-4c54-95f9-782a352e3201", null, false, null });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cac433ae-ffab-f791-1addb453ac61", "19f433ae-aacb-f721-abc57195deab" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "41c433ae-ffab-1ou1-1abda403efd4");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cac433ae-ffab-f791-1addb453ac61", "19f433ae-aacb-f721-abc57195deab" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac433ae-ffab-f791-1addb453ac61");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19f433ae-aacb-f721-abc57195deab");
        }
    }
}
