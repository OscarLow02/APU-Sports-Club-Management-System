using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group4
{
    public partial class frmrecom : Form
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
        public frmrecom()
        {
            InitializeComponent();
            Size = new Size(900, 630);
        }

        private void lblSche_Click(object sender, EventArgs e)
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

        private void lblperforrm_Click(object sender, EventArgs e)
        {
            frmperform pf = new frmperform();
            pf.Show();
            this.Close();
        }

        private void lblUpdate_Click(object sender, EventArgs e)
        {
            frmupdate_coach ud = new frmupdate_coach();
            ud.Show();
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMemId.Clear();
            txtName.Clear();
            txtScore.Clear();
            txtSearch.Clear();
            CoachFunc coach = new CoachFunc();
            dataPerform.DataSource = coach.DisplayData("PerformanceTbl");
        }

        // display data into Data grid view
       

        private void dataPerform_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMemId.Text = dataPerform.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtName.Text = dataPerform.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtScore.Text = dataPerform.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void frmrecom_Load(object sender, EventArgs e)
        {
            CoachFunc coach = new CoachFunc();
            dataPerform.DataSource = coach.DisplayData("PerformanceTbl");
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            CoachFunc coach = new CoachFunc(txtMemId.Text, txtName.Text, Convert.ToInt32(txtScore.Text));
            coach.SendRecommendation();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            CoachFunc coach = new CoachFunc();
            DataTable result = coach.SearchData("PerformanceTbl", "id", "MemberID", txtSearch.Text.Trim());

            if (result.Rows.Count > 0)
            {
                dataPerform.DataSource = result;
            }
            else
            {
                MessageBox.Show("Member ID not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            CurrentUser.UserName = null;
            this.Close();
        }
    }
}
