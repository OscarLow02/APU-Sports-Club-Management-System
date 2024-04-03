using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Group4
{
    public partial class CompetitionDetailsForm : Form
    {

        public CompetitionDetailsForm(int id, string name, DateTime datetime, string venue)
        {
            InitializeComponent();
            lblCompetitionID.Text = id.ToString();
            lblCompetitionName.Text = name;
            lblDateTime.Text = datetime.ToString();
            lblVenue.Text = venue;

            //assign values to the cmbID combobox
            List<Student> student = Student.ViewAll();
            foreach (Student s in student)
            {
                cmbID.Items.Add(s.StudentID1);
            }
            // Call method to load competition details based on ID
            LoadCompetitionDetails(id);
            LoadRecommendations();
        }
        private void cmbID_SelectedIndexChanged(object sender, EventArgs e)
        {
            //retrieve the selected ID from the combobox
            int selectedID = Convert.ToInt32(cmbID.SelectedItem);

            // Fetch the corresponding Competition object from the database
            Student selectedStudent = Student.GetStudentByID(selectedID);

            // Display the competition name in the label
            lblName.Text = selectedStudent.StudentName1;
        }
        private void btnEnroll_Click(object sender, EventArgs e)
        {
            try
            {
                // Retrieve the selected Competition ID and StudentID
                int competitionId = Convert.ToInt32(lblCompetitionID.Text);
                int studentId = Convert.ToInt32(cmbID.SelectedItem);

                // Create an instance of Competition with the competition ID and student object
                Competition enrollment = new Competition(competitionId);
                
                //Enroll the student in the competition
                string message = enrollment.EnrollStudent(studentId);
                MessageBox.Show(message);

                //Refresh the ListView
                RefreshCompetitionListView(competitionId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error recording competition result: " + ex.Message);
            }
        }
        private void LoadCompetitionDetails(int competitionId)
        {
            // Retrieve student details for the specified competition
            ArrayList studentDetails = Competition.ViewCompetitionDetails(competitionId);

            // Populate lstCompDetails ListView
            foreach (object[] studentDetail in studentDetails)
            {
                ListViewItem item = new ListViewItem(studentDetail[0].ToString()); // student_id
                item.SubItems.Add(studentDetail[1].ToString()); // student_name
                lstStudent.Items.Add(item);
            }
        }

        //load the recommendations from Coach
        private void LoadRecommendations()
        {
            Admin admin = new Admin();
            DataTable dt = admin.GetData("RecomTbl");
            // Iterate through each row in the DataTable
            foreach (DataRow row in dt.Rows)
            {
                // Create a new ListViewItem to represent the row
                ListViewItem item = new ListViewItem(row["MemberID"].ToString());

                // Add sub-items for the remaining columns
                item.SubItems.Add(row["MemberName"].ToString());
                item.SubItems.Add(row["Score"].ToString());

                // Add the ListViewItem to the ListView
                lstRecom.Items.Add(item);
            }
        }
        private void RefreshCompetitionListView(int id)
        {
            // Assuming you have a method to repopulate the lstCompetition ListView
            lstStudent.Items.Clear(); // Clear existing items
            LoadCompetitionDetails(id);
        }
    }
}
