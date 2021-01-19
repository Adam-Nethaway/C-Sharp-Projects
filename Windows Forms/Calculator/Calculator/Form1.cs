using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        string userInput = "";
        string firstInput = "";
        string secondInput = "";
        char operation;
        double result = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOne_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            userInput += "1";
            textBox1.Text += userInput;          
        }

        private void buttonTwo_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            userInput += "2";
            textBox1.Text += userInput;
        }

        private void buttonThree_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            userInput += "3";
            textBox1.Text += userInput;
        }

        private void buttonFour_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            userInput += "4";
            textBox1.Text += userInput;
        }

        private void buttonFive_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            userInput += "5";
            textBox1.Text += userInput;
        }

        private void buttonSix_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            userInput += "6";
            textBox1.Text += userInput;
        }

        private void buttonSeven_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            userInput += "7";
            textBox1.Text += userInput;
        }

        private void buttonEight_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            userInput += "8";
            textBox1.Text += userInput;
        }

        private void buttonNine_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            userInput += "9";
            textBox1.Text += userInput;
        }

        private void buttonZero_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            userInput += "0";
            textBox1.Text += userInput;
        }

        private void buttonDecimal_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            userInput += ".";
            textBox1.Text += userInput;
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            operation = '-';
            firstInput = userInput;
            userInput = "";
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            operation = '+';
            firstInput = userInput;
            userInput = "";
            textBox1.Text = "";
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            operation = '*';
            firstInput = userInput;
            userInput = "";
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            operation = '/';
            firstInput = userInput;
            userInput = "";
        }

        private void buttonSquare_Click(object sender, EventArgs e)
        {
            operation = '^';
            firstInput = userInput;
            double square = Convert.ToDouble(firstInput);
            textBox1.Text = Math.Pow(square, 2).ToString();
            userInput = Math.Pow(square, 2).ToString();
        }

        private void buttonRoot_Click(object sender, EventArgs e)
        {
            operation = '√';
            firstInput = userInput;
            double squareRt = Convert.ToDouble(firstInput);
            textBox1.Text = Math.Sqrt(squareRt).ToString();
            userInput = Math.Sqrt(squareRt).ToString();

        }

        private void buttonCe_Click(object sender, EventArgs e)
        {
            userInput = "";
            firstInput = "";
            secondInput = "";
            result = 0.0;
            textBox1.Text = "0";
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            secondInput = userInput;

            double firstNumber, secondNumber;

            firstNumber = Convert.ToDouble(firstInput);
            secondNumber = Convert.ToDouble(secondInput);

            switch (operation)
            {
                case '+':
                    result = firstNumber + secondNumber;
                    textBox1.Text = result.ToString();
                    break;
                case '-':
                    result = firstNumber - secondNumber;
                    textBox1.Text = result.ToString();
                    break;
                case '*':
                    result = firstNumber * secondNumber;
                    textBox1.Text = result.ToString();
                    break;
                case '/':
                    result = firstNumber / secondNumber;
                    textBox1.Text = result.ToString();
                    break;
            }
            
        }
    }
}


