using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExceptionApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void totalButton_Click(object sender, EventArgs e)
        {

            try
            {
                byte noOfTickets = Convert.ToByte(noOfTicketsTextBox.Text);
                double total = noOfTickets*100;
                MessageBox.Show(noOfTickets.ToString());

            }
            catch (OverflowException overflowException)
            {

                MessageBox.Show("Please enter number less than 255");
            }
            catch (FormatException formatException)
            {
                MessageBox.Show("Please  Enter number only");
            }

        }
    }
}
