using Dotnetcore_Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Dotnetcore_Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Celebrations()
        {
            return View();
        }
        public IActionResult Festivals()
        {
            return View();
        }

        public IActionResult Invitation()
        {
            return View();
        }


        public IActionResult Cards()
        {
            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Sigin()
        {
            return View();
        }

        public IActionResult Sigup()
        {
            return View();
        }

        public IActionResult Trial()
        {
            return View();
        }
        public IActionResult Trial2()
        {
            return View();
        }

        public IActionResult Trial3()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
