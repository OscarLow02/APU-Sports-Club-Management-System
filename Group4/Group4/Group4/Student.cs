using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group4
{
    public class Student
    {
        //member fields
        private int StudentID;
        private string StudentName;

        public Student(int studentId, string studentName)
        {
            StudentID = studentId;
            StudentName = studentName;
        }
        public Student(int studentId, string studentName, decimal score)
        {
            StudentID = studentId;
            StudentName = studentName;
        }
        public int StudentID1 { get => StudentID; set => StudentID = value; }
        public string StudentName1 { get => StudentName; set => StudentName = value; }

        public static List<Student> ViewAll()
        {
            List<Student> students = new List<Student>();

            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString()))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Student", con);

                    SqlDataReader rd = cmd.ExecuteReader();

                    while (rd.Read())
                    {
                        int studentId = rd.GetInt32(0);
                        string studentName = rd.GetString(1);

                        // Since there's no competition_id in the student table, all students are included
                        Student student = new Student(studentId, studentName);
                        students.Add(student);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving students: " + ex.Message);
            }

            return students;
        }
        //get student by ID
        public static Student GetStudentByID(int studentId)
        {
            Student student = null;
            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString()))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Student WHERE student_id = @student_id", con);
                    cmd.Parameters.AddWithValue("@student_id", studentId);

                    SqlDataReader rd = cmd.ExecuteReader();

                    if (rd.Read())
                    {
                        int StudentID = rd.GetInt32(0);
                        string StudentName = rd.GetString(1);
                        student = new Student(StudentID, StudentName);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving student: " + ex.Message);
            }
            return student;
        }   
    }
}
