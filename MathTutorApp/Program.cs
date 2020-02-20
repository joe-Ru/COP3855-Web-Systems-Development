using System;
using static System.Console;
// Utilize https://docs.microsoft.com/en-us/dotnet/api/system.random?view=netframework-4.8 for the random number generator
namespace MathTutorApp
{
    class Global
    {
		public static int addAnswer;
		public static int addAnswerCorrect;
		public static int subtractAnswer;
		public static int subtractAnswerCorrect;
		public static int multiplyAnswer;
		public static int multiplyAnswerCorrect;
        public static string fullname;
        public static int gradelevel;
    }

    class Program
    {
        private const int V = 1;

        static void Main(string[] args)
        {
            
            WriteLine("Welcome to the Math Tutor App!");
            WriteLine("");
            WriteLine("This app will ask you questions on basic mathematics skills that an elementary student should master.");
            WriteLine("");
            WriteLine("To get started, please provide your fullname:");
            
            string v = ReadLine();
            Global.fullname = v;

            WriteLine("Enter your grade level [1 to 5]: ");
            string userInput = ReadLine();
            int w = int.Parse(userInput);
            Global.gradelevel = w;

            WriteLine(Global.fullname + ", we appreciate you using the Math Tutor App. When you are ready to be tested on Math skills, press any key to continue");

            ReadKey();
            Clear();
            int testInput = menuOption();
            startHere(testInput);
        }
        static void startHere(int userInput)
        {
            var rand = new Random();
            char userChoice = 'c';

            switch(userInput)
            {
                case 1:
                    while(userChoice == 'c')
                    {
                        Addition();
                        userChoice = displayMenu();
                    }
                    if(userChoice == 'm')
                    {
                        userInput = menuOption();
                        startHere(userInput);
                    }
                    else if(userChoice == 'e')
                    {
                        exitProgram();
                    }
                    break;
                case 2:
                    while(userChoice == 'c')
                    {
                        Substraction();
                        userChoice = displayMenu();
                    }
                    if(userChoice == 'm')
                    {
                        userInput = menuOption();
                        startHere(userInput);
                    }
                    else if(userChoice == 'e')
                    {
                        exitProgram();
                    }
                    break;
                case 3:
                    while(userChoice == 'c')
                    {
                        Multiplication();
                        userChoice = displayMenu();
                    }
                    if(userChoice == 'm')
                    {
                        userInput = menuOption();
                        startHere(userInput);
                    }
                    else if(userChoice == 'e')
                    {
                        exitProgram();
                    }
                    break;
                case 4:
                    userInput = rand.Next(1,4);
                    startHere(userInput);
                    break;
            }
        }
        static int menuOption()
        {
            
            WriteLine("Specify the math skill that you like to be tested. The following are your options");
            WriteLine("Addition - Enter 1");
            WriteLine("Substraction - Enter 2");
            WriteLine("Multiplication - Enter 3");
            WriteLine("Suprise Me - Enter 4");
            WriteLine("Enter your testing option: ");

            
            string u =ReadLine();
            int userTest = int.Parse(u);
            string returnTest = "";

            if (userTest == 1) {returnTest = "Addition";}
            else if (userTest == 2) {returnTest = "Subtraction";}
            else if (userTest == 3) {returnTest = "Multiplication";}
            else {returnTest = "Multiplication";}

            WriteLine("We will be quizzing you on " + returnTest + " skills at the at the K - " + Global.gradelevel + " level. When you are ready to take the quiz, press any key to continue");
            ReadKey();
            Clear();
            return userTest;
        }

        static void Addition()
        {
            var rand = new Random();
            int num1 = rand.Next(10);
            int num2 = rand.Next(10);
            int answer = num1 + num2;
            Boolean checking = true;
            string userInput;
            WriteLine(num1 + " + "+ num2 + "= ");
            userInput = ReadLine();
            int userAnswer = int.Parse(userInput);
            Global.addAnswer++;

            checking = check(userAnswer, answer);
            if (checking == true)
            {
                Global.addAnswerCorrect++;
            }
        }
         static void Substraction()
        {
            var rand = new Random();
            int num1 = rand.Next(10);
            int num2 = rand.Next(10);
            int answer = num1 - num2;
            Boolean checking = true;
            string userInput;
            WriteLine(num1 + " - " + num2 + "= ");
            userInput = ReadLine();
            int userAnswer = int.Parse(userInput);
            Global.subtractAnswer++;

            checking = check(userAnswer, answer);
            if (checking == true)
            {
                Global.subtractAnswerCorrect++;
            }
        }
         static void Multiplication()
        {
            var rand = new Random();
            int num1 = rand.Next(100);
            int num2 = rand.Next(100);
            int answer = num1 * num2;
            Boolean checking = true;
            string userInput;
            WriteLine(num1 + " * " + num2 + " = ");
            userInput = ReadLine();
            int userAnswer = int.Parse(userInput);
            Global.multiplyAnswer++;

            checking = check(userAnswer, answer);
            if (checking == true)
            {
                Global.multiplyAnswerCorrect++;
            }
        }

        static char displayMenu()
        {
            string userInput;
            WriteLine("To continue, press c. To view the menu, press m. To exit, press e");
            userInput = ReadLine();
            char userValue = char.Parse(userInput);
            return userValue;
        }
        

        static Boolean check(int userAnswer, int answer) 
        {
            if (userAnswer == answer)
            {
                WriteLine("Very Good!");
                return true;
            }
            else
            {
                WriteLine("Sorry, that is incorrect. The correct answer is " + answer);
                return false;
            }
        }

        static void exitProgram()
        {
			WriteLine("Name: " + Global.fullname);
			WriteLine("Grade: " + Global.gradelevel);
			WriteLine();
			WriteLine("Number of addition questions asked: " + Global.addAnswer);
			WriteLine("Number of addition questions answered correctly: " + Global.addAnswerCorrect);
			WriteLine("");
			WriteLine("Number of subtraction questions asked: " + Global.subtractAnswer);
			WriteLine("Number of subtraction questions answered correctly: " + Global.subtractAnswerCorrect);
			WriteLine("");
			WriteLine("Number of multiplication questions asked: " + Global.multiplyAnswer);
			WriteLine("Number of multiplication questions answered correctly: " + Global.multiplyAnswerCorrect);
			WriteLine("");
			WriteLine("");
			WriteLine("Thank you for using the Math Tutor App! We hope to see you again soon!");
			ReadKey();	
        }
        
    }
}
