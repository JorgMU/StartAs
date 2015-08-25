namespace StartAs
{
  partial class Form1
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
      this.cmdTB = new System.Windows.Forms.TextBox();
      this.optTB = new System.Windows.Forms.TextBox();
      this.usrTB = new System.Windows.Forms.TextBox();
      this.passTB = new System.Windows.Forms.TextBox();
      this.cmdLabel = new System.Windows.Forms.Label();
      this.optionsLabel = new System.Windows.Forms.Label();
      this.udLabel = new System.Windows.Forms.Label();
      this.pLabel = new System.Windows.Forms.Label();
      this.startButton = new System.Windows.Forms.Button();
      this.cancelButton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // cmdTB
      // 
      this.cmdTB.Location = new System.Drawing.Point(127, 10);
      this.cmdTB.Name = "cmdTB";
      this.cmdTB.Size = new System.Drawing.Size(328, 26);
      this.cmdTB.TabIndex = 0;
      // 
      // optTB
      // 
      this.optTB.Location = new System.Drawing.Point(127, 42);
      this.optTB.Name = "optTB";
      this.optTB.Size = new System.Drawing.Size(328, 26);
      this.optTB.TabIndex = 5;
      // 
      // usrTB
      // 
      this.usrTB.Location = new System.Drawing.Point(127, 74);
      this.usrTB.Name = "usrTB";
      this.usrTB.Size = new System.Drawing.Size(328, 26);
      this.usrTB.TabIndex = 10;
      // 
      // passTB
      // 
      this.passTB.Location = new System.Drawing.Point(127, 106);
      this.passTB.Name = "passTB";
      this.passTB.PasswordChar = '*';
      this.passTB.Size = new System.Drawing.Size(328, 26);
      this.passTB.TabIndex = 15;
      // 
      // cmdLabel
      // 
      this.cmdLabel.AutoSize = true;
      this.cmdLabel.Location = new System.Drawing.Point(35, 13);
      this.cmdLabel.Name = "cmdLabel";
      this.cmdLabel.Size = new System.Drawing.Size(86, 20);
      this.cmdLabel.TabIndex = 1;
      this.cmdLabel.Text = "Command:";
      this.cmdLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
      // 
      // optionsLabel
      // 
      this.optionsLabel.AutoSize = true;
      this.optionsLabel.Location = new System.Drawing.Point(53, 45);
      this.optionsLabel.Name = "optionsLabel";
      this.optionsLabel.Size = new System.Drawing.Size(68, 20);
      this.optionsLabel.TabIndex = 1;
      this.optionsLabel.Text = "Options:";
      this.optionsLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
      // 
      // udLabel
      // 
      this.udLabel.AutoSize = true;
      this.udLabel.Location = new System.Drawing.Point(15, 77);
      this.udLabel.Name = "udLabel";
      this.udLabel.Size = new System.Drawing.Size(106, 20);
      this.udLabel.TabIndex = 1;
      this.udLabel.Text = "Domain\\User:";
      this.udLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
      // 
      // pLabel
      // 
      this.pLabel.AutoSize = true;
      this.pLabel.Location = new System.Drawing.Point(39, 109);
      this.pLabel.Name = "pLabel";
      this.pLabel.Size = new System.Drawing.Size(82, 20);
      this.pLabel.TabIndex = 1;
      this.pLabel.Text = "Password:";
      this.pLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
      // 
      // startButton
      // 
      this.startButton.Location = new System.Drawing.Point(382, 144);
      this.startButton.Name = "startButton";
      this.startButton.Size = new System.Drawing.Size(75, 35);
      this.startButton.TabIndex = 20;
      this.startButton.Text = "Start";
      this.startButton.UseVisualStyleBackColor = true;
      this.startButton.Click += new System.EventHandler(this.startButton_Click);
      // 
      // cancelButton
      // 
      this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.cancelButton.Location = new System.Drawing.Point(301, 144);
      this.cancelButton.Name = "cancelButton";
      this.cancelButton.Size = new System.Drawing.Size(75, 35);
      this.cancelButton.TabIndex = 25;
      this.cancelButton.Text = "Cancel";
      this.cancelButton.UseVisualStyleBackColor = true;
      this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
      // 
      // Form1
      // 
      this.AcceptButton = this.startButton;
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.cancelButton;
      this.ClientSize = new System.Drawing.Size(477, 189);
      this.Controls.Add(this.cancelButton);
      this.Controls.Add(this.startButton);
      this.Controls.Add(this.pLabel);
      this.Controls.Add(this.optionsLabel);
      this.Controls.Add(this.cmdLabel);
      this.Controls.Add(this.udLabel);
      this.Controls.Add(this.passTB);
      this.Controls.Add(this.usrTB);
      this.Controls.Add(this.optTB);
      this.Controls.Add(this.cmdTB);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "Form1";
      this.Text = "StartAs";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox cmdTB;
    private System.Windows.Forms.Label udLabel;
    private System.Windows.Forms.Label pLabel;
    private System.Windows.Forms.TextBox optTB;
    private System.Windows.Forms.Label cmdLabel;
    private System.Windows.Forms.Label optionsLabel;
    private System.Windows.Forms.TextBox usrTB;
    private System.Windows.Forms.TextBox passTB;
    private System.Windows.Forms.Button startButton;
    private System.Windows.Forms.Button cancelButton;
  }
}

