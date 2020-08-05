using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaperPlaneRace.Business
{
    class Allan : Punter
    {
        public Allan()
        {
            punterName = "Allan";
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
