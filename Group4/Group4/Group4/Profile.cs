using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group4
{
    internal class Profile
    {
        static SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
        private string userID;
        private string userRole;
        private string password;
        private string gender;
        private DateTime birthDate;
        private string phone;
        private string email;

        public Profile(string id, string role, string pass, string gd, DateTime bd, string ph, string em)
        {
            userID = id;
            userRole = role;
            password = pass;
            gender = gd;
            birthDate = bd;
            phone = ph;
            email = em;

        }

        public Profile(string id)
        {
            userID = id;
        }

        public string userName { get => userID; set => userID = value; }
        public string UserRole { get => userRole; set => userRole = value; }
        public string Password { get => password; set => password = value; }
        public string Gender { get => gender; set => gender = value; }
        public DateTime BirthDate { get => birthDate; set => birthDate = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }

        public static void viewProfile(Profile us1)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from [User] where userName=@id", conn);
            cmd.Parameters.AddWithValue("@id", us1.userID);

            SqlDataReader rea = cmd.ExecuteReader();
            while (rea.Read())
            {
                us1.userRole = rea.GetString(2);
                us1.password = rea.GetString(1);
                us1.gender = rea.GetString(3);
                us1.birthDate = rea.GetDateTime(4);
                us1.phone = rea.GetString(5);
                us1.email = rea.GetString(6);
            }
            conn.Close();
        }
        public void update()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("update [User] set role = @role, userPass=@ps, gender=@gd, birthday=@bd, phone = @ph, email = @em where userName = @id", conn);
                cmd.Parameters.AddWithValue("@id", userID);
                cmd.Parameters.AddWithValue("@role", userRole);
                cmd.Parameters.AddWithValue("@ps", password);
                cmd.Parameters.AddWithValue("@gd", gender);
                cmd.Parameters.AddWithValue("@bd", birthDate);
                cmd.Parameters.AddWithValue("@ph", phone);
                cmd.Parameters.AddWithValue("@em", Email);

                cmd.ExecuteNonQuery();

                SqlCommand cmd2 = new SqlCommand("update ScheduleTbl set CoachPhone = @ph where CoachName = @id", conn);
                cmd2.Parameters.AddWithValue("@id", userID);
                cmd2.Parameters.AddWithValue("@ph", phone);

                cmd2.ExecuteNonQuery();
                MessageBox.Show("Profile Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Error3: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
