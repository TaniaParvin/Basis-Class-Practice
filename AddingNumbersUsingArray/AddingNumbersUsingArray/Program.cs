using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AddingNumbersUsingArray
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = new double[5];
double sum = 0;
 
            Console.WriteLine("This program adds five numbers");


for (int index = 0; index<numbers.Length ; index++)
    {
        Console.WriteLine("Enter number " + (index + 1).ToString());
      

       numbers[index] = Convert.ToDouble(Console.ReadLine());
        sum += numbers[index];
    }
Console.WriteLine("Sum of five numbers is: " + sum);
Console.ReadKey();
        }

        }
    
}
