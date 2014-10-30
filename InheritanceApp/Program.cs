using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InheritanceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Savings sv1=new Savings("sv-001","Mahin",8000);
            sv1.Deposit(30000);
            sv1.Withdraw(200);
            Console.WriteLine(sv1.Balance);
            Checking chk1 = new Checking("Chk-001", "Alvi", 7000);
            chk1.Deposit(67000);
            chk1.Withdraw(300);
            Console.WriteLine(chk1.Balance);
            Console.ReadKey();
        }
    }
}
