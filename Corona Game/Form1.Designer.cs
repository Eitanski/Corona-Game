namespace Corona_Game
{
    partial class Form1
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
            this.tmrCorona = new System.Windows.Forms.Timer(this.components);
            this.tmrFire = new System.Windows.Forms.Timer(this.components);
            this.lblScore = new System.Windows.Forms.Label();
            this.picBoxCannon = new System.Windows.Forms.PictureBox();
            this.tmrSplashes = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCannon)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrCorona
            // 
            this.tmrCorona.Enabled = true;
            this.tmrCorona.Interval = 1000;
            this.tmrCorona.Tick += new System.EventHandler(this.tmrCorona_Tick);
            // 
            // tmrFire
            // 
            this.tmrFire.Enabled = true;
            this.tmrFire.Interval = 20;
            this.tmrFire.Tick += new System.EventHandler(this.tmrFire_Tick);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblScore.Location = new System.Drawing.Point(26, 19);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(51, 55);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "0";
            // 
            // picBoxCannon
            // 
            this.picBoxCannon.Image = global::Corona_Game.Properties.Resources.cannon;
            this.picBoxCannon.Location = new System.Drawing.Point(12, 288);
            this.picBoxCannon.Name = "picBoxCannon";
            this.picBoxCannon.Size = new System.Drawing.Size(189, 90);
            this.picBoxCannon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxCannon.TabIndex = 0;
            this.picBoxCannon.TabStop = false;
            // 
            // tmrSplashes
            // 
            this.tmrSplashes.Enabled = true;
            this.tmrSplashes.Interval = 1000;
            this.tmrSplashes.Tick += new System.EventHandler(this.tmrSplashes_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 739);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.picBoxCannon);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCannon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxCannon;
        private System.Windows.Forms.Timer tmrCorona;
        private System.Windows.Forms.Timer tmrFire;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Timer tmrSplashes;
    }
}

