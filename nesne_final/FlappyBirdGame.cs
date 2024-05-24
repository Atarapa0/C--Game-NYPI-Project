using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nesne_final
{
    public partial class FlappyBirdGame : Form
    {
        int pipeSpeed = 8;
        int gravity = 15;
        int score = 0;
        int s1 = 0, s2 = 0, s3 = 0, s4 = 0, s5 = 0;
        int ptl, ptl2, pbl, pbl2;
        bool timerCheack = true;
        bool isgame=true;
        SoundPlayer sound = new SoundPlayer();
        String dizin = Application.StartupPath + "\\marios_way.wav";

        public FlappyBirdGame()
        {
            InitializeComponent();
            ControlBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;

        }

        private void fappyGameTimer(object sender, EventArgs e)//oyun end game dediğinde space ye bastıgında oyun başlasın eklenecek
        {
            
            startSetting();
            label1.Text = " Score: " + score;  
            scorePlus();

            if (pictureBox_bird.Bounds.IntersectsWith(pictureBox_Bottom.Bounds) ||
                pictureBox_bird.Bounds.IntersectsWith(pictureBox_Top.Bounds) ||
                pictureBox_bird.Bounds.IntersectsWith(pictureBox_Bottom2.Bounds) ||
                pictureBox_bird.Bounds.IntersectsWith(pictureBox_Top2.Bounds) ||
                pictureBox_bird.Bounds.IntersectsWith(pictureBox_Ground.Bounds) ||
                pictureBox_bird.Top < -25)
            {
                EndGame();
                
            }
            pipeMove();
            


        }
        public void startSetting()
        {
            timerCheack = true;
            isgame = true;
            deadSceenScore.Visible = false;
            silverMadal.Visible = false;
            bronzMadal.Visible = false;
            goldMadal.Visible = false;
            pictureBox_bird.Top += gravity;
            pictureBox_Bottom.Left -= pipeSpeed;
            pictureBox_Top.Left -= pipeSpeed;
            pictureBox_Bottom2.Left -= pipeSpeed;
            pictureBox_Top2.Left -= pipeSpeed;
            backgroundPicture1.Left -= pipeSpeed;
            backgroundPicture2.Left -= pipeSpeed;
            backgroundPicture3.Left -= pipeSpeed;
            backgroundPicture4.Left -= pipeSpeed;
            ptl = pictureBox_Top.Location.Y;
            ptl2 = pictureBox_Top2.Location.Y;
            pbl = pictureBox_Bottom.Location.Y;
            pbl2 = pictureBox_Bottom2.Location.Y;
        }
        
        public void pipeMove()
        {
            if (pictureBox_Bottom.Left < -150)
            {
                pictureBox_Bottom.Left = 500;
                pictureBox_Top.Left = 500;
                pipeupdown();
            }
            if (pictureBox_Bottom2.Left < -150)
            {
                pictureBox_Bottom2.Left = 500;
                pictureBox_Top2.Left = 500;
                pipeupdown();
            }
            if (backgroundPicture1.Location.X < -50)
                backgroundPicture1.Left = 630;

            if (backgroundPicture2.Location.X < -50)
                backgroundPicture2.Left = 740;

            if (backgroundPicture3.Location.X < -50)
                backgroundPicture3.Left = 630;

            if (backgroundPicture4.Location.X < -500)
                backgroundPicture4.Left = 740;
            
            
        }
       
        public void pipeupdown()
        {
           
            Random rd = new Random();
            int a = rd.Next(0, 10);
            int y = rd.Next(0, 50); // random sayıdan 1 gelirse yukarı hareket sağlıyor
            int y2 = rd.Next(-50, 0); // aşağı hareket sağlıyor
            if (a<5)
            {
                pictureBox_Top.Location = new Point(pictureBox_Top.Location.X, -200);
                pictureBox_Bottom.Location = new Point(pictureBox_Bottom.Location.X, 455);
                pictureBox_Bottom.Top += y;
                pictureBox_Top.Top += y;
            }
            else
            {
                pictureBox_Bottom2.Location = new Point(pictureBox_Bottom2.Location.X, 445);
                pictureBox_Top2.Location = new Point(pictureBox_Top2.Location.X, -200);
                pictureBox_Bottom2.Top += y2;
                pictureBox_Top2.Top += y2;
            }
            
        }
        
       
        public void scorePlus()
        {
            if (pictureBox_Bottom.Location.X == pictureBox_bird.Location.X || pictureBox_Bottom2.Location.X == pictureBox_bird.Location.X)
                score++;
            
        }

        private void exitBırd_Clınk(object sender, EventArgs e)
        {
            sound.Stop();
            this.Close();
        }

        
        private void FlappyBirdGame_Load(object sender, EventArgs e)
        {
            
            sound.SoundLocation = dizin;
            sound.Play();

        }

        public void EndGame()
        {
            timerCheack = false;
            isgame = false;
            timer_GameControl.Stop();
            label1.Text = "Game Over";
            deadSceenScore.Visible = true;
            deadSceenScore.Text = " Score: " + score;
            lastScore.Visible = true;
            exitBırd.Visible = true;
            lastSco();
            //bronzMadal.Visible = false;
            //goldMadal.Visible = false;
            //silverMadal.Visible = false;

            playPicture.Visible = true;
            if (score < 5) { 
            silverMadal.Visible = true;
            bronzMadal.Visible = false;
            goldMadal.Visible = false;
                score = 0;
            }
            else if (score < 10)
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
       
        private void game_Down(object sender, KeyEventArgs e)
        {
            if(timer_GameControl.Enabled == true && timerCheack == true && isgame == true)
            {
                if (timerCheack == true && isgame==true && e.KeyCode == Keys.Space)
                    gravity = -10;

                if(timerCheack == true && isgame == true && e.KeyCode == Keys.P)
                {
                    timer_GameControl.Stop();
                    PauseMenu.Visible = true;
                    exitBırd.Visible = true;
                }
            }

            int i = 0;
            if (e.KeyCode == Keys.Space && i == 0 && timerCheack == true && isgame == true)
            {
                timer_GameControl.Start();
                Startlabel.Visible = false;

                i++;
            }
            if (timerCheack == false && isgame == false && e.KeyCode==Keys.Enter)
            {
                timer_GameControl.Start();
                playLocatıon();
                playPicture.Visible = false;
                lastScore.Visible = false;
                silverMadal.Visible = false;
                bronzMadal.Visible = false;
                goldMadal.Visible = false;
                timerCheack = true;
                isgame = true;
            }

        }

        private void game_Up(object sender, KeyEventArgs e)
        {
            if(timer_GameControl.Enabled == true && timerCheack == true && isgame == true)
            {
                if (e.KeyCode == Keys.Space && timerCheack == true && isgame == true)
                    gravity = 15;
                if (e.KeyCode == Keys.P && timerCheack == true && isgame == true)
                {
                    timer_GameControl.Stop();
                    PauseMenu.Visible = true;
                    exitBırd.Visible = true;
                    timerCheack = false;
                }
            }
            
        }
       


        private void PauseMenu_Click(object sender, EventArgs e)
        {
            timer_GameControl.Start();
            PauseMenu.Visible = false;
            exitBırd.Visible = false;
            timerCheack = true;
            isgame = true;
        }

        private void playPicture_Click(object sender, EventArgs e)
        {
            
            timer_GameControl.Start();
            playLocatıon();
            playPicture.Visible = false;
            lastScore.Visible = false;
            silverMadal.Visible = false;
            bronzMadal.Visible = false;
            goldMadal.Visible = false;
            timerCheack = true;
            isgame = true;


        }
        public void playLocatıon()
        {
            pictureBox_bird.Location = new Point(76, 341);
            pictureBox_Top.Location = new Point(428, -200);
            pictureBox_Bottom.Location = new Point(428, 455);
            pictureBox_Bottom2.Location = new Point(768, 445);
            pictureBox_Top2.Location = new Point(768, -200);
            backgroundPicture1.Location = new Point(184, 680);
            backgroundPicture2.Location = new Point(570, 680);
            backgroundPicture3.Location = new Point(312, 680);
            backgroundPicture4.Location = new Point(646, 690);
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
                s1 = s2; s2=s3; s3=s4; s4=s5; s5=score;
                lastScore.Text = "Last Score: \n" + s1 + "\n" + s2 + "\n" + s3 + "\n" + s4 + "\n" + s5;
            }
            
            
            
        }//-------------backgrohnd imageler kutuk gibi işinlanıyopr onları tek tek işinla ve lascsco arkasın tablo koy

    }
}
