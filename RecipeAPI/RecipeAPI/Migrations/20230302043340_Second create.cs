using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RecipeAPI.Migrations
{
    public partial class Secondcreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "cookingMethodId",
                table: "Dishes",
                type: "int",
                nullable: true,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "CookingMethods",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CookingMethods", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Dishes_cookingMethodId",
                table: "Dishes",
                column: "cookingMethodId");

            migrationBuilder.AddForeignKey(
                name: "FK_Dishes_CookingMethods_cookingMethodId",
                table: "Dishes",
                column: "cookingMethodId",
                principalTable: "CookingMethods",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dishes_CookingMethods_cookingMethodId",
                table: "Dishes");

            migrationBuilder.DropTable(
                name: "CookingMethods");

            migrationBuilder.DropIndex(
                name: "IX_Dishes_cookingMethodId",
                table: "Dishes");

            migrationBuilder.DropColumn(
                name: "cookingMethodId",
                table: "Dishes");
        }
    }
}
