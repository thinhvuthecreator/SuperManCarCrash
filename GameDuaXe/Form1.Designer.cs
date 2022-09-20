namespace GameDuaXe
{
    partial class fGameRunning
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fGameRunning));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnYES = new System.Windows.Forms.Button();
            this.btnNO = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbScore = new System.Windows.Forms.Label();
            this.lbScoreCount = new System.Windows.Forms.Label();
            this.pbGameOver = new System.Windows.Forms.PictureBox();
            this.enermie3 = new System.Windows.Forms.PictureBox();
            this.enermie2 = new System.Windows.Forms.PictureBox();
            this.enermie = new System.Windows.Forms.PictureBox();
            this.myCar = new System.Windows.Forms.PictureBox();
            this.midLine4 = new System.Windows.Forms.PictureBox();
            this.midLine3 = new System.Windows.Forms.PictureBox();
            this.midLine2 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.midLine1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbGameOver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enermie3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enermie2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enermie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.midLine4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.midLine3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.midLine2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.midLine1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnYES
            // 
            this.btnYES.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnYES.Enabled = false;
            this.btnYES.Font = new System.Drawing.Font("OCR A Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYES.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnYES.Location = new System.Drawing.Point(137, 337);
            this.btnYES.Name = "btnYES";
            this.btnYES.Size = new System.Drawing.Size(68, 30);
            this.btnYES.TabIndex = 14;
            this.btnYES.Text = "YES";
            this.btnYES.UseVisualStyleBackColor = false;
            this.btnYES.Visible = false;
            this.btnYES.Click += new System.EventHandler(this.btnYES_Click);
            // 
            // btnNO
            // 
            this.btnNO.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNO.Enabled = false;
            this.btnNO.Font = new System.Drawing.Font("OCR A Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNO.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNO.Location = new System.Drawing.Point(241, 337);
            this.btnNO.Name = "btnNO";
            this.btnNO.Size = new System.Drawing.Size(68, 30);
            this.btnNO.TabIndex = 15;
            this.btnNO.Text = "NO";
            this.btnNO.UseVisualStyleBackColor = false;
            this.btnNO.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("OCR A Std", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(146, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "TRY AGAIN ?";
            this.label1.Visible = false;
            // 
            // lbScore
            // 
            this.lbScore.AutoSize = true;
            this.lbScore.BackColor = System.Drawing.Color.Transparent;
            this.lbScore.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScore.ForeColor = System.Drawing.Color.Gold;
            this.lbScore.Location = new System.Drawing.Point(351, 36);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(67, 19);
            this.lbScore.TabIndex = 17;
            this.lbScore.Text = "SCORE :";
            // 
            // lbScoreCount
            // 
            this.lbScoreCount.AutoSize = true;
            this.lbScoreCount.BackColor = System.Drawing.Color.Transparent;
            this.lbScoreCount.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScoreCount.ForeColor = System.Drawing.Color.Gold;
            this.lbScoreCount.Location = new System.Drawing.Point(417, 36);
            this.lbScoreCount.Name = "lbScoreCount";
            this.lbScoreCount.Size = new System.Drawing.Size(18, 19);
            this.lbScoreCount.TabIndex = 18;
            this.lbScoreCount.Text = "0";
            // 
            // pbGameOver
            // 
            this.pbGameOver.Image = global::GameDuaXe.Properties.Resources._9bd3309cb248820725e53f8ff8027431;
            this.pbGameOver.Location = new System.Drawing.Point(-6, -30);
            this.pbGameOver.Name = "pbGameOver";
            this.pbGameOver.Size = new System.Drawing.Size(473, 623);
            this.pbGameOver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGameOver.TabIndex = 13;
            this.pbGameOver.TabStop = false;
            this.pbGameOver.Visible = false;
            // 
            // enermie3
            // 
            this.enermie3.Image = global::GameDuaXe.Properties.Resources.enermie;
            this.enermie3.Location = new System.Drawing.Point(355, -49);
            this.enermie3.Name = "enermie3";
            this.enermie3.Size = new System.Drawing.Size(44, 72);
            this.enermie3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enermie3.TabIndex = 12;
            this.enermie3.TabStop = false;
            // 
            // enermie2
            // 
            this.enermie2.Image = global::GameDuaXe.Properties.Resources.enermie2;
            this.enermie2.Location = new System.Drawing.Point(27, -49);
            this.enermie2.Name = "enermie2";
            this.enermie2.Size = new System.Drawing.Size(58, 72);
            this.enermie2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enermie2.TabIndex = 11;
            this.enermie2.TabStop = false;
            // 
            // enermie
            // 
            this.enermie.Image = global::GameDuaXe.Properties.Resources.enermie1;
            this.enermie.Location = new System.Drawing.Point(206, -49);
            this.enermie.Name = "enermie";
            this.enermie.Size = new System.Drawing.Size(61, 72);
            this.enermie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enermie.TabIndex = 10;
            this.enermie.TabStop = false;
            // 
            // myCar
            // 
            this.myCar.Image = global::GameDuaXe.Properties.Resources.superman;
            this.myCar.Location = new System.Drawing.Point(31, 436);
            this.myCar.Name = "myCar";
            this.myCar.Size = new System.Drawing.Size(31, 71);
            this.myCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.myCar.TabIndex = 9;
            this.myCar.TabStop = false;
            // 
            // midLine4
            // 
            this.midLine4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.midLine4.Location = new System.Drawing.Point(225, 436);
            this.midLine4.Name = "midLine4";
            this.midLine4.Size = new System.Drawing.Size(10, 89);
            this.midLine4.TabIndex = 8;
            this.midLine4.TabStop = false;
            // 
            // midLine3
            // 
            this.midLine3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.midLine3.Location = new System.Drawing.Point(225, 286);
            this.midLine3.Name = "midLine3";
            this.midLine3.Size = new System.Drawing.Size(10, 105);
            this.midLine3.TabIndex = 7;
            this.midLine3.TabStop = false;
            // 
            // midLine2
            // 
            this.midLine2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.midLine2.Location = new System.Drawing.Point(225, 140);
            this.midLine2.Name = "midLine2";
            this.midLine2.Size = new System.Drawing.Size(10, 105);
            this.midLine2.TabIndex = 6;
            this.midLine2.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox6.Location = new System.Drawing.Point(453, -4);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(14, 588);
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox5.Location = new System.Drawing.Point(-6, -4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(10, 588);
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // midLine1
            // 
            this.midLine1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.midLine1.Location = new System.Drawing.Point(225, -4);
            this.midLine1.Name = "midLine1";
            this.midLine1.Size = new System.Drawing.Size(10, 105);
            this.midLine1.TabIndex = 0;
            this.midLine1.TabStop = false;
            // 
            // fGameRunning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(459, 567);
            this.Controls.Add(this.lbScoreCount);
            this.Controls.Add(this.lbScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNO);
            this.Controls.Add(this.btnYES);
            this.Controls.Add(this.pbGameOver);
            this.Controls.Add(this.enermie3);
            this.Controls.Add(this.enermie2);
            this.Controls.Add(this.enermie);
            this.Controls.Add(this.myCar);
            this.Controls.Add(this.midLine4);
            this.Controls.Add(this.midLine3);
            this.Controls.Add(this.midLine2);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.midLine1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fGameRunning";
            this.Text = "Superman Car Crash";
            this.Load += new System.EventHandler(this.fGameRunning_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fGameRunning_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbGameOver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enermie3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enermie2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enermie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.midLine4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.midLine3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.midLine2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.midLine1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox midLine1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox midLine2;
        private System.Windows.Forms.PictureBox midLine3;
        private System.Windows.Forms.PictureBox midLine4;
        private System.Windows.Forms.PictureBox myCar;
        private System.Windows.Forms.PictureBox enermie;
        private System.Windows.Forms.PictureBox enermie2;
        private System.Windows.Forms.PictureBox pbGameOver;
        private System.Windows.Forms.Button btnYES;
        private System.Windows.Forms.Button btnNO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.Label lbScoreCount;
        private System.Windows.Forms.PictureBox enermie3;
    }
}

