using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace RecipeBox.Models
{
  public class Recipe
  {
    public int RecipeID { get; set; }
    [Required(ErrorMessage = "what this recipe is")]
    public string RecipeName { get; set; }
    public List<Cuisine> Cuisines { get; set; }
    public List<CuisineRecipe> JoinEntities { get; }
    // public ApplicationUser User { get; set; }
  }
}