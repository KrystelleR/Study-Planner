using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.ComponentModel.DataAnnotations;
using ProjectWebApp.ModuleLibrary;

namespace ProjectWebApp.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public Credential Credential { get; set; }
        public String Message { get; set; }
        public void OnGet()
        {
            Message = "\t";
        }

        public static String hashedPassword;
        public static String userSalt;
        public static Boolean carryOn = true;
        public void OnPost()
        {
            string Username = Request.Form["txtUsername"];
            string Password = Request.Form["txtPassword"];

            if (Username.Length == 0 || Password.Length == 0)
            {
                Message = "Username and Password required";
                carryOn = false;
            }

            else if (carryOn == true)
            {
                Users user = new Users();
                user.getUser(Username);

                if (Username == Users.Username)
                {
                    userSalt = Users.Salt;

                    byte[] salt = Convert.FromBase64String(userSalt);
                    string encryptedPassword = hashing.HashPassword(Password, salt);

                    if (encryptedPassword.Equals(Users.HashedPassword))
                    {
                        Response.Redirect("/Index");
                        Users.hasSignedIn = true;
                    }
                    else
                    {
                        Message = "Incorrect username or password";
                    }
                }
                else
                {
                    Message = "Incorrect username or password";
                }
            }
            carryOn = true;
        }
    }


    public class Credential
    {
        [Required]
        public string username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string password { get; set; }
    }
}
