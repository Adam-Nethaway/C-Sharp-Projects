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
            
            Random random = new Random();
            randomNumber = random.Next(1, 100);

            do
            {
                Console.WriteLine("Guess a number between 1 and 100. " + (10 - guessNumber) + " guesses remaining ");
                string playerGuess = Console.ReadLine();

                if (guessNumber < randomNumber)
                {
                    Console.WriteLine("Too low.. guess again\n ");
                    guessNumber++;
                }
                else if (guessNumber > randomNumber)
                {
                    Console.WriteLine("Too high, guess again\n ");
                    guessNumber++;
                }
                else if (guessNumber == randomNumber)
                {
                    Console.WriteLine("That is correct! Play Again?" );
                }     
            } while(guessNumber < 10 && playagain);

            string keepGoing = Console.ReadLine().ToLower();

            while (keepGoing != "yes" && keepGoing != "no")
            {
                Console.WriteLine("Yes or No?");
                keepGoing = Console.ReadLine().ToLower();
            }

            if (keepGoing == "no")
            {
                playagain = false;
            }

        }
    }
}
