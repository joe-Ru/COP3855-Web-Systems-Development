using System;
using static System.Console;

namespace CarpetCalculator
{
    class CarpetCalculator
    {
        static void Main()
        {
            const int SQ_FT_PER_SQ_YARD = 9;
            const int INCHES_PER_FOOT = 12;
            const string BEST_CARPET = "Berber";
            const string ECONOMY_CARPET = "Pile";

            int roomLengthFeet = 12, roomLengthInches = 2, roomWidthFeet = 14, roomWidthInches = 7;
            double roomLength, roomWidth, carpetPrice, numOfSquareFeet, numOfSquareYards, totalCost;

            roomLength = roomLengthFeet + (double)roomLengthInches / INCHES_PER_FOOT;

            roomWidth = roomWidthFeet + (double)roomWidthInches / INCHES_PER_FOOT;
            numOfSquareFeet = roomLength * roomWidth;

            numOfSquareYards = numOfSquareFeet / SQ_FT_PER_SQ_YARD;

            carpetPrice = 27.95;

            totalCost = numOfSquareYards * carpetPrice;

            WriteLine("The cost of " + BEST_CARPET + " is {0:C}", totalCost);
            WriteLine();

            carpetPrice = 15.95;

            totalCost = numOfSquareYards * carpetPrice;
            WriteLine("The cost of " + ECONOMY_CARPET +" is " + "{0:C}", totalCost);
            ReadKey(); //ReadKey can be used to close the application
        }
    }
}
