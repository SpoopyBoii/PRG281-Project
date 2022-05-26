using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MuzikMashLib;

namespace PRG281_Project
{
    public delegate void click();
    public partial class frmGameMode1 : Form
    {
        public bool blDarkGame;
        int totalScoreToReach = 5;
        int totalTurns = 5;
        bool multiplayer = false;
        bool player1Turn = true;
        int turns = 0;
        int currentArtist = 1;
        List<Artist> ArtistList = new List<Artist>();
        Player p1 = new Player(1, "Player1", 0, false);
        Player p2 = new Player(1, "Player2", 0, false);

        public frmGameMode1()
        {
            InitializeComponent();
            totalScoreToReach = uc_Settings.TotalScore;
            totalTurns = uc_Settings.TotalTurns;
        }
        public void btnExitGame_Click(object sender, EventArgs e)
        {
            frmMainMenu MainMenuView = new frmMainMenu();
            MainMenuView.Show();
            this.Close();
        }

        private void frmGame_Load(object sender, EventArgs e)
        {
            turns = 0;
            UpdatePicture(currentArtist);
            Artist.CreateArtistList(ArtistList);
            multiplayer = uc_StartGame.multiplayer;
            if (multiplayer == true)
            {
                lblCheckTurn.Visible = true;
                MessageBox.Show("Multiplayer on");
            }
            else
            {
                MessageBox.Show("Multiplayer off");
            }
            //dark mode code
            blDarkGame = uc_Settings.blDarkmode;
            if (blDarkGame == true)
            {
                this.BackColor = Color.FromArgb(68, 68, 68);
                lblCheckTurn.BackColor = Color.FromArgb(68, 68, 68);
                lblGameMode.BackColor = Color.FromArgb(68, 68, 68);
                gbxOptions.BackColor = Color.FromArgb(68, 68, 68);
                btnSubmit.BackColor = Color.FromArgb(68, 68, 68);
                lblCorrect.BackColor = Color.FromArgb(68, 68, 68);
                pnlWinner.BackColor = Color.FromArgb(68, 68, 68);
                lblCongrats.BackColor = Color.FromArgb(68, 68, 68);
                lblWinnerPlayer.BackColor = Color.FromArgb(68, 68, 68);
                lblCheckTurn.BackColor = Color.FromArgb(68, 68, 68);
                pgbCountdown.BackColor = Color.FromArgb(68, 68, 68);
                lblTimer2.BackColor = Color.FromArgb(68, 68, 68);
                lblTimer2.ForeColor = Color.FromArgb(3, 136, 252);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            timeLeft = 5;
            if (player1Turn == true)
            {
                lblCheckTurn.Text = "PLAYER 2's TURN!";
            }
            else
            {
                lblCheckTurn.Text = "PLAYER 1's TURN!";
            }
            string choice = string.Empty;
            string chkChoice = string.Empty;

            PlayGame(choice, chkChoice);

            if (multiplayer == true)
            {
                if (p1.Score == totalScoreToReach || p2.Score == totalScoreToReach)
                {
                    lblCheckTurn.Visible = false;
                    pnlWinner.Visible = true;
                    if (p1.Score > p2.Score)
                    {
                        lblCorrect.Visible = false;
                        p1.HasWon = true;
                        lblWinnerPlayer.ForeColor = Color.Blue;
                        lblWinnerPlayer.Text = p1.UserName;
                    }
                    else
                    {
                        lblCorrect.Visible = false;
                        p2.HasWon = true;
                        lblWinnerPlayer.ForeColor = Color.Red;
                        lblWinnerPlayer.Text = p2.UserName;
                    }
                }
            }
            else
            {
                turns++;
                if (turns == totalTurns)
                {
                    lblCorrect.Visible = false;
                    pnlWinner.Visible = true;
                    lblCongrats.Text = $"You have Scored: {p1.Score} / {turns} ";
                    p1.HasWon = true;
                    lblWinnerPlayer.ForeColor = Color.Blue;
                    lblWinnerPlayer.Text = p1.UserName;
                }
            }
        }
        public void PlayGame(string choice, string chkChoice)
        {
                if (rdbPop.Checked)
                {
                    choice = "pop";
                }
                else if (rdbMetal.Checked)
                {
                    choice = "metal";
                }
                else if (rdbRap.Checked)
                {
                    choice = "rap";
                }
                else if (rdbRock.Checked)
                {
                    choice = "rock";
                }
                else if (rdbAlt.Checked)
                {
                    choice = "alternative";
                }

            try
            {
                if (choice == string.Empty)
                {
                    throw new Exception("No input given!");
                }
            }
            catch(Exception)
            {
                MessageBox.Show("No input", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            foreach (Artist artist in ArtistList)
            {
                if (artist.ArtistId == currentArtist)
                {
                    chkChoice = artist.Genre;
                }
            }

            if (multiplayer == true)
            {
                if (player1Turn == true)
                {
                    if (chkChoice == choice)
                    {
                        p1.Score = p1.Score + 1;
                        tbxScoreP1.Text = p1.Score.ToString();
                        currentArtist = GenRandomNum();
                        UpdatePicture(currentArtist);
                        player1Turn = false;
                    }
                    else
                    {
                        currentArtist = GenRandomNum();
                        UpdatePicture(currentArtist);
                        player1Turn = false;
                    }
                }
                else
                {
                    if (chkChoice == choice)
                    {
                        p2.Score = p2.Score + 1;
                        tbxScoreP2.Text = p2.Score.ToString();
                        currentArtist = GenRandomNum();
                        UpdatePicture(currentArtist);
                        player1Turn = true;
                    }
                    else
                    {
                        currentArtist = GenRandomNum();
                        UpdatePicture(currentArtist);
                        player1Turn = true;
                    }
                }
            }
            else
            {
                if (chkChoice == choice)
                {
                    lblCorrect.Visible = true;
                    lblCorrect.Text = "Correct!";
                    lblCorrect.ForeColor = Color.LawnGreen;
                    p1.Score = p1.Score + 1;
                    tbxScoreP1.Text = p1.Score.ToString();
                    currentArtist = GenRandomNum();
                    UpdatePicture(currentArtist);
                }
                else
                {
                    lblCorrect.Text = "Wrong!";
                    lblCorrect.Visible = true;
                    lblCorrect.ForeColor = Color.Red;
                    currentArtist = GenRandomNum();
                    UpdatePicture(currentArtist);
                }
               
            }
       
        }
        public int GenRandomNum()
        {
            Random randomNum = new Random();
            int rand = randomNum.Next(1, 15);
            return rand;
        }

        public void UpdatePicture(int current)
        {
            string fileName = string.Empty;
            string path = string.Empty;
            //Aerosmith, Queen , Stormzy , Calvin, Twenty , Don , Eminem, Muse, Cole, Slipknot, Coldplay , Post , Black , Billie
            switch (current)
            {
                case 1:
                    fileName = "Aerosmith.jpg";
                    path = Path.Combine(Environment.CurrentDirectory, @"Data\ArtistImages\", fileName);
                    picArtist.ImageLocation = path;
                    picArtist.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 2:
                    fileName = "Queen.jfif";
                    path = Path.Combine(Environment.CurrentDirectory, @"Data\ArtistImages\", fileName);
                    picArtist.ImageLocation = path;
                    picArtist.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 3:
                    fileName = "Stormzy.jpg";
                    path = Path.Combine(Environment.CurrentDirectory, @"Data\ArtistImages\", fileName);
                    picArtist.ImageLocation = path;
                    picArtist.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 4:
                    fileName = "calvin-harris.jpg";
                    path = Path.Combine(Environment.CurrentDirectory, @"Data\ArtistImages\", fileName);
                    picArtist.ImageLocation = path;
                    picArtist.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 5:
                    fileName = "TwentyOnePilots.jpg";
                    path = Path.Combine(Environment.CurrentDirectory, @"Data\ArtistImages\", fileName);
                    picArtist.ImageLocation = path;
                    picArtist.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 6:
                    fileName = "DonMclean.jpg";
                    path = Path.Combine(Environment.CurrentDirectory, @"Data\ArtistImages\", fileName);
                    picArtist.ImageLocation = path;
                    picArtist.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 7:
                    fileName = "Eminem.jpg";
                    path = Path.Combine(Environment.CurrentDirectory, @"Data\ArtistImages\", fileName);
                    picArtist.ImageLocation = path;
                    picArtist.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 8:
                    fileName = "Muse.jpg";
                    path = Path.Combine(Environment.CurrentDirectory, @"Data\ArtistImages\", fileName);
                    picArtist.ImageLocation = path;
                    picArtist.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 9:
                    fileName = "J.cole.jfif";
                    path = Path.Combine(Environment.CurrentDirectory, @"Data\ArtistImages\", fileName);
                    picArtist.ImageLocation = path;
                    picArtist.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 10:
                    fileName = "slipknot.jpg";
                    path = Path.Combine(Environment.CurrentDirectory, @"Data\ArtistImages\", fileName);
                    picArtist.ImageLocation = path;
                    picArtist.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 11:
                    fileName = "coldplay.jpg";
                    path = Path.Combine(Environment.CurrentDirectory, @"Data\ArtistImages", fileName);
                    picArtist.ImageLocation = path;
                    picArtist.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 12:
                    fileName = "post-malone.jpg";
                    path = Path.Combine(Environment.CurrentDirectory, @"Data\ArtistImages", fileName);
                    picArtist.ImageLocation = path;
                    picArtist.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 13:
                    fileName = "black-sabbath.jpg";
                    path = Path.Combine(Environment.CurrentDirectory, @"Data\ArtistImages", fileName);
                    picArtist.ImageLocation = path;
                    picArtist.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 14:
                    fileName = "Billie-Eilish.jpg";
                    path = Path.Combine(Environment.CurrentDirectory, @"Data\ArtistImages", fileName);
                    picArtist.ImageLocation = path;
                    picArtist.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 15:
                    fileName = "Seether.jpg";
                    path = Path.Combine(Environment.CurrentDirectory, @"Data\ArtistImages", fileName);
                    picArtist.ImageLocation = path;
                    picArtist.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                default:
                    break;
            }
        }

        int timeLeft = 5;
        private void GameMode1Timer_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
                lblTimer2.Text = timeLeft + " Seconds";
            }
            else
            { 
                btnSubmit.PerformClick();
                timeLeft = 5;
            }
            if (pnlWinner.Visible == true)
            {
                GameMode1Timer.Enabled = false;
            }
        }
    }
}
