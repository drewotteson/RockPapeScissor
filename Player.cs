using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Player
    {
        static void Main(string[] args)
        {
            int userInput = 0;
            for (int i = 0; i < 10; i++)
            {
                Random rnd = new Random();
                int number = rnd.Next(1, 4);
                Console.WriteLine("Enter 1 for rock, 2 for paper, 3 for scissors.");
                userInput = Convert.ToInt32(Console.ReadLine());

                Scissors scissors = new Scissors();
                string stringer = scissors.ReturnWinner(userInput);
                Console.WriteLine(stringer);
                Console.Read();
            }
            
        }
    }
}
