using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InheritanceApp
{
    class Account
    {
        public Account()
        {
            Balance = 0;
        }

        public Account(string number, string customerName):this()
        {
            Number = number;
            CustomerName = customerName;
            
        }

        public string Number { get; set; }
        public string CustomerName { get; set; }
        public double Balance { get; set; }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            Balance -= amount;
        }
    }
}
