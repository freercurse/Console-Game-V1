﻿using System;
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
    public MainMenu()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void OPButton_Click(object sender, EventArgs e)
    {
      Form Op = new Options();
      Op.Show();      
    }

    private void QButton_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }
  }
}