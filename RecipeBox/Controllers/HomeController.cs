using Microsoft.AspNetCore.Mvc;
using RecipeBox.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;

namespace RecipeBox.Controllers
{
  public class HomeController : Controller
  {
    private readonly RecipeBoxContext _db;

    public HomeController(RecipeBoxContext db)
    {
      _db = db;
    }

    // [HttpGet("/")]
    // public ActionResult Index()
    // {
    //   Recipe[] recipes = _db.Recipes.ToArray();
    //   Dictionary<string, object[]> model = new Dictionary<string, object[]>();
    //   model.Add("recipes", recipes);

    //   return View(model);
    // }

    [HttpGet("/")]
    public ActionResult Index()
    {
      Recipe[] recipes = _db.Recipes.ToArray();
      Cuisine[] cuisines = _db.Cuisines.ToArray();
      Dictionary<string, object[]> model = new Dictionary<string, object[]>();
      model.Add("recipes", recipes);
      model.Add("cuisines", cuisines);
      return View(model);
    }
  }
}