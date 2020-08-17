namespace Platformer__game_assignment_
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Play = new System.Windows.Forms.Button();
            this.Help = new System.Windows.Forms.Button();
            this.Gametick = new System.Windows.Forms.Timer(this.components);
            this.Level_Background = new System.Windows.Forms.PictureBox();
            this.PnlGame = new System.Windows.Forms.Panel();
            this.ground2 = new System.Windows.Forms.PictureBox();
            this.PlayerOne = new System.Windows.Forms.PictureBox();
            this.ground1 = new System.Windows.Forms.PictureBox();
            this.Gravity = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Level_Background)).BeginInit();
            this.PnlGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ground2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground1)).BeginInit();
            this.SuspendLayout();
            // 
            // Play
            // 
            this.Play.Location = new System.Drawing.Point(600, 185);
            this.Play.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(100, 28);
            this.Play.TabIndex = 1;
            this.Play.Text = "Play";
            this.Play.UseVisualStyleBackColor = true;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // Help
            // 
            this.Help.Location = new System.Drawing.Point(600, 324);
            this.Help.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(100, 28);
            this.Help.TabIndex = 2;
            this.Help.Text = "How to play";
            this.Help.UseVisualStyleBackColor = true;
            // 
            // Gametick
            // 
            this.Gametick.Enabled = true;
            this.Gametick.Interval = 30;
            this.Gametick.Tick += new System.EventHandler(this.Gametick_Tick);
            // 
            // Level_Background
            // 
            this.Level_Background.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Level_Background.BackgroundImage")));
            this.Level_Background.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Level_Background.Location = new System.Drawing.Point(4, -4);
            this.Level_Background.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Level_Background.Name = "Level_Background";
            this.Level_Background.Size = new System.Drawing.Size(1333, 570);
            this.Level_Background.TabIndex = 0;
            this.Level_Background.TabStop = false;
            // 
            // PnlGame
            // 
            this.PnlGame.BackColor = System.Drawing.Color.Aqua;
            this.PnlGame.Controls.Add(this.Level_Background);
            this.PnlGame.Controls.Add(this.PlayerOne);
            this.PnlGame.Controls.Add(this.ground1);
            this.PnlGame.Controls.Add(this.ground2);
            this.PnlGame.Location = new System.Drawing.Point(-9, 0);
            this.PnlGame.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PnlGame.Name = "PnlGame";
            this.PnlGame.Size = new System.Drawing.Size(1324, 570);
            this.PnlGame.TabIndex = 6;
            // 
            // ground2
            // 
            this.ground2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ground2.BackgroundImage")));
            this.ground2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ground2.Location = new System.Drawing.Point(215, 442);
            this.ground2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ground2.Name = "ground2";
            this.ground2.Size = new System.Drawing.Size(428, 43);
            this.ground2.TabIndex = 3;
            this.ground2.TabStop = false;
            this.ground2.Tag = "Platform";
            // 
            // PlayerOne
            // 
            this.PlayerOne.BackgroundImage = global::Platformer__game_assignment_.Properties.Resources.Test_Player;
            this.PlayerOne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PlayerOne.Location = new System.Drawing.Point(25, 490);
            this.PlayerOne.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PlayerOne.Name = "PlayerOne";
            this.PlayerOne.Size = new System.Drawing.Size(48, 42);
            this.PlayerOne.TabIndex = 1;
            this.PlayerOne.TabStop = false;
            // 
            // ground1
            // 
            this.ground1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ground1.BackgroundImage")));
            this.ground1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ground1.Location = new System.Drawing.Point(4, 528);
            this.ground1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ground1.Name = "ground1";
            this.ground1.Size = new System.Drawing.Size(1320, 62);
            this.ground1.TabIndex = 2;
            this.ground1.TabStop = false;
            this.ground1.Tag = "Platform";
            // 
            // Gravity
            // 
            this.Gravity.Enabled = true;
            this.Gravity.Interval = 25;
            this.Gravity.Tick += new System.EventHandler(this.Gravity_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 567);
            this.Controls.Add(this.Help);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.PnlGame);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Level_Background)).EndInit();
            this.PnlGame.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ground2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Button Help;
        private System.Windows.Forms.Timer Gametick;
        private System.Windows.Forms.PictureBox Level_Background;
        private System.Windows.Forms.Panel PnlGame;
        private System.Windows.Forms.PictureBox PlayerOne;
        private System.Windows.Forms.PictureBox ground1;
        private System.Windows.Forms.Timer Gravity;
        private System.Windows.Forms.PictureBox ground2;
    }
}

