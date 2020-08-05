using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaperPlaneRace.Business
{
    abstract class Punter
    {
        public string punterName { get; set; }
        public int punterBalance { get; set; }
        public int punterBetPlane { get; set; }
        public bool punterHasBet { get; set; }
        public int punterBetAmount { get; set; }
        public bool punterIsBusted { get; set; }
        public string winningPlane { get; set; }
        public Label myLabel { get; set; }
        public RadioButton myRadioButton { get; set; }
        public TextBox myTextBoxBet { get; set; }
    }
}
