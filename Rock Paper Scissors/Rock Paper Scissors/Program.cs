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

            do
            {

            } while (cpuPoints < 3 && playerPoints < 3);
        }
    }
}
