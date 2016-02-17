using System;
using System.Collections.Generic;

namespace RockPaperCookout
{
  public class RockPaperScissors
  {
    public bool DoBattle(string player1, string player2)
    {
      if (player1 == player2)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}
