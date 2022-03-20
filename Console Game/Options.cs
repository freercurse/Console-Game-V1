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
  

  public partial class Options : Form
  {
    private Player player1;

    public Options(Player player)
    {
      InitializeComponent();
      player1 = player;      
    }

    private void CButton_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void ADButton_Click(object sender, EventArgs e)
    {
      player1.SetDifficulty(DifficultyCB.SelectedIndex);
    }

    private void ASButton_Click(object sender, EventArgs e)
    {
      player1.SetSeed(Convert.ToInt32(SeedTB.Text));
    }
  }
}
