using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolWebApi.Migrations
{
    /// <inheritdoc />
    public partial class AddTeacherClassroomOneToManyRealtionshipEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TeacherId",
                table: "Classroom",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Classroom_TeacherId",
                table: "Classroom",
                column: "TeacherId");

            migrationBuilder.AddForeignKey(
                name: "FK_Classroom_Teacher_TeacherId",
                table: "Classroom",
                column: "TeacherId",
                principalTable: "Teacher",
                principalColumn: "TeacherId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Classroom_Teacher_TeacherId",
                table: "Classroom");

            migrationBuilder.DropIndex(
                name: "IX_Classroom_TeacherId",
                table: "Classroom");

            migrationBuilder.DropColumn(
                name: "TeacherId",
                table: "Classroom");
        }
    }
}
