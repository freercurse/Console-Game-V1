using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Game
{
  public class GameState
  {
    private readonly Player player1;

    public int AM = 1;
    public int AB = 1;
    public int AC = 1;
    public int AW = 1;
    public int AV = 1;
    
    public GameState(Player player)
    {
      player1 = player;
    }

    public int Day = 0;
    public double DailyLuck;
    public int Week = 0;
    public double WeeklyInterest;
    public int WinningBetlimit;

    public void IterateTime() 
    {     
      if(this.Day != 7)
      {
        this.Day++;
      } else
      {
        this.Day = 0;
        this.Week++;
        this.IterateWeek();
      }

      this.IterateDay();      
    }

    private void IterateWeek()
    {
      Console.WriteLine("Probably should perform some Weekly modifier changes");
    }

    private void IterateDay()
    {
      player1.Energy = 100;
      Console.WriteLine("Probably should perform some Daily modifier changes");
    }
  }    
}
