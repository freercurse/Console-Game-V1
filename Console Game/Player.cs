using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Game
{
  class Player
  {
    public int Health;
    public int Money;
    public double Luck;
    public int Strength;
    public double Divine;
    public Boolean God;



    public void SetStats(int H, int M, double L, int S, double D)
    {
      this.Health = H;
      this.Money = M;
      this.Luck = L;
      this.Strength = S;
      this.Divine = D;
    }

    protected String ToggleGod()
    {
      switch (this.God)
      {
        case false:
          this.God = true;
          break;
        case true:
          this.God = false;
          break;        
      }

      return ("fine you loser");
    }

    public override string ToString()
    {
      return base.ToString();
    }

  }
}
