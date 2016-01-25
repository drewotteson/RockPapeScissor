using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class Rock
    {
        public Rock()
        {

        }
        public void PrintWinner(string userInput, string aiChoice)
        {
            if (userInput == "rock")
            {
                Console.WriteLine("TIE");
            }
            else if (userInput == "spock")
            {
                Console.WriteLine("Spock vaporizes rock, you win!");
            }
            else if (userInput == "scissor")
            {
                Console.WriteLine("Rock crushes scissors, you lose!");
            }
            else if (userInput == "lizard")
            {
                Console.WriteLine("The lizard was crushed by the rock, you lose!");
            }
            else if (userInput == "paper")
            {
                Console.WriteLine("Paper covers rock, you win!");
            }
        }
    }
}

