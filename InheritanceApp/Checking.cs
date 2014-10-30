using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InheritanceApp
{
    class Checking:Account
    {
        public double ServiceCharge { get; set; }
        public int NoOfTransaction { get; set; }

        public Checking(string number, string customerName, double serviceCharge):base (number,customerName)
        {
            
            ServiceCharge = serviceCharge;
        }
    }
}
