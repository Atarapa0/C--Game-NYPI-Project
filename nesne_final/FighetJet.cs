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

namespace nesne_final
{
    public partial class FighetJet : Form
    {
        bool goLeft, goRight, shooting, isGameOver;
        int score;
        int playerSpeed = 12;
        int enemySpeed;
        int bulletSpeed;
        Random rnd = new Random();
        int s1, s2, s3, s4, s5;
        SoundPlayer sound = new SoundPlayer();
        String dizin = Application.StartupPath + "\\Ayten Alpman ~ Bir Başkadır Benim Memleketim 1978.wav";
        public FighetJet()
        {
            InitializeComponent();
            resetGame();
            ControlBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void mainGameTimerEvent(object sender, EventArgs e)
        {
            silverMadal.Visible = false;
            bronzMadal.Visible = false;
            goldMadal.Visible = false;

            txtScore.Text = "Score:" + score.ToString();


            enemyOne.Top += enemySpeed;
            enemyTwo.Top += enemySpeed;
            enemyThree.Top += enemySpeed;


            if (enemyOne.Top > 825 || enemyTwo.Top > 825 || enemyThree.Top > 825)
            {
                gameOver();
            }



            // player movement logic starts

            if (goLeft == true && player.Left > 0)
            {
                player.Left -= playerSpeed;
            }
            if (goRight == true && player.Left < 688)
            {
                player.Left += playerSpeed;
            }
            // player movement logic ends

            if (shooting == true)
            {
                bulletSpeed = 20;
                bullet.Top -= bulletSpeed;
            }
            else
            {
                bullet.Left = -300;
                bulletSpeed = 0;
            }

            if (bullet.Top < -30)
            {
                shooting = false;
            }

            if (bullet.Bounds.IntersectsWith(enemyOne.Bounds))
            {
                score += 1;
                enemyOne.Top = -450;
                enemyOne.Left = rnd.Next(20, 600);
                shooting = false;
            }
            if (bullet.Bounds.IntersectsWith(enemyTwo.Bounds))
            {
                score += 1;
                enemyTwo.Top = -650;
                enemyTwo.Left = rnd.Next(20, 600);
                shooting = false;
            }
            if (bullet.Bounds.IntersectsWith(enemyThree.Bounds))
            {
                score += 1;
                enemyThree.Top = -750;
                enemyThree.Left = rnd.Next(20, 600);
                shooting = false;
            }

            if (score == 5)
            {
                enemySpeed = 7;
            }
            if (score == 10)
            {
                enemySpeed = 10;
            }
            if(score==40)
                enemySpeed= 12;
            if(score==80)
                enemySpeed= 15;


        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
        }

        private void FighetJet_Load(object sender, EventArgs e)
        {
            
            sound.SoundLocation = dizin;
            sound.Play();

        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.Space && shooting == false)
            {
                shooting = true;

                bullet.Top = player.Top - 30;
                bullet.Left = player.Left + (player.Width / 2);

            }
            if (e.KeyCode == Keys.P && gameTimer.Enabled == true)
            {
                gameTimer.Stop();
                pauseImage.Visible = true;
                exitImage.Visible = true;
            }
            if (e.KeyCode == Keys.Enter && isGameOver == true)
            {
                PlayImage.Visible = false;
                exitImage.Visible = false;
                lastScore.Visible = false;
                resetGame();
            }
        }

        private void resetGame()
        {
            gameTimer.Start();
            enemySpeed = 6;


            enemyOne.Left = rnd.Next(20, 600);
            enemyTwo.Left = rnd.Next(20, 600);
            enemyThree.Left = rnd.Next(20, 600);

            enemyOne.Top = rnd.Next(0, 200) * -1;
            enemyTwo.Top = rnd.Next(0, 500) * -1;
            enemyThree.Top = rnd.Next(0, 900) * -1;

            score = 0;
            bulletSpeed = 0;
            bullet.Left = -300;
            shooting = false;


            txtScore.Text = "Score:" + score.ToString();

        }

        private void gameOver()
        {
            isGameOver = true;
            gameTimer.Stop();
            PlayImage.Visible = true;
            exitImage.Visible = true;
            lastScore.Visible = true;
            lastSco();
           
            if (score < 4)
            {
                silverMadal.Visible = true;
                bronzMadal.Visible = false;
                goldMadal.Visible = false;
                score = 0;
            }
            else if (score < 8)
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
        
    private void pauseImage_Click(object sender, EventArgs e)
    {
        gameTimer.Start();
        pauseImage.Visible = false;
        exitImage.Visible = false;
    }

    private void PlayImage_Click(object sender, EventArgs e)
    {
        PlayImage.Visible = false;
        exitImage.Visible = false;
        lastScore.Visible = false;
        resetGame();
    }

    private void exitImage_Click(object sender, EventArgs e)
    {
            sound.Stop();
        this.Close();
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
