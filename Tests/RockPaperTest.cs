using Xunit;
using System.Collections.Generic;
using System;
namespace RockPaperCookout
{
  public class RockPaperTest
  {
    [Fact]
    public void DoBattle_DrawTrue()
    {
      RockPaperScissors testRPS = new RockPaperScissors();
      Assert.Equal("draw", testRPS.DoBattle("rock", "rock"));
    }
    [Fact]
    public void DoBattle_DrawFalse()
    {
      RockPaperScissors testRPS = new RockPaperScissors();
      Assert.Equal("invalid", testRPS.DoBattle("rock", "pickle"));
    }
    [Fact]
    public void DoBattle_Player1_RockWins()
    {
      RockPaperScissors testRPS = new RockPaperScissors();
      Assert.Equal("Player 1 Wins!", testRPS.DoBattle("rock", "scissors"));
    }
    [Fact]
    public void DoBattle_Player2_RockWins()
    {
      RockPaperScissors testRPS = new RockPaperScissors();
      Assert.Equal("Player 2 Wins!", testRPS.DoBattle("scissors", "rock"));
    }
    [Fact]
    public void DoBattle_Player1_PaperWins()
    {
      RockPaperScissors testRPS = new RockPaperScissors();
      Assert.Equal("Player 1 Wins!", testRPS.DoBattle("paper", "rock"));
    }
    [Fact]
    public void DoBattle_Player2_PaperWins()
    {
      RockPaperScissors testRPS = new RockPaperScissors();
      Assert.Equal("Player 2 Wins!", testRPS.DoBattle("rock", "paper"));
    }
    [Fact]
    public void DoBattle_Player1_ScissorsWins()
    {
      RockPaperScissors testRPS = new RockPaperScissors();
      Assert.Equal("Player 1 Wins!", testRPS.DoBattle("scissors", "paper"));
    }
    [Fact]
    public void DoBattle_Player2_ScissorsWins()
    {
      RockPaperScissors testRPS = new RockPaperScissors();
      Assert.Equal("Player 2 Wins!", testRPS.DoBattle("paper", "scissors"));
    }
  }
}
