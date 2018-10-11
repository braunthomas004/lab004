using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace lab004.Controllers
{
    public class Lab4Controller : Controller
    {
        public IActionResult Index()
        {
            ViewData["date1"] = DateTime.Now.ToShortTimeString();
            ViewData["date2"] = DateTime.Now.ToLongDateString();
            DateTime now = DateTime.Now;
            DateTime end = new DateTime(now.Year + 1, 1, 1);
            int daysLeftInYear = (int)(end - now).TotalDays;
            ViewData["date3"] = daysLeftInYear;
            ViewData["year1"] = now.Year;
            ViewData["testing"] = DateTime.Now.Hour;
            if (DateTime.Now.Hour < 12 ) { ViewData["greeting"] = "Good Morning"; }
            else if (DateTime.Now.Hour > 18) { ViewData["greeting"] = "Good Evening"; }
            else { ViewData["greeting"] = "Good Afternoon"; }
            return View();
        }
        public IActionResult Waffles()
        {
            return View();
        }
    }
}