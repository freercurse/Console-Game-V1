
namespace Console_Game
{
  partial class Options
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
      this.CButton = new System.Windows.Forms.Button();
      this.SeedLabel = new System.Windows.Forms.Label();
      this.SeedTB = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.DifficultyCB = new System.Windows.Forms.ComboBox();
      this.ASButton = new System.Windows.Forms.Button();
      this.ADButton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // CButton
      // 
      this.CButton.Location = new System.Drawing.Point(110, 97);
      this.CButton.Name = "CButton";
      this.CButton.Size = new System.Drawing.Size(75, 23);
      this.CButton.TabIndex = 0;
      this.CButton.Text = "Close";
      this.CButton.UseVisualStyleBackColor = true;
      this.CButton.Click += new System.EventHandler(this.CButton_Click);
      // 
      // SeedLabel
      // 
      this.SeedLabel.AutoSize = true;
      this.SeedLabel.Location = new System.Drawing.Point(31, 29);
      this.SeedLabel.Name = "SeedLabel";
      this.SeedLabel.Size = new System.Drawing.Size(38, 15);
      this.SeedLabel.TabIndex = 1;
      this.SeedLabel.Text = "Seed :";
      // 
      // SeedTB
      // 
      this.SeedTB.Location = new System.Drawing.Point(85, 26);
      this.SeedTB.Name = "SeedTB";
      this.SeedTB.Size = new System.Drawing.Size(100, 23);
      this.SeedTB.TabIndex = 2;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(8, 58);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(61, 15);
      this.label1.TabIndex = 3;
      this.label1.Text = "Difficulty :";
      // 
      // DifficultyCB
      // 
      this.DifficultyCB.FormattingEnabled = true;
      this.DifficultyCB.Items.AddRange(new object[] {
            "Impossible",
            "Hard",
            "Medium",
            "Easy"});
      this.DifficultyCB.Location = new System.Drawing.Point(85, 55);
      this.DifficultyCB.Name = "DifficultyCB";
      this.DifficultyCB.Size = new System.Drawing.Size(100, 23);
      this.DifficultyCB.TabIndex = 4;
      // 
      // ASButton
      // 
      this.ASButton.Location = new System.Drawing.Point(210, 25);
      this.ASButton.Name = "ASButton";
      this.ASButton.Size = new System.Drawing.Size(75, 23);
      this.ASButton.TabIndex = 5;
      this.ASButton.Text = "Apply";
      this.ASButton.UseVisualStyleBackColor = true;
      this.ASButton.Click += new System.EventHandler(this.ASButton_Click);
      // 
      // ADButton
      // 
      this.ADButton.Location = new System.Drawing.Point(210, 54);
      this.ADButton.Name = "ADButton";
      this.ADButton.Size = new System.Drawing.Size(75, 23);
      this.ADButton.TabIndex = 6;
      this.ADButton.Text = "Apply";
      this.ADButton.UseVisualStyleBackColor = true;
      this.ADButton.Click += new System.EventHandler(this.ADButton_Click);
      // 
      // Options
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(297, 132);
      this.Controls.Add(this.ADButton);
      this.Controls.Add(this.ASButton);
      this.Controls.Add(this.DifficultyCB);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.SeedTB);
      this.Controls.Add(this.SeedLabel);
      this.Controls.Add(this.CButton);
      this.Name = "Options";
      this.Text = "Options";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button CButton;
    private System.Windows.Forms.Label SeedLabel;
    private System.Windows.Forms.TextBox SeedTB;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ComboBox DifficultyCB;
    private System.Windows.Forms.Button ASButton;
    private System.Windows.Forms.Button ADButton;
  }
}