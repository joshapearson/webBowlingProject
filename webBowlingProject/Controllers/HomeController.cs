using System;
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
			
			Games game = new Games()
				{
				Pins = roll,
				GameId = model.GameId,
				frames = Frames[1],
				Score = model.Score,
				player = model.player,
				};
			return View("Index", model);
			}

		//public ActionResult About()
		//	{
		//	ViewBag.Message = "Your application description page.";

		//	return View();
		//	}

		//public ActionResult Contact()
		//	{
		//	ViewBag.Message = "Your contact page.";

		//	return View();
		//	}
		//}
		}
	}








   