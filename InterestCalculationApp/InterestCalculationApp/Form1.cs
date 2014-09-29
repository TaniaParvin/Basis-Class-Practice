using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InterestCalculationApp
{
    public partial class InterestCalculatorUI : Form
    {
       public string bankName;
       public int time;
       double balance;
       public  double interestRate;
       public double totalInterest;
       public  double totalBalance;

        public InterestCalculatorUI()
        {
            InitializeComponent();
        }

        private void intCalculateButton_Click(object sender, EventArgs e)
        {
            bankName=bankComboBox.Text;

          if(bankName =="Brac Bank" )
          {
              interestRate = 6;
          }
          else if(bankName=="DBBL Bank")
          {
              interestRate = 7;
          }
          else
          {
              interestRate = 8;
          }
          balance = Convert.ToDouble(balanceTextBox.Text);
          time = Convert.ToInt16(timeTextBox.Text);
          totalInterest = balance * time * (interestRate / 100);
          totalBalance = balance + totalInterest;
           
         showInterestLabel.Text = Convert.ToString(totalInterest);
         totalBalanceLabel.Text = Convert.ToString(totalBalance);

        }

        
        
       
       
    }
}
