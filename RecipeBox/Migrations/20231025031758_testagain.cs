﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RecipeBox.Migrations
{
    public partial class testagain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CuisineID",
                table: "Recipes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RecipeID",
                table: "Cuisines",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Cuisines_RecipeID",
                table: "Cuisines",
                column: "RecipeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Cuisines_Recipes_RecipeID",
                table: "Cuisines",
                column: "RecipeID",
                principalTable: "Recipes",
                principalColumn: "RecipeID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cuisines_Recipes_RecipeID",
                table: "Cuisines");

            migrationBuilder.DropIndex(
                name: "IX_Cuisines_RecipeID",
                table: "Cuisines");

            migrationBuilder.DropColumn(
                name: "CuisineID",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "RecipeID",
                table: "Cuisines");
        }
    }
}
