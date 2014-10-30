using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InheritanceApp
{
    class Savings:Account
    {
        public double InterestAmount { get; set; }

        public Savings(string number, string customerName, double interestAmount):base(number,customerName)
        {
            InterestAmount = interestAmount;
        }
    }
}
