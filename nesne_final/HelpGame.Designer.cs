namespace nesne_final
{
    partial class HelpGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpGame));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.flappy = new System.Windows.Forms.PictureBox();
            this.jet = new System.Windows.Forms.PictureBox();
            this.egg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.flappy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.egg)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(297, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eggs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(288, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(413, 80);
            this.label2.TabIndex = 1;
            this.label2.Text = resources.GetString("label2.Text");
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(275, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fighter Jet ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label4.Location = new System.Drawing.Point(288, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(426, 96);
            this.label4.TabIndex = 3;
            this.label4.Text = resources.GetString("label4.Text");
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(275, 494);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Flappy Bird";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label6.Location = new System.Drawing.Point(288, 572);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(415, 112);
            this.label6.TabIndex = 5;
            this.label6.Text = resources.GetString("label6.Text");
            // 
            // flappy
            // 
            this.flappy.Image = global::nesne_final.Properties.Resources.flappyhover1;
            this.flappy.Location = new System.Drawing.Point(22, 561);
            this.flappy.Name = "flappy";
            this.flappy.Size = new System.Drawing.Size(260, 133);
            this.flappy.TabIndex = 14;
            this.flappy.TabStop = false;
            // 
            // jet
            // 
            this.jet.Image = global::nesne_final.Properties.Resources.jethover;
            this.jet.Location = new System.Drawing.Point(22, 309);
            this.jet.Name = "jet";
            this.jet.Size = new System.Drawing.Size(260, 133);
            this.jet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.jet.TabIndex = 15;
            this.jet.TabStop = false;
            // 
            // egg
            // 
            this.egg.Image = global::nesne_final.Properties.Resources.egghover;
            this.egg.Location = new System.Drawing.Point(22, 86);
            this.egg.Name = "egg";
            this.egg.Size = new System.Drawing.Size(260, 133);
            this.egg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.egg.TabIndex = 16;
            this.egg.TabStop = false;
            // 
            // HelpGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(710, 749);
            this.Controls.Add(this.egg);
            this.Controls.Add(this.jet);
            this.Controls.Add(this.flappy);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "HelpGame";
            this.Text = "HelpGame";
            ((System.ComponentModel.ISupportInitialize)(this.flappy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.egg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox flappy;
        private System.Windows.Forms.PictureBox jet;
        private System.Windows.Forms.PictureBox egg;
    }
}