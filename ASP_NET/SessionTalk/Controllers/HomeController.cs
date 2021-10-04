using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SessionTalk.Models;
using Microsoft.AspNetCore.Http;

namespace SessionTalk.Controllers
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
            ViewBag.PersonName = HttpContext.Session.GetString("PersonName");
            int? SessionTimes = HttpContext.Session.GetInt32("Times");
            if(SessionTimes == null)
            {
                Console.WriteLine("session returned null");
                ViewBag.Times = 0;
            }
            else
            {
                ViewBag.Times = (int)SessionTimes;
            }

            return View();
        }

        [HttpPost("submitName")]
        public IActionResult SubmitName(string Name, int Times)
        {
            // Console.WriteLine(Name);
            HttpContext.Session.SetString("PersonName", Name);
            HttpContext.Session.SetInt32("Times", Times);

            return RedirectToAction("Index");
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
    }
}
