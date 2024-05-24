namespace nesne_final
{
    partial class Frm_Menu
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.quitbutton = new System.Windows.Forms.Button();
            this.Help_Window = new System.Windows.Forms.Button();
            this.FlappyBird_Game = new System.Windows.Forms.Button();
            this.Fighet_Game = new System.Windows.Forms.Button();
            this.Eggs_Game = new System.Windows.Forms.Button();
            this.flappy = new System.Windows.Forms.PictureBox();
            this.jet = new System.Windows.Forms.PictureBox();
            this.egg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.flappy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.egg)).BeginInit();
            this.SuspendLayout();
            // 
            // quitbutton
            // 
            this.quitbutton.Location = new System.Drawing.Point(228, 289);
            this.quitbutton.Name = "quitbutton";
            this.quitbutton.Size = new System.Drawing.Size(120, 54);
            this.quitbutton.TabIndex = 10;
            this.quitbutton.Text = "Quit";
            this.quitbutton.UseVisualStyleBackColor = true;
            this.quitbutton.Click += new System.EventHandler(this.quitbutton_Click);
            // 
            // Help_Window
            // 
            this.Help_Window.Location = new System.Drawing.Point(81, 289);
            this.Help_Window.Name = "Help_Window";
            this.Help_Window.Size = new System.Drawing.Size(120, 54);
            this.Help_Window.TabIndex = 9;
            this.Help_Window.Text = "Help";
            this.Help_Window.UseVisualStyleBackColor = true;
            this.Help_Window.Click += new System.EventHandler(this.Help_Window_Click);
            // 
            // FlappyBird_Game
            // 
            this.FlappyBird_Game.Location = new System.Drawing.Point(296, 216);
            this.FlappyBird_Game.Name = "FlappyBird_Game";
            this.FlappyBird_Game.Size = new System.Drawing.Size(120, 54);
            this.FlappyBird_Game.TabIndex = 8;
            this.FlappyBird_Game.Text = "Flappy Bird";
            this.FlappyBird_Game.UseVisualStyleBackColor = true;
            this.FlappyBird_Game.Click += new System.EventHandler(this.FlappyBird_Game_Click);
            this.FlappyBird_Game.MouseHover += new System.EventHandler(this.flappyhover);
            // 
            // Fighet_Game
            // 
            this.Fighet_Game.Location = new System.Drawing.Point(155, 216);
            this.Fighet_Game.Name = "Fighet_Game";
            this.Fighet_Game.Size = new System.Drawing.Size(120, 54);
            this.Fighet_Game.TabIndex = 7;
            this.Fighet_Game.Text = "Fighet Jet";
            this.Fighet_Game.UseVisualStyleBackColor = true;
            this.Fighet_Game.Click += new System.EventHandler(this.Fighet_Game_Click);
            this.Fighet_Game.MouseHover += new System.EventHandler(this.jethover);
            // 
            // Eggs_Game
            // 
            this.Eggs_Game.Location = new System.Drawing.Point(12, 216);
            this.Eggs_Game.Name = "Eggs_Game";
            this.Eggs_Game.Size = new System.Drawing.Size(120, 54);
            this.Eggs_Game.TabIndex = 6;
            this.Eggs_Game.Text = "Eggs Game";
            this.Eggs_Game.UseVisualStyleBackColor = true;
            this.Eggs_Game.Click += new System.EventHandler(this.Eggs_Game_Click);
            this.Eggs_Game.MouseHover += new System.EventHandler(this.eggshover);
            // 
            // flappy
            // 
            this.flappy.Image = global::nesne_final.Properties.Resources.flappyhover1;
            this.flappy.Location = new System.Drawing.Point(12, 12);
            this.flappy.Name = "flappy";
            this.flappy.Size = new System.Drawing.Size(404, 186);
            this.flappy.TabIndex = 13;
            this.flappy.TabStop = false;
            this.flappy.Visible = false;
            // 
            // jet
            // 
            this.jet.Image = global::nesne_final.Properties.Resources.jethover;
            this.jet.Location = new System.Drawing.Point(12, 12);
            this.jet.Name = "jet";
            this.jet.Size = new System.Drawing.Size(404, 186);
            this.jet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.jet.TabIndex = 12;
            this.jet.TabStop = false;
            this.jet.Visible = false;
            // 
            // egg
            // 
            this.egg.Image = global::nesne_final.Properties.Resources.egghover;
            this.egg.Location = new System.Drawing.Point(12, 12);
            this.egg.Name = "egg";
            this.egg.Size = new System.Drawing.Size(404, 186);
            this.egg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.egg.TabIndex = 11;
            this.egg.TabStop = false;
            // 
            // Frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 363);
            this.Controls.Add(this.flappy);
            this.Controls.Add(this.jet);
            this.Controls.Add(this.egg);
            this.Controls.Add(this.quitbutton);
            this.Controls.Add(this.Help_Window);
            this.Controls.Add(this.FlappyBird_Game);
            this.Controls.Add(this.Fighet_Game);
            this.Controls.Add(this.Eggs_Game);
            this.Name = "Frm_Menu";
            this.Text = "Game Windows";
            ((System.ComponentModel.ISupportInitialize)(this.flappy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.egg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button quitbutton;
        private System.Windows.Forms.Button Help_Window;
        private System.Windows.Forms.Button FlappyBird_Game;
        private System.Windows.Forms.Button Fighet_Game;
        private System.Windows.Forms.Button Eggs_Game;
        private System.Windows.Forms.PictureBox egg;
        private System.Windows.Forms.PictureBox jet;
        private System.Windows.Forms.PictureBox flappy;
    }
}

