using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace UnitConversionMVC99.Controllers
{
    public class FirstController : Controller
    {
        public ActionResult CmtoIn()
        {
            List<double> bob = new List<double>(2) { 0d, 0d };
            return View(viewName: "CmtoIn", model: bob);
        }
      
        [HttpPost]
        public ActionResult cmtoinches(double inches, double cm)
        {
            List<double> bob = new List<double>();
            if (Math.Abs(inches) < 0.001 || Math.Abs(cm) < 0.001)
            {
                if (Math.Abs(inches) < 0.001)
                {
                    
                   double val1 = cm / 2.54;
                   inches= Math.Round(1000 * val1) / 1000;
                }

                if (Math.Abs(cm) < 0.001)
                {
                    double val1 = inches * 2.54;
                    cm = Math.Round(1000 * val1) / 1000;
                }
                bob.Add(inches);
                bob.Add(cm);
            }
            return View(viewName: "CmtoIn", model: bob);
        }

   }
}