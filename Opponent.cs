using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class Opponent
    {
        Random rnd = new Random();
        public string aiChoice;
        public string aiInput()
        {
            int number = rnd.Next(1, 5);
            switch (number)
            {
                case 1:
                    aiChoice = "rock";
                    return aiChoice;
                case 2:
                    aiChoice = "paper";
                    return aiChoice;
                case 3:
                    aiChoice = "scissor";
                    return aiChoice;
                case 4:
                    aiChoice = "lizard";
                    return aiChoice;
                case 5:
                    aiChoice = "spock";
                    return aiChoice;
            }
            return aiChoice;
        }

    }
}
    



