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
            this.tmrSplashes = new System.Windows.Forms.Timer(this.components);
            this.picBoxCannon = new System.Windows.Forms.PictureBox();
            this.progressBarY = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBarX = new System.Windows.Forms.ProgressBar();
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
            this.lblScore.Location = new System.Drawing.Point(12, 19);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(51, 55);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "0";
            // 
            // tmrSplashes
            // 
            this.tmrSplashes.Enabled = true;
            this.tmrSplashes.Interval = 1000;
            this.tmrSplashes.Tick += new System.EventHandler(this.tmrSplashes_Tick);
            // 
            // picBoxCannon
            // 
            this.picBoxCannon.Image = global::Corona_Game.Properties.Resources.cannonSi;
            this.picBoxCannon.Location = new System.Drawing.Point(12, 241);
            this.picBoxCannon.Name = "picBoxCannon";
            this.picBoxCannon.Size = new System.Drawing.Size(200, 200);
            this.picBoxCannon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxCannon.TabIndex = 0;
            this.picBoxCannon.TabStop = false;
            // 
            // progressBarY
            // 
            this.progressBarY.Location = new System.Drawing.Point(128, 43);
            this.progressBarY.Maximum = 180;
            this.progressBarY.Name = "progressBarY";
            this.progressBarY.Size = new System.Drawing.Size(247, 43);
            this.progressBarY.TabIndex = 2;
            this.progressBarY.Value = 90;
            this.progressBarY.Click += new System.EventHandler(this.progressBarX_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(189, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Height";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(425, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 39);
            this.label2.TabIndex = 5;
            this.label2.Text = "Distance";
            // 
            // progressBarX
            // 
            this.progressBarX.Location = new System.Drawing.Point(381, 43);
            this.progressBarX.Name = "progressBarX";
            this.progressBarX.Size = new System.Drawing.Size(247, 43);
            this.progressBarX.TabIndex = 4;
            this.progressBarX.Value = 30;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 739);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBarX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBarY);
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
        private System.Windows.Forms.ProgressBar progressBarY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBarX;
    }
}

