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
        string firstInput, secondINput, operation;
        
        
        public Form1()
        {
            InitializeComponent();
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            firstInput = "0";
            inputBox.Text += ("0");
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            firstInput = "1";
            inputBox.Text += ("1");
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            firstInput = "2";
            inputBox.Text += ("2");
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            inputBox.Text += ("3");
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            inputBox.Text += ("4");
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            inputBox.Text += ("5");
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            inputBox.Text += ("6");
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            inputBox.Text += ("7");
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            inputBox.Text += ("8");
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            inputBox.Text += ("9");
        }

        private void periodButton_Click(object sender, EventArgs e)
        {
            inputBox.Text += (".");
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            inputBox.Text = ("");
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            inputBox.Text = ("");
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            inputBox.Text = ("");
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            inputBox.Text = ("");
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            inputBox.Text = ("");
        }

        private void squareRootButton_Click(object sender, EventArgs e)
        {
            inputBox.Text = ("");
        }

        private void squareButton_Click(object sender, EventArgs e)
        {
            inputBox.Text = ("");
        }

        private void eraseButton_Click(object sender, EventArgs e)
        {
            inputBox.Text = ("");
        }
    }
}
