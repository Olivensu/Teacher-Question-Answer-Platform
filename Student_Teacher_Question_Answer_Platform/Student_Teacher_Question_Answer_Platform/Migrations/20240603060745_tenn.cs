using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Student_Teacher_Question_Answer_Platform.Migrations
{
    /// <inheritdoc />
    public partial class tenn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "20c1e71a-dc96-449f-bf51-0a5ad57ba74d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "731d4de3-5188-4dcb-a642-5e1e2eeda200");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "db157f8b-7e6c-43a1-ab82-11c3abe8b340");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1e9ca5ad-cc05-4dcb-845c-1df83286e364", null, "student", "student" },
                    { "4a5c74e0-3731-4199-b8af-dc2f65d26e1c", null, "teacher", "teacher" },
                    { "b0543a40-79f3-4099-9a81-f628060957bf", null, "moderator", "moderator" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1e9ca5ad-cc05-4dcb-845c-1df83286e364");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4a5c74e0-3731-4199-b8af-dc2f65d26e1c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b0543a40-79f3-4099-9a81-f628060957bf");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "20c1e71a-dc96-449f-bf51-0a5ad57ba74d", null, "teacher", "teacher" },
                    { "731d4de3-5188-4dcb-a642-5e1e2eeda200", null, "student", "student" },
                    { "db157f8b-7e6c-43a1-ab82-11c3abe8b340", null, "moderator", "moderator" }
                });
        }
    }
}
