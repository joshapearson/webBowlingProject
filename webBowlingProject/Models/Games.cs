using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webBowlingProject.Models
	{
	public class Games
		{
		public int GameId { get; set; }
		public int frames { get; set; }
		public int Score { get; set; }
		public int Pins { get; set; }
		public string player { get; set; }

		}
	}