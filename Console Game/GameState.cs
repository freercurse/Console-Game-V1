using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Game
{
  class GameState
  {
    public int Time;
    public int Day;
    public double DailyLuck;
    public int Week;
    public double WeeklyInterest;
    public int WinningBetlimit;

    public void IterateTime(Boolean Sleep)
    {
      if(this.Time == 23 || Sleep == true)
      {
        this.Time = 10;

        if(this.Day != 7)
        {
          this.Day++;
        } else
        {
          this.Day = 1;
          this.Week++;
          this.IterateWeek();
        }

        this.IterateDay();

      } else
      {
        this.Time++;
      }
    }

    private void IterateWeek()
    {
      Console.WriteLine("Probably should perform some Weekly modifier changes");
    }

    private void IterateDay()
    {
      Console.WriteLine("Probably should perform some Daily modifier changes");
    }
  }    
}
