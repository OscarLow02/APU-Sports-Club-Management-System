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
    public partial class frmperform : Form
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
        public frmperform()
        {
            InitializeComponent();
            Size = new Size(900, 630);
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
        private void lblUpdate_Click(object sender, EventArgs e)
        {
            frmupdate_coach up = new frmupdate_coach();
            up.Show();
            this.Close();
        }
        private void lblRecom_Click(object sender, EventArgs e)
        {
            frmrecom rc = new frmrecom();
            rc.Show();
            this.Close();
        }
        

        private void Reset()
        {
            txtMemID.Clear();
            txtName.Clear();
            txtScore.Value = 0;
            rtxtDescription.Clear();

            txtMemID.Focus();
        }

        private void frmperform_Load(object sender, EventArgs e)
        {
            CoachFunc coach = new CoachFunc();
            dataPerformance.DataSource = coach.DisplayData("PerformanceTbl");
        }

        private void dataPerformance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMemID.Text = dataPerformance.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtName.Text = dataPerformance.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtScore.Value = Convert.ToDecimal(dataPerformance.Rows[e.RowIndex].Cells[2].Value);
            txtDate.Text = dataPerformance.Rows[e.RowIndex].Cells[3].Value.ToString();
            rtxtDescription.Text = dataPerformance.Rows[e.RowIndex].Cells[4].Value.ToString();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtMemID.Text))
            {
                MessageBox.Show("Please enter member's ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CoachFunc coach = new CoachFunc(txtMemID.Text, txtName.Text, txtScore.Value, txtDate.Value, rtxtDescription.Text);
                coach.AddPerform();
                dataPerformance.DataSource = coach.DisplayData("PerformanceTbl");
                Reset();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMemID.Text))
            {
                MessageBox.Show("Please enter member's ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CoachFunc coach = new CoachFunc(txtMemID.Text, txtName.Text, txtScore.Value, txtDate.Value, rtxtDescription.Text);
                coach.UpdatePerform();
                dataPerformance.DataSource = coach.DisplayData("PerformanceTbl");
                Reset();               
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
