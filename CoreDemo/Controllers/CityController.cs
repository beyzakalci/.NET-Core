using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class CityController : Controller
    {
        CityManager cm = new CityManager(new EfCityRepository());
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetCity()
        {
            var cities = cm.GetList().ToList();
            ViewBag.Cities = cities;
            return View(cities);
        }
    }
}
