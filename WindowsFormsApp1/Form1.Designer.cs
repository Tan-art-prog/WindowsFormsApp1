namespace WindowsFormsApp1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblMissed = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.goalKeeper = new System.Windows.Forms.PictureBox();
            this.left = new System.Windows.Forms.PictureBox();
            this.right = new System.Windows.Forms.PictureBox();
            this.topcenter = new System.Windows.Forms.PictureBox();
            this.topleft = new System.Windows.Forms.PictureBox();
            this.topright = new System.Windows.Forms.PictureBox();
            this.Keepertimer = new System.Windows.Forms.Timer(this.components);
            this.Balltimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goalKeeper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.right)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topcenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topleft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topright)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.background;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(799, 443);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(52, 25);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(38, 13);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "Score:";
            this.lblScore.Click += new System.EventHandler(this.SetGoalTargetEvent);
            // 
            // lblMissed
            // 
            this.lblMissed.AutoSize = true;
            this.lblMissed.Location = new System.Drawing.Point(690, 25);
            this.lblMissed.Name = "lblMissed";
            this.lblMissed.Size = new System.Drawing.Size(43, 13);
            this.lblMissed.TabIndex = 2;
            this.lblMissed.Text = "Missed:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.football;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(361, 325);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(62, 50);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // goalKeeper
            // 
            this.goalKeeper.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.stand_small;
            this.goalKeeper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.goalKeeper.Location = new System.Drawing.Point(361, 130);
            this.goalKeeper.Name = "goalKeeper";
            this.goalKeeper.Size = new System.Drawing.Size(62, 75);
            this.goalKeeper.TabIndex = 4;
            this.goalKeeper.TabStop = false;
            // 
            // left
            // 
            this.left.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.target;
            this.left.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.left.Location = new System.Drawing.Point(179, 142);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(57, 42);
            this.left.TabIndex = 5;
            this.left.TabStop = false;
            this.left.Click += new System.EventHandler(this.SetGoalTargetEvent);
            // 
            // right
            // 
            this.right.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.target;
            this.right.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.right.Location = new System.Drawing.Point(582, 142);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(53, 42);
            this.right.TabIndex = 6;
            this.right.TabStop = false;
            this.right.Click += new System.EventHandler(this.SetGoalTargetEvent);
            // 
            // topcenter
            // 
            this.topcenter.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.target;
            this.topcenter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.topcenter.Location = new System.Drawing.Point(361, 57);
            this.topcenter.Name = "topcenter";
            this.topcenter.Size = new System.Drawing.Size(62, 50);
            this.topcenter.TabIndex = 7;
            this.topcenter.TabStop = false;
            this.topcenter.Click += new System.EventHandler(this.SetGoalTargetEvent);
            // 
            // topleft
            // 
            this.topleft.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.target;
            this.topleft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.topleft.Location = new System.Drawing.Point(179, 57);
            this.topleft.Name = "topleft";
            this.topleft.Size = new System.Drawing.Size(57, 50);
            this.topleft.TabIndex = 8;
            this.topleft.TabStop = false;
            this.topleft.Click += new System.EventHandler(this.SetGoalTargetEvent);
            // 
            // topright
            // 
            this.topright.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.target;
            this.topright.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.topright.Location = new System.Drawing.Point(582, 57);
            this.topright.Name = "topright";
            this.topright.Size = new System.Drawing.Size(53, 50);
            this.topright.TabIndex = 9;
            this.topright.TabStop = false;
            this.topright.Click += new System.EventHandler(this.SetGoalTargetEvent);
            // 
            // Keepertimer
            // 
            this.Keepertimer.Interval = 20;
            this.Keepertimer.Tick += new System.EventHandler(this.KeeperTimerEvent);
            // 
            // Balltimer
            // 
            this.Balltimer.Interval = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.topright);
            this.Controls.Add(this.topleft);
            this.Controls.Add(this.topcenter);
            this.Controls.Add(this.right);
            this.Controls.Add(this.left);
            this.Controls.Add(this.goalKeeper);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblMissed);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goalKeeper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.right)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topcenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topleft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topright)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblMissed;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox goalKeeper;
        private System.Windows.Forms.PictureBox left;
        private System.Windows.Forms.PictureBox right;
        private System.Windows.Forms.PictureBox topcenter;
        private System.Windows.Forms.PictureBox topleft;
        private System.Windows.Forms.PictureBox topright;
        private System.Windows.Forms.Timer Keepertimer;
        private System.Windows.Forms.Timer Balltimer;
    }
}

