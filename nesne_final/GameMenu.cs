using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace nesne_final
{
    public partial class Frm_Menu : Form
    {
        
        public Frm_Menu()
        {
            InitializeComponent();
        }

        private void Help_Window_Click(object sender, EventArgs e)
        {
            HelpGame helpWindow = new HelpGame();
            helpWindow.Show();
            

        }
     

        private void FlappyBird_Game_Click(object sender, EventArgs e)
        {
            FlappyBirdGame flappyWindow = new FlappyBirdGame();
            flappyWindow.Show();
            


        }


        private void quitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

       

        private void Fighet_Game_Click(object sender, EventArgs e)
        {
            FighetJet fight = new FighetJet();
            fight.Show();
        }

        private void Eggs_Game_Click(object sender, EventArgs e)
        {
            Eggs_Game eggs = new Eggs_Game();
            eggs.Show();
        }

        private void eggshover(object sender, EventArgs e)
        {
            egg.Visible = true;
            flappy.Visible = false;
            jet.Visible = false;
        }

        private void jethover(object sender, EventArgs e)
        {
            egg.Visible = false;
            flappy.Visible = false;
            jet.Visible = true;
        }

        private void flappyhover(object sender, EventArgs e)
        {
            egg.Visible = false;
            flappy.Visible = true;
            jet.Visible = false;
        }
    }
}
