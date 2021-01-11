using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Guess_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int randomNumber;
            int guessNumber = 0;
            bool playagain = true;
            int playerGuess;
            
            Random random = new Random();
            randomNumber = random.Next(1, 100);

            do
            {
                Console.WriteLine("Guess a number between 1 and 100. " + (10 - guessNumber) + " guesses remaining ");
                string playerInput = Console.ReadLine();

                playerGuess = ValidateNumber(playerInput);

                if (playerGuess < randomNumber)
                {
                    Console.WriteLine("Too low.. guess again\n ");
                    guessNumber++;
                }
                else if (playerGuess > randomNumber)
                {
                    Console.WriteLine("Too high, guess again\n ");
                    guessNumber++;
                }
                else if (guessNumber == 10)
                {
                    Console.WriteLine("You lose! ");
                }
                else
                {
                    Console.WriteLine("That is correct!");
                    guessNumber = 10;
                }
            } while (guessNumber < 10);

            Console.WriteLine("Thanks for playing. PRESS ENTER TO CLOSE ");
            Console.ReadLine().ToLower();

        }

        static int ValidateNumber(string number)
        {
            int validNumber;

            while (!int.TryParse(number, out validNumber))
            {
                Console.Write("Please only use integers. Try again: ");
                number = Console.ReadLine().ToUpper();
            }

            return validNumber;
        }
    }
}


