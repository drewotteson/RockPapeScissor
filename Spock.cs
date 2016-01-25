using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class Spock
    {
        public Spock()
        {

        }
        public void PrintWinner(string userInput, string aiChoice)
        {
            if (userInput == "spock")
            {
                Console.WriteLine("TIE");
            }
            else if (userInput == "rock")
            {
                Console.WriteLine("spock vaporizes rock, you lose!");
            }
            else if (userInput == "paper")
            {
                Console.WriteLine("paper disproves spock, you win!");
            }
            else if (userInput == "scissor")
            {
                Console.WriteLine("spock crushes scissor, you lose!");
            }
            else if (userInput == "lizard")
            {
                Console.WriteLine("lizard poisons spock, you win!");
            }
        }
    }
}

