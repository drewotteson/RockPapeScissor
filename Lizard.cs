using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class Lizard
    {
        public Lizard()
        {

        }
        public void PrintWinner(string userInput, string aiChoice)
        {
            if (userInput == "lizard")
            {
                Console.WriteLine("TIE");
            }
            else if (userInput == "rock")
            {
                Console.WriteLine("rock crushes lizard, you win!");
            }
            else if (userInput == "paper")
            {
                Console.WriteLine("lizard eats paper, you lose!");
            }
            else if (userInput == "scissor")
            {
                Console.WriteLine("scissor decapitates lizard, you win!");
            }
            else if (userInput == "spock")
            {
                Console.WriteLine("lizard poisons spock, you lose");
            }
        }
    }

}
