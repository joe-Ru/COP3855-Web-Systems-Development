using System;
using static System.Console;

namespace TicketApp
{
	class TicketApp
	{
		static void Main()
		{
			string studentNumber;
			char classif;
			int speedLimit,
				speed;

			studentNumber = InputStudentNumber();
			speedLimit = InputSpeed("Speed Limit");
			speed = InputSpeed("Ticketed Speed");
			classif = InputYearInSchool();

			Ticket studentTicket = new
				Ticket(studentNumber, classif, speedLimit, speed);
			Clear();
			WriteLine(studentTicket);
			ReadKey();
		}

		public static string InputStudentNumber()
		{
			string sNumber;
			Write("Enter Student Number: ");
			sNumber = ReadLine();
			return sNumber;
		}

		public static int InputSpeed(string whichSpeed)
		{
			string inValue;
			int speed;

			Write("Enter the {0}: ", whichSpeed);
			inValue = ReadLine();
			if (int.TryParse(inValue, out speed) == false)
				WriteLine("Invalid entry entered for {0} - " +
						  "0 was recorded", whichSpeed);
			return speed;
		}

		public static char InputYearInSchool()
		{
			string inValue;
			char yrInSchool;
			WriteLine("Enter your classification:");
			WriteLine("\tFreshmen (enter 1)");
			WriteLine("\tSophomore (enter 2)");
			WriteLine("\tJunior (enter 3)");
			Write("\tSenior (enter 4)");
			WriteLine();
			inValue = ReadLine();
			yrInSchool = Convert.ToChar(inValue);
			return yrInSchool;
		}
	}
}

