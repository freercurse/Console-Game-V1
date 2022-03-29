using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Console_Game
{
  public partial class GameScreen : Form
  {
    private GameState gst;
    private Player player;
    public GameScreen(Form mm, Player player1, GameState GST)
    {
      InitializeComponent();
      player = player1;
      gst = GST;
      setValues();
      labelName.Text = player.Name;
    }

    private void setValues()
    {
      progressBarEnergy.Value = player.Energy;
      progressBarHealth.Value = player.Health;      
      progressBarStrength.Value = player.Strength;      
      progressBarLuck.Value = player.Luck;      
      progressBarMoney.Value = player.Money;
      labelDay.Text = gst.Day.ToString();
      labelWeek.Text = gst.Week.ToString();
    }

    private void buttonSleep_Click(object sender, EventArgs e)
    {
      gst.IterateTime();
      setValues();
    }

    private void buttonWeight_Click(object sender, EventArgs e)
    {
      if(player.Energy >= 20)
      {
        StrengthMG sg = new StrengthMG(player,gst);
        sg.Show();
        progressBarEnergy.Step = -20;
        progressBarEnergy.PerformStep();
        progressBarEnergy.Step = -10;
      } else
      {
        MessageBox.Show("You are so tired you cant even pick up the weights before fainting", "Fainted");
        gst.IterateTime();
        setValues();
      }
      
    }
  }
}
