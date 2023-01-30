using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using ProjectWebApp.ModuleLibrary;

namespace ProjectWebApp.Pages.UserPages
{
    public class addModuleModel : PageModel
    {
        public static String modCode;
        public static String modName;
        public static int credits;
        public static int hourspw;
        public static int selfStudy;
        public static String StudyDay;

        public String Message { get; set; }

        public void OnGet()
        {
            Message = "\t";
        }
        public void OnPost()
        {
            StudyDay = Request.Form["dayOfTheWeek"];
            Users user = new Users();
            user.getUser(Users.Username);
                Boolean check = false;
                try
                {
                    modCode = Request.Form["txtModCode"];
                    modName = Request.Form["txtModName"];
                    credits = int.Parse(Request.Form["txtCredits"]);
                    hourspw = int.Parse(Request.Form["txtClassHours"]);
                if (modCode.Length !=0 && modName.Length!=0 && credits!=0 && hourspw!=0)
                {
                    if (credits>=1 && credits <=35)
                    {
                        if(hourspw>=1 && hourspw <= 40)
                        {
                            selfStudy = Modules.calculateSelfStudy(credits, Users.SemesterWeeks, hourspw);
                            check = true;
                        }
                        else
                        {
                            Message = "Classroom hours should be a min of 1 and a max of 40";
                        }
                       
                    }
                    else
                    {
                        Message = "You're credits should be a min of 1 and a max of 35";
                    }

                    
                }
                }
                catch
                {
                    Message= "Please fill in all details";
                    check = false;
                }

                if (check)
                {
                    Subjects modules = new Subjects();

                    try
                    {
                        //Primary key is username + moduleCode
                        String PrimaryKey = Users.Username + modCode;
                        modules.addModule(PrimaryKey, modCode, modName, credits, hourspw, selfStudy, selfStudy, Users.Username, StudyDay);

                        Modules objMod = new Modules(modCode, modName, credits, hourspw, selfStudy, selfStudy, StudyDay);
                        Modules.modulesList.Add(objMod);
                        Response.Redirect("/Index");
                    }
                    catch
                    {
                        Message="You already have a module named " + modCode;
                    }               
            }
        }
    }
}
