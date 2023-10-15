using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolWebApi.Migrations
{
    /// <inheritdoc />
    public partial class AddTeacherSubjectsOneToManyRealtionshipEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Subject_Teacher_TeacherSubject",
                table: "Subject");

            migrationBuilder.DropTable(
                name: "TeacherSubject");

            migrationBuilder.RenameColumn(
                name: "TeacherSubject",
                table: "Subject",
                newName: "TeacherId");

            migrationBuilder.RenameIndex(
                name: "IX_Subject_TeacherSubject",
                table: "Subject",
                newName: "IX_Subject_TeacherId");

            migrationBuilder.AddForeignKey(
                name: "FK_Subject_Teacher_TeacherId",
                table: "Subject",
                column: "TeacherId",
                principalTable: "Teacher",
                principalColumn: "TeacherId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Subject_Teacher_TeacherId",
                table: "Subject");

            migrationBuilder.RenameColumn(
                name: "TeacherId",
                table: "Subject",
                newName: "TeacherSubject");

            migrationBuilder.RenameIndex(
                name: "IX_Subject_TeacherId",
                table: "Subject",
                newName: "IX_Subject_TeacherSubject");

            migrationBuilder.CreateTable(
                name: "TeacherSubject",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubjectId = table.Column<int>(type: "int", nullable: false),
                    TeacherId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherSubject", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Subject_Teacher_TeacherSubject",
                table: "Subject",
                column: "TeacherSubject",
                principalTable: "Teacher",
                principalColumn: "TeacherId");
        }
    }
}
