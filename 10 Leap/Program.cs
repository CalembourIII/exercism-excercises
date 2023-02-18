using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Leap
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
        public static bool IsLeapYear(int year)
        {
            if ((year % 4 == 0 && year % 100 != 0) || (year % 4 == 0 && year % 100 == 0 && year % 400 == 0))
            {
                return true;
            }
            else return false;
        }
    }
}
