using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class Player
    {
        public string userInput;
        public string GetUserInput()
        {
            Console.WriteLine("Type: rock, paper, scissors, lizard, or spock.");
            userInput = Console.ReadLine();
            return userInput;
        }
    }
}
