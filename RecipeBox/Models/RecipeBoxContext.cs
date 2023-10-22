using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace RecipeBox.Models
{
  // public class RecipeBoxContext : IdentityDbContext<ApplicationUser>
  public class RecipeBoxContext : DbContext
  {
    public DbSet<Recipe> Recipe { get; set; }
    public DbSet<Variety> Varieties { get; set; }
    public DbSet<RecipeVariety> RecipeVarieties { get; set; }

    public RecipeBoxContext(DbContextOptions options) : base(options) { }
  }
}