using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Csr.Migrations
{
    public partial class Update_Role : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ROLE",
                table: "MD_USER",
                newName: "USER_ROLE");

            migrationBuilder.UpdateData(
                table: "MD_USER",
                keyColumn: "USER_ID",
                keyValue: "admin",
                columns: new[] { "CREATE_DTTM", "MODIFY_DTTM" },
                values: new object[] { new DateTime(2021, 11, 27, 21, 19, 35, 378, DateTimeKind.Local).AddTicks(7203), new DateTime(2021, 11, 27, 21, 19, 35, 378, DateTimeKind.Local).AddTicks(7212) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "USER_ROLE",
                table: "MD_USER",
                newName: "ROLE");

            migrationBuilder.UpdateData(
                table: "MD_USER",
                keyColumn: "USER_ID",
                keyValue: "admin",
                columns: new[] { "CREATE_DTTM", "MODIFY_DTTM" },
                values: new object[] { new DateTime(2021, 11, 27, 21, 14, 16, 42, DateTimeKind.Local).AddTicks(6050), new DateTime(2021, 11, 27, 21, 14, 16, 42, DateTimeKind.Local).AddTicks(6061) });
        }
    }
}
