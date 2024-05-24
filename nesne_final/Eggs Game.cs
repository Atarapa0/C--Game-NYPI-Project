using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace nesne_final
{
    public partial class Eggs_Game : Form
    {
        public Eggs_Game()
        {
            InitializeComponent();
            RestartGame();
            
            ControlBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        
        bool goLeft, goRight;

        int speed = 8;
        int score = 0;
        int missed = 0;
        int s1, s2, s3, s4, s5;

        Random randX = new Random();
        Random randY = new Random();

        PictureBox splash = new PictureBox();
        SoundPlayer sound = new SoundPlayer();
        String dizin = Application.StartupPath + "\\Bouncing Eggs.wav";
        private void MainGameTimerEvent(object sender, EventArgs e)
        {
            silverMadal.Visible = false;
            bronzMadal.Visible = false;
            goldMadal.Visible = false;
           
            txtScore.Text = "Saved: " + score;
            txtMiss.Text = "Missed: " + missed;

            if (goLeft == true && player.Left > 0)
            {
                player.Left -= 12;
                player.Image = Properties.Resources.chicken_normal2;
            }
            if (goRight == true && player.Left + player.Width < this.ClientSize.Width)
            {
                player.Left += 12;
                player.Image = Properties.Resources.chicken_normal;
            }

            foreach (Control x in this.Controls)
            {

                if (x is PictureBox && (string)x.Tag == "eggs")
                {

                    x.Top += speed;

                    if (x.Top + x.Height > this.ClientSize.Height)
                    {

                        splash.Image = Properties.Resources.splash;
                        splash.Location = x.Location;
                        splash.Height = 60;
                        splash.Width = 60;
                        splash.BackColor = Color.Transparent;

                        this.Controls.Add(splash);

                        x.Top = randY.Next(80, 300) * -1;
                        x.Left = randX.Next(5, this.ClientSize.Width - x.Width);
                        missed += 1;
                        player.Image = Properties.Resources.chicken_hurt;

                    }


                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        x.Top = randY.Next(80, 300) * -1;
                        x.Left = randX.Next(5, this.ClientSize.Width - x.Width);
                        score += 1;
                    }
                }
            }

            if (score > 10)
            {
                speed = 12;
            }

            if (missed > 5)
            {
                EndGame();
            }


        }

        public void EndGame()
        {
            GameTimer.Stop();
            PlayImage.Visible = true;
            exitImage.Visible = true;
            lastScore.Visible = true;
            lastSco();
            
            if (score < 20)
            {
                silverMadal.Visible = true;
                bronzMadal.Visible = false;
                goldMadal.Visible = false;
                score = 0;
            }
            else if (score < 40)
            {
                bronzMadal.Visible = true;
                goldMadal.Visible = false;
                silverMadal.Visible = false;
                score = 0;
            }
            else
            {
                goldMadal.Visible = true;
                silverMadal.Visible = false;
                bronzMadal.Visible = false;
                score = 0;
            }

        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
            if(e.KeyCode==Keys.P&& GameTimer.Enabled == true)
            {
                GameTimer.Stop();
                pauseImage.Visible = true;
                exitImage.Visible = true;
            }

        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            //if (e.KeyCode == Keys.P && GameTimer.Enabled == true)
            //{
            //    GameTimer.Stop();
            //    pauseImage.Visible = true;
            //    exitImage.Visible = true;
            //}
        }

        private void Eggs_Game_Load(object sender, EventArgs e)
        {
            
            sound.SoundLocation = dizin;
           
                sound.Play();
        }

        

        private void pauseImage_Click(object sender, EventArgs e)
        {
            GameTimer.Start();
            pauseImage.Visible= false;
            exitImage.Visible= false;
        }

        private void PlayImage_Click(object sender, EventArgs e)
        {
            PlayImage.Visible= false;
            exitImage.Visible= false;
            lastScore.Visible= false;
            RestartGame();
        }

        private void exitImage_Click(object sender, EventArgs e)
        {
            sound.Stop();
            this.Close();
        }

        private void RestartGame()
        {

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "eggs")
                {
                    x.Top = randY.Next(80, 300) * -1;
                    x.Left = randX.Next(5, this.ClientSize.Width - x.Width);
                }
            }

            player.Left = this.ClientSize.Width / 2;
            player.Image = Properties.Resources.chicken_normal;

            score = 0;
            missed = 0;
            speed = 8;

            goLeft = false;
            goRight = false;

            GameTimer.Start();
            



        }
        public void lastSco()
        {

            if (s1 == 0)
            {
                s1 = score;
                lastScore.Text = "Last Score: \n" + s1;
            }

            else if (s2 == 0)
            {
                s2 = score;
                lastScore.Text = "Last Score: \n" + s1 + "\n" + s2;
            }

            else if (s3 == 0)
            {
                s3 = score;
                lastScore.Text = "Last Score: \n" + s1 + "\n" + s2 + "\n" + s3;
            }

            else if (s4 == 0)
            {
                s4 = score;
                lastScore.Text = "Last Score: \n" + s1 + "\n" + s2 + "\n" + s3 + "\n" + s4;

            }
            else if (s5 == 0)
            {
                s5 = score;
                lastScore.Text = "Last Score: \n" + s1 + "\n" + s2 + "\n" + s3 + "\n" + s4 + "\n" + s5;

            }
            else
            {
                s1 = s2; s2 = s3; s3 = s4; s4 = s5; s5 = score;
                lastScore.Text = "Last Score: \n" + s1 + "\n" + s2 + "\n" + s3 + "\n" + s4 + "\n" + s5;
            }

            
        }
    }
}
