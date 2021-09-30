using System;
using Microsoft.AspNetCore.Mvc;

namespace WebIntro.Controllers
{
    public class IntroController : Controller
    {
        [HttpGet]
        [Route("")]
        public string Index()
        {
            return "hey it's me, the index route!!!";
        }

        [HttpGet("other")]
        public string Other()
        {
            Console.WriteLine("hey I'm printing out in the console!!!");
            return "this is the other route!";
        }

        [HttpGet("other/more")]
        public string More()
        {
            return "this is the other route! but wait there's more!";
        }

        [HttpGet("repeat/{phrase}")]
        public string Repeat(string phrase)
        {
            return $"the phrase you entered is: {phrase}";
        }

        [HttpGet("repeat/{phrase}/{times}")]
        public string Repeat(string phrase, int times)
        {
            string repeatedPhrase = "";
            for(int i = 0; i < times; i++)
            {
                repeatedPhrase += phrase + " ";
            }
            return repeatedPhrase;
        }

        [HttpGet("main")]
        public IActionResult Main()
        {
            return View();
        }

        [HttpGet("random")]
        public IActionResult Random()
        {
            return View("OtherPage");
        }
    }
}