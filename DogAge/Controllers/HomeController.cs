using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DogAgeCalculator.Models;

namespace DogAgeCalculator.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Calculate()
        {
            // no data displayed initially
            return View();
        }

        // process data, display Age and Size
        [HttpPost]
        public ActionResult Calculate(Dog dog)
        {
            return View(dog);
        }
    }
}