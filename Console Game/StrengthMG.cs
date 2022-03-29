using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Console_Game
{
  public partial class StrengthMG : Form
  {    
    private Random rnd;
    private int[] MyArray;
    private int[] RndArray;    
    private Player player;
    private GameState gst;
    public StrengthMG(Player player1, GameState gameState)
    {
      gst = gameState;
      player = player1;
      rnd = new Random();
      MyArray = new int[] { 1, 2, 3, 4, 5, 6 };
      
      
      InitializeComponent();
    }

    private void StrengthMG_Load(object sender, EventArgs e)
    {
      MyArray = MyArray.OrderBy(x => rnd.Next()).ToArray();
     
    }

    private void getWin(string name)
    {
      int mod = gst.AW;
      switch (name)
      {
        case "one":
          player.iterateProgress("S", MyArray[0] * mod);
          break;
        case "two":
          player.iterateProgress("S", MyArray[1] * mod);
          break;
        case "three":
          player.iterateProgress("S", MyArray[2] * mod);
          break;
        case "four":
          player.iterateProgress("S", MyArray[3] * mod);
          break;
        case "five":
          player.iterateProgress("S", MyArray[4] * mod);
          break;
        case "six":
          player.iterateProgress("S", MyArray[5] * mod);
          break;

      }
      MessageBox.Show("Updated strength progress " + player.getProgress("S"), "Congratulations");
      this.Close();      
    }

    private void button1_Click(object sender, EventArgs e)
    {
      this.getWin("one");
    }

    private void button2_Click(object sender, EventArgs e)
    {
      this.getWin("two");
    }

    private void button3_Click(object sender, EventArgs e)
    {
      this.getWin("three");
    }

    private void button4_Click(object sender, EventArgs e)
    {
      this.getWin("four");
    }

    private void button5_Click(object sender, EventArgs e)
    {
      this.getWin("five");
    }

    private void button6_Click(object sender, EventArgs e)
    {
      this.getWin("six");
    }
  }
}
