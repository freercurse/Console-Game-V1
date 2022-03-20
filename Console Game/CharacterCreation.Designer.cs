
namespace Console_Game
{
  partial class CharacterCreation
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
      this.NameLabel = new System.Windows.Forms.Label();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.StartButton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // NameLabel
      // 
      this.NameLabel.AutoSize = true;
      this.NameLabel.Location = new System.Drawing.Point(31, 302);
      this.NameLabel.Name = "NameLabel";
      this.NameLabel.Size = new System.Drawing.Size(45, 15);
      this.NameLabel.TabIndex = 0;
      this.NameLabel.Text = "Name :";
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(85, 299);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(100, 23);
      this.textBox1.TabIndex = 1;
      // 
      // StartButton
      // 
      this.StartButton.Location = new System.Drawing.Point(372, 553);
      this.StartButton.Name = "StartButton";
      this.StartButton.Size = new System.Drawing.Size(104, 37);
      this.StartButton.TabIndex = 2;
      this.StartButton.Text = "Start";
      this.StartButton.UseVisualStyleBackColor = true;
      // 
      // CharacterCreation
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(518, 616);
      this.Controls.Add(this.StartButton);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.NameLabel);
      this.Name = "CharacterCreation";
      this.Text = "CharacterCreation";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label NameLabel;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Button StartButton;
  }
}