using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ConditionalApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string planetName;

        
        private void planetNumberButton_Click(object sender, EventArgs e)
        {
          planetName = planetComboBox.Text;

            if (planetName == "Saturn")
            {
                MessageBox.Show("It is in 3rd position");
            }
            else if(planetName=="Urenus")
           {
                MessageBox.Show("It is in 4th Position");
            }
            else if(planetName=="Neptune")
            {
                MessageBox.Show("It is in 5th position");
            }
            else if (planetName == "Pluto")
            {
                MessageBox.Show("It is in 6th position");
            }
            else
            {
                MessageBox.Show("I don't know!");
            }
        }

        
    }
}
