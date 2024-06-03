using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Student_Teacher_Question_Answer_Platform.Migrations
{
    /// <inheritdoc />
    public partial class gag : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bad45f40-e612-4fa2-a013-b563aa1d9177");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ef6b8835-942c-4237-a561-1dc8a5e179f9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f5e94cf0-075e-454d-ba6e-a17d711d201c");

            migrationBuilder.AddColumn<int>(
                name: "AnswersCount",
                table: "StudentQuestions",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "AnswersCount",
                table: "StudentQuestions");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "bad45f40-e612-4fa2-a013-b563aa1d9177", null, "teacher", "teacher" },
                    { "ef6b8835-942c-4237-a561-1dc8a5e179f9", null, "moderator", "moderator" },
                    { "f5e94cf0-075e-454d-ba6e-a17d711d201c", null, "student", "student" }
                });
        }
    }
}
