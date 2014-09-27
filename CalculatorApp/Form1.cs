using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        Calculator aCalculator= new Calculator();
        //public double firstNumber;
       // public double secondNumber;
        public double result;
        public double firstNumber;
        private double secondNumber;

        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            InitializeFirstNumberAndSecondNumber();
            result = Convert.ToDouble(aCalculator.Addition(firstNumber,secondNumber));
            resultTextBox.Text=Convert.ToString(result);
        }

        private void InitializeFirstNumberAndSecondNumber()
        {
            firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            secondNumber = Convert.ToDouble(secondNumberTextBox.Text);
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            InitializeFirstNumberAndSecondNumber();
            result = Convert.ToDouble(aCalculator.Subtraction(firstNumber, secondNumber));
            resultTextBox.Text = Convert.ToString(result);
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            InitializeFirstNumberAndSecondNumber();
            result = Convert.ToDouble(aCalculator.Multiplication(firstNumber, secondNumber));
            resultTextBox.Text = Convert.ToString(result);
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            InitializeFirstNumberAndSecondNumber();
            result = Convert.ToDouble(aCalculator.Division(firstNumber, secondNumber));
            resultTextBox.Text = Convert.ToString(result);

        }
    }
}
