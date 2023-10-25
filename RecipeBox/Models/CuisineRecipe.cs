namespace RecipeBox.Models
{
  public class CuisineRecipe
  {
    public int CuisineRecipeId { get; set; }
    public int RecipeId { get; set; }
    public Recipe Recipe { get; set; }
    public int CuisineID { get; set; }
    public Cuisine Cuisine { get; set; }
  }
}