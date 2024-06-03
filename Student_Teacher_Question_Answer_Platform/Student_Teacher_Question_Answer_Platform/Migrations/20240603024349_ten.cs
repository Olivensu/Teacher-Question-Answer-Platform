using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Student_Teacher_Question_Answer_Platform.Migrations
{
    /// <inheritdoc />
    public partial class ten : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "667b4c8d-b3e2-415e-bfd4-af8430e28ae2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "69df34c5-2873-401d-9ed4-dea9f2c46d9f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a43a254d-58ff-4e64-9471-306f9bfeddd3");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "667b4c8d-b3e2-415e-bfd4-af8430e28ae2", null, "student", "student" },
                    { "69df34c5-2873-401d-9ed4-dea9f2c46d9f", null, "moderator", "moderator" },
                    { "a43a254d-58ff-4e64-9471-306f9bfeddd3", null, "teacher", "teacher" }
                });
        }
    }
}
