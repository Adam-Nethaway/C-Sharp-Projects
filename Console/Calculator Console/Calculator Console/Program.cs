using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adam_Nethaway_Calculator
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            //memoryRecall created so a total can be stored
            //memoryRecall has to go outside the do loop so it doesn't reset every time the do loop runs

            /*created a boolean for when the program should close called closeProgram and set it to false by default
            Wrapped the code in a do while loop so that the program can stay running.
            At the bottom the code reads "while (!closeProgram)" so when close program is false the loop will keep running*/

            /* created a try loop to catch any exceptions the program might throw
            I put the try inside the do loop so that the try does not break the loop.*/

            string memoryRecall = "";
            string cE;

            bool closeProgram = false;

            do
            {
                try
                {
                    //First number input
                    Console.Write("Enter your first number: ");
                    string firstNumber = Console.ReadLine().ToUpper();

                    //runs ValidateNumber method
                    double validFirstNumber = ValidateNumber(firstNumber, memoryRecall);


                    //------------Ask for operation----------------------------


                    Console.Write("Enter your operation (+, -, *, /, ^ ): ");
                    string operation = Console.ReadLine();

                    //runs the ValidateOperation method
                    string validOperation = ValidateOperation(operation);


                    //---------------------------------------------------------

                    //second number input
                    Console.Write("Enter your second number: ");
                    string secondNumber = Console.ReadLine().ToUpper();

                    //runs the ValidateNumber mehtod
                    double validSecondNumber = ValidateNumber(secondNumber, memoryRecall);



                    //---------------------------------------------------------

                    //set total to empty so that it can be defined later
                    string total = "";

                    //switch statement to declare what operators are valid
                    //the switch looks cleaner than an if statement for this portion
                    switch (validOperation)
                    {
                        case "+":
                            total = (validFirstNumber + validSecondNumber).ToString();
                            //converts it to a string so that it can be written out
                            break;
                        case "-":
                            total = (validFirstNumber - validSecondNumber).ToString();
                            break;
                        case "*":
                            total = (validFirstNumber * validSecondNumber).ToString();
                            break;
                        case "/":
                            if (validSecondNumber == 0)
                            {
                                throw new DivideByZeroException();
                            }
                            else
                            {
                                total = (validFirstNumber / validSecondNumber).ToString();
                            }
                            break;
                        case "^":
                            total = ToPower(validFirstNumber, validSecondNumber).ToString();
                            break;
                        default:
                            break;
                    }

                    //when one of the statements are true it will write out this (as a string because of .ToString
                    Console.WriteLine(validFirstNumber + validOperation + validSecondNumber + " = " + total);


                    //----------------------------------------------------------


                    Console.WriteLine("Would you like to continue? Yes, No, Save? ");
                    cE = Console.ReadLine().ToLower();

                    //Validates if the user wants to continue, close, or save.
                    while (cE != "save" && cE != "yes" && cE != "no")
                    {
                        Console.WriteLine("Would you like to continue? Yes, No, Save? ");
                        cE = Console.ReadLine().ToLower();
                    }

                    switch (cE)
                    {
                        case "save":
                            Console.WriteLine("Your total has been saved, use MR to recall");
                            closeProgram = false;
                            memoryRecall = total;
                            break;
                        case "yes":
                            closeProgram = false;
                            break;
                        case "no":
                            closeProgram = true;
                            break;
                        default:
                            break;
                    }
                }


                //-------------------------------------------------------------------------

                catch (DivideByZeroException) //If the user tries to divide by 0 if will catch and execute this 
                {
                    Console.WriteLine("You cannot divide by zero!! Continue? Yes or No? ");
                    string keepGoing = Console.ReadLine().ToLower();
                    closeProgram = true;

                    //because I made a while loop declaring only "yes" or "no" valid, I do not have to make an if statement for No
                    while (keepGoing != "yes" && keepGoing != "no")
                    {
                        Console.WriteLine("Yes or No only please. Yes or No? ");
                        keepGoing = Console.ReadLine().ToLower();
                    }

                    if (keepGoing == "yes")
                    {
                        closeProgram = false;
                    }
                }
                catch (NegativeExponentException) //Catches if they try to have a negative exponent.
                {
                    Console.WriteLine("Please no negative exponents!! Continue? Yes or No? ");
                    string keepGoing = Console.ReadLine().ToLower();
                    closeProgram = true;

                    while (keepGoing != "yes" && keepGoing != "no")
                    {
                        Console.WriteLine("Yes or No only please. Yes or No? ");
                        keepGoing = Console.ReadLine().ToLower();
                    }

                    if (keepGoing == "yes")
                    {
                        closeProgram = false;
                    }
                }
                catch (DecimalExponentException)
                {
                    Console.WriteLine("Please no decimal exponents!! Continue? Yes or No? ");
                    string keepGoing = Console.ReadLine().ToLower();
                    closeProgram = true;

                    while (keepGoing != "yes" && keepGoing != "no")
                    {
                        Console.WriteLine("Yes or No only please. Yes or No? ");
                        keepGoing = Console.ReadLine().ToLower();
                    }

                    if (keepGoing == "yes")
                    {
                        closeProgram = false;
                    }
                }

                //--------------------------------------------------------------------------


            } while (!closeProgram); //while closeProgram = False the program will loop to the top of the do while loop
        }



        //---------------------Validate whether it is a number------------------------------


        static double ValidateNumber(string number, string memoryRecall)
        {
            double validNumber;

            while (!double.TryParse(number, out validNumber))
            {
                if (number == "MR" && memoryRecall != "") //Put memoryRecall in the method
                {
                    return double.Parse(memoryRecall);
                }

                Console.Write("That is not a valid number, please give a number: ");
                number = Console.ReadLine().ToUpper();
            }

            return validNumber;
        }



        //----------------Validate the operator-------------------------------

        static string ValidateOperation(string validOperation)
        {
            //Validates the operator sign input from the user
            while (validOperation != "+" && validOperation != "-" && validOperation != "*" && validOperation != "/" && validOperation != "^")
            {
                Console.Write("That is not a valid operation, try again: ");
                validOperation = Console.ReadLine();
            }

            return validOperation;
        }



        //--------------Power Method-------------------------------

        static double ToPower(double baseNumber, double powerNumber)
        {
            double result = 1;

            if (powerNumber < 0)
            {
                throw new NegativeExponentException();
            }

            else if (!int.TryParse(powerNumber.ToString(), out _))
            {
                throw new DecimalExponentException();
            }

            for (int i = 0; i < powerNumber; i++)
            {
                result *= baseNumber;
            }
            return result;
        }


        //--------------Exceptions-----------------------------------

        public class NegativeExponentException : Exception //Is this the best way to do this??
        {
        }

        public class DecimalExponentException : Exception
        {
        }

    }
}
