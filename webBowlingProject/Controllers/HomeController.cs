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
            int[] Frames = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for (int i = 0; i < 9; i++)
            {
                Games game = new Games()
                {
                    Pins = roll,
                    GameId = model.GameId,
                    frames = Frames[i],
                    Score = model.Score,
                    player = model.player,
                };
            }
            return View("Index", model);
			}
            public JsonResult getFrame(int Frames)
        {
            return Json(JsonRequestBehavior.AllowGet);
        }
		}
	}








   