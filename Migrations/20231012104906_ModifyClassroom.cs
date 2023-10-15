using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolWebApi.Migrations
{
    /// <inheritdoc />
    public partial class ModifyClassroom : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_Classroom_Classroom",
                table: "Student");

            migrationBuilder.DropIndex(
                name: "IX_Student_Classroom",
                table: "Student");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Student_Classroom",
                table: "Student",
                column: "Classroom");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Classroom_Classroom",
                table: "Student",
                column: "Classroom",
                principalTable: "Classroom",
                principalColumn: "ClassroomId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
