using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MuzikMashLib;

namespace PRG281_Project
{
    public partial class uc_StartGame : UserControl
    {
        public bool blDarkStartGame;
        public uc_StartGame()
        {
            InitializeComponent();
        }
        private void uc_StartGame_Load(object sender, EventArgs e)
        {
            blDarkStartGame = uc_Settings.blDarkmode;
            if (blDarkStartGame == true)
            {
                this.BackColor = Color.FromArgb(68, 68, 68);
                pnlLeft.BackColor = Color.FromArgb(68, 68, 68);
                rbxMode1Info.BackColor = Color.FromArgb(68, 68, 68);
                rbxMode2Info.BackColor = Color.FromArgb(68, 68, 68);
                pnlPlayerSelect.BackColor = Color.FromArgb(68, 68, 68);
                btnBack.BackColor = Color.FromArgb(68, 68, 68);
                btnBack.ForeColor = Color.FromArgb(3, 136, 252);
                lblHowMany.ForeColor = Color.FromArgb(3, 136, 252);
                lblSelectedGame.ForeColor = Color.FromArgb(3, 136, 252);
                lblSelectAGame.ForeColor = Color.FromArgb(3, 136, 252);
                lblMode1.ForeColor = Color.FromArgb(3, 136, 252);
                lblMode2.ForeColor = Color.FromArgb(3, 136, 252);
                lblOr.ForeColor = Color.FromArgb(3, 136, 252);
                rbxMode1Info.ForeColor = Color.FromArgb(3, 136, 252);
                rbxMode2Info.ForeColor = Color.FromArgb(3, 136, 252);

            }
            else
            {
                this.BackColor = SystemColors.Control;
                pnlLeft.BackColor = SystemColors.Control;
                rbxMode1Info.BackColor = SystemColors.Control;
                rbxMode2Info.BackColor = SystemColors.Control;
                pnlPlayerSelect.BackColor = SystemColors.Control;
                btnBack.BackColor = SystemColors.Control;
                btnBack.ForeColor = Color.FromArgb(0, 76, 161);
                lblHowMany.ForeColor = Color.FromArgb(0, 76, 161);
                lblSelectedGame.ForeColor = Color.FromArgb(0, 76, 161);
                lblSelectAGame.ForeColor = Color.FromArgb(0, 76, 161);
                lblMode1.ForeColor = Color.FromArgb(0, 76, 161);
                lblMode2.ForeColor = Color.FromArgb(0, 76, 161);
                lblOr.ForeColor = Color.FromArgb(0, 76, 161);
                rbxMode1Info.ForeColor = Color.FromArgb(0, 76, 161);
                rbxMode2Info.ForeColor = Color.FromArgb(0, 76, 161);
            }
        }
        private void btnMode1Info_Click(object sender, EventArgs e)
        {
            pnlMode2Info.Visible = false;       //Hide game 2 details  
            if (pnlMode1Info.Visible == true)   //Alter showing and hiding game 1 details  
            {
                pnlMode1Info.Visible = false;
            }
            else
            {
                pnlMode1Info.Visible = true;
            }
        }

        private void btnMode2Info_Click(object sender, EventArgs e)
        {
            pnlMode1Info.Visible = false;       //Hide game 1 details
            if (pnlMode2Info.Visible == true)   //Alter showing and hiding game 2 details
            {
                pnlMode2Info.Visible = false;
            }
            else
            {
                pnlMode2Info.Visible = true;
            }
        }
        
        private void lblSingle_Click(object sender, EventArgs e)
        {
            multiplayer = false;
            lblMulti.BackColor = SystemColors.Control;
            if (lblSingle.BackColor == SystemColors.Control)
            {
                lblSingle.BackColor = SystemColors.ActiveCaption;   //user selected singleplayer
                btnLaunchGame.Visible = true;
                /*btnLaunchGame.Enabled = true;
                btnLaunchGame.BackColor = Color.FromArgb(0, 111, 207);*/
            }
            else
            {
                lblSingle.BackColor = SystemColors.Control;         //user unchecked singleplayer
                btnLaunchGame.Visible = false;
                /*btnLaunchGame.Enabled = false;
                btnLaunchGame.BackColor = Color.FromArgb(68, 68, 68);*/
            }
        }
        public static bool multiplayer = false;
        private void lblMulti_Click(object sender, EventArgs e)
        {
            multiplayer = true;
            lblSingle.BackColor = SystemColors.Control;
            if (lblMulti.BackColor == SystemColors.Control)
            {
                lblMulti.BackColor = SystemColors.ActiveCaption;    //user selected multiplayer
                btnLaunchGame.Visible = true;
                //btnLaunchGame.BackColor = Color.FromArgb(0, 111, 207);
            }
            else
            {
                lblMulti.BackColor = SystemColors.Control;          //user unchecked multiplayer
                btnLaunchGame.Visible = false;
                /*btnLaunchGame.Enabled = false;
                btnLaunchGame.BackColor = Color.FromArgb(68, 68, 68);*/
            }
        }
        public int iGameMode = 0;
        public void btnLaunchGame_Click(object sender, EventArgs e)
        {
            if (iGameMode == 1)
            {
                frmGameMode1 GameView1 = new frmGameMode1();
                GameView1.Show();
            }
            else
            if (iGameMode == 2)
            {
                frmMainMenu MainMenuView = new frmMainMenu();
                frmGameMode2 GameView2 = new frmGameMode2();
                GameView2.Show();
            }
            ((Form)this.TopLevelControl).Close();
            /*frmMainMenu MainMenuView = new frmMainMenu();
            frmGame GameView = new frmGame();
            GameView.Show();
            MainMenuView.Close(); //won't hide and idk why. Maybe I'm just tired, blonde or both >_<*/
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            pnlPlayerSelect.Visible = false;
        }
        
        private void picMode1_Click(object sender, EventArgs e)
        {
            pnlPlayerSelect.Visible = true;
            lblSelectedGame.Text = "Game Mode 1"; //Change to appropriate name later
            iGameMode = 1;
        }

        private void picMode2_Click(object sender, EventArgs e)
        {
            pnlPlayerSelect.Visible = true;
            lblSelectedGame.Text = "Game Mode 2"; //Change to appropriate name later
            iGameMode = 2;
        }

        private void picSingleP_Click(object sender, EventArgs e)
        {
            multiplayer = false;
            picMultiP.BackColor = Color.Transparent;
            if (picSingleP.BackColor == Color.Transparent)
            {
                picSingleP.BackColor = Color.FromArgb(3, 136, 252);    //user selected multiplayer 
                btnLaunchGame.Visible = true;
                /*btnLaunchGame.Enabled = true;
                btnLaunchGame.BackColor = Color.FromArgb(0, 111, 207);*/
            }
            else
            {
                picSingleP.BackColor = Color.Transparent;         //user unchecked singleplayer
                btnLaunchGame.Visible = false;
                /*btnLaunchGame.Enabled = false;
                btnLaunchGame.BackColor = Color.FromArgb(68, 68, 68);*/
            }
        }

        private void picMultiP_Click(object sender, EventArgs e)
        {
            multiplayer = true;
            picSingleP.BackColor = Color.Transparent;
            if (picMultiP.BackColor == Color.Transparent)
            {
                picMultiP.BackColor = Color.FromArgb(3, 136, 252);    //user selected multiplayer
                btnLaunchGame.Visible = true;
                //btnLaunchGame.BackColor = Color.FromArgb(0, 111, 207);
            }
            else
            {
                picMultiP.BackColor = Color.Transparent;          //user unchecked multiplayer
                btnLaunchGame.Visible = false;
                /*btnLaunchGame.Enabled = false;
                btnLaunchGame.BackColor = Color.FromArgb(68, 68, 68);*/
            }
        }
    }
}
