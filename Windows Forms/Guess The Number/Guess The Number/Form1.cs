using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guess_The_Number
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Random rdm = new Random();
            randomNumber = rdm.Next(1, 100);

        }

        int randomNumber;
        int playerGuess;
        int guessNumber = 0;
        bool playAgain = true;

        private void guessButton_Click(object sender, EventArgs e)
        {

            playerGuess = Convert.ToInt32(playerInput.Text);

            if (playerGuess < randomNumber)
            {
                highLowBox.Text = "Too Low. Guess again..";
            }
            if (playerGuess > randomNumber)
            {
                highLowBox.Text = "Too High. Guess again...";
            }
            if (playerGuess == randomNumber)
            {
                highLowBox.Text = "Congratulations! You win";
                guessButton.Text = "Play again?";
            }
            if (guessButton.Text == "Play again?")
            {
                InitializeComponent();
            }
        }
    }
}
