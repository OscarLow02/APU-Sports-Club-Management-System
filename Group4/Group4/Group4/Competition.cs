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
    public class Competition
    {
        //member fields
        private int competition_id;
        private string competition_name;
        private DateTime date_time;
        private string venue;
        private string result;
        //get connection string from app.config

        public int Competition_id { get => competition_id; }
        public string Competition_Name { get => competition_name; set => competition_name = value; }
        public DateTime Date_time { get => date_time; set => date_time = value; }
        public string Venue { get => venue; set => venue = value; }
        public string Result { get => result; set => result = value; }
        public Student Student { get; set; } // Property to hold the Student object

        //constructor which takes all parameters
        public Competition(int competition_id, string competition_name, DateTime date_time, string venue, string result)
        {
            this.competition_id = competition_id;
            this.competition_name = competition_name;
            this.date_time = date_time;
            this.venue = venue;
            this.result = result;
        }
        //constructor which takes 4 parameters
        public Competition(int competition_id, string competition_name, DateTime date_time, string venue)
        {
            this.competition_id = competition_id;
            this.competition_name = competition_name;
            this.date_time = date_time;
            this.venue = venue;
        }

        //constructor that takes 3 parameters except id
        public Competition(string competition_name, DateTime date_time, string venue)
        {
            this.competition_name = competition_name;
            this.date_time = date_time;
            this.venue = venue;
        }

        //constructor that only competition ID
        public Competition(int competition_id)
        {
            this.competition_id = competition_id;
        }

        //constructor that takes id and result
        public Competition(int competition_id, string result)
        {
            this.competition_id = competition_id;
            this.result = result;
        }
        // Constructor that takes competition_id and a Student object
        public Competition(int competitionId, Student student)
        {
            this.competition_id = competitionId;
            this.Student = student;
        }
        //member method to view competition list
        public static ArrayList viewAll()
        {
            //arraylist to create dynamic array
            ArrayList atr = new ArrayList();

            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString()))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select * from Competition", con);

                    // use SqlDataReader to read data of every row in the database
                    SqlDataReader rd = cmd.ExecuteReader();

                    //use while loop to read every row of data and get the attributes from every row
                    while (rd.Read())
                    {
                        int competitionId = rd.GetInt32(0);
                        string competitionName = rd.GetString(1);
                        DateTime dateTime = rd.GetDateTime(2);
                        string venue = rd.GetString(3);
                        string result = rd.GetString(4);

                        //create a competition object and add it into the ArrayList
                        Competition competition = new Competition(competitionId, competitionName, dateTime, venue, result);
                        atr.Add(competition);
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions here (e.g., log the error, show a message to the user)
                MessageBox.Show("Error retrieving competitions: " + ex.Message);
            }
            return atr;
        }
        //create member method add competition
        public string addCompetition()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString()))
                {
                    con.Open();

                    //insert new competition with name, datetime and venue
                    SqlCommand cmd = new SqlCommand("insert into competition(competition_name, date_time, venue) values(@name, @dt, @v)", con);
                    cmd.Parameters.AddWithValue("@name", competition_name);
                    cmd.Parameters.AddWithValue("@dt", date_time);
                    cmd.Parameters.AddWithValue("@v", venue);

                    //execute the insert sql query
                    cmd.ExecuteNonQuery();

                    // return message
                    return "Competition added successfully.";
                }
            }
            catch (Exception ex)
            {
                //handle exception
                return "Error adding competition: " + ex.Message;
            }
        }

        //create member method edit competition
        public string editCompetition()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString()))
                {
                    con.Open();

                    //edit selected competition from the list view
                    SqlCommand cmd = new SqlCommand("update competition set competition_name = @name, date_time = @dt, venue = @v where competition_id =@id", con);
                    cmd.Parameters.AddWithValue("@name", competition_name);
                    cmd.Parameters.AddWithValue("@dt", date_time);
                    cmd.Parameters.AddWithValue("@v", venue);
                    cmd.Parameters.AddWithValue("@id", competition_id);

                    //execute the update sql query
                    int rowSelected = cmd.ExecuteNonQuery();

                    //return message
                    if (rowSelected > 0)
                    {
                        return "Competition successfully edited.";
                    }
                    else
                    {
                        return "No competition found with the specified ID.";
                    }

                }
            }
            catch (Exception ex)
            {
                //error handling
                return "Error editing competition: " + ex.Message;
            }
        }
        public string delCompetition()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString()))
                {
                    con.Open();

                    //delete selected entries from CompDetails Table
                    SqlCommand cmd0 = new SqlCommand("DELETE FROM CompDetails WHERE competition_id = @id", con);
                    cmd0.Parameters.AddWithValue("@id", competition_id);
                    int rowDeletedCompDetails = cmd0.ExecuteNonQuery();

                    //delete selected competition from the list view and database
                    SqlCommand cmd = new SqlCommand("delete from competition where competition_id = @id", con);
                    cmd.Parameters.AddWithValue("@id", competition_id);

                    //execute the delete sql query
                    int rowAffected = cmd.ExecuteNonQuery();

                    //use ExecuteNonQuery returned value to check if the competition is deleted by checking if the rowAffected is greater than 0
                    if (rowAffected > 0)
                    {
                        return "Competition successfully deleted.";
                    }
                    else
                    {
                        return "No competition found with the specified ID.";
                    }
                }
            }
            catch (Exception ex)
            {
                //error handling
                return "Error deleting competition: " + ex.Message;
            }
        }

        public static ArrayList ViewCompetitionDetails(int competition_id)
        {
            ArrayList studentDetails = new ArrayList();
            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString()))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT s.student_id, s.student_name FROM Student s INNER JOIN CompDetails cd ON s.student_id = cd.student_id WHERE cd.competition_id = @competitionId", con);
                    cmd.Parameters.AddWithValue("@competitionId", competition_id);

                    SqlDataReader rd = cmd.ExecuteReader();

                    while (rd.Read())
                    {
                        int studentId = rd.GetInt32(0);
                        string studentName = rd.GetString(1);
                        studentDetails.Add(new object[] { studentId, studentName });
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving competition details: " + ex.Message);
            }

            return studentDetails;
        }
        public string UpdateCompetitionResult(int id)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString()))
                {
                    con.Open();

                    //update the result of the competition
                    SqlCommand cmd = new SqlCommand("update competition set result = @result where competition_id = @id", con);
                    cmd.Parameters.AddWithValue("@result", result);
                    cmd.Parameters.AddWithValue("@id", competition_id);

                    //execute the update sql query
                    int rowSelected = cmd.ExecuteNonQuery();

                    //return message
                    if (rowSelected > 0)
                    {
                        return "Competition result successfully updated.";
                    }
                    else
                    {
                        return "No competition found with the specified ID.";
                    }

                }
            }
            catch (Exception ex)
            {
                //error handling
                return "Error updating competition result: " + ex.Message;
            }
        }
        public static Competition GetCompetitionByID(int competitionID)
        {
            Competition competition = null;

            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString()))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT competition_name, date_time, venue FROM Competition WHERE competition_id = @competitionID", con);
                    cmd.Parameters.AddWithValue("@competitionID", competitionID);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string competitionName = reader.GetString(0);
                        DateTime dateTime = reader.GetDateTime(1);
                        string venue = reader.GetString(2);

                        competition = new Competition(competitionID, competitionName, dateTime, venue);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving competition details: " + ex.Message);
            }

            return competition;
        }
        public string EnrollStudent(int studentId)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString()))
                {
                    con.Open();

                    // Check if the student is already enrolled in the competition
                    SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM CompDetails WHERE competition_id = @competitionId AND student_id = @studentId", con);
                    checkCmd.Parameters.AddWithValue("@competitionId", this.Competition_id);
                    checkCmd.Parameters.AddWithValue("@studentId", studentId);

                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                    if (count > 0)
                    {
                        return "Student is already enrolled in this competition.";
                    }

                    // Enroll the student in the competition
                    SqlCommand enrollCmd = new SqlCommand("INSERT INTO CompDetails (competition_id, student_id) VALUES (@competitionId, @studentId)", con);
                    enrollCmd.Parameters.AddWithValue("@competitionId", this.Competition_id);
                    enrollCmd.Parameters.AddWithValue("@studentId", studentId);

                    int rowsAffected = enrollCmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        return "Student enrolled successfully.";
                    }
                    else
                    {
                        return "Failed to enroll student.";
                    }
                }
            }
            catch (Exception ex)
            {
                return "Error enrolling student: " + ex.Message;
            }
        }

    }
}
