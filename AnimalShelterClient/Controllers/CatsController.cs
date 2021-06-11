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
    public IActionResult Details(int id)
    {
      var cat = Cat.GetDetails(id);
      return View(cat);
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

    public IActionResult Edit(int id)
    {
      var cat = Cat.GetDetails(id);
      return View(cat);
    }

    [HttpPost]
    public IActionResult Details(int id, Cat cat)
    {
      cat.CatId = id;
      Cat.Put(cat);
      return RedirectToAction("Details", id);
    }

    public IActionResult Delete(int id)
    {
      Cat.Delete(id);
      return RedirectToAction("Index");
    }

  }
}