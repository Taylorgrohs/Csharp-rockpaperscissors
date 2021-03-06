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
      Get["/2player"] = _ => {
        return View["2player.cshtml"];
      };
      Post["/2playerwinner"] = _ => {
        var player1 = Request.Form["player1"];
        var player2 = Request.Form["player2"];
        RockPaperScissors newGame = new RockPaperScissors();
        string winner = newGame.DoBattle(player1, player2);

        return View["2playerwinner.cshtml", winner];
      };
      Get["/computer"] = _ => {
        return View["computer.cshtml"];
      };
      Post["/computerwinner"] = _ => {
        RockPaperScissors newGame = new RockPaperScissors();

        var player1 = Request.Form["player1"];
        var player2 = newGame.ComputerBattle();
        string winner = newGame.DoBattle(player1, player2);
        return View["computerwinner.cshtml", winner];
      };
    }
  }
}
