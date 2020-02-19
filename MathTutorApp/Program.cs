using System;
using static System.Console;
// Utilize https://docs.microsoft.com/en-us/dotnet/api/system.random?view=netframework-4.8 for the random number generator
namespace MathTutorApp
{
    class MathProgram
    {
        
    }
    class StudentInformation
    {
        public string fullname;
        public int gradelevel;
        public int correctAnswers;
        public int incorrectAnswers;


        public int Gradelevel {get => gradelevel; set => gradelevel = value;}
        public string Fullname { get => fullname; set => fullname = value; }

    }

    class Program
    {
        static void Main(string[] args)
        {
            StudentInformation sInfo = new StudentInformation();
            WriteLine("Welcome to the Math Tutor App!");
            WriteLine("");
            WriteLine("This app will ask you questions on basic mathematics skills that an elementary student should master.");
            WriteLine("");
            WriteLine("To get started, please provide your fullname:");
            
            string v = ReadLine();
            sInfo.Fullname = v;

            WriteLine("Enter your grade level [1 to 5]: ");
            string userInput = ReadLine();
            int w = int.Parse(userInput);
            sInfo.Gradelevel = w;

            WriteLine(sInfo.Fullname + ", we appreciate you using the Math Tutor App. When you are ready to be tested on Math skills, press any key to continue");

            ReadKey();
            Clear();

            WriteLine("Specify the math skill that you like to be tested. The following are your options");
            WriteLine("Addition - Enter 1");
            WriteLine("Substraction - Enter 2");
            WriteLine("Multiplication - Enter 3");
            WriteLine("Suprise Me - Enter 4");

            WriteLine("Enter your testing option: ");

            int userTest = Read();
            
            WriteLine("We will be quizzing you on addition skills at the at the K - " + sInfo.Gradelevel + " level. When you are ready to take the quiz, press any key to continue");
            ReadKey();
            Clear();


        }
    }
}
