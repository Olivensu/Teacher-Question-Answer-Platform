using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Student_Teacher_Question_Answer_Platform.Migrations
{
    /// <inheritdoc />
    public partial class nine : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Qty = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

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
                    { "73368832-b0a0-4ee0-af1f-1811f87a13ef", null, "moderator", "moderator" },
                    { "d58ef825-2f8e-4bfa-8b06-088557f66a6a", null, "student", "student" },
                    { "f1409c0d-93e0-41ce-85d5-67a78c6f4f26", null, "teacher", "teacher" }
                });
        }
    }
}
