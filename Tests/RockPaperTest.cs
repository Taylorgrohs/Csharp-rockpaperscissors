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
      Assert.Equal(true, testRPS.DoBattle("rock", "rock"));
    }
    [Fact]
    public void DoBattle_DrawFalse()
    {
      RockPaperScissors testRPS = new RockPaperScissors();
      Assert.Equal(false, testRPS.DoBattle("rock", "paper"));
    }
  }
}
