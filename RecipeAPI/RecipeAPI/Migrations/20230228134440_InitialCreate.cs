using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RecipeAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dishes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dishName = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    category = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    complexity = table.Column<int>(type: "int", nullable: false),
                    time = table.Column<int>(type: "int", nullable: false),
                    efficiency = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dishes", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dishes");
        }
    }
}
