using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group4
{
    internal class Member
    {
        
        public string userid { get; set; }
        public string course { get; set; }
        public string password { get; set; }
        public string Gender { get; set; }
        public string phone { get; set; }
        public string email { get; set; }

        public DateTime birthdate = DateTime.Now;

        public Member()
        {
            
            userid = CurrentUser.UserName;

            // Get member details
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString()))
            {
                connection.Open();
                string query = "SELECT * FROM [Member] WHERE UserID=@a";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@a", userid);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            password = reader.GetString(1);
                            Gender = reader.GetString(2);
                            birthdate = reader.GetDateTime(3);
                            phone = reader.GetString(4);
                            email = reader.GetString(5);
                            course = reader.GetString(6);
                        }

                    }
                }
            }
        }

        

        public void SendFeedback(string feedback)
        {
            DateTime date = DateTime.Now.Date;
            string query = "INSERT INTO memberFeedback (UserID, Suggestion, Date) VALUES (@UserID, @Suggestion, @Date)";

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString()))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters to the command
                    command.Parameters.AddWithValue("@UserID", userid);
                    command.Parameters.AddWithValue("@Suggestion", feedback);
                    command.Parameters.AddWithValue("@Date", date);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        // Handle exceptions (e.g., log the error, display an error message)
                        Console.WriteLine($"Error: {ex.Message}");
                    }
                }
            }
        }

        public (string, bool) GetCourse()
        {
            (string, bool) courseInfo = ("You are not enrolled in any course.", false);

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString()))
            {
                connection.Open();

                string query = "SELECT Course FROM Member WHERE UserID=@a";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@a", userid);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                        while (reader.Read())

                            if (reader["Course"].ToString() == "No Course")
                            {
                                courseInfo = ("You are not enrolled in any course.", false);
                                course = "No Course";
                                
                            }
                            else if (reader["Course"].ToString() == "Beginner")
                            {
                                courseInfo = ("You are enrolled in Beginner Course.", true);
                                course = "Beginner";
                            }
                            else if (reader["Course"].ToString() == "Intermediate")
                            {
                                courseInfo = ("You are enrolled in Intermediate Course.", true);
                                course = "Intermediate";
                            }
                            else if (reader["Course"].ToString() == "Advance")
                            {
                                courseInfo = ("You are enrolled in Advance Course.", true);
                                course = "Advance";
                            }

                    }
                }
            }

            return courseInfo;
        }

        public void UpdateProfile(ArrayList profileInfo)
        {
            // Updating class variables
            userid = (string)profileInfo[0];
            password = (string)profileInfo[1];
            phone = (string)profileInfo[2];
            email = (string)profileInfo[3];
            birthdate = (DateTime)profileInfo[4];




            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString()))
            {
                connection.Open();
                string query = "UPDATE Member SET Password=@b, Gender=@c, Birthdate=@d, Phone=@e, Email=@f WHERE UserID=@g";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@b", password);
                    command.Parameters.AddWithValue("@c", Gender);
                    command.Parameters.AddWithValue("@d", birthdate);
                    command.Parameters.AddWithValue("@e", phone);
                    command.Parameters.AddWithValue("@f", email);
                    command.Parameters.AddWithValue("@g", userid);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void AddtoPayment()
        {
            string coachName;
            string level = null;
            decimal amount = 0;
            DateTime date = DateTime.Now;


            // To get the current course enrolled
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString()))
            {
                connection.Open();
                string query1 = "SELECT Course FROM Member WHERE UserID=@a";

                using (SqlCommand command = new SqlCommand(query1, connection))
                {
                    command.Parameters.AddWithValue("@a", userid);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            level = reader.GetString(0);
                        }
                    }
                }
            }


            if (level == "Beginner")
            {
                amount = 50;
                coachName = "Heng";
            }
            else if (level == "Intermediate")
            {
                amount = 70;
                coachName = "Ming";
            }
            else
            {
                amount = 90;
                coachName = "Muhammad";
            }

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString()))
            {
                connection.Open();
                string query2 = "INSERT INTO memberPayments (memberName, coachName, level, amount, date) " +
                    "VALUES (@a, @b, @c, @d, @e)";

                using (SqlCommand command = new SqlCommand(query2, connection))
                {
                    command.Parameters.AddWithValue("@a", userid);
                    command.Parameters.AddWithValue("@b", coachName);
                    command.Parameters.AddWithValue("@c", level); ;
                    command.Parameters.AddWithValue("@d", amount);
                    command.Parameters.AddWithValue("@e", date);

                    command.ExecuteNonQuery();
                }
            }

        }
         
        public ArrayList ViewCompetitions()
        {
            ArrayList competitionsList = new ArrayList();


            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString()))
            {
                connection.Open();
                string name;
                string competitionid;
                string venue;
                string query = "SELECT competition_id, competition_name, date_time, venue FROM Competition";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)

                            while (reader.Read())

                            {
                                // Storing data from database into variables
                                competitionid = reader["Competition_ID"].ToString();
                                name = reader["Competition_Name"].ToString();

                                DateTime date = ((DateTime)reader["Date_Time"]);
                                string dateString = date.ToString("dd/MM/yyyy HH:mm:ss");

                                venue = reader["Venue"].ToString();
                                
                                ArrayList competition = new ArrayList
                                {
                                    competitionid,
                                    name,
                                    dateString,
                                    venue
                                };

                                competitionsList.Add(competition);
                            }

                    }
                }
            }
            return competitionsList;
        }

        public ArrayList ViewPerformance()
        {
            string memberid = userid;
            string name;
            string score;
            string date;
            string description;
            
            ArrayList performanceList = new ArrayList();

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString()))
            {
                connection.Open();



                string query = "SELECT * FROM PerformanceTbl WHERE Name=@a";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@a", userid);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)

                            while (reader.Read())
                            {
                                memberid = reader["MemberID"].ToString();
                                name = reader["Name"].ToString();
                                score = reader["Score"].ToString();
                                date = reader["Date"].ToString();
                                description = reader["Description"].ToString();

                                ArrayList performanceRecord = new ArrayList();

                                performanceRecord.Add(memberid);
                                performanceRecord.Add(name);   
                                performanceRecord.Add(score);
                                performanceRecord.Add(date);
                                performanceRecord.Add(description);
                                    
                                performanceList.Add(performanceRecord);
                            }

                    }
                }
            }

            return performanceList;
        }

        public ArrayList ViewSchedule()
        {

            ArrayList scheduleList = new ArrayList();

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString()))
            {

                connection.Open();

                string query = "SELECT * FROM ScheduleTbl WHERE Level=@a";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@a", course);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string coachName = reader.GetString(0);
                            string coachPhone =  reader.GetString(1);
                            string level = reader.GetString(2);
                            string Course = reader.GetString(3);
                            DateTime date = reader.GetDateTime(4);
                            TimeSpan time = reader.GetTimeSpan(5);
                            string location = reader.GetString(6);

                            ArrayList schedule = new ArrayList();

                            schedule.Add(coachName);
                            schedule.Add(coachPhone);
                            schedule.Add(level);
                            schedule.Add(Course);
                            schedule.Add(date.ToString("dd/MM/yyyy"));
                            schedule.Add(time.ToString(@"hh\:mm\:ss"));
                            schedule.Add(location);

                            scheduleList.Add(schedule); 
                        }
                    }
                }
            }

            return scheduleList;
        }
    }
}
