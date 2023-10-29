using Microsoft.AspNetCore.Mvc;
using RecipeBox.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;

namespace RecipeBox.Controllers
{
  [Authorize]
  public class RecipeController : Controller
  {
    private readonly RecipeBoxContext _db;
    private readonly UserManager<ApplicationUser> _userManager;

    public RecipeController(UserManager<ApplicationUser> userManager, RecipeBoxContext db)
    {
      _userManager = userManager;
      _db = db;
    }

    public async Task<ActionResult> Index()
    {
      string userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      ApplicationUser currentUser = await _userManager.FindByIdAsync(userId);
      List<Recipe> userRecipes = _db.Recipes
                          .Where(entry => entry.User.Id == currentUser.Id)
                          .Include(recipe => recipe.Cuisines)
                          .ToList();
      return View(userRecipes);
    }

    // public ActionResult Index()
    // {
    //   ViewBag.PageTitle = "All Recipes";
    //   return View(_db.Recipes.ToList());
    // }


    public ActionResult New()
    {
      ViewBag.PageTitle = "Add a Recipe";
      return View();
    }

    [HttpPost]
    public async Task<ActionResult> New(Recipe recipe, int CuisineId)
    {
      if (!ModelState.IsValid)
      {
        ViewBag.CuisineId = new SelectList(_db.Cuisines, "CusiineId", "Name");
        return View(recipe);
      }
      else
      {
        string userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        ApplicationUser currentUser = await _userManager.FindByIdAsync(userId);
        recipe.User = currentUser;
        _db.Recipes.Add(recipe);
        _db.SaveChanges();
        return RedirectToAction("Index");
      }
    }

    // [HttpPost]
    // public ActionResult New(Recipe recipe)
    // {
    //   _db.Recipes.Add(recipe);
    //   _db.SaveChanges();
    //   return RedirectToAction("Index");
    // }

    public ActionResult Details(int id)
    {
      Recipe thisRecipe = _db.Recipes.FirstOrDefault(recipe => recipe.RecipeID == id);
      return View(thisRecipe);
    }

    public ActionResult Edit(int id)
    {
      Recipe thisRecipe = _db.Recipes.FirstOrDefault(recipe => recipe.RecipeID == id);
      return View(thisRecipe);
    }

    [HttpPost]
    public ActionResult Edit(Recipe recipe)
    {
      _db.Recipes.Update(recipe);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      Recipe thisRecipe = _db.Recipes.FirstOrDefault(recipe => recipe.RecipeID == id);
      return View(thisRecipe);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      Recipe thisRecipe = _db.Recipes.FirstOrDefault(recipe => recipe.RecipeID == id);
      _db.Recipes.Remove(thisRecipe);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }


  }
}