﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculatorApplication
{
    class Calculator
    {
        public double Add(double firstNumber,double secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public double Subtract(double firstNumber,double secondNumber)
        {
            return firstNumber - secondNumber;
        }

        public double Multiply(double firstNumber,double secondNumber)
        {
            return firstNumber * secondNumber;
        }

        public double Divide(double firstNumber,double secondNumber)
        {
            return firstNumber / secondNumber;
        }
    }
}
