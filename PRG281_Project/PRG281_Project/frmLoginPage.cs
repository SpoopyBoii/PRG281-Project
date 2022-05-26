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
    public partial class frmLoginPage : Form
    {
        public static string loggedUser;
        public frmLoginPage()
        {
            InitializeComponent();
        }

        private void lblUserLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();     //Closes program
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();     //Closes program
        }

        List<User> userList = new List<User>();
        private void frmLoginPage_Load(object sender, EventArgs e)
        {
            userList = User.CreateUsersList();
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string authUser = tbxUsername.Text;
            string authPass = tbxPassword.Text;
            bool login = false;

            foreach (User person in userList)
            {
                if (person.UserName == authUser)
                {
                    if (person.Password == authPass)
                    {
                        loggedUser = person.UserName;
                        login = true;
                    }
                    else
                    {
                        lblCheckPass.Visible = true;
                        lblCheckPass.Text = "Wrong Password!";
                        lblCheckPass.ForeColor = Color.Red;
                    }
                }
                else
                {
                    lblCheckName.Visible = true;
                    lblCheckName.Text = "Wrong Username!";
                    lblCheckName.ForeColor = Color.Red;
                }
            }
            if (login == true)
            {
                //Sets the Main Menu form to MainMenuView

                frmMainMenu MainMenuView = new frmMainMenu();
                MainMenuView.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } 
    }
}
