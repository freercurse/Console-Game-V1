
namespace Console_Game
{
  partial class MainMenu
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.NGButton = new System.Windows.Forms.Button();
      this.LGButton = new System.Windows.Forms.Button();
      this.OPButton = new System.Windows.Forms.Button();
      this.QButton = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
      this.pictureBox1.Location = new System.Drawing.Point(8, 12);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(408, 75);
      this.pictureBox1.TabIndex = 0;
      this.pictureBox1.TabStop = false;
      // 
      // NGButton
      // 
      this.NGButton.Location = new System.Drawing.Point(155, 144);
      this.NGButton.Name = "NGButton";
      this.NGButton.Size = new System.Drawing.Size(118, 30);
      this.NGButton.TabIndex = 1;
      this.NGButton.Text = "New Game";
      this.NGButton.UseVisualStyleBackColor = true;
      // 
      // LGButton
      // 
      this.LGButton.Location = new System.Drawing.Point(155, 195);
      this.LGButton.Name = "LGButton";
      this.LGButton.Size = new System.Drawing.Size(118, 30);
      this.LGButton.TabIndex = 2;
      this.LGButton.Text = "Load Game";
      this.LGButton.UseVisualStyleBackColor = true;
      // 
      // OPButton
      // 
      this.OPButton.Location = new System.Drawing.Point(155, 246);
      this.OPButton.Name = "OPButton";
      this.OPButton.Size = new System.Drawing.Size(118, 30);
      this.OPButton.TabIndex = 3;
      this.OPButton.Text = "Options";
      this.OPButton.UseVisualStyleBackColor = true;
      this.OPButton.Click += new System.EventHandler(this.OPButton_Click);
      // 
      // QButton
      // 
      this.QButton.Location = new System.Drawing.Point(155, 301);
      this.QButton.Name = "QButton";
      this.QButton.Size = new System.Drawing.Size(118, 30);
      this.QButton.TabIndex = 4;
      this.QButton.Text = "Quit";
      this.QButton.UseVisualStyleBackColor = true;
      this.QButton.Click += new System.EventHandler(this.QButton_Click);
      // 
      // MainMenu
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(438, 343);
      this.Controls.Add(this.QButton);
      this.Controls.Add(this.OPButton);
      this.Controls.Add(this.LGButton);
      this.Controls.Add(this.NGButton);
      this.Controls.Add(this.pictureBox1);
      this.Name = "MainMenu";
      this.Text = "Underworld Champ";
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Button NGButton;
    private System.Windows.Forms.Button LGButton;
    private System.Windows.Forms.Button OPButton;
    private System.Windows.Forms.Button QButton;
  }
}

