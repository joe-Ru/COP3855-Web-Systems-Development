using System;
using static System.Console;

namespace ArrayApplication
{
    class MyArray
    {
        static void Main(string[] args)
        {
            WriteLine("Enter n: ");
            string inValue = ReadLine();

            int n = int.Parse(inValue);
            Fact(n);

        }

        public static int Fact(int n)
        {
            if (n == 1 || n == 0)
                return 1;
            else
                return (n * Fact(n - 1));
        }

    }
}
