using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcFinalProject.Migrations
{
    public partial class CreateSkillTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Contacts_TeacherId",
                table: "Contacts");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_TeacherId",
                table: "Contacts",
                column: "TeacherId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Contacts_TeacherId",
                table: "Contacts");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_TeacherId",
                table: "Contacts",
                column: "TeacherId");
        }
    }
}
