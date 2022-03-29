
namespace Console_Game
{
  partial class StrengthMG
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
      this.one = new System.Windows.Forms.Button();
      this.two = new System.Windows.Forms.Button();
      this.three = new System.Windows.Forms.Button();
      this.four = new System.Windows.Forms.Button();
      this.five = new System.Windows.Forms.Button();
      this.six = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Snap ITC", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
      this.label1.Location = new System.Drawing.Point(194, 24);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(238, 31);
      this.label1.TabIndex = 0;
      this.label1.Text = "Choose a method";
      // 
      // one
      // 
      this.one.Location = new System.Drawing.Point(49, 121);
      this.one.Name = "one";
      this.one.Size = new System.Drawing.Size(98, 83);
      this.one.TabIndex = 1;
      this.one.Text = "Method 1";
      this.one.UseVisualStyleBackColor = true;
      this.one.Click += new System.EventHandler(this.button1_Click);
      // 
      // two
      // 
      this.two.Location = new System.Drawing.Point(153, 121);
      this.two.Name = "two";
      this.two.Size = new System.Drawing.Size(102, 83);
      this.two.TabIndex = 2;
      this.two.Text = "Method 2";
      this.two.UseVisualStyleBackColor = true;
      this.two.Click += new System.EventHandler(this.button2_Click);
      // 
      // three
      // 
      this.three.Location = new System.Drawing.Point(261, 121);
      this.three.Name = "three";
      this.three.Size = new System.Drawing.Size(96, 83);
      this.three.TabIndex = 3;
      this.three.Text = "Method 3";
      this.three.UseVisualStyleBackColor = true;
      this.three.Click += new System.EventHandler(this.button3_Click);
      // 
      // four
      // 
      this.four.Location = new System.Drawing.Point(363, 121);
      this.four.Name = "four";
      this.four.Size = new System.Drawing.Size(96, 83);
      this.four.TabIndex = 4;
      this.four.Text = "Method 4";
      this.four.UseVisualStyleBackColor = true;
      this.four.Click += new System.EventHandler(this.button4_Click);
      // 
      // five
      // 
      this.five.Location = new System.Drawing.Point(465, 121);
      this.five.Name = "five";
      this.five.Size = new System.Drawing.Size(96, 83);
      this.five.TabIndex = 5;
      this.five.Text = "Method 5";
      this.five.UseVisualStyleBackColor = true;
      this.five.Click += new System.EventHandler(this.button5_Click);
      // 
      // six
      // 
      this.six.Location = new System.Drawing.Point(567, 121);
      this.six.Name = "six";
      this.six.Size = new System.Drawing.Size(96, 83);
      this.six.TabIndex = 6;
      this.six.Text = "Method 6";
      this.six.UseVisualStyleBackColor = true;
      this.six.Click += new System.EventHandler(this.button6_Click);
      // 
      // StrengthMG
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(691, 285);
      this.Controls.Add(this.six);
      this.Controls.Add(this.five);
      this.Controls.Add(this.four);
      this.Controls.Add(this.three);
      this.Controls.Add(this.two);
      this.Controls.Add(this.one);
      this.Controls.Add(this.label1);
      this.Name = "StrengthMG";
      this.Text = "StrengthMG";
      this.Load += new System.EventHandler(this.StrengthMG_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button one;
    private System.Windows.Forms.Button two;
    private System.Windows.Forms.Button three;
    private System.Windows.Forms.Button four;
    private System.Windows.Forms.Button five;
    private System.Windows.Forms.Button six;
  }
}