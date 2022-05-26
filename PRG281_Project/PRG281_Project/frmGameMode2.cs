using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using MuzikMashLib;

namespace PRG281_Project
{
    public partial class frmGameMode2 : Form
    {
        public bool blDarkGame;
        int totalScoreToReach = 5;
        int totalTurns = 5;
        bool multiplayer = false;
        bool player1Turn = true;
        int turns = 0;
        int currentArtist = 1;

        public frmGameMode2()
        {
            InitializeComponent();
            totalScoreToReach = uc_Settings.TotalScore;
            totalTurns = uc_Settings.TotalTurns;
        }

        private void btnExitGame_Click_1(object sender, EventArgs e)
        {
            frmMainMenu MainMenuView = new frmMainMenu();
            MainMenuView.Show();
            this.Close();
        }

        List<Artist> ArtistList = new List<Artist>();
        Player p1 = new Player(1, "Player1", 0, false);
        Player p2 = new Player(1, "Player2", 0, false);

        string choice = string.Empty;
        string chkChoice = string.Empty;

        private void frmGame2_Load(object sender, EventArgs e) 
        {
            Artist.CreateArtistList(ArtistList);
            lblSong.Text = "Dream on";
            //dark mode code  vvvv
            blDarkGame = uc_Settings.blDarkmode;
            if (blDarkGame == true)
            {
                this.BackColor = Color.FromArgb(68, 68, 68);
                lblGuess.BackColor = Color.FromArgb(68, 68, 68);
                lblGameMode.BackColor = Color.FromArgb(68, 68, 68);
                cbChoice.BackColor = Color.FromArgb(68, 68, 68);
                btnSubmit.BackColor = Color.FromArgb(68, 68, 68);
                lblSong.BackColor = Color.FromArgb(68, 68, 68);
                pnlWinner.BackColor = Color.FromArgb(68, 68, 68);
                lblCongrats.BackColor = Color.FromArgb(68, 68, 68);
                lblWinnerPlayer.BackColor = Color.FromArgb(68, 68, 68);
                lblCheckTurn.BackColor = Color.FromArgb(68, 68, 68);
                pgbCountdown.BackColor = Color.FromArgb(68, 68, 68);
                lblTimer.BackColor = Color.FromArgb(68, 68, 68);
                lblTimer.ForeColor = Color.FromArgb(3, 136, 252);
            }
            multiplayer = uc_StartGame.multiplayer;
            if (multiplayer == true)
            {
                lblCheckTurn.Visible = true;
                MessageBox.Show("Multiplayer on");
            }
            else
            {
                lblCheckTurn.Visible = false;
                MessageBox.Show("Multiplayer off");
            }
        }

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            timeLeft = 10;
            lblCorrect.Visible = false;
            if (player1Turn == true)
            {
                lblCheckTurn.Text = "PLAYER 2's TURN!";
            }
            else
            {
                lblCheckTurn.Text = "PLAYER 1's TURN!";
            }
            try
            {
                if (cbChoice.SelectedItem.ToString() == null)
                {
                    throw new Exception();
                }
                else
                {
                    choice = cbChoice.SelectedItem.ToString();
                }
              
            }
            catch (Exception)
            {
                MessageBox.Show("No input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cbChoice.SelectedIndex = 1;
            }
            string newSong = string.Empty;
            
            foreach (Artist person in ArtistList)
            {
                if (person.ArtistId == currentArtist)
                { 
                    chkChoice = person.ArtistName;
                }
                
            }

            PlayGame();

            foreach (Artist person in ArtistList)
            {
                if (person.ArtistId == currentArtist)
                {
                    lblSong.Text = person.Song;
                }

            }

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

        public void PlayGame()
        {
            if (multiplayer == true)
            {
                if (player1Turn == true)
                {
                    if (chkChoice == choice)
                    {
                        lblCorrect.Text = "Correct!";
                        lblCorrect.ForeColor = Color.LawnGreen;
                        lblCorrect.Visible = true;
                        p1.Score++;
                        tbxScoreP1.Text = p1.Score.ToString();
                        currentArtist = GenRandomNum();
                        player1Turn = false;
                    }
                    else
                    {
                        lblCorrect.Text = "Wrong!";
                        lblCorrect.ForeColor = Color.Red;
                        lblCorrect.Visible = true;
                        currentArtist = GenRandomNum();
                        player1Turn = false;
                    }
                }
                else
                {
                    if (chkChoice == choice)
                    {
                        lblCorrect.Text = "Correct!";
                        lblCorrect.ForeColor = Color.LawnGreen;
                        lblCorrect.Visible = true;
                        p2.Score++;
                        tbxScoreP2.Text = p2.Score.ToString();
                        currentArtist = GenRandomNum();
                        player1Turn = true;
                    }
                    else
                    {
                        lblCorrect.Text = "Wrong!";
                        lblCorrect.ForeColor = Color.Red;
                        lblCorrect.Visible = true;
                        currentArtist = GenRandomNum();
                        player1Turn = true;
                    }
                }
            }
            else
            {
                if (chkChoice == choice)
                {
                    lblCorrect.Text = "Correct!";
                    lblCorrect.ForeColor = Color.LawnGreen;
                    lblCorrect.Visible = true;
                    p1.Score++;
                    tbxScoreP1.Text = p1.Score.ToString();
                    currentArtist = GenRandomNum();
                }
                else
                {
                    lblCorrect.Text = "Wrong!";
                    lblCorrect.ForeColor = Color.Red;
                    lblCorrect.Visible = true;
                    currentArtist = GenRandomNum();
                }
            }
        }

        public int GenRandomNum()
        {
            
            Random randomNum = new Random();
            int rand = randomNum.Next(1, 15);
            return rand;
        }

        int timeLeft = 10;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
                lblTimer.Text = timeLeft + " Seconds";
            }
            else
            {
                btnSubmit.PerformClick();
                timeLeft = 10;
            }

            if (timeLeft < 9)
            {
                lblCorrect.Visible = false;
            }

            if (pnlWinner.Visible == true)
            {
                GameMode2Timer.Enabled = false;
            }
        }
    }

}
