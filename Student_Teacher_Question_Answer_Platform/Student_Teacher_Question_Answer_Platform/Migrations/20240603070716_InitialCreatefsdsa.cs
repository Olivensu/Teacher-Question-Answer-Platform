using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Student_Teacher_Question_Answer_Platform.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreatefsdsa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "QuestionsList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionsList", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QuestionsList_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "029866e1-0540-46b0-b275-cde829789aa9", null, "student", "student" },
                    { "2376bb6a-7937-4926-9e08-85540b4f40c8", null, "moderator", "moderator" },
                    { "2c246f7d-b8a3-4195-a15e-386d19e0da5a", null, "teacher", "teacher" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_QuestionsList_UserId",
                table: "QuestionsList",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QuestionsList");

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
    }
}
