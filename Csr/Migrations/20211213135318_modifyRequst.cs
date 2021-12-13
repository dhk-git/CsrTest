using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Csr.Migrations
{
    public partial class modifyRequst : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "USER_ID",
                table: "CT_REQUEST");

            migrationBuilder.RenameColumn(
                name: "REQUEST_DETAIL",
                table: "CT_REQUEST",
                newName: "REQUEST_CONTENT");

            migrationBuilder.AlterColumn<string>(
                name: "REQUEST_TYPE",
                table: "CT_REQUEST",
                type: "varchar(50)",
                nullable: false,
                defaultValue: "",
                comment: "요청유형",
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldNullable: true,
                oldComment: "요청유형");

            migrationBuilder.UpdateData(
                table: "MD_USER",
                keyColumn: "USER_ID",
                keyValue: "admin",
                columns: new[] { "CREATE_DTTM", "MODIFY_DTTM" },
                values: new object[] { new DateTime(2021, 12, 13, 22, 53, 17, 673, DateTimeKind.Local).AddTicks(2316), new DateTime(2021, 12, 13, 22, 53, 17, 673, DateTimeKind.Local).AddTicks(2330) });

            migrationBuilder.UpdateData(
                table: "SYS_CODE",
                keyColumns: new[] { "SYS_CD", "SYS_CD_GROUP" },
                keyValues: new object[] { "ModifyData", "REQUEST_TYPE" },
                columns: new[] { "CREATE_DTTM", "MODIFY_DTTM" },
                values: new object[] { new DateTime(2021, 12, 13, 22, 53, 17, 673, DateTimeKind.Local).AddTicks(2691), new DateTime(2021, 12, 13, 22, 53, 17, 673, DateTimeKind.Local).AddTicks(2692) });

            migrationBuilder.UpdateData(
                table: "SYS_CODE",
                keyColumns: new[] { "SYS_CD", "SYS_CD_GROUP" },
                keyValues: new object[] { "ProgramError", "REQUEST_TYPE" },
                columns: new[] { "CREATE_DTTM", "MODIFY_DTTM" },
                values: new object[] { new DateTime(2021, 12, 13, 22, 53, 17, 673, DateTimeKind.Local).AddTicks(2669), new DateTime(2021, 12, 13, 22, 53, 17, 673, DateTimeKind.Local).AddTicks(2670) });

            migrationBuilder.UpdateData(
                table: "SYS_CODE",
                keyColumns: new[] { "SYS_CD", "SYS_CD_GROUP" },
                keyValues: new object[] { "Question", "REQUEST_TYPE" },
                columns: new[] { "CREATE_DTTM", "MODIFY_DTTM" },
                values: new object[] { new DateTime(2021, 12, 13, 22, 53, 17, 673, DateTimeKind.Local).AddTicks(2644), new DateTime(2021, 12, 13, 22, 53, 17, 673, DateTimeKind.Local).AddTicks(2645) });

            migrationBuilder.UpdateData(
                table: "SYS_CODE_GROUP",
                keyColumn: "SYS_CD_GROUP",
                keyValue: "REQUEST_TYPE",
                columns: new[] { "CREATE_DTTM", "MODIFY_DTTM" },
                values: new object[] { new DateTime(2021, 12, 13, 22, 53, 17, 673, DateTimeKind.Local).AddTicks(2608), new DateTime(2021, 12, 13, 22, 53, 17, 673, DateTimeKind.Local).AddTicks(2610) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "REQUEST_CONTENT",
                table: "CT_REQUEST",
                newName: "REQUEST_DETAIL");

            migrationBuilder.AlterColumn<string>(
                name: "REQUEST_TYPE",
                table: "CT_REQUEST",
                type: "varchar(50)",
                nullable: true,
                comment: "요청유형",
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldComment: "요청유형");

            migrationBuilder.AddColumn<string>(
                name: "USER_ID",
                table: "CT_REQUEST",
                type: "varchar(20)",
                nullable: true,
                comment: "사용자ID");

            migrationBuilder.UpdateData(
                table: "MD_USER",
                keyColumn: "USER_ID",
                keyValue: "admin",
                columns: new[] { "CREATE_DTTM", "MODIFY_DTTM" },
                values: new object[] { new DateTime(2021, 12, 7, 9, 13, 51, 815, DateTimeKind.Local).AddTicks(6515), new DateTime(2021, 12, 7, 9, 13, 51, 815, DateTimeKind.Local).AddTicks(6527) });

            migrationBuilder.UpdateData(
                table: "SYS_CODE",
                keyColumns: new[] { "SYS_CD", "SYS_CD_GROUP" },
                keyValues: new object[] { "ModifyData", "REQUEST_TYPE" },
                columns: new[] { "CREATE_DTTM", "MODIFY_DTTM" },
                values: new object[] { new DateTime(2021, 12, 7, 9, 13, 51, 815, DateTimeKind.Local).AddTicks(6679), new DateTime(2021, 12, 7, 9, 13, 51, 815, DateTimeKind.Local).AddTicks(6679) });

            migrationBuilder.UpdateData(
                table: "SYS_CODE",
                keyColumns: new[] { "SYS_CD", "SYS_CD_GROUP" },
                keyValues: new object[] { "ProgramError", "REQUEST_TYPE" },
                columns: new[] { "CREATE_DTTM", "MODIFY_DTTM" },
                values: new object[] { new DateTime(2021, 12, 7, 9, 13, 51, 815, DateTimeKind.Local).AddTicks(6668), new DateTime(2021, 12, 7, 9, 13, 51, 815, DateTimeKind.Local).AddTicks(6669) });

            migrationBuilder.UpdateData(
                table: "SYS_CODE",
                keyColumns: new[] { "SYS_CD", "SYS_CD_GROUP" },
                keyValues: new object[] { "Question", "REQUEST_TYPE" },
                columns: new[] { "CREATE_DTTM", "MODIFY_DTTM" },
                values: new object[] { new DateTime(2021, 12, 7, 9, 13, 51, 815, DateTimeKind.Local).AddTicks(6656), new DateTime(2021, 12, 7, 9, 13, 51, 815, DateTimeKind.Local).AddTicks(6657) });

            migrationBuilder.UpdateData(
                table: "SYS_CODE_GROUP",
                keyColumn: "SYS_CD_GROUP",
                keyValue: "REQUEST_TYPE",
                columns: new[] { "CREATE_DTTM", "MODIFY_DTTM" },
                values: new object[] { new DateTime(2021, 12, 7, 9, 13, 51, 815, DateTimeKind.Local).AddTicks(6638), new DateTime(2021, 12, 7, 9, 13, 51, 815, DateTimeKind.Local).AddTicks(6640) });
        }
    }
}
