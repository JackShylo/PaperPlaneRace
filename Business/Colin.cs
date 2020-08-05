using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperPlaneRace.Business
{
    class Colin : Punter
    {
        public Colin()
        {
            punterName = "Colin";
            punterBalance = generateBalance();

        }

        private int generateBalance()
        {
            Random myRandom = new Random();
            int newBalance = myRandom.Next(1, 20) * 5;
            return newBalance;
        }
    }
}
