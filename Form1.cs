using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apple3
{
    public partial class Form1 : Form
    {

        bool goLeft, goRight, sword, swordSwing;
        bool hold = true;
        int playerSpeed = 1;
        bool jump = false;
        bool run;

        bool playerPosition;
        int force;
        int jumpSpeed;
        int swing = 0;
        int apples = 0;
        int sprint = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Left&hold)
            {
                goLeft = true;
                hold = false;
                player.Image = Properties.Resources.left;
                sprint++;
                if (sprint < 2)
                {
                    playerSpeed = 1;
                }
                if (sprint == 2)
                {
                    run = true;
                    playerSpeed = 3;
                }
            
            }
            if (e.KeyCode == Keys.Right&hold)
            {
                goRight = true;
                hold = false;
                player.Image = Properties.Resources.New_Piskel;
                sprint++;
                if (sprint < 2)
                {
                    playerSpeed = 1;
                }
                if (sprint == 2)
                {
                    run = true;
                    playerSpeed = 3;
                }
            }
            if (e.KeyCode == Keys.Up && jump == false)
            {
                if (playerPosition == false)
                {
                    jump = true;
                    player.Image = Properties.Resources.jump2;
                }
                else if (playerPosition == true)
                {
                    jump = true;
                    player.Image= Properties.Resources.New_Piskel__22_;
                }
                
            }
            if (e.KeyCode == Keys.Space)
            {
                if (playerPosition == false)
                {
                    sword = true;
                    player.Image = Properties.Resources.sword2;
                    swing++;
                    if (swing == 2)
                    {
                        swordSwing = true;
                        player.Image = Properties.Resources.New_Piskel__20_;
                    }
                }
                else if (playerPosition == true)
                {
                    sword = true;
                    player.Image = Properties.Resources.New_Piskel__19_;
                    swing++;
                    if (swing == 2)
                    {
                        swordSwing = true;
                        player.Image = Properties.Resources.New_Piskel__21_;
                    }
                }

                
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left&!hold)
            {
                goLeft = false;
                hold = true;
                run = false;
                player.Image= Properties.Resources.New_Piskel__18_;
            }
            if (e.KeyCode == Keys.Right&!hold)
            {
                goRight = false;
                hold = true;
                run = false;
                player.Image = Properties.Resources.New_Piskel__15_;
            }
            if (jump == true)
            {
                if (playerPosition == false)
                {
                    jump = false;
                    player.Image = Properties.Resources.jump1;
                }
                else if (playerPosition == true)
                {
                    jump = false;
                    player.Image = Properties.Resources.New_Piskel__18_;
                }
               
            }
            if (e.KeyCode == Keys.Space && goRight == true || e.KeyCode == Keys.Space && goLeft == true)
            {   
                if (goRight == true)
                {
                    sword = false;
                    swordSwing= false;
                    player.Image = Properties.Resources.sword1;
                }
                else if (goLeft == true)
                {
                    sword = false;
                    swordSwing = false;
                    player.Image = Properties.Resources.New_Piskel__18_;
                }
               
                
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            player.Top += jumpSpeed;
            if (goLeft == true)
            {
                player.Left -= playerSpeed;
                playerPosition = true;
            }
            if (goRight == true)
            {
                player.Left += playerSpeed;
                playerPosition = false;
            }

            if (jump == true)
            {
                jumpSpeed = -8;
                force -= 1;

            }
            else if (jump == true && force < 0)
            {
                jump = false;
            }
            else
            {
                jumpSpeed = 10;
            }

            if (player.Bounds.IntersectsWith(ground.Bounds))
            {
                player.Top = ground.Top - player.Height;
                force = 8;
                ground.BringToFront();

            }
            if (swing == 2)
            {
                swing = 0;
            }
            
            

            if (player.Bounds.IntersectsWith(apple.Bounds) && apple.Visible == true)
            {
                apple.Visible = false;
                apples++;
                appleLabel.Text = "Apples: " + apples;
            }

            if (sprint == 2)
            {
                sprint = 0;
            }
       
      





    }

        private void Form1_Load(object sender, EventArgs e)
        {
           


        }
    }
}
