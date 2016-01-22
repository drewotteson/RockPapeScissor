using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class PlayGame
    {
        static Rock rock;
        static Paper paper;
        static Scissors scissors;
        

        public PlayGame()
        {
            rock = new Rock();
            paper = new Paper();
            scissors = new Scissors();
            scissors.ReturnWinner(3);
            Console.Read();
        }
     
    }

}