using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RecipeBox.Models
{
  public class Cuisine
  {
    public int CuisineID { get; set; }
    [Required(ErrorMessage = "what this recipe is")]
    public string CuisineName { get; set; }
    // public int RecipeID { get; set; }
    public List<CuisineRecipe> JoinEntities { get; }
    // public ApplicationUser User { get; set; }
  }
}