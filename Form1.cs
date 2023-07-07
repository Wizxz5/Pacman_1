using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pacman_1
{
    public partial class PacmanGame : Form
    {
        bool goup, godown, goleft, goright, isGameOver;
        int score, playerSpeed, redGhostSpeed, yellowGhostSpeed, pinkGhostX, pinkGhostY; 
        public PacmanGame()
        {
            InitializeComponent();
            resetGame();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void yellowGhost_Click(object sender, EventArgs e)
        {

        }

        private void OnFormclosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {

        }

        private void keyisdown(object sender, KeyEventArgs e)

        {
            if(e.KeyCode == Keys.Up)
            {
                goup = true;
            }
            if(e.KeyCode == Keys.Down)
            {
                godown = true;
            }
            if(e.KeyCode == Keys.Left)
            {
                goleft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = true;
            }



        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                goup = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                godown = false;
            }
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }
            if(e.KeyCode == Keys.Enter && isGameOver == true)
            {
                resetGame();
            }
        }

        private void MainGameTimer(object sender, EventArgs e)
        {

            txtScore.Text = "Score: " + score;
            if (goleft == true)
            {
                pacman.Left -= playerSpeed;
                pacman.Image = Properties.Resources.left;
            }
            if (goright == true)
            {
                pacman.Left += playerSpeed;
                pacman.Image = Properties.Resources.right;
            }
            if (godown == true) 
            {
                pacman.Top += playerSpeed;
                pacman.Image = Properties.Resources.down;
            }
            if (goup == true)
            {
                pacman.Top -= playerSpeed;
                pacman.Image = Properties.Resources.Up;
            }

            if (pacman.Left < -10)
            {
                pacman.Left = 500;
            }
            if (pacman.Left > 500)
                {
                    pacman.Left = -10;
                }
            if (pacman.Top < -10)
                {
                pacman.Top = 400;
                }
            if (pacman.Top > 400)
                {
                    pacman.Top = 0;
                }
            
            foreach(Control x in this.Controls)
            {
                if(x is PictureBox)
                {
                    if ((string)x.Tag == "coin" && x.Visible == true) 
                    {
                        if (pacman.Bounds.IntersectsWith(x.Bounds))
                        {
                            score += 1;
                            x.Visible = false;
                        }
                    }
                    if ((string)x.Tag == "wall")
                    {
                        if (pacman.Bounds.IntersectsWith(x.Bounds))
                        {
                            gameOver("you Lose!");
                        }
                        if(pinkGhost.Bounds.IntersectsWith(x.Bounds))
                        {
                            pinkGhostX = -pinkGhostX;
                        }
                          
                    }
                    if ((string)x.Tag == "ghost")
                    {
                        if (pacman.Bounds.IntersectsWith(x.Bounds))
                        {
                            gameOver("you Lose!");
                        }
                    }
                }
            }

            //moving the ghosts

            //red ghost moving

            redGhost.Left += redGhostSpeed;

            if (redGhost.Bounds.IntersectsWith(pictureBox1.Bounds) || redGhost.Bounds.IntersectsWith(pictureBox2.Bounds))
            {
                redGhostSpeed = -redGhostSpeed;
            }

            //Yellow moving  

            yellowGhost.Left -= yellowGhostSpeed;
            if (yellowGhost.Bounds.IntersectsWith(pictureBox3.Bounds) || yellowGhost.Bounds.IntersectsWith(pictureBox4.Bounds))
            {
                yellowGhostSpeed = -yellowGhostSpeed;
            }

            pinkGhost.Left -= pinkGhostX;
            pinkGhost.Top -= pinkGhostY;

            if(pinkGhost.Top < 0 || pinkGhost.Top > 320)
            {
                pinkGhostY = -pinkGhostY;
            }
            if(pinkGhost.Left < 0 || pinkGhost.Left > 420)
            {
                pinkGhostX= -pinkGhostX;
            }




            if (score == 48)
            {
                gameOver(" you win! :)");
                Level2 newLevel = new Level2();
                this.Hide();
                mainGameTimer.Stop();
                newLevel.Show();


            }

        }
        private void resetGame()
        {
            txtScore.Text = "Score: 0";
            score = 0;


            redGhostSpeed = 3;
            yellowGhostSpeed = 3;
            pinkGhostX = 2;
            pinkGhostY = 2;
            playerSpeed = 8;

            isGameOver = false;

            pacman.Left = 31;
            pacman.Top = 46;

            redGhost.Left = 180;
            redGhost.Top = 40;

            yellowGhost.Left = 200;
            yellowGhost.Top = 275;

            pinkGhost.Left = 370;
            pinkGhost.Top = 160;

            foreach(Control x in this.Controls)
            {
                if(x is PictureBox)
                {
                    x.Visible = true;
                }
            }


            mainGameTimer.Start();

            

        }

        //function game over 

        private void gameOver(string message)
        {
            isGameOver= true;

            mainGameTimer.Stop();

            txtScore.Text = "Score: " + score + Environment.NewLine + message;
        }
    }
}
