using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Game
{
  public class Player
  {
    public string Name;
    private string Face;
    private int Difficulty;    
    private int Seed;
    public int Health;
    public int Energy = 100;
    public int Money;
    public int Luck;
    public int Strength;
    private double Divine;
    private Boolean God;

    private int LProgress =0;
    private int HProgress =0;
    private int SProgress =0;
    private int MProgress =0;


    public void SetStats(int H, int M, int L, int S, double D)
    {
      this.Health = H;
      this.Money = M;
      this.Luck = L;
      this.Strength = S;
      this.Divine = D;
    }
    
    public void SetName(string name)
    {
      this.Name = name;
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

    public void SetFace(string face)
    {
      this.Face = face;
    }
    public void SetDifficulty(int D)
    {
      this.Difficulty = D;
    }
    public void SetSeed(int S)
    {
      this.Seed = S;
    }    

    public void iterateProgress(string type,int value)
    {
      switch (type)
      {
        case "H":
          this.HProgress += value;
          break;
        case "M":
          this.MProgress += value;
          break;
        case "S":
          this.SProgress += value;
          break;
        case "L":
          this.LProgress += value;
          break;
      }
    }
    
    public int getProgress(string type)
    {
      switch (type)
      {
        case "H":
          return this.HProgress;          
        case "M":
          return this.MProgress;
        case "S":
          return this.SProgress;
        case "L":
          return this.LProgress;
      }

      return -1;
    }

    public override string ToString()
    {
      return base.ToString();
    }

    

  }
}
