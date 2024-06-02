using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Student_Teacher_Question_Answer_Platform.Migrations
{
    /// <inheritdoc />
    public partial class third : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "Number",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3434a8aa-c57c-4d14-ad4a-1bc80420a9ae", null, "teacher", "teacher" },
                    { "5f2fa0c0-6176-429f-98b6-08c56bc80600", null, "student", "student" },
                    { "a3d57ba3-e3e9-4333-ad24-2d86a98e2707", null, "moderator", "moderator" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3434a8aa-c57c-4d14-ad4a-1bc80420a9ae");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5f2fa0c0-6176-429f-98b6-08c56bc80600");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a3d57ba3-e3e9-4333-ad24-2d86a98e2707");

            migrationBuilder.AddColumn<string>(
                name: "Number",
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
    }
}
