using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_RollTheDie
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
        public int RollDie()
        {
            Random dieRoll = new Random();
            return dieRoll.Next(1, 19);
        }

        public double GenerateSpellStrength()
        {
            Random spellStrength = new Random();
            return spellStrength.Next(0, 100);
        }
    }
}
