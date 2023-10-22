using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RecipeBox.Models
{
  public class Recipe
  {
    public int RecipeID { get; set; }
    [Required(ErrorMessage = "what this recipe is")]
    public string RecipeName { get; set; }
    public List<RecipeVariety> JoinEntities { get; }
    // public ApplicationUser User { get; set; }
  }
}