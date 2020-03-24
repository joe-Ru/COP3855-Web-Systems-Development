// Joseph G. Ruiz N00916743

using System;
using static System.Console;

namespace LoanApp
{
    class Loan
    {
        private double loanAmount, rate, monthInterest, paymentAmount, totalInterestPaid, balance, principal;
        private int numPayments;
        public Loan()
        {

        }
        public Loan(double loan, double interestRate, int years)
        {
            loanAmount = loan;
            if (interestRate < 1)
            {
                rate = interestRate;
            }
            else
            {
                rate = interestRate / 100;
            }
            numPayments = 12 * years;
            totalInterestPaid = 0;
            DeterminePaymentAmount();
        }
        public double TotalInterestPaid
        {
            get
            {
                return totalInterestPaid;
            }
        }
        public double PaymentAmount
        {
            get
            {
                return paymentAmount;
            }
        }
        public double LoanAmount
        {
            set
            {
                loanAmount = value;
            }
            get
            {
                return loanAmount;
            }
        }

        public double Rate
        {
            set
            {
                rate = value;
            }
            get
            {
                return rate;
            }
        }
        public int Years
        {
            set
            {
                numPayments = value * 12;
            }
            get
            {
                return numPayments / 12;
            }
        }
        public void DeterminePaymentAmount()
        {
            double term = Math.Pow((rate + 1 / 12), numPayments);
            paymentAmount = (rate * loanAmount / 12 * term) / (term - 1.0);
        }

        public string ReturnAmortizationSchedule()
        {

            string aSchedule = "Month\t\tInt.\t\tPrin.\t\tNew\nNo.\t\tPd.\t\tPd.\t\tBalnace\n-------\t\t-------\t\t--------\t----------\n";
            balance = loanAmount;
            for (int month = 1; month <= numPayments; month++)
            {

                CalculateMonthCharges(month, numPayments);
                
                aSchedule += month + "\t\t" + monthInterest.ToString("N2") + "\t\t" + principal.ToString("N2") + "\t\t" + balance.ToString("C") + "\n";
            }
            return aSchedule;
        }

        public void DetermineTotalInterestPaid()
        {
            totalInterestPaid = 0;
            balance = loanAmount;
            for (int month = 1; month <= numPayments; month++)
            {
                CalculateMonthCharges(month, numPayments);
                totalInterestPaid += monthInterest;
                month++;
            }
        }

        public void CalculateMonthCharges(int month, int numPayments)
        {
            double payment = paymentAmount;

            monthInterest = rate / 12 * balance;
            if (month == numPayments)
            {
                principal = balance;
                payment = balance + monthInterest;
            }
            else
            {
                principal = payment - monthInterest;
            }
            balance = balance - principal;
        }

    }
    class LoanApp
    {
        static void Main()
        {
            double loanAmount, interestRate;
            int years;
            string inValue;
            char anotherLoan = 'N';
            do
            {
                GetInputValues(out loanAmount, out interestRate, out years);
                Loan loan = new Loan(loanAmount, interestRate, years);
                WriteLine();

                WriteLine(loan);

                loan.DetermineTotalInterestPaid();
               
                WriteLine(loan.ReturnAmortizationSchedule());
                
                WriteLine("Payment Amount: {0:C}", loan.PaymentAmount);
                WriteLine("Interest Paid over Life of Loan: {0:C}", loan.TotalInterestPaid);
                WriteLine("Do another Calculation? (Y or N)");
                inValue = ReadLine();
                anotherLoan = Convert.ToChar(inValue);
            } 
            while ((anotherLoan == 'Y') || (anotherLoan == 'y'));
        }

        public static void GetInputValues(out double loanAmount, out double interestRate, out int years)
        {
            WriteLine("Enter Loan amount: ");
            string stringLoanAmount = ReadLine();
            loanAmount = double.Parse(stringLoanAmount);

            WriteLine("Enter interest rate (as a decimal value: ");
            string stringInterestRate = ReadLine();
            interestRate = double.Parse(stringInterestRate);

            WriteLine("Enter number of years to finance: ");
            string stringYears = ReadLine();
            years = int.Parse(stringYears);
        }

    }
}
