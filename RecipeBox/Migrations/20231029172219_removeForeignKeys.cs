using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RecipeBox.Migrations
{
    public partial class removeForeignKeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cuisines_Recipes_RecipeID",
                table: "Cuisines");

            migrationBuilder.DropColumn(
                name: "CuisineID",
                table: "Recipes");

            migrationBuilder.AlterColumn<int>(
                name: "RecipeID",
                table: "Cuisines",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Cuisines_Recipes_RecipeID",
                table: "Cuisines",
                column: "RecipeID",
                principalTable: "Recipes",
                principalColumn: "RecipeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cuisines_Recipes_RecipeID",
                table: "Cuisines");

            migrationBuilder.AddColumn<int>(
                name: "CuisineID",
                table: "Recipes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "RecipeID",
                table: "Cuisines",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Cuisines_Recipes_RecipeID",
                table: "Cuisines",
                column: "RecipeID",
                principalTable: "Recipes",
                principalColumn: "RecipeID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
