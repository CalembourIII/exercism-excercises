using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_InterestIsInteresting
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
        public static float InterestRate(decimal balance)
        {
            if (balance < 0)
            {
                return 3.213f;
            }
            else if (balance >= 0 && balance < 1000)
            {
                return 0.5f;
            }
            else if (balance >= 1000 && balance < 5000)
            {
                return 1.621f;
            }
            else
            {
                return 2.475f;
            }
        }

        public static decimal Interest(decimal balance)
        {
            //decimal interestRate = Convert.ToDecimal(InterestRate(balance));
            //return balance * (interestRate / 100);
            return balance * (Convert.ToDecimal(InterestRate(balance)) / 100);
        }

        public static decimal AnnualBalanceUpdate(decimal balance)
        {
            //decimal interest = Interest(balance);
            //return balance + interest;
            return Interest(balance) + balance;
        }

        public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
        {
            int yearsToTarget = 0;
            while (balance < targetBalance)
            {
                balance = AnnualBalanceUpdate(balance);
                ++yearsToTarget;
            }
            return yearsToTarget;
        }

        public static int YearsBeforeDesiredBalance2(decimal balance, decimal targetBalance)
        {
            int yearsToTarget = 0;
            do
            {
                balance = AnnualBalanceUpdate(balance);
                ++yearsToTarget;
            } while (balance < targetBalance);
            return yearsToTarget;
        }
    }
}
