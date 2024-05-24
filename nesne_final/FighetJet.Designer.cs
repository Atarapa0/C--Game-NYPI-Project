namespace nesne_final
{
    partial class FighetJet
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
            this.txtScore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.enemyOne = new System.Windows.Forms.PictureBox();
            this.exitImage = new System.Windows.Forms.PictureBox();
            this.pauseImage = new System.Windows.Forms.PictureBox();
            this.lastScore = new System.Windows.Forms.Label();
            this.PlayImage = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.bullet = new System.Windows.Forms.PictureBox();
            this.enemyThree = new System.Windows.Forms.PictureBox();
            this.enemyTwo = new System.Windows.Forms.PictureBox();
            this.goldMadal = new System.Windows.Forms.PictureBox();
            this.bronzMadal = new System.Windows.Forms.PictureBox();
            this.silverMadal = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.enemyOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pauseImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyThree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goldMadal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bronzMadal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.silverMadal)).BeginInit();
            this.SuspendLayout();
            // 
            // txtScore
            // 
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.Location = new System.Drawing.Point(36, 39);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(167, 40);
            this.txtScore.TabIndex = 7;
            this.txtScore.Text = "0";
            this.txtScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.mainGameTimerEvent);
            // 
            // enemyOne
            // 
            this.enemyOne.Image = global::nesne_final.Properties.Resources.asfasfasd1;
            this.enemyOne.Location = new System.Drawing.Point(80, 27);
            this.enemyOne.Name = "enemyOne";
            this.enemyOne.Size = new System.Drawing.Size(100, 103);
            this.enemyOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemyOne.TabIndex = 15;
            this.enemyOne.TabStop = false;
            // 
            // exitImage
            // 
            this.exitImage.Image = global::nesne_final.Properties.Resources.carp;
            this.exitImage.Location = new System.Drawing.Point(793, 27);
            this.exitImage.Name = "exitImage";
            this.exitImage.Size = new System.Drawing.Size(70, 70);
            this.exitImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.exitImage.TabIndex = 14;
            this.exitImage.TabStop = false;
            this.exitImage.Visible = false;
            this.exitImage.Click += new System.EventHandler(this.exitImage_Click);
            // 
            // pauseImage
            // 
            this.pauseImage.Image = global::nesne_final.Properties.Resources.gtbhynujmköl;
            this.pauseImage.Location = new System.Drawing.Point(409, 434);
            this.pauseImage.Name = "pauseImage";
            this.pauseImage.Size = new System.Drawing.Size(70, 70);
            this.pauseImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pauseImage.TabIndex = 13;
            this.pauseImage.TabStop = false;
            this.pauseImage.Visible = false;
            this.pauseImage.Click += new System.EventHandler(this.pauseImage_Click);
            // 
            // lastScore
            // 
            this.lastScore.AutoSize = true;
            this.lastScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(162)))), ((int)(((byte)(155)))));
            this.lastScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lastScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lastScore.Location = new System.Drawing.Point(364, 516);
            this.lastScore.Name = "lastScore";
            this.lastScore.Size = new System.Drawing.Size(165, 33);
            this.lastScore.TabIndex = 12;
            this.lastScore.Text = "Last Score:";
            this.lastScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lastScore.Visible = false;
            // 
            // PlayImage
            // 
            this.PlayImage.Image = global::nesne_final.Properties.Resources.vtbynujmk;
            this.PlayImage.Location = new System.Drawing.Point(409, 434);
            this.PlayImage.Name = "PlayImage";
            this.PlayImage.Size = new System.Drawing.Size(70, 70);
            this.PlayImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PlayImage.TabIndex = 11;
            this.PlayImage.TabStop = false;
            this.PlayImage.Visible = false;
            this.PlayImage.Click += new System.EventHandler(this.PlayImage_Click);
            // 
            // player
            // 
            this.player.Image = global::nesne_final.Properties.Resources.asdaadsa;
            this.player.Location = new System.Drawing.Point(391, 785);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(110, 104);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 2;
            this.player.TabStop = false;
            // 
            // bullet
            // 
            this.bullet.Image = global::nesne_final.Properties.Resources.bullet1;
            this.bullet.Location = new System.Drawing.Point(516, 351);
            this.bullet.Name = "bullet";
            this.bullet.Size = new System.Drawing.Size(25, 50);
            this.bullet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.bullet.TabIndex = 3;
            this.bullet.TabStop = false;
            // 
            // enemyThree
            // 
            this.enemyThree.Image = global::nesne_final.Properties.Resources.asfasfasd1;
            this.enemyThree.Location = new System.Drawing.Point(709, 27);
            this.enemyThree.Name = "enemyThree";
            this.enemyThree.Size = new System.Drawing.Size(100, 103);
            this.enemyThree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemyThree.TabIndex = 4;
            this.enemyThree.TabStop = false;
            // 
            // enemyTwo
            // 
            this.enemyTwo.Image = global::nesne_final.Properties.Resources.asfasfasd1;
            this.enemyTwo.Location = new System.Drawing.Point(379, 27);
            this.enemyTwo.Name = "enemyTwo";
            this.enemyTwo.Size = new System.Drawing.Size(100, 103);
            this.enemyTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemyTwo.TabIndex = 5;
            this.enemyTwo.TabStop = false;
            // 
            // goldMadal
            // 
            this.goldMadal.BackColor = System.Drawing.Color.Transparent;
            this.goldMadal.Image = global::nesne_final.Properties.Resources.gold_madal_1;
            this.goldMadal.Location = new System.Drawing.Point(409, 331);
            this.goldMadal.Name = "goldMadal";
            this.goldMadal.Size = new System.Drawing.Size(70, 70);
            this.goldMadal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.goldMadal.TabIndex = 22;
            this.goldMadal.TabStop = false;
            this.goldMadal.Visible = false;
            // 
            // bronzMadal
            // 
            this.bronzMadal.BackColor = System.Drawing.Color.Transparent;
            this.bronzMadal.Image = global::nesne_final.Properties.Resources.bronz_madal_1;
            this.bronzMadal.Location = new System.Drawing.Point(409, 331);
            this.bronzMadal.Name = "bronzMadal";
            this.bronzMadal.Size = new System.Drawing.Size(70, 70);
            this.bronzMadal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.bronzMadal.TabIndex = 21;
            this.bronzMadal.TabStop = false;
            this.bronzMadal.Visible = false;
            // 
            // silverMadal
            // 
            this.silverMadal.BackColor = System.Drawing.Color.Transparent;
            this.silverMadal.Image = global::nesne_final.Properties.Resources.silver_madal_1;
            this.silverMadal.Location = new System.Drawing.Point(409, 331);
            this.silverMadal.Name = "silverMadal";
            this.silverMadal.Size = new System.Drawing.Size(70, 70);
            this.silverMadal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.silverMadal.TabIndex = 20;
            this.silverMadal.TabStop = false;
            this.silverMadal.Visible = false;
            // 
            // FighetJet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(892, 921);
            this.Controls.Add(this.goldMadal);
            this.Controls.Add(this.bronzMadal);
            this.Controls.Add(this.silverMadal);
            this.Controls.Add(this.enemyOne);
            this.Controls.Add(this.exitImage);
            this.Controls.Add(this.pauseImage);
            this.Controls.Add(this.lastScore);
            this.Controls.Add(this.PlayImage);
            this.Controls.Add(this.player);
            this.Controls.Add(this.bullet);
            this.Controls.Add(this.enemyThree);
            this.Controls.Add(this.enemyTwo);
            this.Controls.Add(this.txtScore);
            this.Name = "FighetJet";
            this.Text = "FighetJet";
            this.Load += new System.EventHandler(this.FighetJet_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.enemyOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pauseImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyThree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goldMadal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bronzMadal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.silverMadal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox bullet;
        private System.Windows.Forms.PictureBox enemyThree;
        private System.Windows.Forms.PictureBox enemyTwo;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox pauseImage;
        private System.Windows.Forms.Label lastScore;
        private System.Windows.Forms.PictureBox PlayImage;
        private System.Windows.Forms.PictureBox exitImage;
        private System.Windows.Forms.PictureBox enemyOne;
        private System.Windows.Forms.PictureBox goldMadal;
        private System.Windows.Forms.PictureBox bronzMadal;
        private System.Windows.Forms.PictureBox silverMadal;
    }
}