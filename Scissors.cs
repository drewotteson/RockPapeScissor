﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class Scissors
    {
        public Scissors()
        {

        }
        public void PrintWinner(string userInput, string aiChoice)
        {
            if (userInput == "scissor")
            {
                Console.WriteLine("TIE");
            }
            else if (userInput == "rock")
            {
                Console.WriteLine("rock crushes scissor, you win!");
            }
            else if (userInput == "paper")
            {
                Console.WriteLine("scissor cuts paper, you lose!");
            }
            else if (userInput == "lizard")
            {
                Console.WriteLine("scissor decapitates lizard, you lose!");
            }
            else if (userInput == "spock")
            {
                Console.WriteLine("spock crushes scissor, you win!");
            }
        }
    }
}
    



