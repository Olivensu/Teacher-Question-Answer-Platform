using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Student_Teacher_Question_Answer_Platform.Migrations
{
    /// <inheritdoc />
    public partial class eight : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "12bc4262-7e17-4e61-ac8a-f0d51ed9c642");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "63c9912f-9761-435e-a7d6-aaf2ee9fe569");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d41b8149-079c-44ec-a979-c7454f02bfe6");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "73368832-b0a0-4ee0-af1f-1811f87a13ef", null, "moderator", "moderator" },
                    { "d58ef825-2f8e-4bfa-8b06-088557f66a6a", null, "student", "student" },
                    { "f1409c0d-93e0-41ce-85d5-67a78c6f4f26", null, "teacher", "teacher" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73368832-b0a0-4ee0-af1f-1811f87a13ef");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d58ef825-2f8e-4bfa-8b06-088557f66a6a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f1409c0d-93e0-41ce-85d5-67a78c6f4f26");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "12bc4262-7e17-4e61-ac8a-f0d51ed9c642", null, "student", "student" },
                    { "63c9912f-9761-435e-a7d6-aaf2ee9fe569", null, "teacher", "teacher" },
                    { "d41b8149-079c-44ec-a979-c7454f02bfe6", null, "moderator", "moderator" }
                });
        }
    }
}
