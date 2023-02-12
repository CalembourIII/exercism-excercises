using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise04
{
    internal class QuestLogic
    {
        static void Main(string[] args)
        {

        }

        public static bool CanFastAttack(bool knightIsAwake)
        {
            if (knightIsAwake == true)
            {
                return false;
            }

            else
            {
                return true;
            }
        }

        public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
        {
            return knightIsAwake || archerIsAwake || prisonerIsAwake;
        }

        public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
        {
            if (archerIsAwake == false && prisonerIsAwake == true)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
        {
            if ((petDogIsPresent == true && archerIsAwake == false) || 
                (prisonerIsAwake == true && archerIsAwake == false && knightIsAwake == false))
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
