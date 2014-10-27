using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EscapeChar
{
    class Program
    {
        static void Main(string[] args)
        {
           // string greetings = "Hello everyone.\nWelcome to OOP class";
           // Console.WriteLine(greetings);

            //string address = @"C:\Software\Books\Beginning";
            string address = @"""Hello everyone"" ,said the the trainer.";

            Console.WriteLine(address);
            Console.ReadKey(); 
        }
    }
}
