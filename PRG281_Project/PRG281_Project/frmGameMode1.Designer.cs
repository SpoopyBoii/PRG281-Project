
namespace PRG281_Project
{
    partial class frmGameMode1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGameMode1));
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.lblScoreP2 = new System.Windows.Forms.Label();
            this.tbxScoreP2 = new System.Windows.Forms.TextBox();
            this.lblScoreP1 = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.tbxScoreP1 = new System.Windows.Forms.TextBox();
            this.picP2 = new System.Windows.Forms.PictureBox();
            this.picP1 = new System.Windows.Forms.PictureBox();
            this.pgbCountdown = new System.Windows.Forms.ProgressBar();
            this.pnlTime = new System.Windows.Forms.Panel();
            this.lblTimer2 = new System.Windows.Forms.Label();
            this.lblGameMode = new System.Windows.Forms.Label();
            this.btnExitGame = new System.Windows.Forms.Button();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.gbxOptions = new System.Windows.Forms.GroupBox();
            this.rdbAlt = new System.Windows.Forms.RadioButton();
            this.rdbMetal = new System.Windows.Forms.RadioButton();
            this.rdbRap = new System.Windows.Forms.RadioButton();
            this.rdbPop = new System.Windows.Forms.RadioButton();
            this.rdbRock = new System.Windows.Forms.RadioButton();
            this.lblCorrect = new System.Windows.Forms.Label();
            this.picArtist = new System.Windows.Forms.PictureBox();
            this.pnlWinner = new System.Windows.Forms.Panel();
            this.pnlWinRight = new System.Windows.Forms.Panel();
            this.pnlWinLeft = new System.Windows.Forms.Panel();
            this.lblCongrats = new System.Windows.Forms.Label();
            this.lblWinnerPlayer = new System.Windows.Forms.Label();
            this.picWinner = new System.Windows.Forms.PictureBox();
            this.lblCheckTurn = new System.Windows.Forms.Label();
            this.GameMode1Timer = new System.Windows.Forms.Timer(this.components);
            this.pnlTopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picP2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picP1)).BeginInit();
            this.pnlTime.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.gbxOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picArtist)).BeginInit();
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
            this.pnlTopBar.TabIndex = 1;
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
            // pgbCountdown
            // 
            this.pgbCountdown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pgbCountdown.Location = new System.Drawing.Point(0, 0);
            this.pgbCountdown.Name = "pgbCountdown";
            this.pgbCountdown.Size = new System.Drawing.Size(1280, 36);
            this.pgbCountdown.TabIndex = 2;
            // 
            // pnlTime
            // 
            this.pnlTime.Controls.Add(this.lblTimer2);
            this.pnlTime.Controls.Add(this.pgbCountdown);
            this.pnlTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTime.Location = new System.Drawing.Point(0, 120);
            this.pnlTime.Name = "pnlTime";
            this.pnlTime.Size = new System.Drawing.Size(1280, 36);
            this.pnlTime.TabIndex = 3;
            // 
            // lblTimer2
            // 
            this.lblTimer2.AutoSize = true;
            this.lblTimer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer2.Location = new System.Drawing.Point(585, 6);
            this.lblTimer2.Name = "lblTimer2";
            this.lblTimer2.Size = new System.Drawing.Size(110, 24);
            this.lblTimer2.TabIndex = 4;
            this.lblTimer2.Text = "10 Seconds";
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
            this.lblGameMode.Size = new System.Drawing.Size(315, 23);
            this.lblGameMode.TabIndex = 6;
            this.lblGameMode.Text = "Game Mode 1 : Guess the Genre!";
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
            this.btnExitGame.Click += new System.EventHandler(this.btnExitGame_Click);
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(136)))), ((int)(((byte)(252)))));
            this.pnlBottom.Controls.Add(this.btnExitGame);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 660);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1280, 60);
            this.pnlBottom.TabIndex = 9;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.Control;
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(136)))), ((int)(((byte)(252)))));
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(136)))), ((int)(((byte)(252)))));
            this.btnSubmit.Location = new System.Drawing.Point(663, 521);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(271, 60);
            this.btnSubmit.TabIndex = 11;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // gbxOptions
            // 
            this.gbxOptions.Controls.Add(this.rdbAlt);
            this.gbxOptions.Controls.Add(this.rdbMetal);
            this.gbxOptions.Controls.Add(this.rdbRap);
            this.gbxOptions.Controls.Add(this.rdbPop);
            this.gbxOptions.Controls.Add(this.rdbRock);
            this.gbxOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxOptions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(136)))), ((int)(((byte)(252)))));
            this.gbxOptions.Location = new System.Drawing.Point(663, 233);
            this.gbxOptions.Name = "gbxOptions";
            this.gbxOptions.Size = new System.Drawing.Size(271, 217);
            this.gbxOptions.TabIndex = 15;
            this.gbxOptions.TabStop = false;
            this.gbxOptions.Text = "Artist Genres";
            // 
            // rdbAlt
            // 
            this.rdbAlt.AutoSize = true;
            this.rdbAlt.Location = new System.Drawing.Point(28, 164);
            this.rdbAlt.Name = "rdbAlt";
            this.rdbAlt.Size = new System.Drawing.Size(115, 28);
            this.rdbAlt.TabIndex = 4;
            this.rdbAlt.TabStop = true;
            this.rdbAlt.Text = "Alternative";
            this.rdbAlt.UseVisualStyleBackColor = true;
            // 
            // rdbMetal
            // 
            this.rdbMetal.AutoSize = true;
            this.rdbMetal.Location = new System.Drawing.Point(28, 130);
            this.rdbMetal.Name = "rdbMetal";
            this.rdbMetal.Size = new System.Drawing.Size(73, 28);
            this.rdbMetal.TabIndex = 3;
            this.rdbMetal.TabStop = true;
            this.rdbMetal.Text = "Metal";
            this.rdbMetal.UseVisualStyleBackColor = true;
            // 
            // rdbRap
            // 
            this.rdbRap.AutoSize = true;
            this.rdbRap.Location = new System.Drawing.Point(28, 96);
            this.rdbRap.Name = "rdbRap";
            this.rdbRap.Size = new System.Drawing.Size(62, 28);
            this.rdbRap.TabIndex = 2;
            this.rdbRap.TabStop = true;
            this.rdbRap.Text = "Rap";
            this.rdbRap.UseVisualStyleBackColor = true;
            // 
            // rdbPop
            // 
            this.rdbPop.AutoSize = true;
            this.rdbPop.Location = new System.Drawing.Point(28, 62);
            this.rdbPop.Name = "rdbPop";
            this.rdbPop.Size = new System.Drawing.Size(62, 28);
            this.rdbPop.TabIndex = 1;
            this.rdbPop.TabStop = true;
            this.rdbPop.Text = "Pop";
            this.rdbPop.UseVisualStyleBackColor = true;
            // 
            // rdbRock
            // 
            this.rdbRock.AutoSize = true;
            this.rdbRock.Location = new System.Drawing.Point(28, 28);
            this.rdbRock.Name = "rdbRock";
            this.rdbRock.Size = new System.Drawing.Size(71, 28);
            this.rdbRock.TabIndex = 0;
            this.rdbRock.TabStop = true;
            this.rdbRock.Text = "Rock";
            this.rdbRock.UseVisualStyleBackColor = true;
            // 
            // lblCorrect
            // 
            this.lblCorrect.AutoSize = true;
            this.lblCorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrect.ForeColor = System.Drawing.Color.LawnGreen;
            this.lblCorrect.Location = new System.Drawing.Point(970, 529);
            this.lblCorrect.Name = "lblCorrect";
            this.lblCorrect.Size = new System.Drawing.Size(131, 37);
            this.lblCorrect.TabIndex = 16;
            this.lblCorrect.Text = "Correct!";
            this.lblCorrect.Visible = false;
            // 
            // picArtist
            // 
            this.picArtist.ImageLocation = "X:\\User\\Documents\\GitHub\\PRG281-Project\\PRG281_Project\\PRG281_Project\\Images\\Arti" +
    "stImages\\Aerosmith.jpg";
            this.picArtist.Location = new System.Drawing.Point(52, 233);
            this.picArtist.Name = "picArtist";
            this.picArtist.Size = new System.Drawing.Size(549, 348);
            this.picArtist.TabIndex = 8;
            this.picArtist.TabStop = false;
            // 
            // pnlWinner
            // 
            this.pnlWinner.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlWinner.Controls.Add(this.pnlWinRight);
            this.pnlWinner.Controls.Add(this.pnlWinLeft);
            this.pnlWinner.Controls.Add(this.lblCongrats);
            this.pnlWinner.Controls.Add(this.lblWinnerPlayer);
            this.pnlWinner.Controls.Add(this.picWinner);
            this.pnlWinner.Location = new System.Drawing.Point(12, 233);
            this.pnlWinner.Name = "pnlWinner";
            this.pnlWinner.Size = new System.Drawing.Size(1256, 348);
            this.pnlWinner.TabIndex = 19;
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
            // lblCheckTurn
            // 
            this.lblCheckTurn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblCheckTurn.AutoSize = true;
            this.lblCheckTurn.BackColor = System.Drawing.SystemColors.Control;
            this.lblCheckTurn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckTurn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(136)))), ((int)(((byte)(252)))));
            this.lblCheckTurn.Location = new System.Drawing.Point(577, 159);
            this.lblCheckTurn.Name = "lblCheckTurn";
            this.lblCheckTurn.Size = new System.Drawing.Size(160, 23);
            this.lblCheckTurn.TabIndex = 20;
            this.lblCheckTurn.Text = "PLAYER 1\'s TURN!";
            this.lblCheckTurn.Visible = false;
            // 
            // GameMode1Timer
            // 
            this.GameMode1Timer.Enabled = true;
            this.GameMode1Timer.Interval = 1000;
            this.GameMode1Timer.Tick += new System.EventHandler(this.GameMode1Timer_Tick);
            // 
            // frmGameMode1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.pnlWinner);
            this.Controls.Add(this.lblCheckTurn);
            this.Controls.Add(this.lblCorrect);
            this.Controls.Add(this.gbxOptions);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.picArtist);
            this.Controls.Add(this.lblGameMode);
            this.Controls.Add(this.pnlTime);
            this.Controls.Add(this.pnlTopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGameMode1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Muzik Mash";
            this.Load += new System.EventHandler(this.frmGame_Load);
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picP2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picP1)).EndInit();
            this.pnlTime.ResumeLayout(false);
            this.pnlTime.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            this.gbxOptions.ResumeLayout(false);
            this.gbxOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picArtist)).EndInit();
            this.pnlWinner.ResumeLayout(false);
            this.pnlWinner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWinner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picP1;
        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.PictureBox picP2;
        private System.Windows.Forms.Label lblScoreP2;
        private System.Windows.Forms.TextBox tbxScoreP2;
        private System.Windows.Forms.Label lblScoreP1;
        private System.Windows.Forms.TextBox tbxScoreP1;
        private System.Windows.Forms.ProgressBar pgbCountdown;
        private System.Windows.Forms.Panel pnlTime;
        private System.Windows.Forms.Label lblGameMode;
        private System.Windows.Forms.Button btnExitGame;
        private System.Windows.Forms.PictureBox picArtist;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.GroupBox gbxOptions;
        private System.Windows.Forms.RadioButton rdbMetal;
        private System.Windows.Forms.RadioButton rdbRap;
        private System.Windows.Forms.RadioButton rdbPop;
        private System.Windows.Forms.RadioButton rdbRock;
        private System.Windows.Forms.RadioButton rdbAlt;
        private System.Windows.Forms.Label lblCorrect;
        private System.Windows.Forms.Panel pnlWinner;
        private System.Windows.Forms.Panel pnlWinRight;
        private System.Windows.Forms.Panel pnlWinLeft;
        private System.Windows.Forms.Label lblCongrats;
        private System.Windows.Forms.Label lblWinnerPlayer;
        private System.Windows.Forms.PictureBox picWinner;
        private System.Windows.Forms.Label lblCheckTurn;
        private System.Windows.Forms.Label lblTimer2;
        private System.Windows.Forms.Timer GameMode1Timer;
    }
}