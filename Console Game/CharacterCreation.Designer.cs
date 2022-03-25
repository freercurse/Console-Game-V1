
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CharacterCreation));
      this.labelName = new System.Windows.Forms.Label();
      this.textBoxName = new System.Windows.Forms.TextBox();
      this.StartButton = new System.Windows.Forms.Button();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.textBoxHealth = new System.Windows.Forms.TextBox();
      this.labelHealth = new System.Windows.Forms.Label();
      this.textBoxStrength = new System.Windows.Forms.TextBox();
      this.labelStrength = new System.Windows.Forms.Label();
      this.textBoxLuck = new System.Windows.Forms.TextBox();
      this.labelLuck = new System.Windows.Forms.Label();
      this.textBoxMoney = new System.Windows.Forms.TextBox();
      this.labelMoney = new System.Windows.Forms.Label();
      this.buttonBack = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // labelName
      // 
      this.labelName.AutoSize = true;
      this.labelName.Location = new System.Drawing.Point(6, 312);
      this.labelName.Name = "labelName";
      this.labelName.Size = new System.Drawing.Size(45, 15);
      this.labelName.TabIndex = 0;
      this.labelName.Text = "Name :";
      // 
      // textBoxName
      // 
      this.textBoxName.Location = new System.Drawing.Point(60, 309);
      this.textBoxName.Name = "textBoxName";
      this.textBoxName.Size = new System.Drawing.Size(100, 23);
      this.textBoxName.TabIndex = 1;
      // 
      // StartButton
      // 
      this.StartButton.Location = new System.Drawing.Point(425, 385);
      this.StartButton.Name = "StartButton";
      this.StartButton.Size = new System.Drawing.Size(104, 37);
      this.StartButton.TabIndex = 2;
      this.StartButton.Text = "Start";
      this.StartButton.UseVisualStyleBackColor = true;
      this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
      this.pictureBox1.Location = new System.Drawing.Point(129, 29);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(240, 240);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
      this.pictureBox1.TabIndex = 3;
      this.pictureBox1.TabStop = false;
      // 
      // textBoxHealth
      // 
      this.textBoxHealth.Location = new System.Drawing.Point(60, 365);
      this.textBoxHealth.Name = "textBoxHealth";
      this.textBoxHealth.Size = new System.Drawing.Size(100, 23);
      this.textBoxHealth.TabIndex = 6;
      // 
      // labelHealth
      // 
      this.labelHealth.AutoSize = true;
      this.labelHealth.Location = new System.Drawing.Point(6, 368);
      this.labelHealth.Name = "labelHealth";
      this.labelHealth.Size = new System.Drawing.Size(48, 15);
      this.labelHealth.TabIndex = 5;
      this.labelHealth.Text = "Health :";
      // 
      // textBoxStrength
      // 
      this.textBoxStrength.Location = new System.Drawing.Point(256, 365);
      this.textBoxStrength.Name = "textBoxStrength";
      this.textBoxStrength.Size = new System.Drawing.Size(100, 23);
      this.textBoxStrength.TabIndex = 8;
      // 
      // labelStrength
      // 
      this.labelStrength.AutoSize = true;
      this.labelStrength.Location = new System.Drawing.Point(202, 368);
      this.labelStrength.Name = "labelStrength";
      this.labelStrength.Size = new System.Drawing.Size(58, 15);
      this.labelStrength.TabIndex = 7;
      this.labelStrength.Text = "Strength :";
      // 
      // textBoxLuck
      // 
      this.textBoxLuck.Location = new System.Drawing.Point(60, 424);
      this.textBoxLuck.Name = "textBoxLuck";
      this.textBoxLuck.Size = new System.Drawing.Size(100, 23);
      this.textBoxLuck.TabIndex = 10;
      // 
      // labelLuck
      // 
      this.labelLuck.AutoSize = true;
      this.labelLuck.Location = new System.Drawing.Point(6, 427);
      this.labelLuck.Name = "labelLuck";
      this.labelLuck.Size = new System.Drawing.Size(38, 15);
      this.labelLuck.TabIndex = 9;
      this.labelLuck.Text = "Luck :";
      // 
      // textBoxMoney
      // 
      this.textBoxMoney.Location = new System.Drawing.Point(256, 424);
      this.textBoxMoney.Name = "textBoxMoney";
      this.textBoxMoney.Size = new System.Drawing.Size(100, 23);
      this.textBoxMoney.TabIndex = 12;
      // 
      // labelMoney
      // 
      this.labelMoney.AutoSize = true;
      this.labelMoney.Location = new System.Drawing.Point(202, 427);
      this.labelMoney.Name = "labelMoney";
      this.labelMoney.Size = new System.Drawing.Size(50, 15);
      this.labelMoney.TabIndex = 11;
      this.labelMoney.Text = "Money :";
      // 
      // buttonBack
      // 
      this.buttonBack.Location = new System.Drawing.Point(425, 428);
      this.buttonBack.Name = "buttonBack";
      this.buttonBack.Size = new System.Drawing.Size(104, 37);
      this.buttonBack.TabIndex = 15;
      this.buttonBack.Text = "Back";
      this.buttonBack.UseVisualStyleBackColor = true;
      this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
      this.label1.Location = new System.Drawing.Point(256, 312);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(113, 15);
      this.label1.TabIndex = 16;
      this.label1.Text = "Maximum Points: 8";
      // 
      // CharacterCreation
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(532, 477);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.buttonBack);
      this.Controls.Add(this.textBoxMoney);
      this.Controls.Add(this.labelMoney);
      this.Controls.Add(this.textBoxLuck);
      this.Controls.Add(this.labelLuck);
      this.Controls.Add(this.textBoxStrength);
      this.Controls.Add(this.labelStrength);
      this.Controls.Add(this.textBoxHealth);
      this.Controls.Add(this.labelHealth);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.StartButton);
      this.Controls.Add(this.textBoxName);
      this.Controls.Add(this.labelName);
      this.Name = "CharacterCreation";
      this.Text = "CharacterCreation";
      this.Load += new System.EventHandler(this.CharacterCreation_Load);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label labelName;
    private System.Windows.Forms.TextBox textBoxName;
    private System.Windows.Forms.Button StartButton;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.TextBox textBoxHealth;
    private System.Windows.Forms.Label labelHealth;
    private System.Windows.Forms.TextBox textBoxStrength;
    private System.Windows.Forms.Label labelStrength;
    private System.Windows.Forms.TextBox textBoxLuck;
    private System.Windows.Forms.Label labelLuck;
    private System.Windows.Forms.TextBox textBoxMoney;
    private System.Windows.Forms.Label labelMoney;
    private System.Windows.Forms.Button buttonBack;
    private System.Windows.Forms.Label label1;
  }
}