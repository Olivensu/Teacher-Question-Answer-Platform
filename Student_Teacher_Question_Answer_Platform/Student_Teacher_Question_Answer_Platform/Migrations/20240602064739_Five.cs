using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Student_Teacher_Question_Answer_Platform.Migrations
{
    /// <inheritdoc />
    public partial class Five : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2e6f375c-6db5-4f07-b3ca-b08249a94094");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7000e1b0-3110-4ac5-bad8-633da18338ee");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd134f52-b53b-4bdc-adf8-bdbca9cb47a7");

            migrationBuilder.RenameColumn(
                name: "cratedAt",
                table: "AspNetUsers",
                newName: "CreatedAt");

            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1f7378e8-9f23-4011-9e29-96c9b03aff57", null, "moderator", "MODERATOR" },
                    { "6ffb8b8e-9f0c-4fb5-a1d9-4484232c9e3e", null, "student", "STUDENT" },
                    { "aba2f79e-be0e-44a2-b162-44b904972bbe", null, "teacher", "TEACHER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1f7378e8-9f23-4011-9e29-96c9b03aff57");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6ffb8b8e-9f0c-4fb5-a1d9-4484232c9e3e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aba2f79e-be0e-44a2-b162-44b904972bbe");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "AspNetUsers",
                newName: "cratedAt");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2e6f375c-6db5-4f07-b3ca-b08249a94094", null, "moderator", "moderator" },
                    { "7000e1b0-3110-4ac5-bad8-633da18338ee", null, "teacher", "teacher" },
                    { "bd134f52-b53b-4bdc-adf8-bdbca9cb47a7", null, "student", "student" }
                });
        }
    }
}
