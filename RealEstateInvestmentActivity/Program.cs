using System;
using static System.Console;

namespace RealEstateInvestmentActivity
{
    class RealEstateInvestment
    {
        private int yearBuilt;
        private double purchasePrice, incomeFromRent, monthlyExpense;
        private string streetAddress;

        public double MonthlyExpense
        {
            set
            {
                monthlyExpense = value;
            }
            get
            {
                return monthlyExpense;
            }
            

        }
        public double IncomeFromRent
        {
            
            set
            {
                incomeFromRent = value;
            }
            get
            {
                return incomeFromRent;
            }
        }
        public string StreetAddress
        {
            get
            {
                return streetAddress;
            }
        }
        public int YearBuilt
        {
            get
            {
                return yearBuilt;
            }
        }
        public double PurchasePrise
        {
            get
            {
                return purchasePrice;
            }
        }
        public double DetermineMonthlyEarnings()
        {
            return (incomeFromRent - monthlyExpense);
        }

        public RealEstateInvestment(int year, double purchase, string street)
        {
            yearBuilt = year;
            purchasePrice = purchase;
            streetAddress = street;
        }
    }

    class PropertyApp
    {
        
        static void Main(string[] args)
        {
            const double RENTAL_AMOUNT = 1000.00;
            RealEstateInvestment invest1 = new RealEstateInvestment(2004, 150000, "65th Street");

            invest1.MonthlyExpense = GetExpenses();
            invest1.IncomeFromRent = RENTAL_AMOUNT;

            WriteLine("Property Location: " +  invest1.StreetAddress);
            WriteLine("Earnings For Month: " + invest1.DetermineMonthlyEarnings());
        }

        public static double GetExpenses()
        {
            string inValue;
            double insurance, taxes, utilities;

            WriteLine("Enter the insurance rate: ");
            inValue = ReadLine();
            insurance = double.Parse(inValue);

            WriteLine("Enter the taxes: ");
            inValue = ReadLine();
            taxes = double.Parse(inValue);

            WriteLine("Enter utility charges: ");
            inValue = ReadLine();
            utilities = double.Parse(inValue);

            return (insurance / 12 + taxes / 12 + utilities);
        }
    }
}
