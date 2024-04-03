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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Group4
{
    public partial class frmschedule : Form
    {
       
        static SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
        //public static string ID;
        string ID = CurrentUser.UserName;
        
        // Training level
        string[] level = new[] {"Beginner","Intermediate","Advanced" };
        string[] beginCou = new[] {"Basic techniques","Skills drills","Flexibility training","Stamina building","Conditioning exercises" };
        string[] interCou = new[] {"Tactical Training", "Agility drills", "Strength training" };
        string[] advCou = new[] {"Speed training","Focus enhancement","Advanced skills","Endurance workouts" };
        public frmschedule()
        {
            InitializeComponent();
            Size = new Size(1000, 650);
        }

        public frmschedule(string id)
        {
            InitializeComponent();
            ID = id;
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

        private void lblRecom_Click(object sender, EventArgs e)
        {
            frmrecom recom = new frmrecom();
            recom.Show();
            this.Close();
        }

        private void lblUpdate_Click(object sender, EventArgs e)
        {
            frmupdate_coach ud = new frmupdate_coach();
            ud.Show();
            this.Close();
        }

        private void displayData()
        {
            try
            {
                string query = $"select * from ScheduleTbl where CoachName = '{ID}' order by Date";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                conn.Close();
                dataSchedule.DataSource = dt;

            }
            catch (Exception ex) 
            { 
                MessageBox.Show("Error4: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         
        }

        private void Reset()
        {
            txtCoach.Clear();
            txtPhone.Clear();
            cmbLevel.Text = "";
            cmbCourse.Text = "";
            txtLocation.Clear();
            txtDate.Value = DateTime.Now;

            txtCoach.Focus();    // input focus on CoachName
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {      
            CoachFunc coach = new CoachFunc(txtCoach.Text, txtPhone.Text, cmbLevel.Text, cmbCourse.Text, txtDate.Value, txtTime.Value, txtLocation.Text);

            // Check if the mandatory fields are filled
            if (string.IsNullOrEmpty(txtCoach.Text) || string.IsNullOrEmpty(txtPhone.Text) || string.IsNullOrEmpty(txtLocation.Text))
            {
                MessageBox.Show("Please fill in all the details ", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            // Check if the selected date and time are already scheduled
            else if (coach.CheckDate() == "Failure")
            {
                MessageBox.Show("Courses have been scheduled for this period", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
            }
            // Prevent coach teaching another level at the same time
            else if (coach.CheckLevel() == "Failure")
            {
                MessageBox.Show("A coach can only teach one level", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            // If all checks pass, add the schedule to the table
            else
            {                
                coach.AddSchedule();
                displayData();               
            }                    
        }

        private void frmschedule_Load(object sender, EventArgs e)
        {          
            displayData();
            for (int i = 0; i < level.Length; i++)
            {
                cmbLevel.Items.Add(level[i]);
            }
            cmbLevel.SelectedIndex = 0;

            txtCoach.Text = ID;
        }

        private void cmbLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLevel.SelectedIndex == 0)
            {
                cmbCourse.Items.Clear();    
                for (int i = 0; i < beginCou.Length; i++)
                {
                    cmbCourse.Items.Add(beginCou[i]);
                }
            }
            else if (cmbLevel.SelectedIndex == 1)
            {
                cmbCourse.Items.Clear();
                for (int i = 0; i < interCou.Length; i++)
                {
                    cmbCourse.Items.Add(interCou[i]);
                }
            }
            else if (cmbLevel.SelectedIndex == 2)
            {
                cmbCourse.Items.Clear();
                for (int i = 0; i < advCou.Length; i++)
                {
                    cmbCourse.Items.Add(advCou[i]);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCoach.Text) || string.IsNullOrEmpty(txtPhone.Text) || string.IsNullOrEmpty(txtLocation.Text))
            {
                MessageBox.Show("Please fill in all the details ", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                CoachFunc coach = new CoachFunc(txtCoach.Text, txtPhone.Text, cmbLevel.Text, cmbCourse.Text, txtDate.Value, txtTime.Value, txtLocation.Text);
                coach.UpdateSchedule();
                displayData();
            }            
        }

        private void dataSchedule_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCoach.Text = dataSchedule.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtPhone.Text = dataSchedule.Rows[e.RowIndex].Cells[1].Value.ToString();
            cmbLevel.Text = dataSchedule.Rows[e.RowIndex].Cells[2].Value.ToString();
            cmbCourse.Text = dataSchedule.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtDate.Text = dataSchedule.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtTime.Text = dataSchedule.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtLocation.Text = dataSchedule.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            CoachFunc coach = new CoachFunc(txtCoach.Text, txtPhone.Text, cmbLevel.Text, cmbCourse.Text, txtDate.Value, txtTime.Value, txtLocation.Text);
            coach.DeleteSchedule();           
            displayData();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            CurrentUser.UserName = null;
            this.Close();
        }
    }             
}
