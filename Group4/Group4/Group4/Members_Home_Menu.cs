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
    public partial class Members_Home_Menu : Form
    {
        public Members_Home_Menu()
        {
            InitializeComponent();
        }

        private void btnCompetition_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            memberViewCompetitions competitions = new memberViewCompetitions();
            competitions.TopLevel = false;
            panel3.Controls.Add(competitions);
            competitions.Show();
        }

        private void btnPerformance_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            memberViewPerformance performance = new memberViewPerformance();
            performance.TopLevel = false;
            panel3.Controls.Add(performance);
            performance.Show();
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            memberViewSchedule schedule = new memberViewSchedule();
            schedule.TopLevel = false;
            panel3.Controls.Add(schedule);
            schedule.Show();
        }

        private void btnCourse_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            memberViewCourses course = new memberViewCourses();
            course.TopLevel = false;
            panel3.Controls.Add(course);
            course.Show();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            memberViewProfile profile = new memberViewProfile();
            profile.TopLevel = false;
            panel3.Controls.Add(profile);
            profile.Show();
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            memberSendFeedback feedback = new memberSendFeedback();
            feedback.TopLevel = false;
            panel3.Controls.Add(feedback);
            feedback.Show();
        }

        private void Members_Home_Menu_Load(object sender, EventArgs e)
        {

        }

        private void btnAdmExit_Click(object sender, EventArgs e)
        {
            CurrentUser.UserName = null;
            this.Close();
        }
    }
}
