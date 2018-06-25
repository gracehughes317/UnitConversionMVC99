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
   
    public ActionResult FtoC()
    {
            List<double> fc = new List<double>();
            fc.Add(0d);
            fc.Add(0d);
            return View(viewName: "FtoC", model: fc);
    }


    [HttpPost]
    public ActionResult ToCelsius(double F, double C)
    {
        List<double> fc = new List<double>();
            /*if (F != 0)
                {
                    fc.Add((F - 32) * 0.5556);
                    fc.Add(F);
                }
            if (C != 0)
                {
                    fc.Add(C);
                    fc.Add((C * 1.8) + 32);
                }*/
            if (F == 0 || C == 0)
            {
                if (F == 0)
                {
                    F = (C * 1.8) + 32;
                }

                if (C == 0)
                {
                    C = (F - 32) * 0.5556;
                }
                fc.Add(F);
                fc.Add(C);
            }
            return View(viewName: "FtoC", model: fc);
    }
  }
}