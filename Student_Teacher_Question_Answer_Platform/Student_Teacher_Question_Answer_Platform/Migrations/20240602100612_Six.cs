using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Student_Teacher_Question_Answer_Platform.Migrations
{
    /// <inheritdoc />
    public partial class Six : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3be207d5-e2e1-4811-9fa7-63b337c909c0", null, "teacher", "teacher" },
                    { "91a21970-6e1e-43bd-bad3-227bf7285232", null, "moderator", "moderator" },
                    { "c3a6185c-5a4d-4c9e-a68b-8e455e872f23", null, "student", "student" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3be207d5-e2e1-4811-9fa7-63b337c909c0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "91a21970-6e1e-43bd-bad3-227bf7285232");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c3a6185c-5a4d-4c9e-a68b-8e455e872f23");

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
    }
}
