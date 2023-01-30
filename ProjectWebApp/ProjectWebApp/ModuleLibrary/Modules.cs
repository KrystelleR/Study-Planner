using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectWebApp.ModuleLibrary
{
	public class Modules
	{
		//as class library creation gave an error, this class has the code needed instead
		//values for list
		public string code { get; set; }
		public string name { get; set; }
		public int credits { get; set; }
		public int classHours { get; set; }
		public int selfStudyHours { get; set; }
		public int SShoursRem { get; set; }

		public String StudyDay { get; set; }
		//list object for modules
		public static List<Modules> modulesList = new List<Modules>();

		//paramiterized constuctor
		public Modules(String myCode, String myName, int myCredits, int myClassHours, int mySelfStudyHours, int mySSHoursRem, String myStudyDay)
		{ 
				code = myCode;
				name = myName;
				credits = myCredits;
				selfStudyHours = mySelfStudyHours;
				classHours = myClassHours;
				SShoursRem = mySSHoursRem;
				StudyDay = myStudyDay;
		}

		/// <summary>
		/// Hours per week is calculated correctly
		/// </summary>


		//calculating self study hours
		public static int calculateSelfStudy(int credits, int semWeeks, int classHours)
		{
			int selfStudy = ((credits * 10) / semWeeks) - classHours;
			return selfStudy;
		}

		//default constructor
		public Modules()
		{

		}

		public override string ToString()
		{
			return $"{code}";
		}
		//indexer
		public Modules this[string code]
		{
			get
			{
				return modulesList.Find(x => x.code.Equals(code));
			}
		}

	}
}

//References:
//Troelsen, A. and Japikse, P., n.d. Pro C# 9 with .NET 5.
