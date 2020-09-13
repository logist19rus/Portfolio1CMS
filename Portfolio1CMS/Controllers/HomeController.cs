using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Portfolio1CMS.Models;

namespace Portfolio1CMS.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult GetIntro()
        {
            return PartialView("_GetIntro");
        }
        public IActionResult GetAdvantages()
        {
            return PartialView("_GetAdvantages");
        }
        public IActionResult GetInfo()
        {
            return PartialView("_GetInfo");
        }
        public IActionResult GetServices()
        {
            return PartialView("_GetServices");
        }
        public IActionResult GetFeedback()
        {
            return PartialView("_GetFeedback");
        }
        public IActionResult GetTeam()
        {
            return PartialView("_GetTeam");
        }
        public IActionResult GetContact()
        {
            return PartialView("_GetContact");
        }
    }
}
