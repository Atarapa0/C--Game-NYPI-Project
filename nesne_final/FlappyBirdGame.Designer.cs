namespace nesne_final
{
    partial class FlappyBirdGame
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
            this.timer_GameControl = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.deadSceenScore = new System.Windows.Forms.Label();
            this.Startlabel = new System.Windows.Forms.Label();
            this.exitBırd = new System.Windows.Forms.PictureBox();
            this.lastScore = new System.Windows.Forms.Label();
            this.goldMadal = new System.Windows.Forms.PictureBox();
            this.bronzMadal = new System.Windows.Forms.PictureBox();
            this.silverMadal = new System.Windows.Forms.PictureBox();
            this.playPicture = new System.Windows.Forms.PictureBox();
            this.backgroundPicture4 = new System.Windows.Forms.PictureBox();
            this.backgroundPicture3 = new System.Windows.Forms.PictureBox();
            this.backgroundPicture2 = new System.Windows.Forms.PictureBox();
            this.backgroundPicture1 = new System.Windows.Forms.PictureBox();
            this.PauseMenu = new System.Windows.Forms.PictureBox();
            this.pictureBox_Ground = new System.Windows.Forms.PictureBox();
            this.pictureBox_Bottom2 = new System.Windows.Forms.PictureBox();
            this.pictureBox_Top2 = new System.Windows.Forms.PictureBox();
            this.pictureBox_Bottom = new System.Windows.Forms.PictureBox();
            this.pictureBox_Top = new System.Windows.Forms.PictureBox();
            this.pictureBox_bird = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.exitBırd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goldMadal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bronzMadal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.silverMadal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundPicture4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundPicture3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundPicture2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundPicture1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PauseMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Bottom2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Top2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Bottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Top)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_bird)).BeginInit();
            this.SuspendLayout();
            // 
            // timer_GameControl
            // 
            this.timer_GameControl.Interval = 20;
            this.timer_GameControl.Tick += new System.EventHandler(this.fappyGameTimer);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "SCORE:";
            // 
            // deadSceenScore
            // 
            this.deadSceenScore.AutoSize = true;
            this.deadSceenScore.BackColor = System.Drawing.Color.Transparent;
            this.deadSceenScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.deadSceenScore.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.deadSceenScore.Location = new System.Drawing.Point(221, 198);
            this.deadSceenScore.Name = "deadSceenScore";
            this.deadSceenScore.Size = new System.Drawing.Size(74, 25);
            this.deadSceenScore.TabIndex = 16;
            this.deadSceenScore.Text = "Score:";
            this.deadSceenScore.Visible = false;
            // 
            // Startlabel
            // 
            this.Startlabel.AutoSize = true;
            this.Startlabel.BackColor = System.Drawing.Color.Transparent;
            this.Startlabel.Font = new System.Drawing.Font("Mistral", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Startlabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Startlabel.Location = new System.Drawing.Point(115, 223);
            this.Startlabel.Name = "Startlabel";
            this.Startlabel.Size = new System.Drawing.Size(277, 44);
            this.Startlabel.TabIndex = 21;
            this.Startlabel.Text = "Press To Start Space ";
            // 
            // exitBırd
            // 
            this.exitBırd.Image = global::nesne_final.Properties.Resources.volumeoff1;
            this.exitBırd.Location = new System.Drawing.Point(467, 13);
            this.exitBırd.Name = "exitBırd";
            this.exitBırd.Size = new System.Drawing.Size(53, 53);
            this.exitBırd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exitBırd.TabIndex = 22;
            this.exitBırd.TabStop = false;
            this.exitBırd.Visible = false;
            this.exitBırd.Click += new System.EventHandler(this.exitBırd_Clınk);
            // 
            // lastScore
            // 
            this.lastScore.AutoSize = true;
            this.lastScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lastScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lastScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lastScore.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lastScore.Location = new System.Drawing.Point(205, 444);
            this.lastScore.Name = "lastScore";
            this.lastScore.Size = new System.Drawing.Size(123, 27);
            this.lastScore.TabIndex = 20;
            this.lastScore.Text = "Last Score:";
            this.lastScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lastScore.Visible = false;
            // 
            // goldMadal
            // 
            this.goldMadal.BackColor = System.Drawing.Color.Transparent;
            this.goldMadal.Image = global::nesne_final.Properties.Resources.gold_madal_1;
            this.goldMadal.Location = new System.Drawing.Point(227, 253);
            this.goldMadal.Name = "goldMadal";
            this.goldMadal.Size = new System.Drawing.Size(70, 70);
            this.goldMadal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.goldMadal.TabIndex = 19;
            this.goldMadal.TabStop = false;
            this.goldMadal.Visible = false;
            // 
            // bronzMadal
            // 
            this.bronzMadal.BackColor = System.Drawing.Color.Transparent;
            this.bronzMadal.Image = global::nesne_final.Properties.Resources.bronz_madal_1;
            this.bronzMadal.Location = new System.Drawing.Point(227, 253);
            this.bronzMadal.Name = "bronzMadal";
            this.bronzMadal.Size = new System.Drawing.Size(70, 70);
            this.bronzMadal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.bronzMadal.TabIndex = 18;
            this.bronzMadal.TabStop = false;
            this.bronzMadal.Visible = false;
            // 
            // silverMadal
            // 
            this.silverMadal.BackColor = System.Drawing.Color.Transparent;
            this.silverMadal.Image = global::nesne_final.Properties.Resources.silver_madal_1;
            this.silverMadal.Location = new System.Drawing.Point(227, 253);
            this.silverMadal.Name = "silverMadal";
            this.silverMadal.Size = new System.Drawing.Size(70, 70);
            this.silverMadal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.silverMadal.TabIndex = 17;
            this.silverMadal.TabStop = false;
            this.silverMadal.Visible = false;
            // 
            // playPicture
            // 
            this.playPicture.BackColor = System.Drawing.Color.Transparent;
            this.playPicture.Image = global::nesne_final.Properties.Resources.play;
            this.playPicture.Location = new System.Drawing.Point(227, 342);
            this.playPicture.Name = "playPicture";
            this.playPicture.Size = new System.Drawing.Size(70, 70);
            this.playPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.playPicture.TabIndex = 14;
            this.playPicture.TabStop = false;
            this.playPicture.Visible = false;
            this.playPicture.Click += new System.EventHandler(this.playPicture_Click);
            // 
            // backgroundPicture4
            // 
            this.backgroundPicture4.BackColor = System.Drawing.Color.Transparent;
            this.backgroundPicture4.Image = global::nesne_final.Properties.Resources.Background_holloween4;
            this.backgroundPicture4.Location = new System.Drawing.Point(662, 690);
            this.backgroundPicture4.Name = "backgroundPicture4";
            this.backgroundPicture4.Size = new System.Drawing.Size(70, 60);
            this.backgroundPicture4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.backgroundPicture4.TabIndex = 12;
            this.backgroundPicture4.TabStop = false;
            // 
            // backgroundPicture3
            // 
            this.backgroundPicture3.BackColor = System.Drawing.Color.Transparent;
            this.backgroundPicture3.Image = global::nesne_final.Properties.Resources.Background_holloween2;
            this.backgroundPicture3.Location = new System.Drawing.Point(336, 680);
            this.backgroundPicture3.Name = "backgroundPicture3";
            this.backgroundPicture3.Size = new System.Drawing.Size(70, 70);
            this.backgroundPicture3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.backgroundPicture3.TabIndex = 11;
            this.backgroundPicture3.TabStop = false;
            // 
            // backgroundPicture2
            // 
            this.backgroundPicture2.BackColor = System.Drawing.Color.Transparent;
            this.backgroundPicture2.Image = global::nesne_final.Properties.Resources.Background_holloween3;
            this.backgroundPicture2.Location = new System.Drawing.Point(567, 680);
            this.backgroundPicture2.Name = "backgroundPicture2";
            this.backgroundPicture2.Size = new System.Drawing.Size(70, 70);
            this.backgroundPicture2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.backgroundPicture2.TabIndex = 10;
            this.backgroundPicture2.TabStop = false;
            // 
            // backgroundPicture1
            // 
            this.backgroundPicture1.BackColor = System.Drawing.Color.Transparent;
            this.backgroundPicture1.Image = global::nesne_final.Properties.Resources.Background_holloween1;
            this.backgroundPicture1.Location = new System.Drawing.Point(238, 680);
            this.backgroundPicture1.Name = "backgroundPicture1";
            this.backgroundPicture1.Size = new System.Drawing.Size(70, 70);
            this.backgroundPicture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.backgroundPicture1.TabIndex = 9;
            this.backgroundPicture1.TabStop = false;
            // 
            // PauseMenu
            // 
            this.PauseMenu.BackColor = System.Drawing.Color.Transparent;
            this.PauseMenu.Image = global::nesne_final.Properties.Resources.pause;
            this.PauseMenu.Location = new System.Drawing.Point(227, 342);
            this.PauseMenu.Name = "PauseMenu";
            this.PauseMenu.Size = new System.Drawing.Size(70, 70);
            this.PauseMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PauseMenu.TabIndex = 8;
            this.PauseMenu.TabStop = false;
            this.PauseMenu.Visible = false;
            this.PauseMenu.Click += new System.EventHandler(this.PauseMenu_Click);
            // 
            // pictureBox_Ground
            // 
            this.pictureBox_Ground.Image = global::nesne_final.Properties.Resources.groundHollowen;
            this.pictureBox_Ground.Location = new System.Drawing.Point(-5, 749);
            this.pictureBox_Ground.Name = "pictureBox_Ground";
            this.pictureBox_Ground.Size = new System.Drawing.Size(873, 95);
            this.pictureBox_Ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Ground.TabIndex = 5;
            this.pictureBox_Ground.TabStop = false;
            // 
            // pictureBox_Bottom2
            // 
            this.pictureBox_Bottom2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Bottom2.Image = global::nesne_final.Properties.Resources.pipebottom;
            this.pictureBox_Bottom2.Location = new System.Drawing.Point(768, 445);
            this.pictureBox_Bottom2.Name = "pictureBox_Bottom2";
            this.pictureBox_Bottom2.Size = new System.Drawing.Size(100, 450);
            this.pictureBox_Bottom2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Bottom2.TabIndex = 4;
            this.pictureBox_Bottom2.TabStop = false;
            // 
            // pictureBox_Top2
            // 
            this.pictureBox_Top2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Top2.Image = global::nesne_final.Properties.Resources.pipedown;
            this.pictureBox_Top2.Location = new System.Drawing.Point(768, -200);
            this.pictureBox_Top2.Name = "pictureBox_Top2";
            this.pictureBox_Top2.Size = new System.Drawing.Size(100, 450);
            this.pictureBox_Top2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Top2.TabIndex = 3;
            this.pictureBox_Top2.TabStop = false;
            // 
            // pictureBox_Bottom
            // 
            this.pictureBox_Bottom.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Bottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox_Bottom.Image = global::nesne_final.Properties.Resources.pipebottom;
            this.pictureBox_Bottom.Location = new System.Drawing.Point(428, 455);
            this.pictureBox_Bottom.Name = "pictureBox_Bottom";
            this.pictureBox_Bottom.Size = new System.Drawing.Size(100, 450);
            this.pictureBox_Bottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Bottom.TabIndex = 2;
            this.pictureBox_Bottom.TabStop = false;
            // 
            // pictureBox_Top
            // 
            this.pictureBox_Top.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Top.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox_Top.Image = global::nesne_final.Properties.Resources.pipedown;
            this.pictureBox_Top.Location = new System.Drawing.Point(428, -200);
            this.pictureBox_Top.Name = "pictureBox_Top";
            this.pictureBox_Top.Size = new System.Drawing.Size(100, 450);
            this.pictureBox_Top.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Top.TabIndex = 1;
            this.pictureBox_Top.TabStop = false;
            // 
            // pictureBox_bird
            // 
            this.pictureBox_bird.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_bird.Image = global::nesne_final.Properties.Resources.pngwing_com;
            this.pictureBox_bird.Location = new System.Drawing.Point(72, 353);
            this.pictureBox_bird.Name = "pictureBox_bird";
            this.pictureBox_bird.Size = new System.Drawing.Size(57, 59);
            this.pictureBox_bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_bird.TabIndex = 0;
            this.pictureBox_bird.TabStop = false;
            // 
            // FlappyBirdGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(532, 839);
            this.Controls.Add(this.exitBırd);
            this.Controls.Add(this.Startlabel);
            this.Controls.Add(this.lastScore);
            this.Controls.Add(this.goldMadal);
            this.Controls.Add(this.bronzMadal);
            this.Controls.Add(this.silverMadal);
            this.Controls.Add(this.deadSceenScore);
            this.Controls.Add(this.playPicture);
            this.Controls.Add(this.backgroundPicture4);
            this.Controls.Add(this.backgroundPicture3);
            this.Controls.Add(this.backgroundPicture2);
            this.Controls.Add(this.backgroundPicture1);
            this.Controls.Add(this.PauseMenu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox_Ground);
            this.Controls.Add(this.pictureBox_Bottom2);
            this.Controls.Add(this.pictureBox_Top2);
            this.Controls.Add(this.pictureBox_Bottom);
            this.Controls.Add(this.pictureBox_Top);
            this.Controls.Add(this.pictureBox_bird);
            this.DoubleBuffered = true;
            this.Name = "FlappyBirdGame";
            this.Text = "FlappyBirdGame";
            this.Load += new System.EventHandler(this.FlappyBirdGame_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.game_Down);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.game_Up);
            ((System.ComponentModel.ISupportInitialize)(this.exitBırd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goldMadal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bronzMadal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.silverMadal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundPicture4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundPicture3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundPicture2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundPicture1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PauseMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Bottom2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Top2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Bottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Top)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_bird)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_bird;
        private System.Windows.Forms.PictureBox pictureBox_Top;
        private System.Windows.Forms.PictureBox pictureBox_Bottom;
        private System.Windows.Forms.PictureBox pictureBox_Top2;
        private System.Windows.Forms.PictureBox pictureBox_Bottom2;
        private System.Windows.Forms.PictureBox pictureBox_Ground;
        private System.Windows.Forms.Timer timer_GameControl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PauseMenu;
        private System.Windows.Forms.PictureBox backgroundPicture1;
        private System.Windows.Forms.PictureBox backgroundPicture2;
        private System.Windows.Forms.PictureBox backgroundPicture3;
        private System.Windows.Forms.PictureBox backgroundPicture4;
        private System.Windows.Forms.PictureBox playPicture;
        private System.Windows.Forms.Label deadSceenScore;
        private System.Windows.Forms.PictureBox silverMadal;
        private System.Windows.Forms.PictureBox bronzMadal;
        private System.Windows.Forms.PictureBox goldMadal;
        private System.Windows.Forms.Label lastScore;
        private System.Windows.Forms.Label Startlabel;
        private System.Windows.Forms.PictureBox exitBırd;
    }
}