using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectWebApp.ModuleLibrary;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ProjectWebApp.Pages
{
    public class IndexModel : PageModel
    {
        public string Message { get; set; }
        public string username { get; set; }
        public List<Subjects> SubjectsList = new List<Subjects>();
        Subjects objSubjects = new Subjects();

        public String semesterWeeks { get; set; }
        public DateTime semesterStart { get; set; } 
        public String display {get;set;}

        public DayOfWeek wk { get; set; } = DateTime.Today.DayOfWeek;
        public String Notification { get; set; } = "\t";

        public string value1 { get; set; } = "\t";
        public string value2 { get; set; } = "\t";

        public void OnGet()
        {
            Notification = "\t";
            DayOfWeek wk = DateTime.Today.DayOfWeek;
            Message = "\t";
            if(Users.hasSignedIn == false)
            {
                Response.Redirect("/Login");
            }
            else
            {     
                objSubjects.Schedule(Users.Username, wk.ToString());
                if(Subjects.days.Count != 0)
                {
                    Notification = "Today, you are scheduled to study: ";
                    for (int i = 0; i < Subjects.days.Count; i++)
                    {
                        Notification += Subjects.days[i] + " ";
                    }
                }
                else
                {
                    Notification = "You do not have any modules scheduled for today!";
                }



                //on form load
                username = Users.Username;
                SubjectsList = objSubjects.AllSubjects(username);

                if(SubjectsList.Count == 0)
                {
                    value1 = "It looks like you don't have any modules as yet. ";
                    value2 = "\t Click here to add your 1st one!";
                }
                semesterWeeks = Users.SemesterWeeks.ToString();
                semesterStart = Users.SemesterStartDate;
                display = Convert.ToDateTime(semesterStart).ToString("dd MMMM yyyy");

            }
        }
    }
}


