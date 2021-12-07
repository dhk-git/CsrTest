using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Csr.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CT_PROJECT",
                columns: table => new
                {
                    PROJECT_ID = table.Column<string>(type: "varchar(20)", nullable: false, comment: "프로젝트ID"),
                    PROJECT_NM = table.Column<string>(type: "nvarchar(50)", nullable: false, comment: "프로젝트명"),
                    CUSTOMER_ID = table.Column<string>(type: "varchar(20)", nullable: false, comment: "고객사ID"),
                    REMARK = table.Column<string>(type: "nvarchar(200)", nullable: true, comment: "비고"),
                    CREATE_USER_ID = table.Column<string>(type: "varchar(20)", nullable: false, comment: "생성자"),
                    CREATE_DTTM = table.Column<DateTime>(type: "datetime", nullable: false, comment: "생성시간"),
                    MODIFY_USER_ID = table.Column<string>(type: "varchar(20)", nullable: false, comment: "수정자"),
                    MODIFY_DTTM = table.Column<DateTime>(type: "datetime", nullable: false, comment: "생성시간")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CT_PROJECT", x => x.PROJECT_ID);
                },
                comment: "CT_프로젝트");

            migrationBuilder.CreateTable(
                name: "MD_CUSTOMER",
                columns: table => new
                {
                    CUSTOMER_ID = table.Column<string>(type: "varchar(20)", nullable: false, comment: "고객사ID"),
                    CUSTOMER_NM = table.Column<string>(type: "nvarchar(50)", nullable: false, comment: "프로젝트명"),
                    VALID_FROM_DT = table.Column<DateTime>(type: "datetime", nullable: false, comment: "유효시작일"),
                    VALID_TO_DT = table.Column<DateTime>(type: "datetime", nullable: true, comment: "유효종료일"),
                    DEL_FG = table.Column<string>(type: "char(1)", nullable: false, defaultValue: "N", comment: "삭제여부"),
                    REMARK = table.Column<string>(type: "nvarchar(200)", nullable: true, comment: "비고"),
                    CREATE_USER_ID = table.Column<string>(type: "varchar(20)", nullable: false, comment: "생성자"),
                    CREATE_DTTM = table.Column<DateTime>(type: "datetime", nullable: false, comment: "생성시간"),
                    MODIFY_USER_ID = table.Column<string>(type: "varchar(20)", nullable: false, comment: "수정자"),
                    MODIFY_DTTM = table.Column<DateTime>(type: "datetime", nullable: false, comment: "생성시간")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MD_CUSTOMER", x => x.CUSTOMER_ID);
                },
                comment: "MD_고객사");

            migrationBuilder.CreateTable(
                name: "MD_USER",
                columns: table => new
                {
                    USER_ID = table.Column<string>(type: "varchar(20)", nullable: false, comment: "사용자ID"),
                    USER_PW = table.Column<byte[]>(type: "varbinary(100)", nullable: false, comment: "사용자PW"),
                    USER_NM = table.Column<string>(type: "nvarchar(50)", nullable: false, comment: "사용자명"),
                    USER_ROLE = table.Column<string>(type: "nvarchar(50)", nullable: false, comment: "권한"),
                    REMARK = table.Column<string>(type: "nvarchar(200)", nullable: true, comment: "비고"),
                    CREATE_USER_ID = table.Column<string>(type: "varchar(20)", nullable: false, comment: "생성자"),
                    CREATE_DTTM = table.Column<DateTime>(type: "datetime", nullable: false, comment: "생성시간"),
                    MODIFY_USER_ID = table.Column<string>(type: "varchar(20)", nullable: false, comment: "수정자"),
                    MODIFY_DTTM = table.Column<DateTime>(type: "datetime", nullable: false, comment: "생성시간")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MD_USER", x => x.USER_ID);
                },
                comment: "MD_사용자");

            migrationBuilder.CreateTable(
                name: "SYS_CODE_GROUP",
                columns: table => new
                {
                    SYS_CD_GROUP = table.Column<string>(type: "varchar(50)", nullable: false, comment: "코드그룹"),
                    SYS_CD_GROUP_NM = table.Column<string>(type: "nvarchar(50)", nullable: false, comment: "코드그룹명"),
                    SORT_NO = table.Column<decimal>(type: "decimal(5,2)", precision: 5, scale: 2, nullable: false, comment: "정렬순서"),
                    REMARK = table.Column<string>(type: "nvarchar(200)", nullable: true, comment: "비고"),
                    CREATE_USER_ID = table.Column<string>(type: "varchar(20)", nullable: false, comment: "생성자"),
                    CREATE_DTTM = table.Column<DateTime>(type: "datetime", nullable: false, comment: "생성시간"),
                    MODIFY_USER_ID = table.Column<string>(type: "varchar(20)", nullable: false, comment: "수정자"),
                    MODIFY_DTTM = table.Column<DateTime>(type: "datetime", nullable: false, comment: "생성시간")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SYS_CODE_GROUP", x => x.SYS_CD_GROUP);
                },
                comment: "SYS_시스템코드_그룹");

            migrationBuilder.CreateTable(
                name: "CT_REQUEST",
                columns: table => new
                {
                    REQUEST_ID = table.Column<int>(type: "int", nullable: false, comment: "요청ID")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    REQUEST_TYPE = table.Column<string>(type: "varchar(50)", nullable: true, comment: "요청유형"),
                    REQUEST_LEVEL = table.Column<string>(type: "varchar(50)", nullable: true, comment: "긴급도"),
                    CREATE_DT = table.Column<DateTime>(type: "date", nullable: false, comment: "요청일자"),
                    PROJECT_ID = table.Column<string>(type: "varchar(20)", nullable: true),
                    USER_ID = table.Column<string>(type: "varchar(20)", nullable: true, comment: "사용자ID"),
                    REQUEST_TITLE = table.Column<string>(type: "nvarchar(100)", nullable: true, comment: "제목"),
                    REQUEST_DETAIL = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "내용"),
                    REQUEST_STATUS = table.Column<string>(type: "varchar(50)", nullable: true, comment: "요청상태"),
                    REMARK = table.Column<string>(type: "nvarchar(200)", nullable: true, comment: "비고"),
                    CREATE_USER_ID = table.Column<string>(type: "varchar(20)", nullable: false, comment: "생성자"),
                    CREATE_DTTM = table.Column<DateTime>(type: "datetime", nullable: false, comment: "생성시간"),
                    MODIFY_USER_ID = table.Column<string>(type: "varchar(20)", nullable: false, comment: "수정자"),
                    MODIFY_DTTM = table.Column<DateTime>(type: "datetime", nullable: false, comment: "생성시간")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CT_REQUEST", x => x.REQUEST_ID);
                    table.ForeignKey(
                        name: "FK_CT_REQUEST_CT_PROJECT_PROJECT_ID",
                        column: x => x.PROJECT_ID,
                        principalTable: "CT_PROJECT",
                        principalColumn: "PROJECT_ID");
                },
                comment: "CT_요청");

            migrationBuilder.CreateTable(
                name: "SYS_CODE",
                columns: table => new
                {
                    SYS_CD_GROUP = table.Column<string>(type: "varchar(50)", nullable: false, comment: "시스템코드그룹"),
                    SYS_CD = table.Column<string>(type: "varchar(50)", nullable: false, comment: "시스템코드"),
                    SYS_CD_NM = table.Column<string>(type: "nvarchar(50)", nullable: false, comment: "시스템코드명"),
                    VALUE_1 = table.Column<string>(type: "nvarchar(50)", nullable: true, comment: "값1"),
                    VALUE_2 = table.Column<string>(type: "nvarchar(50)", nullable: true, comment: "값2"),
                    VALUE_3 = table.Column<string>(type: "nvarchar(50)", nullable: true, comment: "값3"),
                    SORT_NO = table.Column<decimal>(type: "decimal(5,2)", precision: 5, scale: 2, nullable: false, comment: "정렬순서"),
                    REMARK = table.Column<string>(type: "nvarchar(200)", nullable: true, comment: "비고"),
                    CREATE_USER_ID = table.Column<string>(type: "varchar(20)", nullable: false, comment: "생성자"),
                    CREATE_DTTM = table.Column<DateTime>(type: "datetime", nullable: false, comment: "생성시간"),
                    MODIFY_USER_ID = table.Column<string>(type: "varchar(20)", nullable: false, comment: "수정자"),
                    MODIFY_DTTM = table.Column<DateTime>(type: "datetime", nullable: false, comment: "생성시간")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SYS_CODE", x => new { x.SYS_CD_GROUP, x.SYS_CD });
                    table.ForeignKey(
                        name: "FK_SYS_CODE_SYS_CODE_GROUP_SYS_CD_GROUP",
                        column: x => x.SYS_CD_GROUP,
                        principalTable: "SYS_CODE_GROUP",
                        principalColumn: "SYS_CD_GROUP",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "SYS_시스템코드");

            migrationBuilder.CreateTable(
                name: "CT_RESPONSE",
                columns: table => new
                {
                    RESPONSE_ID = table.Column<int>(type: "int", nullable: false, comment: "답변ID")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    REQUEST_ID = table.Column<int>(type: "int", nullable: false, comment: "요청ID"),
                    USER_ID = table.Column<string>(type: "varchar(20)", nullable: true, comment: "사용자ID"),
                    RESPONSE_TITLE = table.Column<string>(type: "nvarchar(100)", nullable: true, comment: "제목"),
                    RESPONSE_DETAIL = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "내용"),
                    FROM_DTTM = table.Column<DateTime>(type: "datetime", nullable: false, comment: "시작일시"),
                    TO_DTTM = table.Column<DateTime>(type: "datetime", nullable: false, comment: "종료일시"),
                    MAN_HOUR = table.Column<int>(type: "int", precision: 5, scale: 2, nullable: false, comment: "실투입공수"),
                    RESPONSE_STATUS = table.Column<string>(type: "varchar(50)", nullable: true, comment: "답변상태"),
                    REMARK = table.Column<string>(type: "nvarchar(200)", nullable: true, comment: "비고"),
                    CREATE_USER_ID = table.Column<string>(type: "varchar(20)", nullable: false, comment: "생성자"),
                    CREATE_DTTM = table.Column<DateTime>(type: "datetime", nullable: false, comment: "생성시간"),
                    MODIFY_USER_ID = table.Column<string>(type: "varchar(20)", nullable: false, comment: "수정자"),
                    MODIFY_DTTM = table.Column<DateTime>(type: "datetime", nullable: false, comment: "생성시간")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CT_RESPONSE", x => x.RESPONSE_ID);
                    table.ForeignKey(
                        name: "FK_CT_RESPONSE_CT_REQUEST_REQUEST_ID",
                        column: x => x.REQUEST_ID,
                        principalTable: "CT_REQUEST",
                        principalColumn: "REQUEST_ID",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "CT_답변");

            migrationBuilder.InsertData(
                table: "MD_USER",
                columns: new[] { "USER_ID", "CREATE_DTTM", "CREATE_USER_ID", "MODIFY_DTTM", "MODIFY_USER_ID", "REMARK", "USER_NM", "USER_PW", "USER_ROLE" },
                values: new object[] { "admin", new DateTime(2021, 12, 7, 9, 13, 51, 815, DateTimeKind.Local).AddTicks(6515), "A", new DateTime(2021, 12, 7, 9, 13, 51, 815, DateTimeKind.Local).AddTicks(6527), "A", null, "admin", new byte[] { 97, 100, 109, 105, 110, 49 }, "Admin" });

            migrationBuilder.InsertData(
                table: "SYS_CODE_GROUP",
                columns: new[] { "SYS_CD_GROUP", "CREATE_DTTM", "CREATE_USER_ID", "MODIFY_DTTM", "MODIFY_USER_ID", "REMARK", "SORT_NO", "SYS_CD_GROUP_NM" },
                values: new object[] { "REQUEST_TYPE", new DateTime(2021, 12, 7, 9, 13, 51, 815, DateTimeKind.Local).AddTicks(6638), "admin", new DateTime(2021, 12, 7, 9, 13, 51, 815, DateTimeKind.Local).AddTicks(6640), "admin", null, 1m, "요청유형" });

            migrationBuilder.InsertData(
                table: "SYS_CODE",
                columns: new[] { "SYS_CD", "SYS_CD_GROUP", "CREATE_DTTM", "CREATE_USER_ID", "MODIFY_DTTM", "MODIFY_USER_ID", "REMARK", "SORT_NO", "SYS_CD_NM", "VALUE_1", "VALUE_2", "VALUE_3" },
                values: new object[] { "ModifyData", "REQUEST_TYPE", new DateTime(2021, 12, 7, 9, 13, 51, 815, DateTimeKind.Local).AddTicks(6679), "admin", new DateTime(2021, 12, 7, 9, 13, 51, 815, DateTimeKind.Local).AddTicks(6679), "admin", null, 1m, "데이터수정", null, null, null });

            migrationBuilder.InsertData(
                table: "SYS_CODE",
                columns: new[] { "SYS_CD", "SYS_CD_GROUP", "CREATE_DTTM", "CREATE_USER_ID", "MODIFY_DTTM", "MODIFY_USER_ID", "REMARK", "SORT_NO", "SYS_CD_NM", "VALUE_1", "VALUE_2", "VALUE_3" },
                values: new object[] { "ProgramError", "REQUEST_TYPE", new DateTime(2021, 12, 7, 9, 13, 51, 815, DateTimeKind.Local).AddTicks(6668), "admin", new DateTime(2021, 12, 7, 9, 13, 51, 815, DateTimeKind.Local).AddTicks(6669), "admin", null, 1m, "프로그램오류", null, null, null });

            migrationBuilder.InsertData(
                table: "SYS_CODE",
                columns: new[] { "SYS_CD", "SYS_CD_GROUP", "CREATE_DTTM", "CREATE_USER_ID", "MODIFY_DTTM", "MODIFY_USER_ID", "REMARK", "SORT_NO", "SYS_CD_NM", "VALUE_1", "VALUE_2", "VALUE_3" },
                values: new object[] { "Question", "REQUEST_TYPE", new DateTime(2021, 12, 7, 9, 13, 51, 815, DateTimeKind.Local).AddTicks(6656), "admin", new DateTime(2021, 12, 7, 9, 13, 51, 815, DateTimeKind.Local).AddTicks(6657), "admin", null, 1m, "단순문의", null, null, null });

            migrationBuilder.CreateIndex(
                name: "IX_CT_REQUEST_PROJECT_ID",
                table: "CT_REQUEST",
                column: "PROJECT_ID");

            migrationBuilder.CreateIndex(
                name: "IX_CT_RESPONSE_REQUEST_ID",
                table: "CT_RESPONSE",
                column: "REQUEST_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CT_RESPONSE");

            migrationBuilder.DropTable(
                name: "MD_CUSTOMER");

            migrationBuilder.DropTable(
                name: "MD_USER");

            migrationBuilder.DropTable(
                name: "SYS_CODE");

            migrationBuilder.DropTable(
                name: "CT_REQUEST");

            migrationBuilder.DropTable(
                name: "SYS_CODE_GROUP");

            migrationBuilder.DropTable(
                name: "CT_PROJECT");
        }
    }
}
