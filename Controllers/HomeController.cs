using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DOJOSURVEYWITHVALIDATIONS.Models;

namespace DOJOSURVEYWITHVALIDATIONS.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            return View("Index");
        }
        [HttpPost("")]
        public IActionResult Create(Survey mySurvey)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("Results", mySurvey);
            }
            else
            {
                // Oh no!  We need to return a ViewResponse to preserve the ModelState, and the errors it now contains!
                return View("Index");
            }
        }
        [HttpGet("results")]
        public IActionResult Results(Survey mySurvey)
        {
            return View("Results", mySurvey);
        }
    }
}
