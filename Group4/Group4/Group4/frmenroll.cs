using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group4
{
    public partial class frmenroll : Form
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
        public frmenroll()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserID.Text) || string.IsNullOrEmpty(txtPass.Text))
            {
                MessageBox.Show("Please fill in all the details ", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string role = "member";
                Enroll er = new Enroll(txtUserID.Text, role, txtPass.Text, gender(), txtBD.Text, txtPhone.Text, txtEmail.Text);
                er.submit();
                //Login lg = new Login();
                //lg.Show();
                this.Close();
            }
        }

        private string gender()
        {
            string gen = null;
            if (rbMale.Checked)
            {
                gen = "Male";
            }
            else if (rbFemale.Checked)
            {
                gen = "Female";
            }
            return gen;
        }

        private void frmenroll_Load(object sender, EventArgs e)
        {

        }
    }

    class Enroll
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
        private string userID;
        private string userRole;
        private string password;
        private string gender;
        private string birthDate;
        private string phone;
        private string email;

        public Enroll(string id, string role, string pass, string gd, string bd, string ph, string em)
        {
            userID = id;
            userRole = role;
            password = pass;
            gender = gd;
            birthDate = bd;
            phone = ph;
            email = em;

        }

        public string UserID { get => userID; set => userID = value; }
        public string UserRole { get => userRole; set => userRole = value; }
        public string Password { get => password; set => password = value; }
        public string Gender { get => gender; set => gender = value; }
        public string BirthDate { get => birthDate; set => birthDate = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }

        // submit details
        public void submit()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into UserTbl (UserID,UserRole,UserPass,Gender,BirthDate,Phone,Email) values (@id, @role,@ps,@gd,@bd,@ph,@em)", conn);
                cmd.Parameters.AddWithValue("@id", userID);
                cmd.Parameters.AddWithValue("@role", userRole);
                cmd.Parameters.AddWithValue("@ps", password);
                cmd.Parameters.AddWithValue("@gd", gender);
                cmd.Parameters.AddWithValue("@bd", birthDate);
                cmd.Parameters.AddWithValue("@ph", phone);
                cmd.Parameters.AddWithValue("@em", Email);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Register successfully");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
