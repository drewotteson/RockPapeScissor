using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    interface IMatchStatus
    {
        void displayLoss(string firstchoice, string secondchoice);
        void displayWin(string firstchoice, string secondchoice);
    }
}
