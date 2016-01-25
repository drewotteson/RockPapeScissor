using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class Paper
    {
        public Paper()
        {
        }
        public void PrintWinner(string userInput, string aiChoice)
        {
            if (userInput == "paper")
            {
                Console.WriteLine("TIE");
            }
            else if (userInput == "rock")
            {
                Console.WriteLine("paper covers rock, you lose!");
            }
            else if (userInput == "scissor")
            {
                Console.WriteLine("scissor cuts paper, you win!");
            }
            else if (userInput == "lizard")
            {
                Console.WriteLine("lizard eats paper, you win!");
            }
            else if (userInput == "spock")
            {
                Console.WriteLine("paper exposes spock, you lose!");
            }
        }
    }
}
    



