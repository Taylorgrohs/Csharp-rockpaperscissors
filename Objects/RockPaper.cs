using System;
using System.Collections.Generic;

namespace RockPaperCookout
{
  public class RockPaperScissors
  {
    public string DoBattle(string player1, string player2)
    {
      if (player1 == player2)
      {
        return "draw";
      }
      else if (player1 == "rock" && player2 == "scissors")
      {
        return "Player 1 Wins!";
      }
      else if (player1 == "scissors" && player2 == "rock")
      {
        return "Player 2 Wins!";
      }
      else if (player1 == "paper" && player2 == "rock")
      {
        return "Player 1 Wins!";
      }
      else if (player1 == "rock" && player2 == "paper")
      {
        return "Player 2 Wins!";
      }
      else if (player1 == "scissors" && player2 == "paper")
      {
        return "Player 1 Wins!";
      }
      else if (player1 == "paper" && player2 == "scissors")
      {
        return "Player 2 Wins!";
      }
      else
      {
        return "invalid";
      }
    }
  }
}
