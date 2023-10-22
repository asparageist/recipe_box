using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RecipeBox.Models
{
  public class Variety
  {
    public int VarietyID { get; set; }
    [Required(ErrorMessage = "what this recipe is")]
    public string Name { get; set; }
    public List<RecipeVariety> JoinEntities { get; }
    // public ApplicationUser User { get; set; }
  }
}