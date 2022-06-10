using Juan.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Juan.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Slide slide = new Slide();
            return View(slide);
        }
    }
}
