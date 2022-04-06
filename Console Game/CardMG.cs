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
  public partial class CardMG : Form
  {
    private Random rnd;
    private Player player;
    private GameState gst;
    private double Bounty;
    private int card;
    public CardMG(Player player1, GameState gameState)
    {
      InitializeComponent();

      gst = gameState;
      player = player1;
      rnd = new Random();
    }

    private void buttonLower_Click(object sender, EventArgs e)
    {
      GameStep(false);
    }

    private void buttonHigher_Click(object sender, EventArgs e)
    {
      GameStep(true);
    }

    private void GameStep(bool but)
    {
      
      int prevCard = card;
      card = card = rnd.Next(1, 13);
      buttonCard.Text = card.ToString();
      if (but == false && prevCard >= card)
      {
        Bounty += 5;
        Bounty *= 1.2;        
      }else if (but == true && prevCard <= card)
      {
        Bounty += 5;
        Bounty *= 1.2;
      }
      else
      {
        MessageBox.Show("Bad luck you lost all of your bounty ", "Unlucky");
        this.Close();
      }
      labelBounty.Text = Bounty.ToString();
    }

    private void CardMG_Load(object sender, EventArgs e)
    {
      card = rnd.Next(1, 13);
      buttonCard.Text = card.ToString();
    }

    private void buttonCash_Click(object sender, EventArgs e)
    {
      int mod = gst.AW;
      player.iterateProgress("L", (int)(Bounty * mod));
      MessageBox.Show("Updated Luck progress " + player.getProgress("L"), "Congratulations");
      this.Close();
    }
  }
}
