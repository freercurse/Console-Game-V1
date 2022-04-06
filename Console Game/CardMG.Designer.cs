
namespace Console_Game
{
  partial class CardMG
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.label1 = new System.Windows.Forms.Label();
      this.labelCard = new System.Windows.Forms.Label();
      this.buttonCard = new System.Windows.Forms.Button();
      this.buttonLower = new System.Windows.Forms.Button();
      this.buttonHigher = new System.Windows.Forms.Button();
      this.buttonCash = new System.Windows.Forms.Button();
      this.labelBounty = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Snap ITC", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
      this.label1.Location = new System.Drawing.Point(22, 24);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(239, 31);
      this.label1.TabIndex = 1;
      this.label1.Text = "Higher or Lower";
      // 
      // labelCard
      // 
      this.labelCard.AutoSize = true;
      this.labelCard.Location = new System.Drawing.Point(44, 84);
      this.labelCard.Name = "labelCard";
      this.labelCard.Size = new System.Drawing.Size(45, 15);
      this.labelCard.TabIndex = 2;
      this.labelCard.Text = "Bounty";
      // 
      // buttonCard
      // 
      this.buttonCard.Enabled = false;
      this.buttonCard.Location = new System.Drawing.Point(173, 84);
      this.buttonCard.Name = "buttonCard";
      this.buttonCard.Size = new System.Drawing.Size(74, 73);
      this.buttonCard.TabIndex = 3;
      this.buttonCard.Text = "Card";
      this.buttonCard.UseVisualStyleBackColor = true;
      // 
      // buttonLower
      // 
      this.buttonLower.Location = new System.Drawing.Point(44, 195);
      this.buttonLower.Name = "buttonLower";
      this.buttonLower.Size = new System.Drawing.Size(71, 77);
      this.buttonLower.TabIndex = 4;
      this.buttonLower.Text = "Lower";
      this.buttonLower.UseVisualStyleBackColor = true;
      this.buttonLower.Click += new System.EventHandler(this.buttonLower_Click);
      // 
      // buttonHigher
      // 
      this.buttonHigher.Location = new System.Drawing.Point(176, 195);
      this.buttonHigher.Name = "buttonHigher";
      this.buttonHigher.Size = new System.Drawing.Size(71, 77);
      this.buttonHigher.TabIndex = 5;
      this.buttonHigher.Text = "Higher";
      this.buttonHigher.UseVisualStyleBackColor = true;
      this.buttonHigher.Click += new System.EventHandler(this.buttonHigher_Click);
      // 
      // buttonCash
      // 
      this.buttonCash.Location = new System.Drawing.Point(173, 303);
      this.buttonCash.Name = "buttonCash";
      this.buttonCash.Size = new System.Drawing.Size(70, 69);
      this.buttonCash.TabIndex = 6;
      this.buttonCash.Text = "CashOut";
      this.buttonCash.UseVisualStyleBackColor = true;
      this.buttonCash.Click += new System.EventHandler(this.buttonCash_Click);
      // 
      // labelBounty
      // 
      this.labelBounty.AutoSize = true;
      this.labelBounty.Location = new System.Drawing.Point(76, 128);
      this.labelBounty.Name = "labelBounty";
      this.labelBounty.Size = new System.Drawing.Size(13, 15);
      this.labelBounty.TabIndex = 7;
      this.labelBounty.Text = "0";
      // 
      // CardMG
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(295, 374);
      this.Controls.Add(this.labelBounty);
      this.Controls.Add(this.buttonCash);
      this.Controls.Add(this.buttonHigher);
      this.Controls.Add(this.buttonLower);
      this.Controls.Add(this.buttonCard);
      this.Controls.Add(this.labelCard);
      this.Controls.Add(this.label1);
      this.Name = "CardMG";
      this.Text = "CardMG";
      this.Load += new System.EventHandler(this.CardMG_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label labelCard;
    private System.Windows.Forms.Button buttonCard;
    private System.Windows.Forms.Button buttonLower;
    private System.Windows.Forms.Button buttonHigher;
    private System.Windows.Forms.Button buttonCash;
    private System.Windows.Forms.Label labelBounty;
  }
}