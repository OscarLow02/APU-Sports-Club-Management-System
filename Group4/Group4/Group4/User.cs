using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Group4
{
    internal class User
    {
        private string connString = ConfigurationManager.ConnectionStrings["myCS"].ConnectionString;

        // Properties
        public string UserName { get; set; }
        public string UserPass { get; set; }
        public string Role { get; set; }
        public string Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public double Salary { get; set; } // coach
        public string Level { get; set; }  // coach


        // Constructors
        public User() 
        {
        }

        public User(string userName, string userPass) // for login
        {
            UserName = userName;
            UserPass = userPass;
        }
        public User(string userName, string userPass, string role,
                    string gender, DateTime birthDate, string phone, string email,
                    double salary, string level) // add user
        {
           
            UserName = userName;
            UserPass = userPass;
            Role = role;
            Gender = gender;
            BirthDate = birthDate;
            Phone = phone;
            Email = email;
            Salary = salary;
            Level = level;
        }
        public User(string userName, string userPass,
                    string gender, DateTime birthDate, string phone, string email) // for update
        {
            UserName = userName;
            UserPass = userPass;
            Gender = gender;
            BirthDate = birthDate;
            Phone = phone;
            Email = email;
            Salary = 0;
            Level = "";
        }

        //private string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\U S E R\\Desktop\\oop\\admin\\admin\\admin_database.mdf\";Integrated Security=True";
        public bool AuthenticateUser(User user)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT TOP 1 role FROM [User] 
                                    WHERE userName = @userName COLLATE SQL_Latin1_General_CP1_CS_AS    
                                    AND userPass = @userPass COLLATE SQL_Latin1_General_CP1_CS_AS ";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@userName", user.UserName);
                        cmd.Parameters.AddWithValue("@userPass", user.UserPass);
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            user.Role = reader["role"].ToString();
                            return true;
                        }
                        else return false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                    return false;
                }
            }
        }
        public string[] GetSecurity(string un) //get questions
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string query = "SELECT question1, question2 FROM [Security] WHERE userName = @userName";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userName", un);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        string[] questions = new string[2];
                        questions[0] = reader.GetString(0);
                        questions[1] = reader.GetString(1);
                        return questions;
                    }
                    else return new string[] { "", "" };
                }
            }
        }
        public bool AuthenticateSecurity(string un, string a1, string a2)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM [Security]  WHERE userName = @userName AND answer1 = @a1 AND answer2 = @a2";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", un);
                    cmd.Parameters.AddWithValue("@a1", a1);
                    cmd.Parameters.AddWithValue("@a2", a2);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    if (count > 0) return true;
                    return false;
                }
            }
        }

        public bool UpdatePassword(string un, string pw)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string query = "UPDATE [User] SET userPass = @userPass WHERE userName = @userName";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userName", un);
                    cmd.Parameters.AddWithValue("@userPass", pw);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0) return true;
                    return false;
                }
            }
        }

        public User GetProfile(string username)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string query = "SELECT * FROM [User] WHERE userName = @userName";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userName", username);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        User user = new User(
                            userName: reader["userName"].ToString(),
                            userPass: reader["userPass"].ToString(),
                            role: reader["role"].ToString(),
                            gender: reader["gender"].ToString(),
                            birthDate: (DateTime)reader["birthday"],
                            phone: reader["phone"].ToString(),
                            email: reader["email"].ToString(),
                            salary: Convert.ToDouble(reader["salary"]),
                            level: reader["level"].ToString()
                            );
                        return user;
                    }
                    else return null;
                }
            }
        }
        public bool UpdateUser(User user)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {


                    conn.Open();
                    string query = @"
                    UPDATE [User] 
                    SET userPass = @userPass, gender = @gender,birthday = @birthday,  
                        phone = @phone, email = @email, level = @level, salary = @salary
                    WHERE userName = @userName";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@userName", user.UserName);
                        cmd.Parameters.AddWithValue("@userPass", user.UserPass);
                        cmd.Parameters.AddWithValue("@gender", user.Gender);
                        cmd.Parameters.AddWithValue("@birthday", user.BirthDate);
                        cmd.Parameters.AddWithValue("@phone", user.Phone);
                        cmd.Parameters.AddWithValue("@email", user.Email);
                        cmd.Parameters.AddWithValue("@salary", user.Salary);
                        cmd.Parameters.AddWithValue("@level", user.Level);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return false;
                }
            }
        } // 



    }




}
