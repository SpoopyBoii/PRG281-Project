using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG281_Project
{
    public partial class uc_Settings : UserControl
    {
        public static bool blDarkmode;
        public static bool blDarkmode_Check;
        public static int TotalScore = 5;
        public static int TotalTurns = 5;
        public uc_Settings()
        {
            InitializeComponent();
        }
        // TODO - DarkMode with color 68,68,68 (almost done)
        private void uc_Settings_Load(object sender, EventArgs e)
        {
            if (blDarkmode_Check == true)
            {
                chkDarkmode.Checked = true;
            }
            else
            {
                chkDarkmode.Checked = false;
            }

            if (blDarkmode == true)
            {
                this.BackColor = Color.FromArgb(68, 68, 68);
                lblGeneral.BackColor = Color.FromArgb(68, 68, 68);
                chkDarkmode.BackColor = Color.FromArgb(68, 68, 68);
                lblSingleplayer.BackColor = Color.FromArgb(68, 68, 68);
                lblTotalTurns.BackColor = Color.FromArgb(68, 68, 68);
                lblTotalTurnsNum.BackColor = Color.FromArgb(68, 68, 68);
                lblMultiplayer.BackColor = Color.FromArgb(68, 68, 68);
                lblTargetScore.BackColor = Color.FromArgb(68, 68, 68);
                lblTargetScoreNum.BackColor = Color.FromArgb(68, 68, 68);
                btnSave.BackColor = Color.FromArgb(68, 68, 68);
                cbTotalTurns.BackColor = SystemColors.ControlDark;
                cbTotalScore.BackColor = SystemColors.ControlDark;
            }
            else
            {
                this.BackColor = SystemColors.Control;
                lblGeneral.BackColor = SystemColors.Control;
                chkDarkmode.BackColor = SystemColors.Control;
                lblSingleplayer.BackColor = SystemColors.Control;
                lblTotalTurns.BackColor = SystemColors.Control;
                lblTotalTurnsNum.BackColor = SystemColors.Control;
                lblMultiplayer.BackColor = SystemColors.Control;
                lblTargetScore.BackColor = SystemColors.Control;
                lblTargetScoreNum.BackColor = SystemColors.Control;
                btnSave.BackColor = SystemColors.Control;
                cbTotalTurns.BackColor = SystemColors.Control;
                cbTotalScore.BackColor = SystemColors.Control;
            }
        }
        public void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Setting Saved!");
            TotalScore = int.Parse(cbTotalScore.SelectedItem.ToString());
            TotalTurns = int.Parse(cbTotalTurns.SelectedItem.ToString());
            if (blDarkmode == true)
            {
                this.BackColor = Color.FromArgb(68, 68, 68);
                lblGeneral.BackColor = Color.FromArgb(68, 68, 68);
                chkDarkmode.BackColor = Color.FromArgb(68, 68, 68);
                lblSingleplayer.BackColor = Color.FromArgb(68, 68, 68);
                lblTotalTurns.BackColor = Color.FromArgb(68, 68, 68);
                lblTotalTurnsNum.BackColor = Color.FromArgb(68, 68, 68);
                lblMultiplayer.BackColor = Color.FromArgb(68, 68, 68);
                lblTargetScore.BackColor = Color.FromArgb(68, 68, 68);
                lblTargetScoreNum.BackColor = Color.FromArgb(68, 68, 68);
                btnSave.BackColor = Color.FromArgb(68, 68, 68);
                cbTotalTurns.BackColor = SystemColors.ControlDark;
                cbTotalScore.BackColor = SystemColors.ControlDark;
            }
            else
            {
                this.BackColor = SystemColors.Control;
                lblGeneral.BackColor = SystemColors.Control;
                chkDarkmode.BackColor = SystemColors.Control;
                lblSingleplayer.BackColor = SystemColors.Control;
                lblTotalTurns.BackColor = SystemColors.Control;
                lblTotalTurnsNum.BackColor = SystemColors.Control;
                lblMultiplayer.BackColor = SystemColors.Control;
                lblTargetScore.BackColor = SystemColors.Control;
                lblTargetScoreNum.BackColor = SystemColors.Control;
                btnSave.BackColor = SystemColors.Control;
                cbTotalTurns.BackColor = SystemColors.Control;
                cbTotalScore.BackColor = SystemColors.Control;
            }
            frmMainMenu NewMainMenuView = new frmMainMenu();
            NewMainMenuView.Show();
            ((Form)this.TopLevelControl).Close();
        }

        public void chkDarkmode_CheckedChanged(object sender, EventArgs e)
        {
            if(chkDarkmode.Checked == false)
            {
                blDarkmode = false;
                blDarkmode_Check = false;
            }
            else
            if (chkDarkmode.Checked == true)
            {
                blDarkmode = true;
                blDarkmode_Check = true;
            }
        }
    }
}
