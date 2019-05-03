namespace BrickBreaker
{
    partial class NameScreen1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.initial1 = new System.Windows.Forms.Label();
			this.initial2 = new System.Windows.Forms.Label();
			this.initial3 = new System.Windows.Forms.Label();
			this.scoreText = new System.Windows.Forms.Label();
			this.buttonMenu = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// initial1
			// 
			this.initial1.AutoSize = true;
			this.initial1.BackColor = System.Drawing.Color.Transparent;
			this.initial1.Font = new System.Drawing.Font("OCR A Std", 102F, System.Drawing.FontStyle.Bold);
			this.initial1.ForeColor = System.Drawing.Color.Cyan;
			this.initial1.Location = new System.Drawing.Point(150, 154);
			this.initial1.Name = "initial1";
			this.initial1.Size = new System.Drawing.Size(162, 144);
			this.initial1.TabIndex = 0;
			this.initial1.Text = "A";
			// 
			// initial2
			// 
			this.initial2.AutoSize = true;
			this.initial2.BackColor = System.Drawing.Color.Transparent;
			this.initial2.Font = new System.Drawing.Font("OCR A Std", 102F, System.Drawing.FontStyle.Bold);
			this.initial2.ForeColor = System.Drawing.Color.Cyan;
			this.initial2.Location = new System.Drawing.Point(318, 154);
			this.initial2.Name = "initial2";
			this.initial2.Size = new System.Drawing.Size(162, 144);
			this.initial2.TabIndex = 1;
			this.initial2.Text = "A";
			// 
			// initial3
			// 
			this.initial3.AutoSize = true;
			this.initial3.BackColor = System.Drawing.Color.Transparent;
			this.initial3.Font = new System.Drawing.Font("OCR A Std", 102F, System.Drawing.FontStyle.Bold);
			this.initial3.ForeColor = System.Drawing.Color.Cyan;
			this.initial3.Location = new System.Drawing.Point(486, 154);
			this.initial3.Name = "initial3";
			this.initial3.Size = new System.Drawing.Size(162, 144);
			this.initial3.TabIndex = 2;
			this.initial3.Text = "A";
			// 
			// scoreText
			// 
			this.scoreText.AutoSize = true;
			this.scoreText.BackColor = System.Drawing.Color.Transparent;
			this.scoreText.Font = new System.Drawing.Font("OCR A Std", 14F);
			this.scoreText.ForeColor = System.Drawing.Color.Cyan;
			this.scoreText.Location = new System.Drawing.Point(200, 52);
			this.scoreText.Name = "scoreText";
			this.scoreText.Size = new System.Drawing.Size(205, 20);
			this.scoreText.TabIndex = 3;
			this.scoreText.Text = "YOUR SCORE WAS";
			// 
			// buttonMenu
			// 
			this.buttonMenu.BackColor = System.Drawing.Color.Transparent;
			this.buttonMenu.BackgroundImage = global::BrickBreaker.Properties.Resources.button;
			this.buttonMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.buttonMenu.FlatAppearance.BorderSize = 0;
			this.buttonMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonMenu.Font = new System.Drawing.Font("OCR A Std", 14F);
			this.buttonMenu.ForeColor = System.Drawing.Color.Cyan;
			this.buttonMenu.Location = new System.Drawing.Point(656, 360);
			this.buttonMenu.Name = "buttonMenu";
			this.buttonMenu.Size = new System.Drawing.Size(75, 23);
			this.buttonMenu.TabIndex = 4;
			this.buttonMenu.Text = "Menu";
			this.buttonMenu.UseVisualStyleBackColor = false;
			this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
			// 
			// NameScreen1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::BrickBreaker.Properties.Resources.Stars;
			this.Controls.Add(this.buttonMenu);
			this.Controls.Add(this.scoreText);
			this.Controls.Add(this.initial3);
			this.Controls.Add(this.initial2);
			this.Controls.Add(this.initial1);
			this.Name = "NameScreen1";
			this.Size = new System.Drawing.Size(800, 550);
			this.Load += new System.EventHandler(this.NameScreen1_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NameScreen1_KeyDown);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Label initial1;
		private System.Windows.Forms.Label initial2;
		private System.Windows.Forms.Label initial3;
		private System.Windows.Forms.Label scoreText;
		private System.Windows.Forms.Button buttonMenu;
	}
}
