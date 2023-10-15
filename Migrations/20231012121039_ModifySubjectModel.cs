using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolWebApi.Migrations
{
    /// <inheritdoc />
    public partial class ModifySubjectModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Subject_Subject_SubjectId1",
                table: "Subject");

            migrationBuilder.DropIndex(
                name: "IX_Subject_SubjectId1",
                table: "Subject");

            migrationBuilder.DropColumn(
                name: "SubjectId1",
                table: "Subject");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SubjectId1",
                table: "Subject",
                type: "int",
                nullable: true);

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
        }
    }
}
