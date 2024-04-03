using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Group4
{
    public partial class frmupdate_coach : Form
    {
        //public static string ID;

        string ID = CurrentUser.UserName;

        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
        public frmupdate_coach()
        {
            InitializeComponent();
            Size = new Size(840, 630);
        }

        public frmupdate_coach(string id)
        {
            InitializeComponent();
            ID = id;
            ID = CurrentUser.UserName;
        }

        private void lblManage_Click(object sender, EventArgs e)
        {
            frmschedule sch = new frmschedule();
            sch.Show();
            this.Close();    
        }

        private void lblPay_Click(object sender, EventArgs e)
        {
            frmpayment pay = new frmpayment();
            pay.Show();
            this.Close();
        }

        private void lblperform_Click(object sender, EventArgs e)
        {
            frmperform pf = new frmperform();
            pf.Show();
            this.Close();
        }

        private void lblRecom_Click(object sender, EventArgs e)
        {
            frmrecom rc = new frmrecom();
            rc.Show();
            this.Close();
        }

       
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserID.Text) || string.IsNullOrEmpty(txtUserPass.Text))
            {
                MessageBox.Show("Please fill in all the details ", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Profile pf = new Profile(txtUserID.Text, txtUserRole.Text, txtUserPass.Text, gender(), txtBDate.Value, txtPhone.Text, txtEmail.Text);
                pf.update();
                userData();
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
        private void frmupdate_Load(object sender, EventArgs e)
        {
            Profile pf = new Profile(ID);

            //calling static method
            Profile.viewProfile(pf);


            //data can be modified
            txtUserID.Text = ID.ToString();
            txtUserRole.Text = pf.UserRole;
            txtUserPass.Text = pf.Password;
            txtBDate.Value = pf.BirthDate;
            txtPhone.Text = pf.Phone;
            txtEmail.Text = pf.Email;

            userData();
            
        }

        private void userData()  // data for read-only
        {
            Profile pf = new Profile(ID);

            //calling static method
            Profile.viewProfile(pf);

            txtUserID2.Text = ID.ToString();
            txtUserRole2.Text = pf.UserRole;
            txtUserPass2.Text = pf.Password;
            txtGender2.Text = pf.Gender;
            txtBDate2.Value = pf.BirthDate;
            txtPhone2.Text = pf.Phone;
            txtEmail2.Text = pf.Email;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            CurrentUser.UserName = null;
            this.Close();   
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
