using Microsoft.AspNetCore.Mvc;
using Carsweb.Models;
using System.Collections.Generic;

namespace Carsweb.Controllers
{
    public class CarsController : Controller
    {
        private static List<Cars> cars = new List<Cars>
        {
            new Cars { Id = 1, Name = "S63", Brand = "Mercedes", Price = 185000 },
            new Cars { Id = 2, Name = "RS6", Brand = "Audi", Price = 160000 },
            new Cars { Id = 3, Name = "M5", Brand = "BMW", Price = 145000 }
        };

        public IActionResult Index()
        {
            return View(cars);
        }

        public IActionResult Details(int id)
        {
            var car = cars.Find(c => c.Id == id);
            if (car == null) return NotFound();
            return View(car);
        }
    }
}