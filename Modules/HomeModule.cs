using Nancy;
using System;
using System.Collections.Generic;
using RockPaperCookout;

namespace TheRocksCookout
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Post["/winner"] = _ => {
        var player1 = Request.Form["player1"];
        var player2 = Request.Form["player2"];
        RockPaperScissors newGame = new RockPaperScissors();
        string winner = newGame.DoBattle(player1, player2);

        return View["winner.cshtml", winner];
      };
    }
  }
}
