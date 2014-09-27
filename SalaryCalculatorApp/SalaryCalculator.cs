using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculatorApp
{
    class SalaryCalculator
    {
      
        public double salary;
        
        public double calculateSalary(double basicAmount, double houseRent, double medicalAllowance)
        {
           return salary = basicAmount + (basicAmount*houseRent)/100 + (basicAmount*medicalAllowance)/100;
        }
    }
}
