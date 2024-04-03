using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Group4
{
    internal class CoachFunc
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        private string coaName;
        private string phone;
        private string course;
        private DateTime date;
        private DateTime time;
        private string location;
        private string level;
        private string memberID;
        private string memberName;
        private decimal score;
        private string description;

        public string CoaName { get => coaName; set => coaName = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Course { get => course; set => course = value; }
        public DateTime Date { get => date; set => date = value; }
        public DateTime Time { get => time; set => time = value; }
        public string Location { get => location; set => location = value; }
        public string Level { get => level; set => level = value; }
        public string MemberID { get => memberID; set => memberID = value; }
        public string MemberName { get => memberName; set => memberName = value; }
        public decimal Score { get => score; set => score = value; }
        public string Description { get => description; set => description = value; }

        public CoachFunc(string cn, string ph, string lv, string crs, DateTime dt, DateTime tm, string lct)
        {
            coaName = cn;
            phone = ph;
            level = lv;
            course = crs;
            date = dt;
            time = tm;
            location = lct;
        }

        public CoachFunc(string id, string name, decimal sc, DateTime dt, string dcp)
        {
            memberID = id;
            memberName = name;
            score = sc;
            date = dt;
            description = dcp;
        }
        public CoachFunc(string id, string name, decimal sc)
        {
            memberID = id;
            memberName = name;
            score = sc;
        }

        public CoachFunc() 
        {
            
        }

        public void AddSchedule()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into ScheduleTbl (CoachName, CoachPhone,Level,Course, Date,Time, Location) values (@cn,@ph,@lvl,@crs,@dt,@tm,@lct)", conn);

                cmd.Parameters.AddWithValue("@cn", coaName);
                cmd.Parameters.AddWithValue("@ph", phone);
                cmd.Parameters.AddWithValue("@lvl", level);
                cmd.Parameters.AddWithValue("@crs", course);
                cmd.Parameters.AddWithValue("@dt", date);
                cmd.Parameters.AddWithValue("@tm", time.ToString("HH:mm:ss"));
                cmd.Parameters.AddWithValue("@lct", location);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Schedule Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UpdateSchedule()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("update ScheduleTbl set CoachName = @cn,Level = @lvl, Course=@crs, CoachPhone = @ph, Location=@lct, Date = @dt where Time=@tm", conn);

                cmd.Parameters.AddWithValue("@cn", coaName);
                cmd.Parameters.AddWithValue("@ph", phone);
                cmd.Parameters.AddWithValue("@lvl", level);
                cmd.Parameters.AddWithValue("@crs", course);
                cmd.Parameters.AddWithValue("@dt", date);
                cmd.Parameters.AddWithValue("@tm", time.ToString("HH:mm:ss"));
                cmd.Parameters.AddWithValue("@lct", location);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Schedule updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DeleteSchedule()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("delete from ScheduleTbl where CoachName = @nm and Date = @dt and Time=@tm", conn);
                cmd.Parameters.AddWithValue("@nm", coaName);
                cmd.Parameters.AddWithValue("@dt", date);
                cmd.Parameters.AddWithValue("@tm", time.ToString("HH:mm:ss"));

                cmd.ExecuteNonQuery();
                MessageBox.Show("Schedule Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string CheckDate()  // same schedule date and time is not allowed
        {
            string status = null;
            conn.Open();
            SqlCommand cmd = new SqlCommand("select count(*) from ScheduleTbl where CoachName = @nm and Date = @dt and Time=@tm", conn);
            cmd.Parameters.AddWithValue("@nm", coaName);
            cmd.Parameters.AddWithValue("@dt", date);
            cmd.Parameters.AddWithValue("@tm", time.ToString("HH:mm:ss"));

            int count = (int)cmd.ExecuteScalar();
            if (count > 0)
            {
                status = "Failure";

            }
            else
            {
                status = "Pass";
            }
            conn.Close();

            return status;
        }

        public string CheckLevel()
        {
            string status = null;
            conn.Open();
            SqlCommand cmd = new SqlCommand("select count(*) from ScheduleTbl where CoachName = @nm and Level = @lv", conn);
            cmd.Parameters.AddWithValue("@nm", coaName);
            cmd.Parameters.AddWithValue("@lv", level);
            
            int count = (int)cmd.ExecuteScalar();
            if (count > 0)
            {
                status = "Pass";
               
            }
            else
            {
                status = "Failure";
                
            }
            conn.Close();

            return status;
        }

        // Display data into data grid view panel
        public DataTable DisplayData(string tableName)
        {
            string query = $"select * from {tableName}";           
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);

            // Dispose of the command and connection objects
            conn.Close();   
            cmd.Dispose();
            conn.Dispose();
            return dt;
        }

        public void AddPerform()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into PerformanceTbl(MemberID, Name, Score, Date, Description) values (@id, @nm, @sc,@dt,@dp)", conn);
                cmd.Parameters.AddWithValue("@id", memberID);
                cmd.Parameters.AddWithValue("@nm", memberName);
                cmd.Parameters.AddWithValue("@sc", score);
                cmd.Parameters.AddWithValue("@dt", date);
                cmd.Parameters.AddWithValue("@dp", description);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Done", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UpdatePerform()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("update PerformanceTbl set Name = @nm, Score = @sc, Date = @dt, Description = @dp where MemberId = @id", conn);
                cmd.Parameters.AddWithValue("@id", memberID);
                cmd.Parameters.AddWithValue("@nm", memberName);
                cmd.Parameters.AddWithValue("@sc", score);
                cmd.Parameters.AddWithValue("@dt", date);
                cmd.Parameters.AddWithValue("@dp", description);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SendRecommendation()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into RecomTbl(MemberID, MemberName, Score) values (@id, @nm, @sc)", conn);
                cmd.Parameters.AddWithValue("@id", memberID);
                cmd.Parameters.AddWithValue("@nm", memberName);
                cmd.Parameters.AddWithValue("@sc", score);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Recommendation Sent Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        public DataTable SearchData(string tableName, string paramName, string paramValue, string searchText )
        {
            string query = $"select * from {tableName} where {paramValue} = @{paramName}";
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue($"@{paramName}", searchText);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            conn.Close();
            cmd.Dispose();
            conn.Dispose();
            return dt;
        }
      

    }
}
