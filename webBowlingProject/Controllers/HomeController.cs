using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;
using webBowlingProject.Models;
using webBowlingProject.ViewModels;

namespace webBowlingProject.Controllers
	{

    public class HomeController : Controller
    {

        public ActionResult Index(GamesViewModel model)
        {
            Random rnd = new Random();
            int roll = rnd.Next(1, 10);
            int[] Frames = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var vm = new List<Games>
            {
                new Games {frames = Frames[0], Pins = roll, Score = model.Pins  }
            };
            return View (vm);
        }

        public JsonResult getFrame(int GameId)
        {
			Games games = new Games();
			gamesAjax i = new gamesAjax { Pins = games.Pins, frames = games.frames, score = games.Score };
            return Json(i, JsonRequestBehavior.AllowGet);
        }

		private class gamesAjax
			{
			public int Pins { get; set; }
			public int frames { get; set; }
			public int score { get; set; }

			}
		}
	}



//Random rnd = new Random();
//         int roll = rnd.Next(1, 10);

//             Games game = new Games()
//             {
//                 Pins = roll,
//                 GameId = model.GameId,
//                 frames = model.frames,
//                 Score = model.Score,
//                 player = model.player,
//             };
//         return View("Index", model);





