using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolWebApi.Migrations
{
    /// <inheritdoc />
    public partial class AddTeacherSubjectsEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TeacherSubject",
                table: "Subject",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "TeacherSubject",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeacherId = table.Column<int>(type: "int", nullable: false),
                    SubjectId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherSubject", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Subject_TeacherSubject",
                table: "Subject",
                column: "TeacherSubject");

            migrationBuilder.AddForeignKey(
                name: "FK_Subject_Teacher_TeacherSubject",
                table: "Subject",
                column: "TeacherSubject",
                principalTable: "Teacher",
                principalColumn: "TeacherId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Subject_Teacher_TeacherSubject",
                table: "Subject");

            migrationBuilder.DropTable(
                name: "TeacherSubject");

            migrationBuilder.DropIndex(
                name: "IX_Subject_TeacherSubject",
                table: "Subject");

            migrationBuilder.DropColumn(
                name: "TeacherSubject",
                table: "Subject");
        }
    }
}
