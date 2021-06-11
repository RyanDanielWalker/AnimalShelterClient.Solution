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
  }
}