using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using ProjectWebApp.ModuleLibrary;

namespace ProjectWebApp.Pages
{
    public class RegisterModel : PageModel
    {
        [BindProperty]
        public signup signup { get; set; }
        public string Message { get; set; }

        public int semesterWeeks { get; set; }
        public DateTime semesterStart { get; set; }
        public void OnGet()
        {
           Message = "\t";
        }

        public static string hashedPassword;
        public static string userSalt;

        //boolean checking if password meets requirements
        public static Boolean correct = false;
        public static Boolean confirm = false;
        public static Boolean goodPassword = false;


        public int weeks;
        public DateTime semDate;
        public Boolean check = false;
        public void OnPost()
        {
            string myName = Request.Form["txtName"];
            string mySurname = Request.Form["txtSurname"];
            string myUsername = Request.Form["txtUsername"];
            string myPassword = Request.Form["txtPassword"];
            string myConfirmPassword = Request.Form["txtConfirmPassword"];

            if (myName.Length != 0 && mySurname.Length != 0 && myUsername.Length != 0 && myPassword.Length != 0 && myConfirmPassword.Length != 0)
            {
                    //Checking if password meets requirements
                    try
                    {

                    if (myPassword.Length >= 8)
                    {
                        for (int i = 0; i < myPassword.Length; i++)
                        {
                            if (Regex.IsMatch(myPassword[i].ToString(), @"^\d+$"))
                            {
                                //my salt
                                byte[] salt = hashing.NewSalt();
                                //my hashed password
                                hashedPassword = hashing.HashPassword(myPassword, salt);
                                userSalt = Convert.ToBase64String(salt);
                                goodPassword = true;
                            }
                        }

                        //checking if  passwords match
                        if (myPassword.Equals(myConfirmPassword) && (goodPassword == true))
                        {
                            confirm = true;
                        }
                        else
                        {
                            Message = "Passwords do not match";
                        }

                    }
                    else
                    {
                        Message = "Password should be a minimum of 8 digits long and should contain a numerical value (0-9)";
                    }

                }
                catch
                {
                    Message = "Invalid Input";
                }

                try
                {
                    weeks = int.Parse(Request.Form["txtSemWeeks"]);
                    semDate = DateTime.Parse(Request.Form["txtSemStart"]);
                    if (weeks >= 4 && weeks <= 20)
                    {
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

                //checking if username was already taken
                if (confirm == true && check ==true)
                    {
                        try
                        {
                            //Both username and password are correct
                            Users user = new Users();
                            user.addUser(myUsername, myName, mySurname, hashedPassword, userSalt, weeks, semDate);
                            Users.hasSignedIn = true;
                            user.getUser(myUsername);


                        Response.Redirect("/Index");                     

                        }
                        catch
                        {
                            Message = "Username was already taken or is invalid.";
                        }
                    }
                }
                else
                {
                    Message = "Please fill in all fields.";
                }
        }
    }

    public class signup
    {
        [Required]
        public string name { get; set; }
        [Required]
        public string surname { get; set; }
        [Required]
        public string username { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string confirmPassword { get; set; }
    }
}
