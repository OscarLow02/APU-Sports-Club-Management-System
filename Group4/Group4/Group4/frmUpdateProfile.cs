//using admin;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group4
{
    public partial class frmUpdateProfile : Form
    {
        string currentUser;
        User user = new User();
        public frmUpdateProfile()
        {
            InitializeComponent();
            currentUser = CurrentUser.UserName;
        }

        private void frmUpdateProfile_Load(object sender, EventArgs e)
        {
            string currentUser = CurrentUser.UserName;
            user = user.GetProfile(currentUser);

            txtRole.Text = user.Role;
            txtRole2.Text = user.Role;
            txtUserID.Text = user.UserName;
            txtUserID2.Text = user.UserName;
            txtPassword.Text = user.UserPass;
            txtPassword2.Text = user.UserPass;
            rbtnMale.Checked = user.Gender == "Male";
            rbtnMale2.Checked = user.Gender == "Male";
            rbtnFemale.Checked = user.Gender == "Female";
            rbtnFemale2.Checked = user.Gender == "Female";
            dtDOB.Value = user.BirthDate;
            dtDOB2.Value = user.BirthDate;
            txtPhone.Text = user.Phone;
            txtPhone2.Text = user.Phone;
            txtEmail.Text = user.Email;
            txtEmail2.Text = user.Email;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                try
                {
                    User newProfile = new User(
                        userName: txtUserID.Text,
                        userPass: txtPassword.Text,
                        gender: rbtnMale.Checked ? "Male" : "Female",
                        birthDate: dtDOB.Value,
                        phone: txtPhone.Text,
                        email: txtEmail.Text
                        );

                    if (user.UpdateUser(newProfile))
                    {
                        User updated = user.GetProfile(currentUser);
                        if (updated != null)
                        {
                            MessageBox.Show("Update successful");
                            //if (updated.RoleID.StartsWith("AD")) tboxRoleID2.Text = "Admin";
                            txtRole2.Text = updated.Role;
                            txtUserID2.Text = updated.UserName;
                            txtPassword2.Text = updated.UserPass;
                            rbtnMale2.Checked = updated.Gender == "Male";
                            rbtnFemale2.Checked = updated.Gender == "Female";
                            dtDOB2.Value = updated.BirthDate;
                            txtPhone2.Text = updated.Phone;
                            txtEmail2.Text = updated.Email;
                            lblStatus.Text = "Updated :D";
                        }
                        else
                        {
                            MessageBox.Show("Failed to retrieve updated profile");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Update failed");
                        lblStatus.Text = "Failed :(";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("btnUpdate_Click Error: " + ex.Message);
                }
            }
        }
        private bool ValidateForm()
        {

            //username
            if (string.IsNullOrWhiteSpace(txtUserID.Text))
            {
                MessageBox.Show("Please enter user name.");
                return false;
            }
            //userpass
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please enter password.");
                return false;
            }
            //gender
            if (!rbtnFemale.Checked && !rbtnMale.Checked)
            {
                MessageBox.Show("Please select gender.");
                return false;
            }
            //phone
            if (txtPhone.Text.Length < 10 || !txtPhone.Text.All(char.IsDigit)) // _ --> discard
            {
                MessageBox.Show("Phone number must be at least 10 digits.");
                return false;
            }

            //email
            if (!txtEmail.Text.Contains("@") || !txtEmail.Text.Contains("."))
            {
                MessageBox.Show("Email must contain '@' and '.'");
                return false;
            }
            return true;
        }
    }
}
