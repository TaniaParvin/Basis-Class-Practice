using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TicketPurchaseApp
{
    public partial class TicketPurchaseUI : Form
    {
        public TicketPurchaseUI()
        {
            InitializeComponent();
        }
        string name;
        int noOfTickets;
        double total;
        int unitPrice = 100;

        private void saveButton_Click(object sender, EventArgs e)
        {
            name = nameTextBox.Text;
            noOfTickets = Convert.ToInt16(ticketsTextBox.Text);
            total = noOfTickets * unitPrice;
            nameTextBox.Text = string.Empty;
            ticketsTextBox.Text = "";
            MessageBox.Show("Data saved successfully");
        }
        

        private void totalButton_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show(name +", please pay "+ total + " taka to purchase" +  noOfTickets + " Tickets");
           
        }
               
             
        private void detailsButton_Click(object sender, EventArgs e)
        {
            
            
            MessageBox.Show("Customer Name: " +name +"\nNumber Of Tickets: " + noOfTickets+ "\nTotal Price: " + total);
        }

        

       
    }
}
