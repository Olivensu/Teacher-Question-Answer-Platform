using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Student_Teacher_Question_Answer_Platform.Migrations
{
    /// <inheritdoc />
    public partial class fourth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3434a8aa-c57c-4d14-ad4a-1bc80420a9ae");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5f2fa0c0-6176-429f-98b6-08c56bc80600");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a3d57ba3-e3e9-4333-ad24-2d86a98e2707");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "3434a8aa-c57c-4d14-ad4a-1bc80420a9ae", null, "teacher", "teacher" },
                    { "5f2fa0c0-6176-429f-98b6-08c56bc80600", null, "student", "student" },
                    { "a3d57ba3-e3e9-4333-ad24-2d86a98e2707", null, "moderator", "moderator" }
                });
        }
    }
}
