using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Csr.Migrations
{
    public partial class AddRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MD_USER",
                keyColumn: "USER_ID",
                keyValue: "A");

            migrationBuilder.DeleteData(
                table: "MD_USER",
                keyColumn: "USER_ID",
                keyValue: "B");

            migrationBuilder.AddColumn<string>(
                name: "ROLE",
                table: "MD_USER",
                type: "nvarchar(50)",
                nullable: false,
                defaultValue: "",
                comment: "권한");

            migrationBuilder.InsertData(
                table: "MD_USER",
                columns: new[] { "USER_ID", "CREATE_DTTM", "CREATE_USER_ID", "MODIFY_DTTM", "MODIFY_USER_ID", "REMARK", "ROLE", "USER_NM", "USER_PW" },
                values: new object[] { "admin", new DateTime(2021, 11, 27, 21, 14, 16, 42, DateTimeKind.Local).AddTicks(6050), "A", new DateTime(2021, 11, 27, 21, 14, 16, 42, DateTimeKind.Local).AddTicks(6061), "A", null, "Admin", "admin", new byte[] { 97, 100, 109, 105, 110, 49 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MD_USER",
                keyColumn: "USER_ID",
                keyValue: "admin");

            migrationBuilder.DropColumn(
                name: "ROLE",
                table: "MD_USER");

            migrationBuilder.InsertData(
                table: "MD_USER",
                columns: new[] { "USER_ID", "CREATE_DTTM", "CREATE_USER_ID", "MODIFY_DTTM", "MODIFY_USER_ID", "REMARK", "USER_NM", "USER_PW" },
                values: new object[] { "A", new DateTime(2021, 11, 26, 23, 23, 27, 708, DateTimeKind.Local).AddTicks(1270), "A", new DateTime(2021, 11, 26, 23, 23, 27, 708, DateTimeKind.Local).AddTicks(1279), "A", null, "홍길동1", new byte[] { 65 } });

            migrationBuilder.InsertData(
                table: "MD_USER",
                columns: new[] { "USER_ID", "CREATE_DTTM", "CREATE_USER_ID", "MODIFY_DTTM", "MODIFY_USER_ID", "REMARK", "USER_NM", "USER_PW" },
                values: new object[] { "B", new DateTime(2021, 11, 26, 23, 23, 27, 708, DateTimeKind.Local).AddTicks(1281), "A", new DateTime(2021, 11, 26, 23, 23, 27, 708, DateTimeKind.Local).AddTicks(1281), "A", null, "홍길동2", new byte[] { 66 } });
        }
    }
}
