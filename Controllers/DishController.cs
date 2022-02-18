using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ChefsNDishes.Models;
using Microsoft.EntityFrameworkCore;

namespace ChefsNDishes.Controllers
{
    public class DishController : Controller
    {
        private ChefsNDishesContext db;
        public DishController(ChefsNDishesContext context)
        {
            db = context;
        }

        [HttpGet("/alldishes")]
        public ViewResult AllDishes()
        {
            List<Dish> allDishes = db.Dishes
                .Include(c => c.Creator)
                .ToList();

            return View("AllDishes", allDishes);
        }

        [HttpGet("/dish/new")]
        public ViewResult NewDish()
        {
            List<Chef> allChefs = db.Chefs
                .ToList();
            ViewBag.allChefs = allChefs;
            
            return View("New");
        }

        [HttpPost("/dish/create")]
        public IActionResult CreateDish(Dish newDish)
        {
            List<Chef> allChefs = db.Chefs
                .ToList();
            ViewBag.allChefs = allChefs;

            if(ModelState.IsValid == false)
            {
                return View("New");
            }

            Dish dishCheck = db.Dishes.FirstOrDefault(d => d.Name == newDish.Name);
            if (dishCheck == null)
            {
                // newDish.Creator = 
                db.Add(newDish);
                db.SaveChanges();
                return RedirectToAction("AllDishes", "Dish");
            }
            ModelState.AddModelError("Name", "This dish already exists!");
            return View("New");
        }
    }
}

