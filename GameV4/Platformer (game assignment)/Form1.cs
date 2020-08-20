using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace Platformer__game_assignment_
{
    public partial class Form1 : Form
    {
        // all int's and bool's for game to work
        bool left = false;
        bool right = false;
        bool space = false;
        int Ymovement;
        int Jump = 0;
        int level = 0;
        bool invisable = false;
        bool invisable1 = false;

        public Form1()
        {
            InitializeComponent();
        }

        //This Loads on bootup
        private void Form1_Load(object sender, EventArgs e)
        {
            Level_Background.Show();
            Play.Show();
            Help.Show();
            pngHelp.Hide();
            Back.Hide();
        }

        //Basic menu things
        public void Play_Click(object sender, EventArgs e)
        {
             if (invisable1==false)
            {
                Level_Background.Hide();
                Play.Hide();
                Help.Hide();
                level = 1;
                invisable1 = true;
            }
        }

        private void Gametick_Tick(object sender, EventArgs e)
        {
            if (PlayerOne.Bounds.IntersectsWith(Door.Bounds))
            {
                PlayerOne.Left = PnlGame.Width - 950;
                PlayerOne.Top = PnlGame.Height - 90;
                level += 1;
                Console.WriteLine(level);
            }
            //Setting up each level when the int "level" is increased by 
            //Or the level loading
            if (level==0)
            {
                ground1.Hide();
                ground2.Hide();
                ground3.Hide();
                ground4.Hide();
                ground5.Hide();
                Spikes.Hide();
                Spikes1.Hide();
                Spikes2.Hide();
                Spikes3.Hide();
                Door.Hide();
                Bullet.Hide();
                Bullet1.Hide();
                Turret1.Hide();
                Turret2.Hide();
                ground6.Hide();
                ground7.Hide();
                ground8.Hide();
            }
            else
            {
                if (level==1)
                {
                    ground1.Show();
                    ground2.Show();
                    ground3.Show();
                    ground4.Show();
                    ground5.Show();
                    Spikes.Show();
                    Door.Show();
                }
                else
                {
                    if (level == 2)
                    {                        
                        ground2.Hide();
                        ground3.Hide();
                        ground4.Hide();
                        ground5.Hide();
                        Spikes.Hide();
                        Spikes1.Show();
                        Spikes2.Show();
                        Spikes3.Show();
                        Turret1.Show();
                        Bullet.Show();
                        Bullet1.Show();
                        Turret2.Show();
                        ground6.Show();
                        ground7.Show();
                        ground8.Show();

                        //This makes the door move to the new location
                        Door.Left = PnlGame.Width -100;
                        Door.Top = PnlGame.Height - 325;
                    }
                    else
                    {
                        if (level == 3)
                        {
                            Bullet.Hide();
                            Bullet1.Hide();
                            Turret1.Hide();
                            Turret2.Hide();
                            ground6.Hide();
                            ground7.Hide();
                            ground8.Hide();
                        }
                    }
                }
            }

            //movement (I got some help on this)
            if (space == true)
            {
                if (Jump == 0)
                {
                    Jump = 1;
                    Ymovement += -12;
                }
            }
            if (left == true)
            {
                if (PlayerOne.Location.X < -10)
                {
                    PlayerOne.Left = 1000;
                }
                else
                {
                    PlayerOne.Left -= 5;
                }
            }
            if (right == true)
            {
                if (PlayerOne.Location.X > PnlGame.Width )
                {
                    PlayerOne.Left = -10;
                }
                else
                {
                    PlayerOne.Left += 5;
                }
            }
            if (level == 1)
                {
                if (PlayerOne.Bounds.IntersectsWith(Spikes.Bounds))
                {
                    PlayerOne.Left = PnlGame.Width - 950;
                    PlayerOne.Top = PnlGame.Height - 90;
                }
            }
            if (level == 2)
                {
                if (PlayerOne.Bounds.IntersectsWith(Spikes1.Bounds))
                {
                    PlayerOne.Left = PnlGame.Width - 950;
                    PlayerOne.Top = PnlGame.Height - 90;
                }
                if (PlayerOne.Bounds.IntersectsWith(Spikes2.Bounds))
                {
                    PlayerOne.Left = PnlGame.Width - 950;
                    PlayerOne.Top = PnlGame.Height - 90;
                }
                if (PlayerOne.Bounds.IntersectsWith(Spikes3.Bounds))
                {
                    PlayerOne.Left = PnlGame.Width - 950;
                    PlayerOne.Top = PnlGame.Height - 90;
                }
            }
        }
        private void Gravity_Tick(object sender, EventArgs e)
        {
            //Just to make the player fall when not touching anything
            PlayerOne.Top += Ymovement;
            if (PlayerOne.Bounds.IntersectsWith(ground1.Bounds))
            {
                Ymovement = 0;
                Jump = 0;
                PlayerOne.Top = ground1.Top - 34;
            }
            else
            {
                Ymovement += 1;
                if (Ymovement > 20)
                {
                    Ymovement = 20;
                }
            }
            //Collision detection (Note: this took me way longer than it should have)
            if (level == 1)
            {
                if (PlayerOne.Bounds.IntersectsWith(ground1.Bounds) == true)
                //this part was easy but finding collision for all platforms easily didnt happen so we end up with this mess of "if" and "else"
                {
                    Ymovement = 0;
                    Jump = 0;
                    PlayerOne.Top = ground1.Top - 34;
                }
                else
                {
                    //figured out a slow and painful way of dectecting for all platforms for above and below so people cant shoot right through them (I should have dont this from the start)
                    if (PlayerOne.Bounds.IntersectsWith(ground2.Bounds))
                    {
                        //I used console to write lines of the pos of player and ground's top to figure out the Y cords for the above/below decetection
                        if (PlayerOne.Location.Y < 350)
                        {
                            PlayerOne.Top = ground2.Top - 34;
                            Ymovement = 0;
                            Jump = 0;
                        }
                        else
                        {
                            PlayerOne.Top = ground2.Top + 36;
                            Ymovement = 0;
                        }
                        //this code ^^^^^^^ is the base set up for all collision   
                    }
                    if (PlayerOne.Bounds.IntersectsWith(ground3.Bounds))
                    {
                        if (PlayerOne.Location.Y < 305)
                        {
                            PlayerOne.Top = ground3.Top - 34;
                            Ymovement = 0;
                            Jump = 0;
                        }
                        else
                        {
                            PlayerOne.Top = ground3.Top + 36;
                            Ymovement = 0;
                        }
                    }
                    else
                        if (PlayerOne.Bounds.IntersectsWith(ground4.Bounds))
                    {
                        if (PlayerOne.Location.Y < 230)
                        {
                            PlayerOne.Top = ground4.Top - 34;
                            Ymovement = 0;
                            Jump = 0;
                        }
                        else
                        {
                            PlayerOne.Top = ground4.Top + 36;
                            Ymovement = 0;
                        }
                    }
                    else
                        if (PlayerOne.Bounds.IntersectsWith(ground5.Bounds))
                    {
                        if (PlayerOne.Location.Y < 174)
                        {
                            PlayerOne.Top = ground5.Top - 34;
                            Ymovement = 0;
                            Jump = 0;
                        }
                        else
                        {
                            PlayerOne.Top = ground4.Top - 10;
                            Ymovement = 0;
                        }

                    }
                }
            }
            if (level == 2)
            {
                //Bullet collision code
                if (PlayerOne.Bounds.IntersectsWith(Bullet.Bounds))
                {
                    PlayerOne.Left = PnlGame.Width -950;
                    PlayerOne.Top = PnlGame.Height - 90;
                }

                if (PlayerOne.Bounds.IntersectsWith(Bullet1.Bounds))
                {
                    PlayerOne.Left = PnlGame.Width - 950;
                    PlayerOne.Top = PnlGame.Height - 90;
                }
                //Level 2 collision code
                if (PlayerOne.Bounds.IntersectsWith(ground6.Bounds))
                {
                    if (PlayerOne.Location.Y < 350)
                    {
                        PlayerOne.Top = ground6.Top - 34;
                        Ymovement = 0;
                        Jump = 0;
                    }
                    else
                    {
                        PlayerOne.Top = ground6.Top + 40;
                        Ymovement = 0;
                    }
                }
                else
                    if (PlayerOne.Bounds.IntersectsWith(ground7.Bounds))
                {
                    if (PlayerOne.Location.Y < 250)
                    {
                        PlayerOne.Top = ground7.Top - 34;
                        Ymovement = 0;
                        Jump = 0;
                    }
                    else
                    {
                        PlayerOne.Top = ground7.Top + 45;
                        Ymovement = 0;
                    }
                }
                else
                        if (PlayerOne.Bounds.IntersectsWith(ground8.Bounds))
                {
                    if (PlayerOne.Location.Y < 250)
                    {
                        PlayerOne.Top = ground8.Top - 34;
                        Ymovement = 0;
                        Jump = 0;
                    }
                    else
                    {
                        PlayerOne.Top = ground8.Top + 45;
                        Ymovement = 0;
                    }
                }
            }
            
        }

        //key dectection
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { left = true; }
            if (e.KeyData == Keys.Right){ right = true; }
            if (e.KeyData == Keys.Space) { space = true; }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { left = false; }
            if (e.KeyData == Keys.Right) { right = false; }
            if (e.KeyData == Keys.Space) { space = false; }
        }

        // this is the code for the help menu which lists controls and basic mechanics
        private void Help_Click(object sender, EventArgs e)
        {
            if (invisable1 == false)
            {
                Play.Hide();
                Help.Hide();
                Level_Background.Hide();
                pngHelp.Show();
                Back.Show();
                invisable = false;
            }
        }      
        //Back to main menu from help screen
        private void Back_Click(object sender, EventArgs e)
        {
            if (invisable == false)
            {
                Level_Background.Show();
                Play.Show();
                Help.Show();
                pngHelp.Hide();
                Back.Hide();
                invisable = true;
            }
        }

        private void turretTm_Tick(object sender, EventArgs e)
        {
            //I have a timer for both turrets so they can shoot at different times
            if (level==2)
                {
                if (Bullet1.Location.X > PnlGame.Width)
                {
                    Bullet1.Left = -10;
                }
                else
                {
                    Bullet1.Left += 15;
                }
            }
        }

        private void turretTm2_Tick(object sender, EventArgs e)
        {
            if (level == 2)
            {
                if (Bullet.Location.X > PnlGame.Width)
                {
                    Bullet.Left = -10;
                }
                else
                {
                    Bullet.Left += 10;
                }
            }
        }
    }

}
