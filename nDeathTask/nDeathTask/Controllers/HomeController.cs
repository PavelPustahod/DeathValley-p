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
            if (p.ACoeff == 0)
                ModelState.AddModelError("ACoeff", "A coefficient can't be 0");
            if (p.BCoeff == 0)
                ModelState.Remove("BCoeff");
            if (p.CCoeff == 0)
                ModelState.Remove("CCoeff");
            if (p.LowerBorder == p.UpperBorder)
                ModelState.AddModelError("LowerBorder", "Borders can't be equal");

            if (ModelState.IsValid)
            {
                List<Point> points = new List<Point>();
                double y = 0;
                if (p.LowerBorder < p.UpperBorder)
                {
                    for (double i = p.LowerBorder; i < p.UpperBorder; i += p.Step)
                    {
                        y = p.ACoeff * (i * i) + p.BCoeff * i + p.CCoeff;
                        points.Add(new Point(i, y));

                    }
                }
                else
                {
                    for (double i = p.UpperBorder; i < p.LowerBorder; i += p.Step)
                    {
                        y = p.ACoeff * (i * i) + p.BCoeff * i + p.CCoeff;
                        points.Add(new Point(i, y));

                    }
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