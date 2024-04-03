using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Group4
{
    public partial class frmAdminHome : Form
    {
        
       
        Admin admin = new Admin();
        public frmAdminHome()
        {
            InitializeComponent();
            Size = new Size(1200, 700);

            dataUser.CellClick += dataUser_CellClick; //subcribe to cellclick event 
            
        }

        private void frmAdminHome_Load(object sender, EventArgs e)
        {
            //Size = new Size(1200, 700);
            //this.Size = new Size(10, 70);
            dateBirth.Value = DateTime.Now;
            
            lblSalary.Visible = false;
            lblLevel.Visible = false;
            tboxSalary.Visible = false;
            cboxLevel.Visible = false;
            
            dataUser.DataSource = admin.GetData("User");
            dataUser.Columns[0].HeaderText = "User Name";
            dataUser.Columns[1].HeaderText = "Password";
            dataUser.Columns[2].HeaderText = "Role";
            dataUser.Columns[3].HeaderText = "Gender";
            dataUser.Columns[4].HeaderText = "Date of Birth";
            dataUser.Columns[5].HeaderText = "Phone";
            dataUser.Columns[6].HeaderText = "Email";
            dataUser.Columns[7].HeaderText = "Salary";
            dataUser.Columns[8].HeaderText = "Level";

            dataUser.ColumnHeadersDefaultCellStyle.BackColor = Color.Blue;
            dataUser.DefaultCellStyle.SelectionBackColor = Color.White;
            dataUser.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataUser.RowsDefaultCellStyle.BackColor = Color.FromArgb(247, 255, 243);
            dataUser.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 241);
            dataUser.AutoResizeColumns();

            //placeholder
            InitializePlaceholder(tboxEmail, "example@gmail.com");
            InitializePlaceholder(tboxPhone, "0123456789");
           
        }

        private void lblSuggestion_Click_1(object sender, EventArgs e)
        {
            frmSuggestion frmSuggestion = new frmSuggestion();
            frmSuggestion.Show();
            this.Close();
        }

        private void lblIncome_Click_1(object sender, EventArgs e)
        {
            frmIncome frmIncome = new frmIncome();
            frmIncome.Show();
            this.Close();
        }

        private void lblCompetition_Click_1(object sender, EventArgs e)
        {
            frmCompetition frmCompetition = new frmCompetition();
            frmCompetition.Show();
            this.Close();
        }

        private void lblUpdate_Click_1(object sender, EventArgs e)
        {
            frmUpdate frmUpdate = new frmUpdate();
            frmUpdate.Show();
            this.Close();
        }

        private void cboxRole_SelectedIndexChanged_1(object sender, EventArgs e)
        {
           
            if (cboxRole.SelectedItem != null)
            {
                bool isCoach = (cboxRole.SelectedItem.ToString() == "Coach");

                lblSalary.Visible = isCoach;
                lblLevel.Visible = isCoach;
                tboxSalary.Visible = isCoach;
                cboxLevel.Visible = isCoach;
                InitializePlaceholder(tboxSalary, "2000");
            }
            else
            {
                lblSalary.Visible = false;
                lblLevel.Visible = false;
                tboxSalary.Visible = false;
                cboxLevel.Visible = false;
                tboxSalary.Clear();
            }

            
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                double salary = 0;
                string level = "";
                if (cboxRole.SelectedItem.ToString() == "Coach") //cboxRole.SelectedItem -> object
                {
                    salary = Double.Parse(tboxSalary.Text);
                    level = cboxLevel.Text;
                }
                // Create a new User object full constructor
                User user = new User(
                    userName: tboxUserID.Text,
                    userPass: tboxPassword.Text,
                    role: cboxRole.Text,
                    gender: rdMale.Checked ? "Male" : "Female",
                    birthDate: dateBirth.Value,
                    phone: tboxPhone.Text,
                    email: tboxEmail.Text,
                    salary: salary,
                    level: level
                );
                frmSecurity frmSecurity = new frmSecurity(tboxUserID.Text);
                frmSecurity.ShowDialog(); //to add security questions
                if (frmSecurity.SecurityInfoSaved)
                {
                    if (admin.AddUser(user))
                    {
                        MessageBox.Show("Successfully added.");
                        ClearForm();
                        dataUser.DataSource = admin.GetData("User"); //refresh data
                    }
                    else MessageBox.Show("Error adding user.");  
                }
                else MessageBox.Show("Error adding security questions");
            }          
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                try
                {
                   
                    string selectedUserName = tboxUserID.Text; 
                    double salary = cboxRole.Text == "Coach" ? Double.Parse(tboxSalary.Text) : 0;
                    string level = cboxRole.Text == "Coach" ? cboxLevel.Text : "";

                   
                    User userToUpdate = new User(
                        userName: selectedUserName,
                        userPass: tboxPassword.Text,
                        role: cboxRole.Text, 
                        gender: rdMale.Checked ? "Male" : "Female",
                        birthDate: dateBirth.Value,
                        phone: tboxPhone.Text,
                        email: tboxEmail.Text,
                        salary: salary,
                        level: level
                    );

                    // Update the user in the database

                    try
                    {
                        if (admin.UpdateUser(userToUpdate))
                        {
                            MessageBox.Show("User successfully updated.");
                            ClearForm();
                            
                            dataUser.DataSource = admin.GetData("User");
                            tboxUserID.Enabled = true;
                            btnAdd.Enabled = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error updating user: {ex.Message}");
                    }
                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating user: {ex.Message}");
                }


            }


        }

        private void dataUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataUser.Rows[e.RowIndex];

               
                string userName = selectedRow.Cells[0].Value.ToString();
                string userPass = selectedRow.Cells[1].Value.ToString();
                string role = selectedRow.Cells[2].Value.ToString();
                string gender = selectedRow.Cells[3].Value.ToString();
                DateTime birthday = DateTime.Parse(selectedRow.Cells[4].Value.ToString());
                string phone = selectedRow.Cells[5].Value.ToString();
                string email = selectedRow.Cells[6].Value.ToString();
                string salary = selectedRow.Cells[7].Value.ToString();
                string level = selectedRow.Cells[8].Value.ToString();
           
                // Update textboxes
                tboxUserID.Text = userName;
                tboxPassword.Text = userPass;
                cboxRole.Text = role;
                rdMale.Checked = (gender == "Male");
                rdFemale.Checked = (gender == "Female");
                dateBirth.Value = birthday;
                tboxPhone.Text = phone;
                tboxEmail.Text = email;
                tboxSalary.Text = salary;
                cboxLevel.Text = level;
                tboxUserID.Enabled = false;
                tboxPhone.ForeColor = Color.Black;
                tboxEmail.ForeColor = Color.Black;
                tboxSalary.ForeColor = Color.Black;

                btnAdd.Enabled = false;
            }
        }
        

        private void btnDelete_Click(object sender, EventArgs e)
        {
            double salary = cboxRole.Text == "Coach" ? Double.Parse(tboxSalary.Text) : 0;
            string level = cboxRole.Text == "Coach" ? cboxLevel.Text : "";
            User userToDelete = new User(
                        userName: tboxUserID.Text,
                        userPass: tboxPassword.Text,
                        role: cboxRole.Text,
                        gender: rdMale.Checked ? "Male" : "Female",
                        birthDate: dateBirth.Value,
                        phone: tboxPhone.Text,
                        email: tboxEmail.Text,
                        salary: salary,
                        level: level
                    );

            if (admin.DeleteUser(userToDelete)) 
            {
                MessageBox.Show("User successfully deleted.");
                ClearForm();
                btnAdd.Enabled = true;
                dataUser.DataSource = admin.GetData("User");
            }
            else
            {
                MessageBox.Show("Failed to delete user.");
            }
           
        }

        

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        private void ClearForm()
        {
            cboxRole.SelectedIndex = -1;
            tboxUserID.Clear();
            tboxPassword.Clear();
            rdMale.Checked = false;
            rdFemale.Checked = false;
            dateBirth.Value = DateTime.Today;
            tboxPhone.Clear();
            tboxEmail.Clear();
            if (tboxSalary != null) tboxSalary.Clear();
            if (cboxLevel != null) cboxLevel.SelectedIndex = -1;
            tboxUserID.Enabled = true;
            //placeholder
            InitializePlaceholder(tboxEmail, "example@gmail.com");
            InitializePlaceholder(tboxPhone, "0123456789");
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
            btnAdd.Enabled = true;
        }

        private void dateBirth_ValueChanged(object sender, EventArgs e)
        {

        }

        private bool ValidateForm()
        {
            // role
            if (cboxRole.SelectedIndex == -1)
            {
                MessageBox.Show("Please select role.");
                return false;
            }
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
            //phone placeholder
            if (tboxPhone.Text == tboxPhone.Tag.ToString())
            {
                MessageBox.Show("Please enter phone number.");
                return false;
            }
            //email
            if ( !tboxEmail.Text.Contains("@") || !tboxEmail.Text.Contains("."))
            {
                MessageBox.Show("Email must contain '@' and '.'");
                return false;
            }
            //try
            //{
            //    var addr = new System.Net.Mail.MailAddress(tboxEmail.Text);
            //    if (addr.Address != tboxEmail.Text)
            //    {
            //        MessageBox.Show("Enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        return false;
            //    }
            //}
            //catch
            //{
            //    MessageBox.Show("Enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return false;
            //}
            //email placeholder
            if (tboxEmail.Text == tboxEmail.Tag.ToString())
            {
                MessageBox.Show("Please enter email.");
                return false;
            }
            //salary
            if (cboxRole.SelectedText == "Coach" )
            {
                if (string.IsNullOrEmpty(tboxSalary.Text) || double.TryParse(tboxSalary.Text, out _))
                {
                    MessageBox.Show("Please enter salary.");
                    return false;
                }
            }
            //level
            if(cboxRole.SelectedText == "Coach" && cboxLevel.SelectedIndex == -1)
            {
                MessageBox.Show("Please enter level.");
                return false;
            }
            return true;
        }

        private void InitializePlaceholder(TextBox tbox, string placeholder)
        {
            tbox.Tag = placeholder; //tag is like a variable/storage that is tied to tbox
            SetPlaceholder(tbox, null);

            //enter & leave event handlers
            tbox.Enter += RemovePlaceholder;
            tbox.Leave += SetPlaceholder;
        }

        private void RemovePlaceholder (object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text == tb.Tag.ToString() && tb.ForeColor == SystemColors.GrayText)
            {
                tb.Text = "";
                tb.ForeColor = SystemColors.WindowText;
            }
        }

        private void SetPlaceholder (object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (string.IsNullOrEmpty (tb.Text) )
            {
                tb.Text = tb.Tag.ToString();
                tb.ForeColor = SystemColors.GrayText;
            }
        }

        private void btnAdmExit_Click(object sender, EventArgs e)
        {
            CurrentUser.UserName = null;
            this.Close();
           

        }
    }
}
