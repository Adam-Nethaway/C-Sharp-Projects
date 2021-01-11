using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    class Program
    {
        static void Main(string[] args)
        {
            string playerInput, aiInput;
            int aiChoice;
            int cpuPoints = 0;
            int playerPoints = 0;
            
            Random randomChoice = new Random();

            aiChoice = randomChoice.Next(1, 4);

            Console.WriteLine("Welcome to Rock Paper Scissors. First to 3 wins!");

            do
            {
                Console.WriteLine("Rock, Paper, or Scissors? " + " Player " + playerPoints + " Computer " + cpuPoints);
                string playerChoice = Console.ReadLine();

                switch (aiChoice)
                {
                    case 1: //Rock
                        Console.WriteLine("Computer chose rock");
                        
                        if (playerChoice == "rock")
                        {
                            Console.WriteLine("Draw\n");
                        }
                        else if (playerChoice == "paper")
                        {
                            Console.WriteLine("You win!\n");
                            playerPoints++;
                        }
                        else if (playerChoice == "scissors")
                        {
                            Console.WriteLine("You lose!");
                            cpuPoints++;
                        }
                        break;
                    case 2: //Paper
                        Console.WriteLine("Computer chose paper");

                        if (playerChoice == "rock")
                        {
                            Console.WriteLine("You lose!\n");
                            cpuPoints++;
                        }
                        else if (playerChoice == "paper")
                        {
                            Console.WriteLine("Draw!\n");
                        }
                        else if (playerChoice == "scissors")
                        {
                            Console.WriteLine("You win!\n");
                            playerPoints++;
                        }
                }

            } while (cpuPoints < 3 && playerPoints < 3);
        }
    }
}
