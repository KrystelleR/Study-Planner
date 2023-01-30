using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace ProjectWebApp.ModuleLibrary
{
    public class Subjects
    {
        SqlConnection conn = Connections.GetConeection();
        public String PrimaryKey { get; set; }
        public  string ModuleCode { get; set; }
        public  string ModuleName { get; set; }
        public  int Credits { get; set; }
        public  int ClassHours { get; set; }
        public  int StudyHoursPW { get; set; }
        public  int StudyHoursLeft { get; set; }
        public  String Username { get; set; }

        public String StudyDay { get; set; }

        public Subjects()
        {

        }
        public Subjects(String myModuleCode, String myModuleName, int myCredits, int myClassHours, int myStudyHoursPW, int myStudyHoursLeft, String myUsername, String myStudyDay)
        {
            ModuleCode = myModuleCode;
            ModuleName = myModuleName;
            Credits = myCredits;
            ClassHours = myClassHours;
            StudyHoursPW = myStudyHoursPW;
            StudyHoursLeft = myStudyHoursLeft;
            Username = myUsername;
            PrimaryKey = myModuleCode + myUsername;
            StudyDay = myStudyDay;
        }

        public void addModule(String myPrimaryKey, String myModuleCode, String myModuleName, int myCredits, int myClassHours, int myStudyHoursPW, int myStudyHoursLeft, String myUsername, String myStudyDay)
        {
            string strInsert = $"INSERT INTO tblModules VALUES('{myPrimaryKey}','{myModuleCode}','{myModuleName}',{myCredits}, {myClassHours}, {myStudyHoursPW}, {myStudyHoursLeft}, '{myUsername}', '{myStudyDay}')";
            SqlCommand cmdInsert = new SqlCommand(strInsert, conn);

            conn.Open();
            cmdInsert.ExecuteNonQuery();
            conn.Close();
        }

        public void addStudyDate(String ModuleCode, int Hours, DateTime Date, String Username, String ModulePK)
        {
            string strInsert = $"INSERT INTO tblStudyDates VALUES('{ModuleCode}',{Hours},'{Date}','{Username}', '{ModulePK}')";
            SqlCommand cmdInsert = new SqlCommand(strInsert, conn);

            conn.Open();
            cmdInsert.ExecuteNonQuery();
            conn.Close();
        }


        public void updateHoursRemaining(int theStudyHoursLeft, String theModulePK)
        {
            string strUpdate = $"UPDATE tblModules SET StudyHoursLeft = {theStudyHoursLeft} WHERE PrimaryKey = '{theModulePK}'";
            SqlCommand cmdUpdate = new SqlCommand(strUpdate, conn);

            conn.Open();
            cmdUpdate.ExecuteNonQuery();
            conn.Close();
        }

        public static Boolean hasModules = false;
        public List<Subjects> AllSubjects(String username)
        {
            string strSelect = $"SELECT * FROM tblModules WHERE Username = '{username}';";
            SqlCommand cmdSelect = new SqlCommand(strSelect, conn);
            DataTable myTable = new DataTable();
            DataRow myRow;
            SqlDataAdapter myAdapter = new SqlDataAdapter(cmdSelect);
            List<Subjects> _list = new List<Subjects>();

            conn.Open();
            myAdapter.Fill(myTable);

            if (myTable.Rows.Count > 0)
            {
                for (int i = 0; i < myTable.Rows.Count; i++)
                {
                    myRow = myTable.Rows[i];

                    PrimaryKey = (string)myRow[0];
                    ModuleCode = (string)myRow[1];
                    ModuleName = (string)myRow[2];
                    Credits = (int)myRow[3];
                    ClassHours = (int)myRow[4];
                    StudyHoursPW = (int)myRow[5];
                    StudyHoursLeft = (int)myRow[6];
                    Username = (string)myRow[7];
                    StudyDay = (string)myRow[8];

                    Modules objMod = new Modules(ModuleCode, ModuleName, Credits, ClassHours, StudyHoursPW, StudyHoursLeft, StudyDay);
                    Modules.modulesList.Add(objMod);
                    _list.Add(new Subjects( ModuleCode, ModuleName, Credits, ClassHours, StudyHoursPW, StudyHoursLeft, Username, StudyDay));

                    if (ModuleCode.Length != 0)
                    {
                        hasModules = true;
                    }
                }
            }

            conn.Close();
            return _list;
        }

        public static List<String> days = new List<String>();
        public void Schedule(String username, String day)
        {
            days.Clear();
            string strSelect = $"SELECT * FROM tblModules WHERE Username= '{username}' AND StudyDay = '{day}';";
            SqlCommand cmdSelect = new SqlCommand(strSelect, conn);
            DataTable myTable = new DataTable();
            DataRow myRow;
            SqlDataAdapter myAdapter = new SqlDataAdapter(cmdSelect);
            
            conn.Open();
            myAdapter.Fill(myTable);

            if (myTable.Rows.Count > 0)
            {
                for (int i = 0; i < myTable.Rows.Count; i++)
                {
                    myRow = myTable.Rows[i];

                    PrimaryKey = (string)myRow[0];
                    ModuleCode = (string)myRow[1];
                    ModuleName = (string)myRow[2];
                    Credits = (int)myRow[3];
                    ClassHours = (int)myRow[4];
                    StudyHoursPW = (int)myRow[5];
                    StudyHoursLeft = (int)myRow[6];
                    Username = (string)myRow[7];
                    StudyDay = (string)myRow[8];

                    days.Add(ModuleCode);

                    if (ModuleCode.Length != 0)
                    {
                        hasModules = true;
                    }
                }
            }

            conn.Close();
        }
    }
}


