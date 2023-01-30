HOW TO START MY PROGRAM:

To run the program, you will need Visual Studio downloaded onto your PC.
Start up Visual Studio and open up project named "ProjectWebApp".
The next step is to change the connection string for my database. To get the connection string, in solution explorer open up data, then double click the ProjectDB
database to open it up. Next by server explorer, click on the ProjectDB database (now that it is connected) and go to properties (this will appear on the right hand side)
There, find connection-string column and copy the connection string. Then, open the folder module manager in solution explorer and open up the connection 
class. Where it says return sql-connection, change the connection string that was already there to the one you have copied. You have now successfully connected to
the database I created and the application will run.
Once done, you may run the program. 

DESCRIPTION:

The program allows multiple users to keep track of their current modules and days they studied. 
They can indicate the module code, name, credits, class hours and the number of self studying hours for a week will be created for them. 
Once a user has studied, they can indicate the day they studied and the amount and the program will track how many more hours of self studying they should do for the rest of the week.
The user is also able to say which day of the week they want to study. When it is that day, they will be notified.

INSTRUCTIONS:

1. To sign up, click on the sign up button in Login Window and fill in the details required. Then click the submit button.
	Password should be a minimum of 8 characters and should contain a numeric value.

2. Once you have successfully been signed up, sign in by using the username and password used in signing up.

3. In the home page, enter semester weeks (i.e. 30 weeks) and semester start date (i.e. 1 August 2022)

4. Too add a module:
	Enter module code (i.e. PROG6212)
	Enter module name (i.e. Programming 2B)
	Enter module credits (i.e. 15)
	Enter module class hours per week (i.e. 4)
	Press add button

5. To view entered information, go to home page and click refresh.

6. To add hours studied this week, go to add hours page. Refresh the page and click on the module code nesassary in the list box. Indicate hours studied (2 hours) and date (i.e 19 September 2022) and click add 

7. To get a better understanding of the program, please read the user manuel.
Refereneces:
Troelsen, A.and Japikse, P., n.d. Pro C# 9 with .NET 5.