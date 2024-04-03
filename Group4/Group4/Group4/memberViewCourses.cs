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
    public partial class memberViewCourses : Form
    {
        Member member = new Member();
        public bool enrolled;
        private string course;

        public memberViewCourses()
        {
            InitializeComponent();
        }

        private void memberViewCourses_Load(object sender, EventArgs e)
        {
            {
                (string, bool) courseInfo;

                courseInfo = member.GetCourse();
                lblEnrol.Text = courseInfo.Item1;
                enrolled = courseInfo.Item2;
              
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (enrolled)
            {
                memberViewCoursesPayment courses_Payment = new memberViewCoursesPayment();
                courses_Payment.ShowDialog();

            }
            else
                MessageBox.Show("You are not enrolled in a course yet.");
        }

        private void btnEnrol_Click(object sender, EventArgs e)
        {
       

            if (enrolled == false && lstCourses.SelectedIndex >= 0)
            {

                enrolled = true;

                if (lstCourses.SelectedIndex == 0)
                {
                    lblEnrol.Text = $"You are enrolled in Beginner Course";
                    member.course = "Beginner";
                }
                else if (lstCourses.SelectedIndex == 1)
                {
                    lblEnrol.Text = $"You are enrolled in Intermediate Course";
                    member.course = "Intermediate";
                }
                else if (lstCourses.SelectedIndex == 2)
                {
                    lblEnrol.Text = $"You are enrolled in Advance Course";
                    member.course = "Advance";
                }

                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString()))
                {
                    connection.Open();

                    string query = "UPDATE Member SET Course = @new WHERE UserID=@a";


                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@new", member.course);
                        command.Parameters.AddWithValue("@a", member.userid);

                        command.ExecuteNonQuery();
                    }
                }
            }
            else if (enrolled)
                MessageBox.Show("You are already enrolled in a course.");
            else if (lstCourses.SelectedIndex < 0)
                MessageBox.Show("Please select a course.");




        }

        private void btnUnenrol_Click(object sender, EventArgs e)
        {
            if (enrolled == true)
            {
                MessageBox.Show("You have unenrolled.");
                lblEnrol.Text = "You are not enrolled in any course.";
                enrolled = false;
                member.course = null;

                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString()))
                {
                    string query = "UPDATE Member SET Course = @new WHERE UserID=@a";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@new", "No Course");
                        command.Parameters.AddWithValue("@a", member.userid);

                        connection.Open();
                        command.ExecuteNonQuery();
                    }

                }

            }
            else
                MessageBox.Show("You have not enrolled in any course!");
        }

    }
}
