using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Csr.Migrations
{
    public partial class InitMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "CT_PROJECT",
                columns: table => new
                {
                    PROJECT_ID = table.Column<string>(type: "varchar(20)", nullable: false, comment: "프로젝트ID"),
                    PROJECT_NM = table.Column<string>(type: "nvarchar(50)", nullable: false, comment: "프로젝트명"),
                    MD_CUSTOMERCUSTOMER_ID = table.Column<string>(type: "varchar(20)", nullable: false),
                    REMARK = table.Column<string>(type: "nvarchar(200)", nullable: true, comment: "비고"),
                    CREATE_USER_ID = table.Column<string>(type: "varchar(20)", nullable: false, comment: "생성자"),
                    CREATE_DTTM = table.Column<DateTime>(type: "datetime", nullable: false, comment: "생성시간"),
                    MODIFY_USER_ID = table.Column<string>(type: "varchar(20)", nullable: false, comment: "수정자"),
                    MODIFY_DTTM = table.Column<DateTime>(type: "datetime", nullable: false, comment: "생성시간")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CT_PROJECT", x => x.PROJECT_ID);
                    table.ForeignKey(
                        name: "FK_CT_PROJECT_MD_CUSTOMER_MD_CUSTOMERCUSTOMER_ID",
                        column: x => x.MD_CUSTOMERCUSTOMER_ID,
                        principalTable: "MD_CUSTOMER",
                        principalColumn: "CUSTOMER_ID",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "CT_프로젝트");

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

            migrationBuilder.InsertData(
                table: "MD_USER",
                columns: new[] { "USER_ID", "CREATE_DTTM", "CREATE_USER_ID", "MODIFY_DTTM", "MODIFY_USER_ID", "REMARK", "USER_NM", "USER_PW" },
                values: new object[] { "A", new DateTime(2021, 11, 26, 23, 23, 27, 708, DateTimeKind.Local).AddTicks(1270), "A", new DateTime(2021, 11, 26, 23, 23, 27, 708, DateTimeKind.Local).AddTicks(1279), "A", null, "홍길동1", new byte[] { 65 } });

            migrationBuilder.InsertData(
                table: "MD_USER",
                columns: new[] { "USER_ID", "CREATE_DTTM", "CREATE_USER_ID", "MODIFY_DTTM", "MODIFY_USER_ID", "REMARK", "USER_NM", "USER_PW" },
                values: new object[] { "B", new DateTime(2021, 11, 26, 23, 23, 27, 708, DateTimeKind.Local).AddTicks(1281), "A", new DateTime(2021, 11, 26, 23, 23, 27, 708, DateTimeKind.Local).AddTicks(1281), "A", null, "홍길동2", new byte[] { 66 } });

            migrationBuilder.CreateIndex(
                name: "IX_CT_PROJECT_MD_CUSTOMERCUSTOMER_ID",
                table: "CT_PROJECT",
                column: "MD_CUSTOMERCUSTOMER_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CT_PROJECT");

            migrationBuilder.DropTable(
                name: "MD_USER");

            migrationBuilder.DropTable(
                name: "SYS_CODE");

            migrationBuilder.DropTable(
                name: "MD_CUSTOMER");

            migrationBuilder.DropTable(
                name: "SYS_CODE_GROUP");
        }
    }
}
