using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AnimalShelterClient.Models;

namespace AnimalShelterClient.Controllers
{
  public class DogsController : Controller
  {
    public IActionResult Index()
    {
      var allDogs = Dog.GetDogs();
      return View(allDogs);
    }
    public IActionResult Details(int id)
    {
      var dog = Dog.GetDetails(id);
      return View(dog);
    }
    public IActionResult Create()
    {
      return View();
    }
    [HttpPost]
    public IActionResult Create(Dog dog)
    {
      Dog.Post(dog);
      return RedirectToAction("Index");
    }
    public IActionResult Edit(int id)
    {
      var dog = Dog.GetDetails(id);
      return View(dog);
    }

    [HttpPost]
    public IActionResult Details(int id, Dog dog)
    {
      dog.DogId = id;
      Dog.Put(dog);
      return RedirectToAction("Details", id);
    }

    public IActionResult Delete(int id)
    {
      Dog.Delete(id);
      return RedirectToAction("Index");
    }
  }
}