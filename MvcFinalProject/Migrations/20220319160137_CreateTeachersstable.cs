using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcFinalProject.Migrations
{
    public partial class CreateTeachersstable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Teachers_teacherId",
                table: "Contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_Skills_Teachers_teacherId",
                table: "Skills");

            migrationBuilder.RenameColumn(
                name: "teacherId",
                table: "Skills",
                newName: "TeacherId");

            migrationBuilder.RenameIndex(
                name: "IX_Skills_teacherId",
                table: "Skills",
                newName: "IX_Skills_TeacherId");

            migrationBuilder.RenameColumn(
                name: "teacherId",
                table: "Contacts",
                newName: "TeacherId");

            migrationBuilder.RenameIndex(
                name: "IX_Contacts_teacherId",
                table: "Contacts",
                newName: "IX_Contacts_TeacherId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Teachers_TeacherId",
                table: "Contacts",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_Teachers_TeacherId",
                table: "Skills",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Teachers_TeacherId",
                table: "Contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_Skills_Teachers_TeacherId",
                table: "Skills");

            migrationBuilder.RenameColumn(
                name: "TeacherId",
                table: "Skills",
                newName: "teacherId");

            migrationBuilder.RenameIndex(
                name: "IX_Skills_TeacherId",
                table: "Skills",
                newName: "IX_Skills_teacherId");

            migrationBuilder.RenameColumn(
                name: "TeacherId",
                table: "Contacts",
                newName: "teacherId");

            migrationBuilder.RenameIndex(
                name: "IX_Contacts_TeacherId",
                table: "Contacts",
                newName: "IX_Contacts_teacherId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Teachers_teacherId",
                table: "Contacts",
                column: "teacherId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_Teachers_teacherId",
                table: "Skills",
                column: "teacherId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
