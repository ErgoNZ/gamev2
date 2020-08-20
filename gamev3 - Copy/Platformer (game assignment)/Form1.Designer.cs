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
            this.Door = new System.Windows.Forms.PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.Door)).BeginInit();
            this.SuspendLayout();
            // 
            // Play
            // 
            this.Play.Location = new System.Drawing.Point(450, 150);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(75, 23);
            this.Play.TabIndex = 1;
            this.Play.Text = "Play";
            this.Play.UseVisualStyleBackColor = true;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // Help
            // 
            this.Help.Location = new System.Drawing.Point(450, 263);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(75, 23);
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
            this.PnlGame.Controls.Add(this.Door);
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
            this.PnlGame.Location = new System.Drawing.Point(-7, 0);
            this.PnlGame.Margin = new System.Windows.Forms.Padding(2);
            this.PnlGame.Name = "PnlGame";
            this.PnlGame.Size = new System.Drawing.Size(993, 463);
            this.PnlGame.TabIndex = 6;
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(426, 429);
            this.Back.Margin = new System.Windows.Forms.Padding(2);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(135, 19);
            this.Back.TabIndex = 8;
            this.Back.Text = "Back to main menu";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // pngHelp
            // 
            this.pngHelp.BackgroundImage = global::Platformer__game_assignment_.Properties.Resources.help;
            this.pngHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pngHelp.Location = new System.Drawing.Point(6, -6);
            this.pngHelp.Margin = new System.Windows.Forms.Padding(2);
            this.pngHelp.Name = "pngHelp";
            this.pngHelp.Size = new System.Drawing.Size(987, 466);
            this.pngHelp.TabIndex = 7;
            this.pngHelp.TabStop = false;
            // 
            // Level_Background
            // 
            this.Level_Background.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Level_Background.BackgroundImage")));
            this.Level_Background.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Level_Background.Location = new System.Drawing.Point(4, -3);
            this.Level_Background.Name = "Level_Background";
            this.Level_Background.Size = new System.Drawing.Size(1000, 463);
            this.Level_Background.TabIndex = 0;
            this.Level_Background.TabStop = false;
            // 
            // PlayerOne
            // 
            this.PlayerOne.BackgroundImage = global::Platformer__game_assignment_.Properties.Resources.Test_Player;
            this.PlayerOne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PlayerOne.Location = new System.Drawing.Point(19, 398);
            this.PlayerOne.Name = "PlayerOne";
            this.PlayerOne.Size = new System.Drawing.Size(36, 34);
            this.PlayerOne.TabIndex = 1;
            this.PlayerOne.TabStop = false;
            // 
            // Spikes
            // 
            this.Spikes.BackColor = System.Drawing.Color.Aqua;
            this.Spikes.Image = global::Platformer__game_assignment_.Properties.Resources.Spikes;
            this.Spikes.Location = new System.Drawing.Point(688, 142);
            this.Spikes.Margin = new System.Windows.Forms.Padding(2);
            this.Spikes.Name = "Spikes";
            this.Spikes.Size = new System.Drawing.Size(39, 32);
            this.Spikes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Spikes.TabIndex = 7;
            this.Spikes.TabStop = false;
            // 
            // ground5
            // 
            this.ground5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ground5.BackgroundImage")));
            this.ground5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ground5.Location = new System.Drawing.Point(559, 174);
            this.ground5.Name = "ground5";
            this.ground5.Size = new System.Drawing.Size(431, 35);
            this.ground5.TabIndex = 6;
            this.ground5.TabStop = false;
            this.ground5.Tag = "Platform";
            // 
            // ground4
            // 
            this.ground4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ground4.BackgroundImage")));
            this.ground4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ground4.Location = new System.Drawing.Point(375, 228);
            this.ground4.Name = "ground4";
            this.ground4.Size = new System.Drawing.Size(77, 35);
            this.ground4.TabIndex = 5;
            this.ground4.TabStop = false;
            this.ground4.Tag = "Platform";
            // 
            // ground3
            // 
            this.ground3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ground3.BackgroundImage")));
            this.ground3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ground3.Location = new System.Drawing.Point(262, 304);
            this.ground3.Name = "ground3";
            this.ground3.Size = new System.Drawing.Size(77, 35);
            this.ground3.TabIndex = 4;
            this.ground3.TabStop = false;
            this.ground3.Tag = "Platform";
            // 
            // ground2
            // 
            this.ground2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ground2.BackgroundImage")));
            this.ground2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ground2.Location = new System.Drawing.Point(75, 359);
            this.ground2.Name = "ground2";
            this.ground2.Size = new System.Drawing.Size(96, 35);
            this.ground2.TabIndex = 3;
            this.ground2.TabStop = false;
            this.ground2.Tag = "Platform";
            // 
            // ground1
            // 
            this.ground1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ground1.BackgroundImage")));
            this.ground1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ground1.Location = new System.Drawing.Point(3, 429);
            this.ground1.Name = "ground1";
            this.ground1.Size = new System.Drawing.Size(990, 50);
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
            // Door
            // 
            this.Door.BackColor = System.Drawing.Color.LightBlue;
            this.Door.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Door.BackgroundImage")));
            this.Door.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Door.Location = new System.Drawing.Point(896, 82);
            this.Door.Name = "Door";
            this.Door.Size = new System.Drawing.Size(52, 127);
            this.Door.TabIndex = 9;
            this.Door.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.Help);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.PnlGame);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.Door)).EndInit();
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
        private System.Windows.Forms.PictureBox Door;
    }
}

