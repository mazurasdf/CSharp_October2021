using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HangMan.Models;
using Microsoft.AspNetCore.Http;

namespace HangMan.Controllers
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

        [HttpPost("start")]
        public IActionResult StartGame(string Word)
        {
            //incorrect guesses, blank spaces(with guesses filled in later), image url, THE word
            Word = Word.ToUpper();
            
            HttpContext.Session.SetString("Answer", Word);
            HttpContext.Session.SetString("Incorrect", "");

            string emptyGuesses = "";
            for(int i = 0; i < Word.Length; i++){
                emptyGuesses += "_";
            }
            Console.WriteLine(emptyGuesses);
            HttpContext.Session.SetString("Hint", emptyGuesses);
            HttpContext.Session.SetString("ImgURL", "~/img/0.png");

            return RedirectToAction("Game");
        }

        [HttpGet("game")]
        public IActionResult Game()
        {
            ViewBag.Incorrect = HttpContext.Session.GetString("Incorrect");
            ViewBag.Hint = HttpContext.Session.GetString("Hint");
            ViewBag.ImgURL = Url.Content(HttpContext.Session.GetString("ImgURL"));
            return View();
        }

        [HttpPost("guess")]
        public IActionResult GuessLetter(string Letter)
        {
            if(Letter.Length < 1) return RedirectToAction("Game");
            
            char GuessedLetter = Letter.ToUpper()[0];

            string Incorrect = HttpContext.Session.GetString("Incorrect");
            string Answer = HttpContext.Session.GetString("Answer");
            string Hint = HttpContext.Session.GetString("Hint");
            string ImgURL = HttpContext.Session.GetString("ImgURL");

            string newHint = "";

            if(Answer.Contains(GuessedLetter))
            {
                Console.WriteLine("correct!");
                for(int i = 0; i < Answer.Length; i++)
                {
                    if(GuessedLetter == Answer[i])
                    {
                        newHint += GuessedLetter;
                    }
                    else
                    {
                        newHint += Hint[i];
                    }
                }
                Hint = newHint;
            }
            else
            {
                Incorrect += GuessedLetter;
                ImgURL = $"~/img/{Incorrect.Length}.png";
                Console.WriteLine(ImgURL);
            }

            if(!Hint.Contains("_"))
            {
                ImgURL = "~/img/win.png";
            }


            //set sessions again
            HttpContext.Session.SetString("Incorrect", Incorrect);
            HttpContext.Session.SetString("Answer", Answer);
            HttpContext.Session.SetString("Hint", Hint);
            HttpContext.Session.SetString("ImgURL", Url.Content(ImgURL));

            return RedirectToAction("Game");
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
