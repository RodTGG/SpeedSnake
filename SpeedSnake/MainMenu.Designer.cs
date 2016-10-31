namespace SpeedSnake
{
    partial class MainMenu
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
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.pnlSettings = new System.Windows.Forms.Panel();
            this.cbWalls = new System.Windows.Forms.CheckBox();
            this.btnSettings_OK = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAbout
            // 
            this.btnAbout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbout.Location = new System.Drawing.Point(12, 68);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(150, 50);
            this.btnAbout.TabIndex = 2;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSettings.Location = new System.Drawing.Point(12, 124);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(150, 50);
            this.btnSettings.TabIndex = 3;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlay.Location = new System.Drawing.Point(12, 12);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(150, 50);
            this.btnPlay.TabIndex = 4;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // pnlSettings
            // 
            this.pnlSettings.Controls.Add(this.btnSettings_OK);
            this.pnlSettings.Controls.Add(this.cbWalls);
            this.pnlSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSettings.Location = new System.Drawing.Point(0, 0);
            this.pnlSettings.Name = "pnlSettings";
            this.pnlSettings.Size = new System.Drawing.Size(317, 295);
            this.pnlSettings.TabIndex = 5;
            // 
            // cbWalls
            // 
            this.cbWalls.AutoSize = true;
            this.cbWalls.BackColor = System.Drawing.Color.Transparent;
            this.cbWalls.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbWalls.ForeColor = System.Drawing.SystemColors.Control;
            this.cbWalls.Location = new System.Drawing.Point(12, 27);
            this.cbWalls.Name = "cbWalls";
            this.cbWalls.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbWalls.Size = new System.Drawing.Size(99, 35);
            this.cbWalls.TabIndex = 2;
            this.cbWalls.Text = "Walls";
            this.cbWalls.UseVisualStyleBackColor = false;
            // 
            // btnSettings_OK
            // 
            this.btnSettings_OK.Location = new System.Drawing.Point(13, 260);
            this.btnSettings_OK.Name = "btnSettings_OK";
            this.btnSettings_OK.Size = new System.Drawing.Size(75, 23);
            this.btnSettings_OK.TabIndex = 3;
            this.btnSettings_OK.Text = "OK";
            this.btnSettings_OK.UseVisualStyleBackColor = true;
            this.btnSettings_OK.Click += new System.EventHandler(this.btnSettings_OK_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(12, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 50);
            this.button1.TabIndex = 3;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(317, 295);
            this.Controls.Add(this.pnlSettings);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnPlay);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainMenu_FormClosed);
            this.pnlSettings.ResumeLayout(false);
            this.pnlSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Panel pnlSettings;
        private System.Windows.Forms.Button btnSettings_OK;
        private System.Windows.Forms.CheckBox cbWalls;
        private System.Windows.Forms.Button button1;
    }
}