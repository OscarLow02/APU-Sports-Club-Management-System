using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Group4
{
    internal class Admin
    {
        //private string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\U S E R\\Desktop\\oop\\admin\\admin\\admin_database.mdf\";Integrated Security=True";
        private readonly string connString = ConfigurationManager.ConnectionStrings["myCS"].ConnectionString;

        public Admin()
        {
            //connString = ConfigurationManager.ConnectionStrings["myCS"].ConnectionString;
        }
        //general
        public DataTable GetData(string tableName) //get data from table
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string query = $"SELECT * FROM [{tableName}]";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    DataTable dt = new DataTable();
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                    return dt;
                }
            }
        }
        //User Management Form
        
        public bool AddUser(User user)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    string userQuery = @"
                INSERT INTO [User] (userName, userPass, role, gender, birthday, phone, email, salary, level) 
                VALUES (@userName, @userPass, @role, @gender, @birthday, @phone, @email, @salary, @level)";
                    using (SqlCommand cmd = new SqlCommand(userQuery, conn))
                    {
                        //User table
                        cmd.Parameters.AddWithValue("@userName", user.UserName);
                        cmd.Parameters.AddWithValue("@userPass", user.UserPass);
                        cmd.Parameters.AddWithValue("@role", user.Role);
                        cmd.Parameters.AddWithValue("@gender", user.Gender);
                        cmd.Parameters.AddWithValue("@birthday", user.BirthDate);
                        cmd.Parameters.AddWithValue("@phone", user.Phone);
                        cmd.Parameters.AddWithValue("@email", user.Email);
                        cmd.Parameters.AddWithValue("@salary", user.Salary);
                        cmd.Parameters.AddWithValue("@level", user.Level);

                        cmd.ExecuteNonQuery(); 
                    }

                    if  (user.Role == "Member" ) //coach no table
                    {
                        query2 = $@"
                    INSERT INTO [{user.Role}] (UserID, Password, Gender, Birthdate, Phone, Email, Course) 
                    VALUES (@UserID, @Password, @Gender, @Birthdate, @Phone, @Email, @a)";

                        using (SqlCommand cmd = new SqlCommand(query2, conn))
                        {
                            cmd.Parameters.AddWithValue("@UserID", user.UserName);
                            cmd.Parameters.AddWithValue("@Password", user.UserPass);
                            cmd.Parameters.AddWithValue("@Gender", user.Gender);
                            cmd.Parameters.AddWithValue("@Birthdate", user.BirthDate);
                            cmd.Parameters.AddWithValue("@Phone", user.Phone);
                            cmd.Parameters.AddWithValue("@Email", user.Email);
                            cmd.Parameters.AddWithValue("@a", "No Course");
                            cmd.ExecuteNonQuery();
                        }
                    }
                    return true;
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627)
                        MessageBox.Show("Added failed. User ID is duplicated.");
                    else MessageBox.Show("Error: " + ex.Message);
                    return false;
                }
            }
        }


        //Specific table based on role
        string query2;

        // 23March: coach no table
        //if (user.Role == "Coach")
        //{
        //    query2 = @"
        //INSERT INTO [Coach] (userName, userPass, gender, birthday, phone, email, salary, level) 
        //VALUES (@userName, @userPass, @gender, @birthday, @phone, @email, @salary, @level)";
        //    using (SqlCommand cmd = new SqlCommand(query2, conn))
        //    {
        //        cmd.Parameters.AddWithValue("@userName", user.UserName);
        //        cmd.Parameters.AddWithValue("@userPass", user.UserPass);
        //        cmd.Parameters.AddWithValue("@role", user.Role);
        //        cmd.Parameters.AddWithValue("@gender", user.Gender);
        //        cmd.Parameters.AddWithValue("@birthday", user.BirthDate);
        //        cmd.Parameters.AddWithValue("@phone", user.Phone);
        //        cmd.Parameters.AddWithValue("@email", user.Email);
        //        cmd.Parameters.AddWithValue("@salary", user.Salary);
        //        cmd.Parameters.AddWithValue("@level", user.Level);
        //        cmd.ExecuteNonQuery();
        //    }
        //}
        //else

        public bool AddSecurity(string un, string q1, string q2, string a1, string a2)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO [Security] (userName,question1,answer1,question2,answer2) VALUES (@userName,@question1,@answer1,@question2,@answer2)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@userName", un);
                        cmd.Parameters.AddWithValue("@question1", q1);
                        cmd.Parameters.AddWithValue("@answer1", a1);
                        cmd.Parameters.AddWithValue("@question2", q2);
                        cmd.Parameters.AddWithValue("@answer2", a2);

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

                        cmd.ExecuteNonQuery(); 
                    }
                    string query2;

                    // 23 March : no coach table

                    //if (user.Role == "Coach")
                    //{
                    //    query2 = @"
                    //UPDATE [Coach] 
                    //SET userPass = @userPass, gender = @gender,birthday = @birthday,  
                    //    phone = @phone, email = @email, level = @level, salary = @salary
                    //WHERE userName = @userName";
                    //    using (SqlCommand cmd = new SqlCommand(query2, conn))
                    //    {
                    //        cmd.Parameters.AddWithValue("@userName", user.UserName);
                    //        cmd.Parameters.AddWithValue("@userPass", user.UserPass);
                    //        cmd.Parameters.AddWithValue("@gender", user.Gender);
                    //        cmd.Parameters.AddWithValue("@birthday", user.BirthDate);
                    //        cmd.Parameters.AddWithValue("@phone", user.Phone);
                    //        cmd.Parameters.AddWithValue("@email", user.Email);
                    //        cmd.Parameters.AddWithValue("@salary", user.Salary);
                    //        cmd.Parameters.AddWithValue("@level", user.Level);

                    //        cmd.ExecuteNonQuery();
                    //    }
                    //}
                    if (user.Role == "Manager" ||  user.Role == "Member")
                    {
                        query2 = $@"
                    UPDATE [{user.Role}] 
                    SET Password = @userPass, Gender = @gender,Birthdate = @birthday,  
                        Phone = @phone, Email = @email
                    WHERE UserID = @userName";
                        using (SqlCommand cmd = new SqlCommand(query2, conn))
                        {
                            cmd.Parameters.AddWithValue("@userName", user.UserName);
                            cmd.Parameters.AddWithValue("@userPass", user.UserPass);
                            cmd.Parameters.AddWithValue("@gender", user.Gender);
                            cmd.Parameters.AddWithValue("@birthday", user.BirthDate);
                            cmd.Parameters.AddWithValue("@phone", user.Phone);
                            cmd.Parameters.AddWithValue("@email", user.Email);

                            cmd.ExecuteNonQuery();
                        }
                    }
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return false;
                }
            }
        } // 

        public bool DeleteUser(User user)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    string query = " DELETE FROM [User] where userName = @userName ";
                    string query2 = "DELETE FROM [Security] WHERE userName = @userName";
                    string query3 = $"DELETE FROM [{user.Role}] WHERE UserID = @userName";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@userName", user.UserName);
                        cmd.ExecuteNonQuery();
                    }
                    using (SqlCommand cmd2 = new SqlCommand(query2, conn))
                    {
                        cmd2.Parameters.AddWithValue("@userName", user.UserName);
                        cmd2.ExecuteNonQuery();
                    }
                    if (user.Role == "Member")
                    {
                        using (SqlCommand cmd3 = new SqlCommand(query3, conn))
                        {
                            cmd3.Parameters.AddWithValue("@userName", user.UserName);
                            cmd3.ExecuteNonQuery();
                        }
                    }
                    
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return false;
                }
            }
        }


        //Suggestion form
            // to get username to import to combobox //income form too
        public DataTable GetUserName(string name, string tableName)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string query = $"SELECT DISTINCT {name} FROM {tableName}";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    DataTable dt = new DataTable();
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                    return dt;
                }
            }
        }

        // - Min Date
        public DateTime GetMinDate()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string query = "SELECT MIN(Date) from [memberFeedback]";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    return (DateTime)cmd.ExecuteScalar();
                }
            }
        }

        // - Max Date
        public DateTime GetMaxDate()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string query = "SELECT MAX(Date) from [memberFeedback]";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    return (DateTime)cmd.ExecuteScalar();
                }
            }
        }

        //Get Data Within Date
        public DataTable WithinDate(DateTime startDate, DateTime endDate)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string query = "SELECT * FROM [memberFeedback] WHERE Date >= @startDate AND Date <= @endDate";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@startDate", startDate);
                    cmd.Parameters.AddWithValue("@endDate", endDate);
                    DataTable dt = new DataTable();
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                    return dt;
                }
            }
        }

        //Get Data By Username
        public DataTable UserFilter(string tableName, string userName)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string query = $"SELECT * FROM [{tableName}] WHERE UserID = @userName";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userName", userName);
                    DataTable dt = new DataTable();
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                    return dt;
                }
            }
        }

        //Get Username by Date (to update cboxUser when new date is selected)
        public DataTable GetUserByDate(DateTime startDate, DateTime endDate)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string query = "SELECT DISTINCT UserID FROM [memberFeedback] WHERE date >= @startDate and date <= @endDate";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@startDate", startDate);
                    cmd.Parameters.AddWithValue("@endDate", endDate);
                    DataTable dt = new DataTable();
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                    return dt;
                }
            }

        }

        //Get MinDate by User (to update dateStart when user is selected)
        public DateTime GetMinDateByUser(string userName)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string query = "SELECT MIN(date) FROM [memberFeedback] WHERE UserID = @userName";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userName", userName);
                    return (DateTime)cmd.ExecuteScalar();
                }
            }
        }
        //Get MaxDate by User (to update dateEnd when user is selected)
        public DateTime GetMaxDateByUser(string userName)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string query = "SELECT MAX(date) FROM [memberFeedback] WHERE UserID = @userName";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userName", userName);
                    return (DateTime)cmd.ExecuteScalar();
                }
            }
        }

        public DataTable UserFilterWithinDate(string userName, DateTime startDate, DateTime endDate)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string query = "SELECT * FROM [memberFeedback] WHERE UserID = @userName and Date >= @startDate and Date <= @endDate ";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    DataTable dt = new DataTable();
                    cmd.Parameters.AddWithValue("@userName", userName);
                    cmd.Parameters.AddWithValue("@startDate", startDate);
                    cmd.Parameters.AddWithValue("@endDate", endDate);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                    return dt;
                }
            }
        }

        // Income form
        
        
        public DataTable GetMonths()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string query = "SELECT DISTINCT MONTH(date) as month FROM [memberPayments]";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader r = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(r);
                        return dt;
                    }
                }
            }
        }

        public DataTable Filter(string month, string coachName, string level)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                DataTable dataTable = new DataTable();
                // like a overloading methods o.O!!
                StringBuilder queryBuilder = new StringBuilder("SELECT * FROM [memberPayments] WHERE 1=1");
                // append conditions based on provided parameters o_O
                if (!string.IsNullOrEmpty(month)) queryBuilder.Append(" AND MONTH(date)=@month");
                if (!string.IsNullOrEmpty(coachName)) queryBuilder.Append(" AND coachName = @coachName");
                if (!string.IsNullOrEmpty(level)) queryBuilder.Append(" AND level = @level");
                using (SqlCommand cmd = new SqlCommand(queryBuilder.ToString(), conn))
                {
                    if (!string.IsNullOrEmpty(month)) cmd.Parameters.AddWithValue("@month", month);
                    if (!string.IsNullOrEmpty(coachName)) cmd.Parameters.AddWithValue("@coachName", coachName);
                    if (!string.IsNullOrEmpty(level)) cmd.Parameters.AddWithValue("@level", level);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        dataTable.Load(reader);
                    }
                }// to get total amount and add to last row
                StringBuilder queryBuilder2 = new StringBuilder("SELECT SUM(amount) AS TotalAmount FROM [memberPayments] WHERE 1=1");
                if (!string.IsNullOrEmpty(month)) queryBuilder2.Append(" AND MONTH(date)=@month");
                if (!string.IsNullOrEmpty(coachName)) queryBuilder2.Append(" AND coachName = @coachName");
                if (!string.IsNullOrEmpty(level)) queryBuilder2.Append(" AND level = @level");
                using (SqlCommand cmd2 = new SqlCommand(queryBuilder2.ToString(), conn))
                {
                    if (!string.IsNullOrEmpty(month)) cmd2.Parameters.AddWithValue("@month", month);
                    if (!string.IsNullOrEmpty(coachName)) cmd2.Parameters.AddWithValue("@coachName", coachName);
                    if (!string.IsNullOrEmpty(level)) cmd2.Parameters.AddWithValue("@level", level);
                    object result = cmd2.ExecuteScalar();
                    decimal totalAmount = result != DBNull.Value ? Convert.ToDecimal(result) : 0;
                    {
                        DataRow row = dataTable.NewRow();
                        row["Amount"] = totalAmount;
                        dataTable.Rows.Add(row);
                        return dataTable;
                    }
                }
            }
        }
        public DataTable test()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string query = "SELECT SUM(amount) AS Income_Total FROM [Payment]";
                using (SqlCommand cmd = new SqlCommand (query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader ())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        return dataTable;
                    }
                }
            }
        }

        
        public DataTable GetMonthlyResults()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string query = @"SELECT FORMAT(date_time, 'MM-yyyy') as Month, result, COUNT(*) as Total 
                                    FROM [Competition] 
                                    GROUP BY YEAR(date_time), MONTH(date_time), FORMAT(date_time, 'MM-yyyy'), result 
                                    ORDER BY YEAR(date_time), MONTH(date_time)
                                    ";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        return dataTable;
                    }
                }
            }
        }

        



        public string TotalResult(string result)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string query = "SELECT COUNT(result) FROM [Competition] WHERE result = @result";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@result", result);
                    return cmd.ExecuteScalar().ToString();


                }

            }
        }

        public DataTable GetMonthlyResults2()
        {
            DataTable results = new DataTable();

            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT FORMAT(date_time, 'MM-yy') AS MonthYear, result, COUNT(*) AS Count FROM Competition GROUP BY FORMAT(date_time, 'MM-yy'), result ORDER BY MonthYear", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Load the data into the DataTable
                        results.Load(reader);
                    }
                }
            }

            return results;
        }


    }
}
