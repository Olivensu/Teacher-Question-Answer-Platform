using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Student_Teacher_Question_Answer_Platform.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreatefsdsas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "029866e1-0540-46b0-b275-cde829789aa9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2376bb6a-7937-4926-9e08-85540b4f40c8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c246f7d-b8a3-4195-a15e-386d19e0da5a");

            migrationBuilder.CreateTable(
                name: "StudentQuestions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentQuestions", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentQuestions");

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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "029866e1-0540-46b0-b275-cde829789aa9", null, "student", "student" },
                    { "2376bb6a-7937-4926-9e08-85540b4f40c8", null, "moderator", "moderator" },
                    { "2c246f7d-b8a3-4195-a15e-386d19e0da5a", null, "teacher", "teacher" }
                });
        }
    }
}
