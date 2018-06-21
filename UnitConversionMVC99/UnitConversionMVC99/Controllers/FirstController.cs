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
    }
}