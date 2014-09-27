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

namespace SalaryCalculatorApp
{
    public partial class Form1 : Form
    {
        SalaryCalculator aSalaryCalculator=new SalaryCalculator();
        public string name;
        public double basicAmount;
        public double houseRent;
        public double medicalAllowance;
        public double salary;

        

        public Form1()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
           name = nameTextBox.Text;
            basicAmount = Convert.ToDouble(amountTextBox.Text);
            houseRent = Convert.ToDouble(houseRentTextBox.Text);
            medicalAllowance = Convert.ToDouble(medicalTextBox.Text);
            salary = Convert.ToDouble(aSalaryCalculator.calculateSalary(basicAmount, houseRent, medicalAllowance));
            string msg = name + "  your salary is " + Convert.ToString(salary);

           // MessageBox.Show(Convert.ToString(salary));
            MessageBox.Show(msg);
        }
    }
}
