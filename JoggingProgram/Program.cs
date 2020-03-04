using System;
using static System.Console;

namespace JoggingProgram
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Declaring variables
            int initialStrideCount, finalStrideCount, hrs, mins, totalMinutes;
            double numberOfStepsPerMin, distanceTraveled;

            const double STRIDE = 2.5;
            const int FEET_PER_MILE = 5280;

            DisplayInstructions();

            initialStrideCount = GetNumberStrides("first");
            finalStrideCount = GetNumberStrides("last");
            InputJoggingTime(out hrs, out mins);

            totalMinutes = CalculateTime(hrs, mins);
            numberOfStepsPerMin = CalculateAvgSteps(initialStrideCount, finalStrideCount);
            distanceTraveled = CalculateDistance(numberOfStepsPerMin, totalMinutes);

            DisplayResults(numberOfStepsPerMin, mins, hrs, distanceTraveled);

        }

        public static void DisplayInstructions()
        {
            WriteLine("This program will calculate the distance travelled based on the inputs you insert");
            WriteLine("The values entered will be integers and float values");
        }

        public static int GetNumberStrides(string when)
        {
            WriteLine("Enter the {0}, number of steps", when);
            string inValue = ReadLine();
            int numberOfSteps = int.Parse(inValue);
            return numberOfSteps;
        }
        public static void InputJoggingTime(out int hrs, out int mins)
        {
            WriteLine("Enter number of hours");
            string inValue = ReadLine();
            hrs = int.Parse(inValue);

            WriteLine("Enter number of minutes");
            inValue = ReadLine();
            mins = int.Parse(inValue);
        }
        public static double CalculateAvgSteps(int initialStrideCount, int finalStrideCount)
        {
            return (initialStrideCount + finalStrideCount) / 2.0;
        }

        public static int CalculateTime(int hrs, int mins)
        {
            return hrs * 60 + mins;
        }
        public static double CalculateDistance(double numberOfStepsPerMin, int totalMinutes)
        {
            return numberOfStepsPerMin * 2.5 * totalMinutes / 5280;
        }
        public static void DisplayResults(double numberOfStepsPerMin, int mins, int hrs, double distanceTraveled)
        {
            WriteLine("Strides Per Minutes: {0} Steps", numberOfStepsPerMin);
            WriteLine("Jogging Time: {0} Hours {1} Minutes", hrs, mins);
            WriteLine("Distance Traveled: {0} Miles", distanceTraveled);
        }

    }
}