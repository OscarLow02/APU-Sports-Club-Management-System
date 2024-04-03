using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group4
{
    public partial class frmSuggestion : Form
    {
        private DateTime orgMinDate;
        private DateTime orgMaxDate;
        private bool IsUpdatingDate = false;
        Admin admin = new Admin();
        public frmSuggestion()
        {
            InitializeComponent();
            
            this.Size = new Size(800, 655);
            this.Size = new Size(1600, 1255);
            this.Size = new Size(1200, 800);
            this.Size = new Size(800, 655);
            Size = new Size(800, 655);

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void frmSuggestion_Load(object sender, EventArgs e)
        {
            
            dataView.DataSource = admin.GetData("memberFeedback"); //table name
            dataView.Columns[0].HeaderText = "User Name";
            dataView.Columns[1].HeaderText = "Suggestion";
            dataView.Columns[2].HeaderText = "Date";
            dataView.DefaultCellStyle.SelectionBackColor = Color.White;
            dataView.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataView.DefaultCellStyle.ForeColor = Color.Black;
            dataView.RowsDefaultCellStyle.BackColor = Color.FromArgb(247, 255, 243);
            dataView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 241);
            dataView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dataView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //dataView.AutoResizeColumns();
            dataView.Columns[1].Width = 410;
            bool TooLong = false;
            foreach (DataGridViewRow row in dataView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().Length > 70)
                    {
                        TooLong = true;
                        break;
                    }
                    
                }
            }
            if (TooLong) dataView.AutoResizeColumns();

            //user combobox
            
            //DataTable dt = admin.GetUserName("UserID","memberFeedback");
            //foreach (DataRow row in dt.Rows)
            //{
            //    cboxUser.Items.Add(row["UserID"].ToString());
            //}

            orgMinDate = admin.GetMinDate();
            orgMaxDate = admin.GetMaxDate();

            dateStart.MinDate = orgMinDate;
            dateEnd.MinDate = orgMinDate;
            dateStart.Value = orgMinDate;

            dateEnd.MaxDate = orgMaxDate;
            dateStart.MaxDate = orgMaxDate;
            dateEnd.Value = orgMaxDate;

            
        }

        private void lblManage_Click(object sender, EventArgs e)
        {
            frmAdminHome adminHome = new frmAdminHome();
            adminHome.Show();
            this.Close();

        }

        private void lblIncome_Click(object sender, EventArgs e)
        {
            frmIncome income = new frmIncome();
            income.Show();
            this.Close();
        }

        private void lblCompetition_Click(object sender, EventArgs e)
        {
            frmCompetition competition = new frmCompetition();
            competition.Show();
            this.Close();
        }

        private void lblUpdate_Click(object sender, EventArgs e)
        {
            frmUpdate update = new frmUpdate();
            update.Show();
            this.Close();
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateStart_ValueChanged(object sender, EventArgs e)
        {
            if (!IsUpdatingDate) // Only update the data and ComboBox if the user changed the date
            {
                DateTime startDate = dateStart.Value; //start of the day 00:00
                DateTime endDate = dateEnd.Value.AddHours(23).AddMinutes(59).AddSeconds(59); // end 11:59
                FilterDate(startDate, endDate);
                dateEnd.MinDate = startDate; // prevent selecting end date that is before start date
            }
         

        }

        private void dateEnd_ValueChanged(object sender, EventArgs e)
        {
            if (!IsUpdatingDate)
            {
                DateTime startDate = dateStart.Value; //start of the day 00:00
                DateTime endDate = dateEnd.Value.AddHours(23).AddMinutes(59).AddSeconds(59); // end 11:59
                FilterDate(startDate, endDate);
            }
            
        }
        private void cboxUser_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (cboxUser.SelectedIndex != -1)
            {
                IsUpdatingDate = true;  // Set the flag to true
                string userName = cboxUser.Text;
                FilterUser(userName);
                
                DateTime userMinDate = admin.GetMinDateByUser(userName);
                DateTime userMaxDate = admin.GetMaxDateByUser(userName);

                // Set the MaxDate to the maximum possible value to prevent error setting min date
                dateStart.MaxDate = DateTimePicker.MaximumDateTime;
                dateEnd.MaxDate = DateTimePicker.MaximumDateTime;

                dateStart.MinDate = userMinDate;
                dateEnd.MinDate = userMinDate;

                dateStart.MaxDate = userMaxDate;
                dateEnd.MaxDate = userMaxDate;

                dateStart.Value = dateStart.MinDate;
                dateEnd.Value = dateEnd.MaxDate;

                IsUpdatingDate = false;
            }
            if (cboxUser.SelectedIndex == -1)
            {
                // dbHelper dbHelper = new dbHelper();
                dataView.DataSource = admin.GetData("memberFeedback");
            }


        }

        private void FilterDate(DateTime startDate, DateTime endDate)
        {
           
           dataView.DataSource = admin.WithinDate(startDate, endDate);
            // Update the ComboBox with the users who have suggestions within the selected date range
            //cboxUser.DataSource = dbHelper.GetUserByDate(startDate, endDate);
            if (cboxUser.SelectedIndex != -1)
            {
                string userName = cboxUser.Text;
                dataView.DataSource = admin.UserFilterWithinDate(userName, startDate, endDate);
            }
            if (cboxUser.SelectedIndex == -1)
            {
                cboxUser.Items.Clear(); // to clear the original data
                DataTable dt = admin.WithinDate(startDate, endDate);
                DataTable dt2 = admin.GetUserByDate(startDate, endDate);
                foreach (DataRow row in dt2.Rows)
                {
                    cboxUser.Items.Add(row["UserID"].ToString());
                }

            }

        }

        private void FilterUser (string userName)
        {
           
            dataView.DataSource = admin.UserFilter("memberFeedback",userName);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dateStart.MaxDate = orgMaxDate;
            dateEnd.MaxDate = orgMaxDate;

            dateStart.MinDate = orgMinDate;
            dateEnd.MinDate = orgMinDate;

            dateStart.Value = orgMinDate;
            dateEnd.MinDate = orgMinDate;

            cboxUser.SelectedIndex = -1;
        }

        private void btnAdmExit_Click(object sender, EventArgs e)
        {
            CurrentUser.UserName = null;
            this.Close();
        }
    }
}
