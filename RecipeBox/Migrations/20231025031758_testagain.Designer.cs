﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RecipeBox.Models;

#nullable disable

namespace RecipeBox.Migrations
{
    [DbContext(typeof(RecipeBoxContext))]
    [Migration("20231025031758_testagain")]
    partial class testagain
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("RecipeBox.Models.Cuisine", b =>
                {
                    b.Property<int>("CuisineID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CuisineName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("RecipeID")
                        .HasColumnType("int");

                    b.HasKey("CuisineID");

                    b.HasIndex("RecipeID");

                    b.ToTable("Cuisines");
                });

            modelBuilder.Entity("RecipeBox.Models.CuisineRecipe", b =>
                {
                    b.Property<int>("CuisineRecipeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CuisineID")
                        .HasColumnType("int");

                    b.Property<int>("RecipeId")
                        .HasColumnType("int");

                    b.HasKey("CuisineRecipeId");

                    b.HasIndex("CuisineID");

                    b.HasIndex("RecipeId");

                    b.ToTable("CuisineRecipes");
                });

            modelBuilder.Entity("RecipeBox.Models.Recipe", b =>
                {
                    b.Property<int>("RecipeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CuisineID")
                        .HasColumnType("int");

                    b.Property<string>("RecipeName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("RecipeID");

                    b.ToTable("Recipes");
                });

            modelBuilder.Entity("RecipeBox.Models.Cuisine", b =>
                {
                    b.HasOne("RecipeBox.Models.Recipe", null)
                        .WithMany("Cuisines")
                        .HasForeignKey("RecipeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RecipeBox.Models.CuisineRecipe", b =>
                {
                    b.HasOne("RecipeBox.Models.Cuisine", "Cuisine")
                        .WithMany("JoinEntities")
                        .HasForeignKey("CuisineID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RecipeBox.Models.Recipe", "Recipe")
                        .WithMany("JoinEntities")
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cuisine");

                    b.Navigation("Recipe");
                });

            modelBuilder.Entity("RecipeBox.Models.Cuisine", b =>
                {
                    b.Navigation("JoinEntities");
                });

            modelBuilder.Entity("RecipeBox.Models.Recipe", b =>
                {
                    b.Navigation("Cuisines");

                    b.Navigation("JoinEntities");
                });
#pragma warning restore 612, 618
        }
    }
}
