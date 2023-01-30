using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace ProjectWebApp.ModuleLibrary
{
    public class Users
    {
        public static Boolean hasSignedIn = false;
        SqlConnection conn = Connections.GetConeection();
        public static String Username { get; set; }
        public static string Name { get; set; }
        public static string Surname { get; set; }
        public static string HashedPassword { get; set; }
        public static string Salt { get; set; }
        public static int SemesterWeeks { get; set; }
        public static DateTime SemesterStartDate { get; set; }

        public Users()
        {

        }
        public Users(string myUsername, string myName, string mySurname, string myHashedPassword, string mySalt, int mySemesterWeeks, DateTime mySemesterStartDate)
        {
            Username = myUsername;
            Name = myName;
            Surname = mySurname;
            HashedPassword = myHashedPassword;
            Salt = mySalt;
            SemesterWeeks = mySemesterWeeks;
            SemesterStartDate = mySemesterStartDate;
        }

        public void addUser(String theUsername, String theName, String theSurname, String theHashedPassword, String theSalt, int theSemesterWeeks, DateTime theSemesterStartDate)
        {
            string strInsert = $"INSERT INTO tblUsers VALUES('{theUsername}','{theName}','{theSurname}','{theHashedPassword}','{theSalt}', {theSemesterWeeks}, '{theSemesterStartDate}')";
            SqlCommand cmdInsert = new SqlCommand(strInsert, conn);

            conn.Open();
            cmdInsert.ExecuteNonQuery();
            conn.Close();
        }
          
        public void getUser(string theUsername)
        {
            string sqlSelect = $"SELECT * FROM tblUsers WHERE Username = '{theUsername}'";

            using (conn)
            {
                SqlCommand cmdSelect = new SqlCommand(sqlSelect, conn);
                 conn.Open();
                using (SqlDataReader reader = cmdSelect.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Username = (string)reader[0];
                        Name = (string)reader[1];
                        Surname = (string)reader[2];
                        HashedPassword = (string)reader[3];
                        Salt = (string)reader[4];
                        SemesterWeeks = Convert.ToInt32(reader[5]);
                        SemesterStartDate = Convert.ToDateTime(reader[6]);
                    }
                }
            }
        }

        public void updateSemDates(string theUsername, int theSemesterWeeks, DateTime theSemesterStartDate)
        {
            string strUpdate = $"UPDATE tblUsers SET SemesterWeeks = {theSemesterWeeks}, SemesterStartDate = '{theSemesterStartDate}' WHERE Username = '{theUsername}'";
            SqlCommand cmdUpdate = new SqlCommand(strUpdate, conn);

            conn.Open();
            cmdUpdate.ExecuteNonQuery();
            conn.Close();

            getUser(theUsername);
        }
    }
}
