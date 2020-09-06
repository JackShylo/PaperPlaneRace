using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaperPlaneRace.Business
{
    public class Factory
    {
        public static Punter GeneratePunter(int id)
        {
            switch (id)
            {
                case 0:
                    return new Allan();
                case 1:
                    return new Brian();
                case 2:
                    return new Colin();
                default:
                    return null;
            }
        }
    }
}
