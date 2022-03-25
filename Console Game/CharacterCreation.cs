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
  public partial class CharacterCreation : Form
  {
    private Player player1;
    private Random rn;
    private Form MM;
    public CharacterCreation(Player player, Form mm)
    {
      InitializeComponent();
      player1 = player;
      rn = new Random();
      MM = mm;
    }  

    private void CharacterCreation_Load(object sender, EventArgs e)
    {

    }
    private void StartButton_Click(object sender, EventArgs e)
    {      
      int H = Convert.ToInt32(textBoxHealth.Text);
      int L = Convert.ToInt32(textBoxHealth.Text);
      int S = Convert.ToInt32(textBoxHealth.Text);
      int M = Convert.ToInt32(textBoxHealth.Text);
      double D = rn.NextDouble() * 4;

      player1.SetFace(picture1.Name);

      if(H+L+S+M == 8)
      {
        player1.SetStats(H, M, L + rn.Next(0, 3), S, D);
        player1.SetName(textBoxName.Text);
        //TODO open Game screen
      } else
      {
        MessageBox.Show("You can do math right.\n They all need to add up 8", "MATH ERROR");
      }

      
    }

    private void buttonBack_Click(object sender, EventArgs e)
    {
      MM.Show();
      this.Close();
    }
  }
}
