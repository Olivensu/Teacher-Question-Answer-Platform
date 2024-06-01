using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Student_Teacher_Question_Answer_Platform.Migrations
{
    /// <inheritdoc />
    public partial class second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6a705fd2-c70d-49bc-9b41-d7a7c84e0a9c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9f8d5b76-5410-468d-a53f-591d6a5560dd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eb371de4-ba2b-4ea5-be84-ba6d16584abd");

            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "32abb066-469c-4a10-a112-e74351327bdb", null, "moderator", "moderator" },
                    { "7188fecf-371e-4216-a1af-f514f5156315", null, "teacher", "teacher" },
                    { "7c46c398-3b0b-4d41-99cd-69b27bf08548", null, "student", "student" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "32abb066-469c-4a10-a112-e74351327bdb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7188fecf-371e-4216-a1af-f514f5156315");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7c46c398-3b0b-4d41-99cd-69b27bf08548");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6a705fd2-c70d-49bc-9b41-d7a7c84e0a9c", null, "student", "student" },
                    { "9f8d5b76-5410-468d-a53f-591d6a5560dd", null, "teacher", "teacher" },
                    { "eb371de4-ba2b-4ea5-be84-ba6d16584abd", null, "moderator", "moderator" }
                });
        }
    }
}
