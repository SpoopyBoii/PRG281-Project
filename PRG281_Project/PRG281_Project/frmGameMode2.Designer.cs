
namespace PRG281_Project
{
    partial class frmGameMode2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGameMode2));
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.lblScoreP2 = new System.Windows.Forms.Label();
            this.tbxScoreP2 = new System.Windows.Forms.TextBox();
            this.lblScoreP1 = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.tbxScoreP1 = new System.Windows.Forms.TextBox();
            this.picP2 = new System.Windows.Forms.PictureBox();
            this.picP1 = new System.Windows.Forms.PictureBox();
            this.pnlTime = new System.Windows.Forms.Panel();
            this.lblTimer = new System.Windows.Forms.Label();
            this.pgbCountdown = new System.Windows.Forms.ProgressBar();
            this.lblGameMode = new System.Windows.Forms.Label();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnExitGame = new System.Windows.Forms.Button();
            this.pnlWinner = new System.Windows.Forms.Panel();
            this.pnlWinRight = new System.Windows.Forms.Panel();
            this.pnlWinLeft = new System.Windows.Forms.Panel();
            this.lblCongrats = new System.Windows.Forms.Label();
            this.lblWinnerPlayer = new System.Windows.Forms.Label();
            this.picWinner = new System.Windows.Forms.PictureBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblSong = new System.Windows.Forms.Label();
            this.lblGuess = new System.Windows.Forms.Label();
            this.cbChoice = new System.Windows.Forms.ComboBox();
            this.GameMode2Timer = new System.Windows.Forms.Timer(this.components);
            this.lblCorrect = new System.Windows.Forms.Label();
            this.lblCheckTurn = new System.Windows.Forms.Label();
            this.pnlTopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picP2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picP1)).BeginInit();
            this.pnlTime.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.pnlWinner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWinner)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(136)))), ((int)(((byte)(252)))));
            this.pnlTopBar.Controls.Add(this.lblScoreP2);
            this.pnlTopBar.Controls.Add(this.tbxScoreP2);
            this.pnlTopBar.Controls.Add(this.lblScoreP1);
            this.pnlTopBar.Controls.Add(this.picLogo);
            this.pnlTopBar.Controls.Add(this.tbxScoreP1);
            this.pnlTopBar.Controls.Add(this.picP2);
            this.pnlTopBar.Controls.Add(this.picP1);
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(1280, 120);
            this.pnlTopBar.TabIndex = 2;
            // 
            // lblScoreP2
            // 
            this.lblScoreP2.AutoSize = true;
            this.lblScoreP2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreP2.ForeColor = System.Drawing.SystemColors.Control;
            this.lblScoreP2.Location = new System.Drawing.Point(1113, 42);
            this.lblScoreP2.Name = "lblScoreP2";
            this.lblScoreP2.Size = new System.Drawing.Size(67, 23);
            this.lblScoreP2.TabIndex = 7;
            this.lblScoreP2.Text = "Score:";
            // 
            // tbxScoreP2
            // 
            this.tbxScoreP2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(136)))), ((int)(((byte)(252)))));
            this.tbxScoreP2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxScoreP2.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbxScoreP2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxScoreP2.ForeColor = System.Drawing.SystemColors.Control;
            this.tbxScoreP2.Location = new System.Drawing.Point(1074, 68);
            this.tbxScoreP2.Name = "tbxScoreP2";
            this.tbxScoreP2.ReadOnly = true;
            this.tbxScoreP2.Size = new System.Drawing.Size(100, 24);
            this.tbxScoreP2.TabIndex = 6;
            this.tbxScoreP2.Text = "0";
            this.tbxScoreP2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblScoreP1
            // 
            this.lblScoreP1.AutoSize = true;
            this.lblScoreP1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreP1.ForeColor = System.Drawing.SystemColors.Control;
            this.lblScoreP1.Location = new System.Drawing.Point(106, 42);
            this.lblScoreP1.Name = "lblScoreP1";
            this.lblScoreP1.Size = new System.Drawing.Size(67, 23);
            this.lblScoreP1.TabIndex = 5;
            this.lblScoreP1.Text = "Score:";
            // 
            // picLogo
            // 
            this.picLogo.Image = global::PRG281_Project.Properties.Resources.MuzikMash_Bar_Game1;
            this.picLogo.Location = new System.Drawing.Point(390, 0);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(500, 120);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            // 
            // tbxScoreP1
            // 
            this.tbxScoreP1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(136)))), ((int)(((byte)(252)))));
            this.tbxScoreP1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxScoreP1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbxScoreP1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxScoreP1.ForeColor = System.Drawing.SystemColors.Control;
            this.tbxScoreP1.Location = new System.Drawing.Point(110, 68);
            this.tbxScoreP1.Name = "tbxScoreP1";
            this.tbxScoreP1.ReadOnly = true;
            this.tbxScoreP1.Size = new System.Drawing.Size(100, 24);
            this.tbxScoreP1.TabIndex = 4;
            this.tbxScoreP1.Text = "0";
            // 
            // picP2
            // 
            this.picP2.Dock = System.Windows.Forms.DockStyle.Right;
            this.picP2.Image = global::PRG281_Project.Properties.Resources.P2Avatar;
            this.picP2.Location = new System.Drawing.Point(1180, 0);
            this.picP2.Name = "picP2";
            this.picP2.Size = new System.Drawing.Size(100, 120);
            this.picP2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picP2.TabIndex = 3;
            this.picP2.TabStop = false;
            // 
            // picP1
            // 
            this.picP1.Dock = System.Windows.Forms.DockStyle.Left;
            this.picP1.Image = global::PRG281_Project.Properties.Resources.P1Avatar;
            this.picP1.Location = new System.Drawing.Point(0, 0);
            this.picP1.Name = "picP1";
            this.picP1.Size = new System.Drawing.Size(100, 120);
            this.picP1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picP1.TabIndex = 2;
            this.picP1.TabStop = false;
            // 
            // pnlTime
            // 
            this.pnlTime.Controls.Add(this.lblTimer);
            this.pnlTime.Controls.Add(this.pgbCountdown);
            this.pnlTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTime.Location = new System.Drawing.Point(0, 120);
            this.pnlTime.Name = "pnlTime";
            this.pnlTime.Size = new System.Drawing.Size(1280, 36);
            this.pnlTime.TabIndex = 4;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(590, 3);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(110, 24);
            this.lblTimer.TabIndex = 3;
            this.lblTimer.Text = "10 Seconds";
            // 
            // pgbCountdown
            // 
            this.pgbCountdown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pgbCountdown.Location = new System.Drawing.Point(0, 0);
            this.pgbCountdown.Name = "pgbCountdown";
            this.pgbCountdown.Size = new System.Drawing.Size(1280, 36);
            this.pgbCountdown.TabIndex = 2;
            // 
            // lblGameMode
            // 
            this.lblGameMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblGameMode.AutoSize = true;
            this.lblGameMode.BackColor = System.Drawing.SystemColors.Control;
            this.lblGameMode.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(136)))), ((int)(((byte)(252)))));
            this.lblGameMode.Location = new System.Drawing.Point(12, 159);
            this.lblGameMode.Name = "lblGameMode";
            this.lblGameMode.Size = new System.Drawing.Size(298, 23);
            this.lblGameMode.TabIndex = 7;
            this.lblGameMode.Text = "Game Mode 2 : Guess the Artist";
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(136)))), ((int)(((byte)(252)))));
            this.pnlBottom.Controls.Add(this.btnExitGame);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 660);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1280, 60);
            this.pnlBottom.TabIndex = 21;
            // 
            // btnExitGame
            // 
            this.btnExitGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(86)))), ((int)(((byte)(252)))));
            this.btnExitGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExitGame.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnExitGame.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(136)))), ((int)(((byte)(252)))));
            this.btnExitGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitGame.ForeColor = System.Drawing.SystemColors.Control;
            this.btnExitGame.Location = new System.Drawing.Point(0, 0);
            this.btnExitGame.Name = "btnExitGame";
            this.btnExitGame.Size = new System.Drawing.Size(210, 60);
            this.btnExitGame.TabIndex = 7;
            this.btnExitGame.Text = "Exit Game";
            this.btnExitGame.UseVisualStyleBackColor = false;
            this.btnExitGame.Click += new System.EventHandler(this.btnExitGame_Click_1);
            // 
            // pnlWinner
            // 
            this.pnlWinner.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlWinner.Controls.Add(this.pnlWinRight);
            this.pnlWinner.Controls.Add(this.pnlWinLeft);
            this.pnlWinner.Controls.Add(this.lblCongrats);
            this.pnlWinner.Controls.Add(this.lblWinnerPlayer);
            this.pnlWinner.Controls.Add(this.picWinner);
            this.pnlWinner.Location = new System.Drawing.Point(0, 230);
            this.pnlWinner.Name = "pnlWinner";
            this.pnlWinner.Size = new System.Drawing.Size(1256, 348);
            this.pnlWinner.TabIndex = 26;
            this.pnlWinner.Visible = false;
            // 
            // pnlWinRight
            // 
            this.pnlWinRight.BackgroundImage = global::PRG281_Project.Properties.Resources.Icon;
            this.pnlWinRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlWinRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlWinRight.Location = new System.Drawing.Point(1019, 0);
            this.pnlWinRight.Name = "pnlWinRight";
            this.pnlWinRight.Size = new System.Drawing.Size(233, 344);
            this.pnlWinRight.TabIndex = 10;
            // 
            // pnlWinLeft
            // 
            this.pnlWinLeft.BackgroundImage = global::PRG281_Project.Properties.Resources.Icon;
            this.pnlWinLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlWinLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlWinLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlWinLeft.Name = "pnlWinLeft";
            this.pnlWinLeft.Size = new System.Drawing.Size(233, 344);
            this.pnlWinLeft.TabIndex = 9;
            // 
            // lblCongrats
            // 
            this.lblCongrats.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCongrats.AutoSize = true;
            this.lblCongrats.BackColor = System.Drawing.SystemColors.Control;
            this.lblCongrats.Font = new System.Drawing.Font("Century Gothic", 35F, System.Drawing.FontStyle.Bold);
            this.lblCongrats.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(136)))), ((int)(((byte)(252)))));
            this.lblCongrats.Location = new System.Drawing.Point(363, 2);
            this.lblCongrats.Name = "lblCongrats";
            this.lblCongrats.Size = new System.Drawing.Size(452, 56);
            this.lblCongrats.TabIndex = 8;
            this.lblCongrats.Text = "We Have a Winner!";
            // 
            // lblWinnerPlayer
            // 
            this.lblWinnerPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblWinnerPlayer.AutoSize = true;
            this.lblWinnerPlayer.BackColor = System.Drawing.SystemColors.Control;
            this.lblWinnerPlayer.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinnerPlayer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(136)))), ((int)(((byte)(252)))));
            this.lblWinnerPlayer.Location = new System.Drawing.Point(594, 254);
            this.lblWinnerPlayer.Name = "lblWinnerPlayer";
            this.lblWinnerPlayer.Size = new System.Drawing.Size(107, 28);
            this.lblWinnerPlayer.TabIndex = 7;
            this.lblWinnerPlayer.Text = "Player X";
            // 
            // picWinner
            // 
            this.picWinner.Image = global::PRG281_Project.Properties.Resources.P1Avatar;
            this.picWinner.Location = new System.Drawing.Point(563, 101);
            this.picWinner.Name = "picWinner";
            this.picWinner.Size = new System.Drawing.Size(150, 150);
            this.picWinner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picWinner.TabIndex = 3;
            this.picWinner.TabStop = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.Control;
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(136)))), ((int)(((byte)(252)))));
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(136)))), ((int)(((byte)(252)))));
            this.btnSubmit.Location = new System.Drawing.Point(802, 253);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(271, 60);
            this.btnSubmit.TabIndex = 29;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click_1);
            // 
            // lblSong
            // 
            this.lblSong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblSong.AutoSize = true;
            this.lblSong.BackColor = System.Drawing.SystemColors.Control;
            this.lblSong.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(136)))), ((int)(((byte)(252)))));
            this.lblSong.Location = new System.Drawing.Point(644, 230);
            this.lblSong.Name = "lblSong";
            this.lblSong.Size = new System.Drawing.Size(129, 23);
            this.lblSong.TabIndex = 31;
            this.lblSong.Text = "PlaceHolder.";
            // 
            // lblGuess
            // 
            this.lblGuess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblGuess.AutoSize = true;
            this.lblGuess.BackColor = System.Drawing.SystemColors.Control;
            this.lblGuess.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuess.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(136)))), ((int)(((byte)(252)))));
            this.lblGuess.Location = new System.Drawing.Point(424, 230);
            this.lblGuess.Name = "lblGuess";
            this.lblGuess.Size = new System.Drawing.Size(212, 23);
            this.lblGuess.TabIndex = 33;
            this.lblGuess.Text = "Guess this songs Artist:";
            // 
            // cbChoice
            // 
            this.cbChoice.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbChoice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(136)))), ((int)(((byte)(252)))));
            this.cbChoice.FormattingEnabled = true;
            this.cbChoice.Items.AddRange(new object[] {
            "Aerosmith",
            "Queen",
            "Stormzy",
            "Calvin Harris",
            "Twenty One Pilots",
            "Don McLean",
            "Eminem",
            "Muse",
            "J.Cole",
            "Slipknot",
            "Coldplay",
            "Post Malone",
            "Black Sabbath",
            "Billie Eilish",
            "Seether"});
            this.cbChoice.Location = new System.Drawing.Point(428, 267);
            this.cbChoice.Name = "cbChoice";
            this.cbChoice.Size = new System.Drawing.Size(345, 33);
            this.cbChoice.TabIndex = 34;
            // 
            // GameMode2Timer
            // 
            this.GameMode2Timer.Enabled = true;
            this.GameMode2Timer.Interval = 1000;
            this.GameMode2Timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblCorrect
            // 
            this.lblCorrect.AutoSize = true;
            this.lblCorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrect.ForeColor = System.Drawing.Color.LawnGreen;
            this.lblCorrect.Location = new System.Drawing.Point(869, 329);
            this.lblCorrect.Name = "lblCorrect";
            this.lblCorrect.Size = new System.Drawing.Size(131, 37);
            this.lblCorrect.TabIndex = 17;
            this.lblCorrect.Text = "Correct!";
            this.lblCorrect.Visible = false;
            // 
            // lblCheckTurn
            // 
            this.lblCheckTurn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblCheckTurn.AutoSize = true;
            this.lblCheckTurn.BackColor = System.Drawing.SystemColors.Control;
            this.lblCheckTurn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckTurn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(136)))), ((int)(((byte)(252)))));
            this.lblCheckTurn.Location = new System.Drawing.Point(544, 159);
            this.lblCheckTurn.Name = "lblCheckTurn";
            this.lblCheckTurn.Size = new System.Drawing.Size(160, 23);
            this.lblCheckTurn.TabIndex = 35;
            this.lblCheckTurn.Text = "PLAYER 1\'s TURN!";
            // 
            // frmGameMode2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.pnlWinner);
            this.Controls.Add(this.lblCheckTurn);
            this.Controls.Add(this.lblCorrect);
            this.Controls.Add(this.cbChoice);
            this.Controls.Add(this.lblGuess);
            this.Controls.Add(this.lblSong);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.lblGameMode);
            this.Controls.Add(this.pnlTime);
            this.Controls.Add(this.pnlTopBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGameMode2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Muzik Mash";
            this.Load += new System.EventHandler(this.frmGame2_Load);
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picP2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picP1)).EndInit();
            this.pnlTime.ResumeLayout(false);
            this.pnlTime.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            this.pnlWinner.ResumeLayout(false);
            this.pnlWinner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWinner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Label lblScoreP2;
        private System.Windows.Forms.TextBox tbxScoreP2;
        private System.Windows.Forms.Label lblScoreP1;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.TextBox tbxScoreP1;
        private System.Windows.Forms.PictureBox picP2;
        private System.Windows.Forms.PictureBox picP1;
        private System.Windows.Forms.Panel pnlTime;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.ProgressBar pgbCountdown;
        private System.Windows.Forms.Label lblGameMode;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Button btnExitGame;
        private System.Windows.Forms.Panel pnlWinner;
        private System.Windows.Forms.Panel pnlWinRight;
        private System.Windows.Forms.Panel pnlWinLeft;
        private System.Windows.Forms.Label lblCongrats;
        private System.Windows.Forms.Label lblWinnerPlayer;
        private System.Windows.Forms.PictureBox picWinner;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblSong;
        private System.Windows.Forms.Label lblGuess;
        private System.Windows.Forms.ComboBox cbChoice;
        private System.Windows.Forms.Timer GameMode2Timer;
        private System.Windows.Forms.Label lblCorrect;
        private System.Windows.Forms.Label lblCheckTurn;
    }
}