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
            this.PnlGame = new System.Windows.Forms.Panel();
            this.Back = new System.Windows.Forms.Button();
            this.pngHelp = new System.Windows.Forms.PictureBox();
            this.Level_Background = new System.Windows.Forms.PictureBox();
            this.PlayerOne = new System.Windows.Forms.PictureBox();
            this.Spikes = new System.Windows.Forms.PictureBox();
            this.ground5 = new System.Windows.Forms.PictureBox();
            this.ground4 = new System.Windows.Forms.PictureBox();
            this.ground3 = new System.Windows.Forms.PictureBox();
            this.ground2 = new System.Windows.Forms.PictureBox();
            this.ground1 = new System.Windows.Forms.PictureBox();
            this.Gravity = new System.Windows.Forms.Timer(this.components);
            this.PnlGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pngHelp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Level_Background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Spikes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground1)).BeginInit();
            this.SuspendLayout();
            // 
            // Play
            // 
            this.Play.Location = new System.Drawing.Point(600, 185);
            this.Play.Margin = new System.Windows.Forms.Padding(4);
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
            this.Help.Margin = new System.Windows.Forms.Padding(4);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(100, 28);
            this.Help.TabIndex = 2;
            this.Help.Text = "How to play";
            this.Help.UseVisualStyleBackColor = true;
            this.Help.Click += new System.EventHandler(this.Help_Click);
            // 
            // Gametick
            // 
            this.Gametick.Enabled = true;
            this.Gametick.Interval = 25;
            this.Gametick.Tick += new System.EventHandler(this.Gametick_Tick);
            // 
            // PnlGame
            // 
            this.PnlGame.BackColor = System.Drawing.Color.Aqua;
            this.PnlGame.Controls.Add(this.Back);
            this.PnlGame.Controls.Add(this.pngHelp);
            this.PnlGame.Controls.Add(this.Level_Background);
            this.PnlGame.Controls.Add(this.PlayerOne);
            this.PnlGame.Controls.Add(this.Spikes);
            this.PnlGame.Controls.Add(this.ground5);
            this.PnlGame.Controls.Add(this.ground4);
            this.PnlGame.Controls.Add(this.ground3);
            this.PnlGame.Controls.Add(this.ground2);
            this.PnlGame.Controls.Add(this.ground1);
            this.PnlGame.Location = new System.Drawing.Point(-9, 0);
            this.PnlGame.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PnlGame.Name = "PnlGame";
            this.PnlGame.Size = new System.Drawing.Size(1324, 570);
            this.PnlGame.TabIndex = 6;
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(568, 528);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(180, 23);
            this.Back.TabIndex = 8;
            this.Back.Text = "Back to main menu";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // pngHelp
            // 
            this.pngHelp.BackgroundImage = global::Platformer__game_assignment_.Properties.Resources.help;
            this.pngHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pngHelp.Location = new System.Drawing.Point(8, -8);
            this.pngHelp.Name = "pngHelp";
            this.pngHelp.Size = new System.Drawing.Size(1316, 574);
            this.pngHelp.TabIndex = 7;
            this.pngHelp.TabStop = false;
            // 
            // Level_Background
            // 
            this.Level_Background.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Level_Background.BackgroundImage")));
            this.Level_Background.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Level_Background.Location = new System.Drawing.Point(5, -4);
            this.Level_Background.Margin = new System.Windows.Forms.Padding(4);
            this.Level_Background.Name = "Level_Background";
            this.Level_Background.Size = new System.Drawing.Size(1333, 570);
            this.Level_Background.TabIndex = 0;
            this.Level_Background.TabStop = false;
            // 
            // PlayerOne
            // 
            this.PlayerOne.BackgroundImage = global::Platformer__game_assignment_.Properties.Resources.Test_Player;
            this.PlayerOne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PlayerOne.Location = new System.Drawing.Point(25, 490);
            this.PlayerOne.Margin = new System.Windows.Forms.Padding(4);
            this.PlayerOne.Name = "PlayerOne";
            this.PlayerOne.Size = new System.Drawing.Size(48, 42);
            this.PlayerOne.TabIndex = 1;
            this.PlayerOne.TabStop = false;
            // 
            // Spikes
            // 
            this.Spikes.BackColor = System.Drawing.Color.Aqua;
            this.Spikes.Image = global::Platformer__game_assignment_.Properties.Resources.Spikes;
            this.Spikes.Location = new System.Drawing.Point(917, 175);
            this.Spikes.Name = "Spikes";
            this.Spikes.Size = new System.Drawing.Size(52, 39);
            this.Spikes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Spikes.TabIndex = 7;
            this.Spikes.TabStop = false;
            // 
            // ground5
            // 
            this.ground5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ground5.BackgroundImage")));
            this.ground5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ground5.Location = new System.Drawing.Point(745, 214);
            this.ground5.Margin = new System.Windows.Forms.Padding(4);
            this.ground5.Name = "ground5";
            this.ground5.Size = new System.Drawing.Size(575, 43);
            this.ground5.TabIndex = 6;
            this.ground5.TabStop = false;
            this.ground5.Tag = "Platform";
            // 
            // ground4
            // 
            this.ground4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ground4.BackgroundImage")));
            this.ground4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ground4.Location = new System.Drawing.Point(500, 281);
            this.ground4.Margin = new System.Windows.Forms.Padding(4);
            this.ground4.Name = "ground4";
            this.ground4.Size = new System.Drawing.Size(103, 43);
            this.ground4.TabIndex = 5;
            this.ground4.TabStop = false;
            this.ground4.Tag = "Platform";
            // 
            // ground3
            // 
            this.ground3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ground3.BackgroundImage")));
            this.ground3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ground3.Location = new System.Drawing.Point(350, 374);
            this.ground3.Margin = new System.Windows.Forms.Padding(4);
            this.ground3.Name = "ground3";
            this.ground3.Size = new System.Drawing.Size(103, 43);
            this.ground3.TabIndex = 4;
            this.ground3.TabStop = false;
            this.ground3.Tag = "Platform";
            // 
            // ground2
            // 
            this.ground2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ground2.BackgroundImage")));
            this.ground2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ground2.Location = new System.Drawing.Point(100, 442);
            this.ground2.Margin = new System.Windows.Forms.Padding(4);
            this.ground2.Name = "ground2";
            this.ground2.Size = new System.Drawing.Size(128, 43);
            this.ground2.TabIndex = 3;
            this.ground2.TabStop = false;
            this.ground2.Tag = "Platform";
            // 
            // ground1
            // 
            this.ground1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ground1.BackgroundImage")));
            this.ground1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ground1.Location = new System.Drawing.Point(4, 528);
            this.ground1.Margin = new System.Windows.Forms.Padding(4);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.PnlGame.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pngHelp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Level_Background)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Spikes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground2)).EndInit();
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
        private System.Windows.Forms.PictureBox ground3;
        private System.Windows.Forms.PictureBox ground4;
        private System.Windows.Forms.PictureBox ground5;
        private System.Windows.Forms.PictureBox Spikes;
        private System.Windows.Forms.PictureBox pngHelp;
        private System.Windows.Forms.Button Back;
    }
}

