using System;
using Microsoft.AspNetCore.Mvc;

namespace ChooseYourOwnAdventure.Controllers
{
    public class AdventureController : Controller
    {
        [HttpGet("")]
        public IActionResult Main()
        {
            return RedirectToAction("Room", new {id = 1});
        }

        [HttpGet("other")]
        public IActionResult Other()
        {
            return RedirectToAction("Main");
        }

        [HttpGet("repeat/{word}/{times}")]
        public IActionResult Repeat(string word, int times)
        {
            ViewBag.Word = word;
            ViewBag.Times = times;
            return View();
        }

        [HttpGet("room/death")]
        public IActionResult Death()
        {
            return View();
        }

        [HttpGet("room/{id}")]
        public IActionResult Room(int id)
        {
            if(id == 1)
            {
                ViewBag.Story = "You walk into a dungeon that is quite dark and damp. It's a little smelly. Smells like......dragon's blood. There are two doors in front of you. Pick either one.";
                ViewBag.Door1 = 2;
                ViewBag.Door2 = 3;
            }
            else if(id == 2)
            {
                ViewBag.Story = "oh no you happened to walk right into the dragon's imediately!!! YOu instantly regret your decision and try to click the back button. But it's too late. You have been burninated by the dragon...";
                ViewBag.Door1 = "death";
                ViewBag.Door2 = "death";
            }
            else if(id == 3)
            {
                ViewBag.Story = "There are so many potions in this room. Hundreds, possible thousands of vials. Yet there are two doors each with an image of a potion on it. Your eye is caught by these doors and you wish you enter so you may try their special 'behind closed doors potion'. Door 1 has a bubbly green potion. Door 2 has a shiny looking color changing potion";
                ViewBag.Door1 = "4";
                ViewBag.Door2 = "5";
            }
            else if(id == 4)
            {
                ViewBag.Story = "You enter the room for the bubbly potion. It's a dark room lit by only a single candle light. On a table is the single vial of green potion. It's bubbling quite intensely. You walk to pick it up and before you can even take a sip, your breath is lifted from your mouth. You get sudden chills and you slowly turn around to see...........the DRAGON has closed the door. Surely this was the wrong choice. I will spare and let you gues what happens.";
                ViewBag.Door1 = "death";
                ViewBag.Door2 = "death";
            }
            else if(id == 5)
            {
                ViewBag.Story = "Clowns.";
                ViewBag.Door1 = "6";
                ViewBag.Door2 = "6";
            }
            else if(id == 6)
            {
                ViewBag.Story = "this was surely a mistake to enter an unknown dungeon. A dark, damp place lit by only your own imagination. What did you think would happen? The best move would have been to not play the game.";
                ViewBag.Door1 = "death";
                ViewBag.Door2 = "death";
            }
            

            return View();
        }
    }
}