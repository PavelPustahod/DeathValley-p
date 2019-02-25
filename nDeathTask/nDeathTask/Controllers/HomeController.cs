using System;
using System.Collections.Generic;
using nDeathTask.Models;
using System.Web.Mvc;
using Newtonsoft.Json;

namespace nDeathTask.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ViewResult Index()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Index(ParabolaCoefficients p)
        {
            if (p.LowerBorder > p.UpperBorder)
                ModelState.AddModelError("LowerBorder", "Lower border must be less then upper border");
            if (ModelState.IsValid)
            {
                List<Point> points = new List<Point>();
                double y = 0;
                for (double i = p.LowerBorder; i < p.UpperBorder; i += p.Step)
                {
                    y = p.ACoeff * (i * i) + p.BCoeff * i + p.CCoeff;
                    points.Add(new Point(i, y));

                }
                ViewBag.DataPoints = JsonConvert.SerializeObject(points);
                return View();
            }
            else
            {
                return View();
            }
            
        }

    }
}