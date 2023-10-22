using Microsoft.AspNetCore.Mvc;
using RecipeBox.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace RecipeBox.Controllers
{
  public class VarietyController : Controller
  {
    private readonly RecipeBoxContext _db;

    public VarietyController(RecipeBoxContext db)
    {
      _db = db;
    }
  }

}