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
  public partial class MainMenu : Form
  {
    private Player player1;
    public MainMenu()
    {
      InitializeComponent();
      player1 = new();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      
    }

    private void OPButton_Click(object sender, EventArgs e)
    {
      Form Op = new Options(player1);
      Op.Show();      
    }

    private void QButton_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void NGButton_Click(object sender, EventArgs e)
    {
      Form CharCre = new CharacterCreation(player1,this);
      CharCre.Show();
      this.Hide();
    }
  }
}
