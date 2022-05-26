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
    public partial class uc_Home : UserControl
    {
        public bool blDarkHome;
        public uc_Home()
        {
            InitializeComponent();
            blDarkHome = uc_Settings.blDarkmode;
        }
        private void uc_Home_Load(object sender, EventArgs e)
        {
            blDarkHome = uc_Settings.blDarkmode;
            if (blDarkHome == true)
            {
                this.BackColor = Color.FromArgb(68, 68, 68);
                rbxHome_Info.BackColor = Color.FromArgb(68, 68, 68);
            }
            else
            {
                this.BackColor = SystemColors.Control;
                rbxHome_Info.BackColor = SystemColors.Control;
            }
        }

        private void lblHomeWelcome_Click_1(object sender, EventArgs e)
        {

        }
    }
}
