using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Student_Teacher_Question_Answer_Platform.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreatefs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "33aeb19e-3642-48b0-bea8-8646e6a6cef1", null, "moderator", "moderator" },
                    { "714801ce-96da-48c7-a80c-f1ccbfd9e617", null, "student", "student" },
                    { "f4c57049-3c03-44b3-aec1-0b1986fcadc2", null, "teacher", "teacher" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "33aeb19e-3642-48b0-bea8-8646e6a6cef1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "714801ce-96da-48c7-a80c-f1ccbfd9e617");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f4c57049-3c03-44b3-aec1-0b1986fcadc2");

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
    }
}
