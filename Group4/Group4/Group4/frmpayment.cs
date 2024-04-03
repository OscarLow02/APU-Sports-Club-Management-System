using System;
using System.Collections;
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
    public partial class frmpayment : Form
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
        public frmpayment()
        {
            InitializeComponent();
            Size = new Size(750, 590);
        }

        private void lblManage_Click(object sender, EventArgs e)
        {
            frmschedule sch = new frmschedule();
            sch.Show();
            this.Close();
        }

        private void lblRecom_Click(object sender, EventArgs e)
        {
            frmrecom rc = new frmrecom();
            rc.Show();
            this.Close();
        }

        private void lblUpdate_Click(object sender, EventArgs e)
        {
            frmupdate_coach up = new frmupdate_coach();
            up.Show();
            this.Close();
        }

        private void lblperform_Click(object sender, EventArgs e)
        {
            frmperform pf = new frmperform();
            pf.Show();
            this.Close();
        }
        private void frmpayment_Load(object sender, EventArgs e)
        {
            CoachFunc coach = new CoachFunc();
            dataPayment.DataSource = coach.DisplayData("memberPayments");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {      
            CoachFunc coach = new CoachFunc();
            DataTable result = coach.SearchData("memberPayments", "nm", "MemberName", txtSearch.Text.Trim());

            if (result.Rows.Count > 0)
            {
                dataPayment.DataSource = result;
            }
            else
            {
                MessageBox.Show("Member Name not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSearch.Clear();
                txtSearch.Focus();
            }
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
