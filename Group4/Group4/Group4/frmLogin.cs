using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Group4
{
    public partial class frmLogin : Form
    {

        public frmLogin()
        {
            InitializeComponent();


        }


    private void btnLogin_Click(object sender, EventArgs e)
        {
            bool otherFormOpen = Application.OpenForms.Cast<Form>().Any(form => form != this);
            bool otherMainFormOpen = false;

            if (otherFormOpen)
            {
                otherMainFormOpen = Application.OpenForms.Cast<Form>().Any(form =>
                    (form is Members_Home_Menu || form is frmMain) && form != this);
            }

            if (otherMainFormOpen)
            {
                MessageBox.Show("Please log out from the current session first.");
                return; 
            }
            
            //bool otherFormOpen = Application.OpenForms.Cast<Form>().Any(form => form != this);
            //if (otherFormOpen)
            //{
            //    MessageBox.Show("Please log out from the current session first.");
            //    return; //exit
            //}
            //if (CurrentUser.UserName != null)
            //{
            //    MessageBox.Show("Please log out from the current session first.");
            //    return;
            //}
            User user = new User(userName: txtUserName.Text, userPass: txtPassword.Text);
           
            if (user.AuthenticateUser(user))
            {
                CurrentUser.UserName = user.UserName;
                txtUserName.Clear();
                txtPassword.Clear();
                switch (user.Role)
                {
                    case "Admin":
                        frmAdminHome adminHome = new frmAdminHome();
                        adminHome.Show();
                        break;
                    case "Member":
                        Members_Home_Menu member = new Members_Home_Menu();
                        member.Show();
                        break;
                    case "Coach":
                        frmschedule coach = new frmschedule();
                        coach.Show();
                        break;
                    case "Manager":
                        frmMain mg  = new frmMain();
                        mg.Show();
                        break;
                }
            }
            else MessageBox.Show("Login failed. Invalid username or password."); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }

        private void linkForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmReset frmReset = new frmReset(txtUserName.Text);
            frmReset.Show();
        }

        private void checkbox_CheckedChanged(object sender, EventArgs e)
        {         
            txtPassword.PasswordChar = cboxShow.Checked ? '\0' : '*'; // \0 = null char
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
