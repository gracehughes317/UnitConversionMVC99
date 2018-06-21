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
        public IActionResult MilesKm()
        {
            List<double> inputsF = new List<double>(2) {0d,0d };
            return View(viewName: "MilesKm", model: inputsF);
        }
        public IActionResult GallonsLiters()
        {
            List<double> list = new List<double>();
            list.Add(0d);
            list.Add(0d);
            return View(viewName: "GallonsLiters", model: list);
        }
        [HttpPost]
        public ActionResult MilesKm(double input1, double input2)
        {
            if (input1 == 0 || input2 == 0)
            {
                if (input1 == 0)
                {
                    input1 = input2 / 1.609;
                }
                if (input2 == 0)
                {
                    input2 = input1 * 1.609;
                }
            }
            List<double> inputs = new List<double>();
            inputs.Add(input1);
            inputs.Add(input2);
            return View(viewName: "MilesKm", model: inputs);
        }
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