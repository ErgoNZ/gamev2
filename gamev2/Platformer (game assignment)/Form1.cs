﻿using System;
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

        //Basic menu things
        public void Play_Click(object sender, EventArgs e)
        {
            Level_Background.Hide();
            Play.Hide();
            Help.Hide();
        }

        private void Gametick_Tick(object sender, EventArgs e)
        {


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
            //Collistion detection (Note: this took me way longer than it should have)
            PlayerOne.Top += Ymovement;
            if (PlayerOne.Bounds.IntersectsWith(ground1.Bounds) == true)
            //this part was easy but finding collistion for all platforms easily didnt happen so we end up with this mess of "if" and "else"
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
                    //this code ^^^^^^^ is the base set up for all collistion   
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
                        Console.WriteLine(ground4.Top);
                        Console.WriteLine(PlayerOne.Location.Y);
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
                        Console.WriteLine(ground5.Top);
                        Console.WriteLine(PlayerOne.Location.Y);
                        PlayerOne.Top = ground5.Top - 34;
                        Ymovement = 0;
                        Jump = 0;
                    }
                    else
                    {
                        PlayerOne.Top = ground4.Top -10;
                        Ymovement = 0;
                    }
                }
                else
                {
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