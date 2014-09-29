using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalculatorApplication
{
    public partial class Form1 : Form
    {
        double firstNumber;
        double secondNumber;
        double result;
        Calculator aCalculator = new Calculator();
        public Form1()
        {
            InitializeComponent();
        }
        
        private void addButton_Click(object sender, EventArgs e)
        {
            Initialize();
            result= aCalculator.Add(firstNumber,secondNumber);
            resultTextBox.Text = result.ToString();
        }

        private void Initialize()
        {
            firstNumber = Convert.ToDouble(firstNoTextBox.Text);
            secondNumber = Convert.ToDouble(secondNoTextBox.Text);
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            Initialize();
            result = aCalculator.Subtract(firstNumber,secondNumber);
            resultTextBox.Text = result.ToString();
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            Initialize();
            result = aCalculator.Multiply(firstNumber, secondNumber);
            resultTextBox.Text = result.ToString();
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            Initialize();
            result = aCalculator.Divide(firstNumber, secondNumber);
            resultTextBox.Text = result.ToString();
        }
    }
}
