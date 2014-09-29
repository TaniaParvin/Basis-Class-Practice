using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BonusCalculationApp
{
    public partial class Form1 : Form
    {
        double basicSalary;
        double bonus;
        double total;
        public Form1()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            basicSalary=Convert.ToDouble(salaryTextBox.Text);
            salaryTextBox.Text = string.Empty;

            if(basicSalary>=10000)
            {
                bonus=20;
              bonusTextBox.Text=Convert.ToString(bonus);
            }

            else if(basicSalary>=8000 && basicSalary<=10000)
            {
                bonus = 12;
                bonusTextBox.Text = Convert.ToString(bonus);
            }
            else
            {
                bonus = 10;
                bonusTextBox.Text = Convert.ToString(bonus);
            }
        }

        private void totalButton_Click(object sender, EventArgs e)
        {
            total = basicSalary + (basicSalary * bonus / 100);
            totalTextBox.Text = Convert.ToString(total);
        }
    }
}
