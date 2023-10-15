using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolWebApi.Migrations
{
    /// <inheritdoc />
    public partial class ModifiedStudentClassroomEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "studentLastName",
                table: "Student",
                newName: "StudentLastName");

            migrationBuilder.RenameColumn(
                name: "studentFirstName",
                table: "Student",
                newName: "StudentFirstName");

            migrationBuilder.RenameColumn(
                name: "studentDob",
                table: "Student",
                newName: "StudentDob");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "Student",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "contactPerson",
                table: "Student",
                newName: "ContactPerson");

            migrationBuilder.RenameColumn(
                name: "contactNo",
                table: "Student",
                newName: "ContactNo");

            migrationBuilder.RenameColumn(
                name: "studentId",
                table: "Student",
                newName: "StudentId");

            migrationBuilder.RenameColumn(
                name: "classroomName",
                table: "Classroom",
                newName: "ClassroomName");

            migrationBuilder.RenameColumn(
                name: "classroomId",
                table: "Classroom",
                newName: "ClassroomId");

            migrationBuilder.RenameIndex(
                name: "IX_Classroom_classroomName",
                table: "Classroom",
                newName: "IX_Classroom_ClassroomName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StudentLastName",
                table: "Student",
                newName: "studentLastName");

            migrationBuilder.RenameColumn(
                name: "StudentFirstName",
                table: "Student",
                newName: "studentFirstName");

            migrationBuilder.RenameColumn(
                name: "StudentDob",
                table: "Student",
                newName: "studentDob");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Student",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "ContactPerson",
                table: "Student",
                newName: "contactPerson");

            migrationBuilder.RenameColumn(
                name: "ContactNo",
                table: "Student",
                newName: "contactNo");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "Student",
                newName: "studentId");

            migrationBuilder.RenameColumn(
                name: "ClassroomName",
                table: "Classroom",
                newName: "classroomName");

            migrationBuilder.RenameColumn(
                name: "ClassroomId",
                table: "Classroom",
                newName: "classroomId");

            migrationBuilder.RenameIndex(
                name: "IX_Classroom_ClassroomName",
                table: "Classroom",
                newName: "IX_Classroom_classroomName");
        }
    }
}
