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
            if (inches == 0 || cm == 0)
            {
                if (inches == 0)
                {
                    
                   double val1 = cm / 2.54;
                   inches= Math.Round(100 * val1) / 100;
                }

                if (cm == 0)
                {
                    double val1 = inches * 2.54;
                    cm = Math.Round(100 * val1) / 100;
                }
                bob.Add(inches);
                bob.Add(cm);
            }
            return View(viewName: "CmtoIn", model: bob);
        }

   }
}