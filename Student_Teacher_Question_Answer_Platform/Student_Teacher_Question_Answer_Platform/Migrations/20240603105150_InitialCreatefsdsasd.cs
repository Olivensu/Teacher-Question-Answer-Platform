using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Student_Teacher_Question_Answer_Platform.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreatefsdsasd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6d64b39f-0b4a-4cb8-b2b4-f8aafc9a43d8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "99dbbe59-f2b7-4527-aa7a-9a2a7ae059db");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d03f6a69-8c93-4689-992a-26346b9e7e63");

            migrationBuilder.CreateTable(
                name: "Answers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudentQuestionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Answers_StudentQuestions_StudentQuestionId",
                        column: x => x.StudentQuestionId,
                        principalTable: "StudentQuestions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "bad45f40-e612-4fa2-a013-b563aa1d9177", null, "teacher", "teacher" },
                    { "ef6b8835-942c-4237-a561-1dc8a5e179f9", null, "moderator", "moderator" },
                    { "f5e94cf0-075e-454d-ba6e-a17d711d201c", null, "student", "student" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Answers_StudentQuestionId",
                table: "Answers",
                column: "StudentQuestionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Answers");

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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6d64b39f-0b4a-4cb8-b2b4-f8aafc9a43d8", null, "teacher", "teacher" },
                    { "99dbbe59-f2b7-4527-aa7a-9a2a7ae059db", null, "student", "student" },
                    { "d03f6a69-8c93-4689-992a-26346b9e7e63", null, "moderator", "moderator" }
                });
        }
    }
}
