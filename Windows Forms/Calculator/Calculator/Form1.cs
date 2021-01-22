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

            this.KeyPreview = true;

            textBox1.ReadOnly = true;

            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad1 || e.KeyCode == Keys.D1)
            {
                buttonOne.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad2 || e.KeyCode == Keys.D2)
            {
                buttonTwo.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad3 || e.KeyCode == Keys.D3)
            {
                buttonThree.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad4 || e.KeyCode == Keys.D4)
            {
                buttonFour.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad5 || e.KeyCode == Keys.D5)
            {
                buttonFive.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad6 || e.KeyCode == Keys.D6)
            {
                buttonSix.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad7 || e.KeyCode == Keys.D7)
            {
                buttonSeven.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad8 || e.KeyCode == Keys.D8)
            {
                buttonEight.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad9 || e.KeyCode == Keys.D9)
            {
                buttonNine.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad0 || e.KeyCode == Keys.D0)
            {
                buttonZero.PerformClick();
            }
            if (e.KeyCode == Keys.Decimal)
            {
                buttonDecimal.PerformClick();
            }
            if (e.KeyCode == Keys.Add || e.KeyCode == Keys.Oemplus)
            {
                buttonPlus.PerformClick();
            }
            if (e.KeyCode == Keys.Subtract || e.KeyCode == Keys.OemMinus)
            {
                buttonMinus.PerformClick();
            }
            if (e.KeyCode == Keys.Divide || e.KeyCode == Keys.OemQuestion)
            {
                buttonDivide.PerformClick();
            }
            if (e.KeyCode == Keys.Multiply)
            {
                buttonMultiply.PerformClick();
            }
            if (e.KeyCode == Keys.Enter)
            {
                buttonEquals.PerformClick();
            }
        }

        private void buttonOne_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            userInput += "1";
            textBox1.Text += userInput;
            buttonEquals.Focus();
        }

        private void buttonTwo_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            userInput += "2";
            textBox1.Text += userInput;
            buttonEquals.Focus();
        }

        private void buttonThree_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            userInput += "3";
            textBox1.Text += userInput;
            buttonEquals.Focus();
        }

        private void buttonFour_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            userInput += "4";
            textBox1.Text += userInput;
            buttonEquals.Focus();
        }

        private void buttonFive_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            userInput += "5";
            textBox1.Text += userInput;
            buttonEquals.Focus();
        }
        
        private void buttonSix_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            userInput += "6";
            textBox1.Text += userInput;
            buttonEquals.Focus();
        }

        private void buttonSeven_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            userInput += "7";
            textBox1.Text += userInput;
            buttonEquals.Focus();
        }

        private void buttonEight_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            userInput += "8";
            textBox1.Text += userInput;
            buttonEquals.Focus();
        }

        private void buttonNine_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            userInput += "9";
            textBox1.Text += userInput;
            buttonEquals.Focus();
        }

        private void buttonZero_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            userInput += "0";
            textBox1.Text += userInput;
            buttonEquals.Focus();
        }

        private void buttonDecimal_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            userInput += ".";
            textBox1.Text += userInput;
            buttonEquals.Focus();
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            operation = '-';
            firstInput = userInput;
            textBox2.Text = firstInput + "-";
            userInput = "";
            buttonEquals.Focus();
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            operation = '+';
            firstInput = userInput;
            textBox2.Text = firstInput + "+";
            userInput = "";
            textBox1.Text = "";
            buttonEquals.Focus();
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            operation = '*';
            firstInput = userInput;
            textBox2.Text = firstInput + "*";
            userInput = "";
            buttonEquals.Focus();
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            operation = '/';
            firstInput = userInput;
            textBox2.Text = firstInput + "/";
            userInput = "";
            buttonEquals.Focus();
        }

        private void buttonSquare_Click(object sender, EventArgs e)
        {
            operation = '^';
            firstInput = userInput;
            textBox2.Text = firstInput + "^" + "²" + " =";
            double square = Convert.ToDouble(firstInput);
            textBox1.Text = Math.Pow(square, 2).ToString();
            userInput = Math.Pow(square, 2).ToString();
        }

        private void buttonRoot_Click(object sender, EventArgs e)
        {
            operation = '√';
            firstInput = userInput;
            textBox2.Text = "²√" + firstInput + " =";
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
            try
            {
                secondInput = userInput;

                textBox2.Text = firstInput + operation + secondInput + " =";

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

                userInput = result.ToString();

            }
            catch (FormatException)
            {
                textBox1.Text = "Error";
            }
        }
    }
}


