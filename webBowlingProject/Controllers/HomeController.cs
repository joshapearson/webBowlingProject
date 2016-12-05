using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
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
                Games game = new Games()
                {
                    Pins = roll,
                    GameId = model.GameId,
                    frames = model.frames,
                    Score = model.Score,
                    player = model.player,
                };
         
            return View("Index", model);
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








   