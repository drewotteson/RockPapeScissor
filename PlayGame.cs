using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class PlayGame
    {
        Paper paper = new Paper();
        Scissors scissors = new Scissors();
        Spock spock = new Spock();
        Rock rock = new Rock();
        Lizard lizard = new Lizard();
        Player player = new Player();
        Opponent opponent = new Opponent();
        
        public void Play()
        {
            for (int i = 0; i < 10; i++)
            {
                string userInput = player.GetUserInput();
                string aiInput = opponent.aiInput();
                VerifyInput(userInput, aiInput);
            }
            //lizard.displayLoss(player.userInput, opponent.aiChoice);
            //scissors.ReturnWinner(3);
            Console.ReadLine();
            
        }
        public void VerifyInput(string userChoice, string aiChoice)
        {
            if(aiChoice == "rock")
            {
                rock.PrintWinner(userChoice, aiChoice);
            }
            else if(aiChoice == "paper")
            {
                paper.PrintWinner(userChoice, aiChoice);
            }
            else if (aiChoice == "scissor")
            {
                scissors.PrintWinner(userChoice, aiChoice);
            }
            else if (aiChoice == "lizard")
            {
                lizard.PrintWinner(userChoice, aiChoice);
            }
            else if (aiChoice == "spock")
            {
                spock.PrintWinner(userChoice, aiChoice);
            }
        }
        //public string FileWrite()
        //{

        }
    }
