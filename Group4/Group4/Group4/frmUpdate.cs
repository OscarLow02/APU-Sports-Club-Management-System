using System;
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
    public partial class frmUpdate : Form
    {
        string currentUser;
        User user =  new User();
        public frmUpdate()
        {
            InitializeComponent();
            this.Size = new Size(800, 655);
            currentUser = CurrentUser.UserName;
            
        }

        private void frmUpdate_Load(object sender, EventArgs e)
        {           
            string currentUser = CurrentUser.UserName;
            user = user.GetProfile(currentUser);
            
            tboxRoleID.Text = user.Role;
            tboxUserID.Text = user.UserName;
            tboxPassword.Text = user.UserPass;
            rdMale.Checked = user.Gender == "Male";
            rdFemale.Checked = user.Gender == "Female";
            dateBirth.Value = user.BirthDate;
            tboxPhone.Text = user.Phone;
            tboxEmail.Text = user.Email;

        }

        private void lblManage_Click(object sender, EventArgs e)
        {
            frmAdminHome frmAdminHome = new frmAdminHome();
            frmAdminHome.Show();
            this.Close();
        }

        private void lblSuggestion_Click(object sender, EventArgs e)
        {
            frmSuggestion frmSuggestion = new frmSuggestion();
            frmSuggestion.Show();
            this.Close();
        }

        private void lblIncome_Click(object sender, EventArgs e)
        {
            frmIncome frmIncome = new frmIncome();
            frmIncome.Show();
            this.Close();
        }

        private void lblCompetition_Click(object sender, EventArgs e)
        {
            frmCompetition frmCompetition = new frmCompetition();
            frmCompetition.Show();
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                try
                {
                    User newProfile = new User(
                        userName: tboxUserID.Text,
                        userPass: tboxPassword.Text,
                        gender: rdMale.Checked ? "Male" : "Female",
                        birthDate: dateBirth.Value,
                        phone: tboxPhone.Text,
                        email: tboxEmail.Text
                        );

                    if (user.UpdateUser(newProfile))
                    {
                        User updated = user.GetProfile(currentUser);
                        if (updated != null)
                        {
                            MessageBox.Show("Update successful");
                            //if (updated.RoleID.StartsWith("AD")) tboxRoleID2.Text = "Admin";
                            tboxRoleID2.Text = updated.Role;
                            tboxUserID2.Text = updated.UserName;
                            tboxPassword2.Text = updated.UserPass;
                            rdMale2.Checked = updated.Gender == "Male";
                            rdFemale2.Checked = updated.Gender == "Female";
                            dateBirth2.Value = updated.BirthDate;
                            tboxPhone2.Text = updated.Phone;
                            tboxEmail2.Text = updated.Email;
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

        private void btnAdmExit_Click(object sender, EventArgs e)
        {
            CurrentUser.UserName = null;
            this.Close();
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private bool ValidateForm()
        {
            
            //username
            if (string.IsNullOrWhiteSpace(tboxUserID.Text))
            {
                MessageBox.Show("Please enter user name.");
                return false;
            }
            //userpass
            if (string.IsNullOrWhiteSpace(tboxPassword.Text))
            {
                MessageBox.Show("Please enter password.");
                return false;
            }
            //gender
            if (!rdFemale.Checked && !rdMale.Checked)
            {
                MessageBox.Show("Please select gender.");
                return false;
            }
            //phone
            if (tboxPhone.Text.Length < 10 || !tboxPhone.Text.All(char.IsDigit)) // _ --> discard
            {
                MessageBox.Show("Phone number must be at least 10 digits.");
                return false;
            }
            
            //email
            if (!tboxEmail.Text.Contains("@") || !tboxEmail.Text.Contains("."))
            {
                MessageBox.Show("Email must contain '@' and '.'");
                return false;
            }       
            return true;
        }
    }
}
