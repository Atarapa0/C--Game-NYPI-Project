namespace nesne_final
{
    partial class Eggs_Game
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
            this.txtMiss = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.lastScore = new System.Windows.Forms.Label();
            this.exitImage = new System.Windows.Forms.PictureBox();
            this.pauseImage = new System.Windows.Forms.PictureBox();
            this.PlayImage = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.goldMadal = new System.Windows.Forms.PictureBox();
            this.bronzMadal = new System.Windows.Forms.PictureBox();
            this.silverMadal = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.exitImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pauseImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goldMadal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bronzMadal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.silverMadal)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMiss
            // 
            this.txtMiss.AutoSize = true;
            this.txtMiss.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMiss.Location = new System.Drawing.Point(507, 12);
            this.txtMiss.Name = "txtMiss";
            this.txtMiss.Size = new System.Drawing.Size(99, 24);
            this.txtMiss.TabIndex = 6;
            this.txtMiss.Text = "Missed: 0";
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.Location = new System.Drawing.Point(16, 12);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(91, 24);
            this.txtScore.TabIndex = 7;
            this.txtScore.Text = "Saved: 0";
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.MainGameTimerEvent);
            // 
            // lastScore
            // 
            this.lastScore.AutoSize = true;
            this.lastScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(129)))), ((int)(((byte)(47)))));
            this.lastScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lastScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lastScore.Location = new System.Drawing.Point(231, 427);
            this.lastScore.Name = "lastScore";
            this.lastScore.Size = new System.Drawing.Size(165, 33);
            this.lastScore.TabIndex = 9;
            this.lastScore.Text = "Last Score:";
            this.lastScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lastScore.Visible = false;
            // 
            // exitImage
            // 
            this.exitImage.Image = global::nesne_final.Properties.Resources.adasfve;
            this.exitImage.Location = new System.Drawing.Point(536, 39);
            this.exitImage.Name = "exitImage";
            this.exitImage.Size = new System.Drawing.Size(70, 70);
            this.exitImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.exitImage.TabIndex = 11;
            this.exitImage.TabStop = false;
            this.exitImage.Visible = false;
            this.exitImage.Click += new System.EventHandler(this.exitImage_Click);
            // 
            // pauseImage
            // 
            this.pauseImage.Image = global::nesne_final.Properties.Resources.vtybn;
            this.pauseImage.Location = new System.Drawing.Point(276, 345);
            this.pauseImage.Name = "pauseImage";
            this.pauseImage.Size = new System.Drawing.Size(70, 70);
            this.pauseImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pauseImage.TabIndex = 10;
            this.pauseImage.TabStop = false;
            this.pauseImage.Visible = false;
            this.pauseImage.Click += new System.EventHandler(this.pauseImage_Click);
            // 
            // PlayImage
            // 
            this.PlayImage.Image = global::nesne_final.Properties.Resources.adssa;
            this.PlayImage.Location = new System.Drawing.Point(276, 345);
            this.PlayImage.Name = "PlayImage";
            this.PlayImage.Size = new System.Drawing.Size(70, 70);
            this.PlayImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PlayImage.TabIndex = 8;
            this.PlayImage.TabStop = false;
            this.PlayImage.Visible = false;
            this.PlayImage.Click += new System.EventHandler(this.PlayImage_Click);
            // 
            // player
            // 
            this.player.Image = global::nesne_final.Properties.Resources.chicken_normal;
            this.player.Location = new System.Drawing.Point(261, 690);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(85, 80);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 2;
            this.player.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::nesne_final.Properties.Resources.egg;
            this.pictureBox3.Location = new System.Drawing.Point(469, 125);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "eggs";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::nesne_final.Properties.Resources.egg;
            this.pictureBox2.Location = new System.Drawing.Point(261, 125);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "eggs";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::nesne_final.Properties.Resources.egg;
            this.pictureBox1.Location = new System.Drawing.Point(75, 125);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "eggs";
            // 
            // goldMadal
            // 
            this.goldMadal.BackColor = System.Drawing.Color.Transparent;
            this.goldMadal.Image = global::nesne_final.Properties.Resources.gold_madal_1;
            this.goldMadal.Location = new System.Drawing.Point(276, 256);
            this.goldMadal.Name = "goldMadal";
            this.goldMadal.Size = new System.Drawing.Size(70, 70);
            this.goldMadal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.goldMadal.TabIndex = 25;
            this.goldMadal.TabStop = false;
            this.goldMadal.Visible = false;
            // 
            // bronzMadal
            // 
            this.bronzMadal.BackColor = System.Drawing.Color.Transparent;
            this.bronzMadal.Image = global::nesne_final.Properties.Resources.bronz_madal_1;
            this.bronzMadal.Location = new System.Drawing.Point(276, 256);
            this.bronzMadal.Name = "bronzMadal";
            this.bronzMadal.Size = new System.Drawing.Size(70, 70);
            this.bronzMadal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.bronzMadal.TabIndex = 24;
            this.bronzMadal.TabStop = false;
            this.bronzMadal.Visible = false;
            // 
            // silverMadal
            // 
            this.silverMadal.BackColor = System.Drawing.Color.Transparent;
            this.silverMadal.Image = global::nesne_final.Properties.Resources.silver_madal_1;
            this.silverMadal.Location = new System.Drawing.Point(276, 256);
            this.silverMadal.Name = "silverMadal";
            this.silverMadal.Size = new System.Drawing.Size(70, 70);
            this.silverMadal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.silverMadal.TabIndex = 23;
            this.silverMadal.TabStop = false;
            this.silverMadal.Visible = false;
            // 
            // Eggs_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(143)))), ((int)(((byte)(14)))));
            this.ClientSize = new System.Drawing.Size(632, 782);
            this.Controls.Add(this.goldMadal);
            this.Controls.Add(this.bronzMadal);
            this.Controls.Add(this.silverMadal);
            this.Controls.Add(this.exitImage);
            this.Controls.Add(this.pauseImage);
            this.Controls.Add(this.lastScore);
            this.Controls.Add(this.PlayImage);
            this.Controls.Add(this.txtMiss);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.player);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Eggs_Game";
            this.Text = "Eggs_Game";
            this.Load += new System.EventHandler(this.Eggs_Game_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.exitImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pauseImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goldMadal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bronzMadal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.silverMadal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtMiss;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.PictureBox PlayImage;
        private System.Windows.Forms.Label lastScore;
        private System.Windows.Forms.PictureBox pauseImage;
        private System.Windows.Forms.PictureBox exitImage;
        private System.Windows.Forms.PictureBox goldMadal;
        private System.Windows.Forms.PictureBox bronzMadal;
        private System.Windows.Forms.PictureBox silverMadal;
    }
}