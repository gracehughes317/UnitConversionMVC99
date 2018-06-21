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

        public ActionResult DollarsPounds()
        {
            return View(viewName: "DollarsPounds", model: 0.0);
        }

        [HttpPost]
        public ActionResult ToPounds(double dollars)
        {
           double pounds = dollars * 1.32;
            return View(viewName: "DollarsPounds", model: pounds);
        }
        [HttpPost]
        public ActionResult ToDollars(double pounds)
        {
            double dollars = pounds * 0.72;
            return View(viewName: "DollarsPounds", model: dollars);
        }


    }
}