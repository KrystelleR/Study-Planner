using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using ProjectWebApp.ModuleLibrary;
using System;
using System.Linq;

namespace ProjectWebApp.Pages
{
    public class addStudyHoursModel : PageModel
    {
        public string label1 { get; set; }
        public string label2 { get; set; }

        public static String ModuleCode;
        public static int amount;
        public string Message { get; set; }
        public void OnGet(string id)
        {
            if (Users.hasSignedIn == false)
            {
                Response.Redirect("/Login");
            }
            else
            {
                Message = "\t";
                label1 = id;

                var addedHours = from i in Modules.modulesList select i;
                foreach (var i in addedHours)
                {
                    if (id.Equals(i.code))
                    {
                        label2 = i.SShoursRem.ToString();
                    }
                }
            }
        }

        public List<Subjects> SubjectsList = new List<Subjects>();
        Subjects objSubjects = new Subjects();
        public String username { get; set; }
        public void OnPost(String id)
        {
            label1 = id;
            username = Users.Username;
             SubjectsList = objSubjects.AllSubjects(username);

             foreach (var sub in SubjectsList)
             { 
                 if (id.Equals(sub.ModuleCode))
                 {
                    try
                    {
                        //ModuleCode, ModuleName, Credits, ClassHours, StudyHoursPW, StudyHoursLeft, Username
                        label2 = sub.StudyHoursLeft.ToString();
                        int hoursRem = sub.StudyHoursLeft;

                        int UsersHours = int.Parse(Request.Form["txtHrsDone"]);

                        if ((UsersHours >= 1) && (UsersHours <= 24))
                        {
                            int value = sub.StudyHoursLeft - int.Parse(Request.Form["txtHrsDone"]);
                            sub.StudyHoursLeft = value;
                            DateTime dayDone = DateTime.Parse(Request.Form["txtDateDone"]);

                            String ModulePK = Users.Username + id;

                            Subjects subjects = new Subjects();
                            //adding to studyDates table
                            subjects.addStudyDate(id, UsersHours, dayDone, Users.Username, ModulePK);

                            //updating Modules table
                            subjects.updateHoursRemaining(value, ModulePK);
                            Response.Redirect("/Index");
                        }
                        else
                        {
                            Message = "Hours should be between 1 and 24";
                        }
                    }
                    catch
                    {
                        Message = "Hours should be between 1 and 24";
                    }
                 }
             }
        }
    }
}
