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
    public partial class frmMainMenu : Form
    {
        public bool blDarkMainMenu;
        string currentUserName;
        public frmMainMenu()
        {
            InitializeComponent();
            currentUserName = frmLoginPage.loggedUser;
            blDarkMainMenu = uc_Settings.blDarkmode;
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            if (blDarkMainMenu == true)
            {
                blDarkMainMenu = uc_Settings.blDarkmode;
                btnHome.BackColor = Color.FromArgb(68, 68, 68);
                btnHome.ForeColor = Color.FromArgb(3, 166, 252);

            }
            else
            {
                
                btnHome.BackColor = SystemColors.Control;
            }
            btnStartGame.BackColor = Color.FromArgb(0, 111, 207);
            btnSettings.BackColor = Color.FromArgb(0, 111, 207);
            lblUsername.Text = currentUserName;
            uc_Home1.Visible = true;
            uc_StartGame.Visible = false;
            uc_Settings1.Visible = false;

        }


        private void btnHome_Click(object sender, EventArgs e)
        {
            blDarkMainMenu = uc_Settings.blDarkmode;
            if (blDarkMainMenu == true)
            {
                btnHome.BackColor = Color.FromArgb(68, 68, 68);
                btnHome.ForeColor = Color.FromArgb(3, 166, 252);
                
            }
            else
            {

                btnHome.BackColor = SystemColors.Control;
                btnHome.ForeColor = Color.FromArgb(0, 76, 161);
            }
            btnStartGame.BackColor = Color.FromArgb(0, 111, 207);
            btnSettings.BackColor = Color.FromArgb(0, 111, 207);
            btnStartGame.ForeColor = Color.FromArgb(0, 76, 161);
            btnSettings.ForeColor = Color.FromArgb(0, 76, 161);
            lblUsername.Text = currentUserName;
            uc_Home1.Visible = true;
            uc_StartGame.Visible = false;
            uc_Settings1.Visible = false;
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            blDarkMainMenu = uc_Settings.blDarkmode;
            if (blDarkMainMenu == true)
            {
                btnStartGame.BackColor = Color.FromArgb(68, 68, 68);
                btnStartGame.ForeColor = Color.FromArgb(3, 166, 252);

            }
            else
            {

                btnStartGame.BackColor = SystemColors.Control;
                btnStartGame.ForeColor = Color.FromArgb(0, 76, 161);
            }
            btnHome.BackColor = Color.FromArgb(0, 111, 207);
            btnSettings.BackColor = Color.FromArgb(0, 111, 207);
            btnHome.ForeColor = Color.FromArgb(0, 76, 161);
            btnSettings.ForeColor = Color.FromArgb(0, 76, 161);
            lblUsername.Text = currentUserName;
            uc_Home1.Visible = false;
            uc_StartGame.Visible = true;
            uc_Settings1.Visible = false;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            blDarkMainMenu = uc_Settings.blDarkmode;
            if (blDarkMainMenu == true)
            {
                btnSettings.BackColor = Color.FromArgb(68, 68, 68);
                btnSettings.ForeColor = Color.FromArgb(3, 166, 252);

            }
            else
            {

                btnSettings.BackColor = SystemColors.Control;
                btnSettings.ForeColor = Color.FromArgb(0, 76, 161);
            }
            btnHome.BackColor = Color.FromArgb(0, 111, 207);
            btnStartGame.BackColor = Color.FromArgb(0, 111, 207);
            btnHome.ForeColor = Color.FromArgb(0, 76, 161);
            btnStartGame.ForeColor = Color.FromArgb(0, 76, 161);
            lblUsername.Text = currentUserName;
            uc_Home1.Visible = false;
            uc_StartGame.Visible = false;
            uc_Settings1.Visible = true;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();     //Closes program
        }

    }


}
