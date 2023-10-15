using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolWebApi.Migrations
{
    /// <inheritdoc />
    public partial class ModifyStudentModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Classroom_Teacher_TeacherId",
                table: "Classroom");

            migrationBuilder.DropIndex(
                name: "IX_Classroom_TeacherId",
                table: "Classroom");

            migrationBuilder.RenameColumn(
                name: "Classroom",
                table: "Student",
                newName: "ClassroomId");

            migrationBuilder.AddColumn<int>(
                name: "ClassroomId",
                table: "Teacher",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SubjectId1",
                table: "Subject",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Teacher_ClassroomId",
                table: "Teacher",
                column: "ClassroomId");

            migrationBuilder.CreateIndex(
                name: "IX_Subject_SubjectId1",
                table: "Subject",
                column: "SubjectId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Subject_Subject_SubjectId1",
                table: "Subject",
                column: "SubjectId1",
                principalTable: "Subject",
                principalColumn: "SubjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Teacher_Classroom_ClassroomId",
                table: "Teacher",
                column: "ClassroomId",
                principalTable: "Classroom",
                principalColumn: "ClassroomId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Subject_Subject_SubjectId1",
                table: "Subject");

            migrationBuilder.DropForeignKey(
                name: "FK_Teacher_Classroom_ClassroomId",
                table: "Teacher");

            migrationBuilder.DropIndex(
                name: "IX_Teacher_ClassroomId",
                table: "Teacher");

            migrationBuilder.DropIndex(
                name: "IX_Subject_SubjectId1",
                table: "Subject");

            migrationBuilder.DropColumn(
                name: "ClassroomId",
                table: "Teacher");

            migrationBuilder.DropColumn(
                name: "SubjectId1",
                table: "Subject");

            migrationBuilder.RenameColumn(
                name: "ClassroomId",
                table: "Student",
                newName: "Classroom");

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
    }
}
