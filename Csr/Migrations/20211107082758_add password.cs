using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Csr.Migrations
{
    public partial class addpassword : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Users",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "Password", "UserName" },
                values: new object[] { "A", "A", "홍길동1" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "Password", "UserName" },
                values: new object[] { "B", "B", "홍길동2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: "A");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: "B");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Users");
        }
    }
}
