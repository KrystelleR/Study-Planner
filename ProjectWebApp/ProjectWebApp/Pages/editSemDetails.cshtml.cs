using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using ProjectWebApp.ModuleLibrary;

namespace ProjectWebApp.Pages
{
    public class editSemDetailsModel : PageModel
    {
        public String semesterWeeks { get; set; }
        public DateTime semesterStart { get; set; } = DateTime.Today;
        public void OnGet()
        {
            semesterWeeks = Users.SemesterWeeks.ToString();
            semesterStart = Users.SemesterStartDate;
            Message = "\t";
        }


        public string Message { get; set; }
        public string username { get; set; }
        public List<Subjects> SubjectsList = new List<Subjects>();
        Subjects objSubjects = new Subjects();
        public int weeks;
        public DateTime semDate;
        public void OnPost()
        {
            Boolean check = false;
            semesterWeeks = Users.SemesterWeeks.ToString();
            semesterStart = Users.SemesterStartDate;
            //try and catch for invalid values
            username = Users.Username;
            try
            {
                weeks = int.Parse(Request.Form["txtSemWeeks"]);
                semDate = DateTime.Parse(Request.Form["txtSemStart"]);
                if (weeks >= 4 && weeks <= 20) {
                    check = true;
                }
                else
                {
                    Message = "Semester weeks should be a min of 4 and a max of 25";
                }
            }
            catch
            {
                Message = "Invalid Input.";
                check = false;
            }

            if (check)
            {
                Users user = new Users();
                user.updateSemDates(username, weeks, semDate);
                Message = "Successfully changed.";

                Response.Redirect("/Index");
            }
        }
    }
}
