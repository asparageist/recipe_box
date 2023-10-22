namespace RecipeBox.Models
{
  public class RecipeVariety
  {
    public int RecipeVarietyId { get; set; }
    public int RecipeId { get; set; }
    public Recipe Recipe { get; set; }
    public int VarietyId { get; set; }
    public Variety Variety { get; set; }
  }
}