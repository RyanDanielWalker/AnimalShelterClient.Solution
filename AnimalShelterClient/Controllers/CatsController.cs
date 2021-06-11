using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AnimalShelterClient.Models;

namespace AnimalShelterClient.Controllers
{
  public class CatsController : Controller
  {
    public IActionResult Index()
    {
      var allCats = Cat.GetCats();
      return View(allCats);
    }
    public IActionResult Create()
    {
      return View();
    }
    [HttpPost]
    public IActionResult Create(Cat cat)
    {
      Cat.Post(cat);
      return RedirectToAction("Index");
    }

  }
}