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
    public partial class frmIncome : Form
    {
        
        public frmIncome()
        {
            InitializeComponent();
            this.Size = new Size(800, 655);
        }
        Admin admin = new Admin();
        private void frmIncome_Load(object sender, EventArgs e)
        {
            
            dataView.DataSource = admin.GetData("memberPayments");
            dataView.Columns[0].HeaderText = "Payment ID";
            dataView.Columns[1].HeaderText = "Member Name";
            dataView.Columns[2].HeaderText = "Coach Name";
            dataView.Columns[3].HeaderText = "Level";
            dataView.Columns[4].HeaderText = "Amount";
            dataView.Columns[5].HeaderText = "Date";
            dataView.DefaultCellStyle.SelectionBackColor = Color.White;
            dataView.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataView.DefaultCellStyle.ForeColor = Color.Black;
            dataView.RowsDefaultCellStyle.BackColor = Color.FromArgb(247, 255, 243);
            dataView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 241);
            dataView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            DataTable month = admin.GetMonths();
            foreach (DataRow row in month.Rows)
            {
                cboxMonth.Items.Add(row["month"].ToString());
            }
            DataTable user = admin.GetUserName("coachName","memberPayments");
            foreach (DataRow row in user.Rows)
            {
                cboxCoach.Items.Add(row["coachName"].ToString());
            }
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

        private void lblCompetition_Click(object sender, EventArgs e)
        {
            frmCompetition frmCompetition = new frmCompetition();
            frmCompetition.Show();
            this.Close();
        }

        private void lblUpdate_Click(object sender, EventArgs e)
        {
            frmUpdate frmUpdate = new frmUpdate();
            frmUpdate.Show();
            this.Close();
        }

        private void cboxUser_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboxLevel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cboxMonth.SelectedIndex = -1;
            cboxCoach.SelectedIndex = -1;
            cboxLevel.SelectedIndex = -1;
            dataView.DataSource = admin.GetData("memberPayments");
        }

        private void dataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void cboxMonth_SelectedIndexChanged(object sender, EventArgs e)
        {  
        }


        private void btnApply_Click(object sender, EventArgs e)
        {
            string month = cboxMonth.SelectedIndex != -1 ? cboxMonth.SelectedItem.ToString() : "";
            string coach = cboxCoach.SelectedIndex != -1 ? cboxCoach.SelectedItem.ToString() : "";
            string level = cboxLevel.SelectedIndex != -1 ? cboxLevel.SelectedItem.ToString() : "";

            DataTable dt = admin.Filter(month, coach, level); //Clever!!👍 o.O
            dataView.DataSource = dt;
        }

        private void btnAdmExit_Click(object sender, EventArgs e)
        {
            CurrentUser.UserName = null;
            this.Close();
        }
    }
}
