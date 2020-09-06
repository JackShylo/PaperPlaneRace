using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaperPlaneRace.Business
{
    class Bet
    {
        public static string PlaceBet(Punter[] myPunters, string punterName, int punterBetAmount, int punterBetPlane)
        {
            for (int i = 0; i < myPunters.Length; i++)
            {
                if (myPunters[i].punterName == punterName)
                {
                    myPunters[i].punterBetPlane = punterBetPlane;
                    myPunters[i].punterBetAmount = punterBetAmount;
                    myPunters[i].punterHasBet = true;

                    if (punterBetAmount == 0)
                    {
                        return $@"BUSTED";
                    }
                    else
                    {
                        return $@"{myPunters[i].punterName} has bet {myPunters[i].punterBetAmount} on Plane {myPunters[i].punterBetPlane}";
                    }
                }
            }
            return null;
        }

        public static bool HaveAllPuntersBet(Punter[] myPunters)
        {
            int betCount = 0;

            for (int i = 0; i < myPunters.Length; i++)
            {
                if (myPunters[i].punterHasBet == true)
                {
                    betCount++;
                }
            }

            if (betCount == (myPunters.Length - 1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string[] FindRoundResults(Punter[] myPunters, int planeID)
        {
            string[] result = new string[myPunters.Length];

            for (int i = 0; i < myPunters.Length; i++)
            {
                if (planeID == myPunters[i].punterBetPlane)
                {
                    myPunters[i].punterBalance = (myPunters[i].punterBalance + myPunters[i].punterBetAmount);
                    result[i] = ($@"{myPunters[i].punterName} Won ${myPunters[i].punterBetAmount} by betting on plane #{myPunters[i].punterBetPlane}");
                }
                else
                {
                    myPunters[i].punterBalance = (myPunters[i].punterBalance - myPunters[i].punterBetAmount);
                    result[i] = ($@"{myPunters[i].punterName} Lost ${myPunters[i].punterBetAmount} by betting on plane #{myPunters[i].punterBetPlane}");
                }
            }

            return result;
        }
    }
}
