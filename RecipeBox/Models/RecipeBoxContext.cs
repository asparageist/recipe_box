using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace RecipeBox.Models
{
  public class RecipeBoxContext : IdentityDbContext<ApplicationUser>
  {
    public DbSet<Recipe> Recipes { get; set; }
    public DbSet<Cuisine> Cuisines { get; set; }
    public DbSet<CuisineRecipe> CuisineRecipes { get; set; }

    public RecipeBoxContext(DbContextOptions options) : base(options) { }
  }
}