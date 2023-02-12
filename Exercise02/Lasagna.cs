using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02
{
    internal class Lasagna
    {
        static void Main(string[] args)
        {

        }

        static int ExpectedMinutesInOven()
        {
            return 40;
        }

        static int RemainingMinutesInOven(int CurrentMinutesInOven)
        {
            return ExpectedMinutesInOven() - CurrentMinutesInOven;
        }

        static int PreparationTimeInMinutes(int numberOfLasagnaLayers)
        {
            return numberOfLasagnaLayers * 2;
        }

        static int ElapsedTimeInMinutes(int numberOfLasagnaLayers, int CurrentMinutesInOven)
        {
            return PreparationTimeInMinutes(numberOfLasagnaLayers) + CurrentMinutesInOven;
        }

    }
}
