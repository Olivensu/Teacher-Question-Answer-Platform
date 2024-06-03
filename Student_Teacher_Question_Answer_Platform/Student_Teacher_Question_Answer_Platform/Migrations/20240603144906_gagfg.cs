using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Student_Teacher_Question_Answer_Platform.Migrations
{
    /// <inheritdoc />
    public partial class gagfg : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "VoteCount",
                table: "StudentQuestions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "VoteCount",
                table: "Answers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8a0a9b13-056a-4f9b-be43-cbfa8f657199", null, "moderator", "moderator" },
                    { "bbb96cd3-5c63-4ff8-831a-cc30d683a153", null, "student", "student" },
                    { "e305a074-3327-4c0c-be61-6e5c27cdca3c", null, "teacher", "teacher" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8a0a9b13-056a-4f9b-be43-cbfa8f657199");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bbb96cd3-5c63-4ff8-831a-cc30d683a153");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e305a074-3327-4c0c-be61-6e5c27cdca3c");

            migrationBuilder.DropColumn(
                name: "VoteCount",
                table: "StudentQuestions");

            migrationBuilder.DropColumn(
                name: "VoteCount",
                table: "Answers");

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
    }
}
