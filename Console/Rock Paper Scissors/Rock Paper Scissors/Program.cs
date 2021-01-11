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
            int randomChoice;
            bool playAgian = true;

            int cpuPoints = 0;
            int playerPoints = 0;
            
            Random rnd = new Random();

            randomChoice = rnd.Next(1,4);

            Console.WriteLine("Welcome to Rock Paper Scissors. First to 3 wins!\n");

            do
            {
                while (cpuPoints < 3 && playerPoints < 3)
                {
                    randomChoice = rnd.Next(1, 4);

                    Console.WriteLine("Rock, Paper, or Scissors? " + " Player " + playerPoints + " Computer " + cpuPoints);
                    playerInput = Console.ReadLine().ToLower();

                    while (playerInput != "rock" && playerInput != "paper" && playerInput != "scissors")
                    {
                        Console.WriteLine("Rock, Paper, or Scissors? " + " Player " + playerPoints + " Computer " + cpuPoints);
                        playerInput = Console.ReadLine().ToLower();
                    }

                    switch (randomChoice)
                    {
                        case 1:
                            aiInput = "rock";
                            Console.WriteLine("\nComputer chose rock");

                            if (playerInput == "rock")
                            {
                                Console.WriteLine("Draw\n");
                            }
                            else if (playerInput == "paper")
                            {
                                Console.WriteLine("You win!\n");
                                playerPoints++;
                            }
                            else if (playerInput == "scissors")
                            {
                                Console.WriteLine("You lose!");
                                cpuPoints++;
                            }
                            break;

                        case 2:
                            aiInput = "paper";
                            Console.WriteLine("\nComputer chose paper");

                            if (playerInput == "rock")
                            {
                                Console.WriteLine("You lose!\n");
                                cpuPoints++;
                            }
                            else if (playerInput == "paper")
                            {
                                Console.WriteLine("Draw!\n");
                            }
                            else if (playerInput == "scissors")
                            {
                                Console.WriteLine("You win!\n");
                                playerPoints++;
                            }
                            break;

                        case 3:
                            aiInput = "scissors";
                            Console.WriteLine("\nComputer chose scissors");

                            if (playerInput == "rock")
                            {
                                Console.WriteLine("You win!\n");
                                playerPoints++;
                            }
                            else if (playerInput == "paper")
                            {
                                Console.WriteLine("You lose!\n");
                                cpuPoints++;
                            }
                            else if (playerInput == "scissors")
                            {
                                Console.WriteLine("Draw!\n");
                            }
                            break;
                        default:
                            break;
                    }
                }

                if(playerPoints == 3)
                {
                    Console.WriteLine("COngratulations, you win!\n");
                }
                else if(cpuPoints == 3)
                {
                    Console.WriteLine("The Computer has beaten you!\n");
                }

                Console.WriteLine("Would you like to play again? ");
                string keepGoing = Console.ReadLine().ToLower();

                while(keepGoing != "yes" && keepGoing != "no")
                {
                    Console.WriteLine("Would you like to play again? ");
                    keepGoing = Console.ReadLine().ToLower();
                }

                if (keepGoing == "yes")
                {
                    playAgian = true;
                    playerPoints = 0;
                    cpuPoints = 0;
                }
                else if (keepGoing == "no")
                {
                    playAgian = false;
                }

            } while (playAgian);
        }
    }
}
