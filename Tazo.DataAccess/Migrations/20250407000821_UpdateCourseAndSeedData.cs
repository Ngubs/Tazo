using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Tazo.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCourseAndSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NQF",
                table: "Courses",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CourseCode", "CourseTitle", "NQF", "Year" },
                values: new object[,]
                {
                    { 1, "BCA1", "Bachelor of Computer and Information Science 1", 7, 1 },
                    { 2, "BCA2", "Bachelor of Computer and Information Science 2", 7, 2 },
                    { 3, "BCA3", "Bachelor of Computer and Information Science 3", 7, 3 },
                    { 4, "PDDA", "Postgraduate Diploma in Data Analytics", 8, 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "NQF",
                table: "Courses");
        }
    }
}
