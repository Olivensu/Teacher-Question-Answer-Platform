using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Student_Teacher_Question_Answer_Platform.Migrations
{
    /// <inheritdoc />
    public partial class gagf : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "16567b50-3b8e-4222-9719-91e0b1d52a87");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b32aaeb6-f95e-46c1-a6bd-388a2f18a306");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c2987aa7-a04c-479c-b050-2bd5e9426c45");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1013c4f9-57f0-4f50-8c73-3403402e8f0a", null, "moderator", "moderator" },
                    { "71539876-9ce1-4479-aa92-c6c9cdb80bcd", null, "teacher", "teacher" },
                    { "f67cc380-efa7-439d-b857-aab68fda4e19", null, "student", "student" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1013c4f9-57f0-4f50-8c73-3403402e8f0a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "71539876-9ce1-4479-aa92-c6c9cdb80bcd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f67cc380-efa7-439d-b857-aab68fda4e19");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "16567b50-3b8e-4222-9719-91e0b1d52a87", null, "teacher", "teacher" },
                    { "b32aaeb6-f95e-46c1-a6bd-388a2f18a306", null, "moderator", "moderator" },
                    { "c2987aa7-a04c-479c-b050-2bd5e9426c45", null, "student", "student" }
                });
        }
    }
}
