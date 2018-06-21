using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace UnitConversionMVC99.Controllers
{
    public class FirstController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GallonsLiters()
        {
            List<double> list = new List<double>();
            list.Add(0d);
            list.Add(0d);
            return View(viewName: "GallonsLiters", model: list);
        }

        [HttpPost]
        public IActionResult ConvertGL(double gallons, double liters)
        {
            List<double> units = new List<double>();
            if (gallons != 0)
            {
                units.Add(gallons);
                units.Add(gallons * 3.78541);
            }
            else if (liters != 0)
            {
                units.Add(liters / 3.78541);
                units.Add(liters);
            }
            return View(viewName: "GallonsLiters", model: units);
        }
    }
}