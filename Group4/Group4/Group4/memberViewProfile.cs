using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace Group4
{
    public partial class memberViewProfile : Form
    {
        Member member;
        
        public memberViewProfile()
        {
            InitializeComponent();
        }

        private void memberViewProfile_Load(object sender, EventArgs e)
        {
            member = new Member();

            txtUserID.Text = member.userid;
            txtUserID2.Text = member.userid;
            txtPassword2.Text = member.password;

            if (member.Gender == "Male")
                btnMale2.Checked = true;
            else
                btnFemale2.Checked = true;

            birthdate2.Value = member.birthdate;

            txtPhone2.Text = member.phone;
            txtEmail2.Text = member.email;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Updating read-through only profile
            txtUserID2.Text = txtUserID.Text;
            txtPassword2.Text = txtPassword.Text;

            if (btnMale.Checked)
            {
                btnMale2.Checked = true;
                member.Gender = "Male";
            }
            else
            {
                btnFemale2.Checked = true;
                member.Gender = "Female";
            }

            birthdate2.Value = birthdate1.Value;

            txtPhone2.Text = txtPhone.Text;
            txtEmail2.Text = txtEmail.Text;


            ArrayList profileInfo = new ArrayList();
            profileInfo.Add(txtUserID.Text);
            profileInfo.Add(txtPassword.Text);
            profileInfo.Add(txtPhone.Text);
            profileInfo.Add(txtEmail.Text);
            profileInfo.Add(birthdate1.Value);

            // Updating class
            member.UpdateProfile(profileInfo);

            //to update in user table for admin
            User user = new User(
                userName: txtUserID.Text,
                userPass: txtPassword.Text,
                gender: member.Gender,
                birthDate: birthdate1.Value,
                phone: txtPhone.Text,
                email: txtEmail.Text
                );
            user.UpdateUser(user);

            foreach (Control control in panel1.Controls)
            {
                if (control is TextBox textBox && control.Name != "txtUserID")
                {
                    textBox.Clear();
                }
                else if (control is RadioButton radioButton)
                {
                    radioButton.Checked = false;
                }
            }

        }


    }
}
