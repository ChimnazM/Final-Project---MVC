using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcFinalProject.Migrations
{
    public partial class CreateSliderTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sliders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(maxLength: 300, nullable: false),
                    TopTitle = table.Column<string>(maxLength: 170, nullable: false),
                    BottomTitle = table.Column<string>(maxLength: 170, nullable: true),
                    Description = table.Column<string>(maxLength: 300, nullable: false),
                    Order = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sliders", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sliders");
        }
    }
}
