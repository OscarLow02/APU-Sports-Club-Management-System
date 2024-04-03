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
    public partial class frmViewStudent : Form
    {
        public frmViewStudent()
        {
            InitializeComponent();
        }

        private void frmViewStudent_Load(object sender, EventArgs e)
        {
            List<Student> students = new List<Student>();
            //call static method --> className.method
            students = Student.ViewAll();
            foreach (Student studentList in students)
            {
                //create a new ListViewItem
                ListViewItem column = new ListViewItem();

                //set the student_id and name to columns
                column.Text = studentList.StudentID1.ToString();
                column.SubItems.Add(studentList.StudentName1);

                //add the items to the list view
                lstStudent.Items.Add(column);
            }
        }
    }
}
