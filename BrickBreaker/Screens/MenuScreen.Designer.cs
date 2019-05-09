namespace BrickBreaker
{
    partial class MenuScreen
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
            this.playButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.coopBox = new System.Windows.Forms.CheckBox();
            this.how = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.Transparent;
            this.playButton.BackgroundImage = global::BrickBreaker.Properties.Resources.button;
            this.playButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.playButton.FlatAppearance.BorderSize = 0;
            this.playButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.playButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton.Font = new System.Drawing.Font("OCR A Std", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.ForeColor = System.Drawing.Color.Cyan;
            this.playButton.Location = new System.Drawing.Point(306, 240);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(181, 78);
            this.playButton.TabIndex = 0;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            this.playButton.Enter += new System.EventHandler(this.playButton_Enter);
            this.playButton.Leave += new System.EventHandler(this.playButton_Leave);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.BackgroundImage = global::BrickBreaker.Properties.Resources.button;
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("OCR A Std", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.Cyan;
            this.exitButton.Location = new System.Drawing.Point(306, 400);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(181, 78);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            this.exitButton.Enter += new System.EventHandler(this.exitButton_Enter);
            this.exitButton.Leave += new System.EventHandler(this.exitButton_Leave);
            // 
            // title
            // 
            this.title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("OCR A Std", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.Aqua;
            this.title.Location = new System.Drawing.Point(87, 89);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(653, 68);
            this.title.TabIndex = 2;
            this.title.Text = "Brick Breaker";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("OCR A Std", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(90, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(653, 68);
            this.label1.TabIndex = 2;
            this.label1.Text = "Brick Breaker";
            // 
            // coopBox
            // 
            this.coopBox.AutoSize = true;
            this.coopBox.BackColor = System.Drawing.Color.Transparent;
            this.coopBox.ForeColor = System.Drawing.Color.Cyan;
            this.coopBox.Location = new System.Drawing.Point(493, 276);
            this.coopBox.Name = "coopBox";
            this.coopBox.Size = new System.Drawing.Size(92, 17);
            this.coopBox.TabIndex = 3;
            this.coopBox.Text = "2-Player Coop";
            this.coopBox.UseVisualStyleBackColor = false;
            this.coopBox.CheckedChanged += new System.EventHandler(this.coopBox_CheckedChanged);
            this.coopBox.Enter += new System.EventHandler(this.coopBox_Enter);
            this.coopBox.Leave += new System.EventHandler(this.coopBox_Leave);
            // 
            // how
            // 
            this.how.BackColor = System.Drawing.Color.Transparent;
            this.how.BackgroundImage = global::BrickBreaker.Properties.Resources.button;
            this.how.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.how.FlatAppearance.BorderSize = 0;
            this.how.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.how.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.how.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.how.Font = new System.Drawing.Font("OCR A Std", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.how.ForeColor = System.Drawing.Color.Cyan;
            this.how.Location = new System.Drawing.Point(306, 320);
            this.how.Name = "how";
            this.how.Size = new System.Drawing.Size(181, 78);
            this.how.TabIndex = 1;
            this.how.Text = "How To Play";
            this.how.UseVisualStyleBackColor = false;
            this.how.Click += new System.EventHandler(this.how_Click);
            this.how.Enter += new System.EventHandler(this.how_Enter);
            this.how.Leave += new System.EventHandler(this.how_Leave);
            // 
            // MenuScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::BrickBreaker.Properties.Resources.Stars;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Controls.Add(this.how);
            this.Controls.Add(this.coopBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.playButton);
            this.DoubleBuffered = true;
            this.Name = "MenuScreen";
            this.Size = new System.Drawing.Size(800, 550);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button howButton;
        private System.Windows.Forms.CheckBox coopBox;
        private System.Windows.Forms.Button how;
        private System.Windows.Forms.Button exitButton;
    }

}
