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
        bool left = false;
        bool right = false;
        bool space = false;
        int Ymovement;
        int Jump = 0;
        

        public Form1()
        {
            //Player location and Size
            InitializeComponent();

            Console.WriteLine("REEEEEEEEEEEEE");
        }

        //This Loads on bootup
        private void Form1_Load(object sender, EventArgs e)
        {
            Level_Background.Show();
            Play.Show();
            Help.Show();
        }


        public void Play_Click(object sender, EventArgs e)
        {
            Level_Background.Hide();
            Play.Hide();
            Help.Hide();
        }

        private void Gametick_Tick(object sender, EventArgs e)
        {


            //movement
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
                if (PlayerOne.Location.X < -20)
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
                if (PlayerOne.Location.X > PnlGame.Width + 30)
                {
                    PlayerOne.Left = -10;
                }
                else
                {
                    PlayerOne.Left += 5;
                }
            }
        }
        private void Gravity_Tick(object sender, EventArgs e)
        {
            PlayerOne.Top += Ymovement;
            foreach (Control x in this.Controls)
            {
                if (x.Tag == "Platform")
                {
                    if (PlayerOne.Bounds.IntersectsWith(x.Bounds))
                    {
                        Ymovement = 0;
                        Jump = 0;
                        PlayerOne.Top = x.Top - 34;
                        Console.WriteLine("this works");
                    }
                    else
                    {
                        Ymovement += 1;
                        if (Ymovement > 20)
                        {
                            Ymovement = 20;
                        }
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

    }

}
