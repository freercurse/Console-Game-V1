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
  public partial class GameScreen : Form
  {

    private Player player;
    public GameScreen(Form mm, Player player1)
    {
      InitializeComponent();
      player = player1;
      setValues();
    }

    private void setValues()
    {
      progressBarHealth.Value = player.Health;
      progressBarStrength.Value = player.Strength;
      progressBarLuck.Value = player.Luck;
      progressBarMoney.Value = player.Money;
    }
  }
}
