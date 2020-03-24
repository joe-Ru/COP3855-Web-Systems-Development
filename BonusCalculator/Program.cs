using System;
using static System.Console;
namespace BonusApp
{
    class BonusCalculator
    {
        static void Main()
        {
            string inValue;
            double salesForYear, bonusAmount = 0M;
            WriteLine("Do you get a bonus this year?");
            WriteLine();
            WriteLine("To determine if you are due one, ");
            Write("enter your gross sales figure: ");
            inValue = ReadLine();
            salesForYear = Convert.ToDouble(inValue);
            if (salesForYear > 500000.00)
            {
                WriteLine();
                WriteLine("YES...you get a bonus!");
                bonusAmount = 1000.00;
            }
            WriteLine("Bonus for the year: {0:C}", bonusAmount);

            ReadLine();
        } // end of Main( ) method
    }  // end of class BonusCalculator 
}  // end of BonusApp namespace
