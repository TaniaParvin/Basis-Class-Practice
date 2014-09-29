using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PersonalInformationApp
{
    public partial class PersonalUI : Form
    {
        string firstName;
        string lastName;
        string name;
        string father;
        string mother;
        string parents;
        string address;
             
        public PersonalUI()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (firstName!=null && lastName !=null && father !=null && mother!=null && address != null)
            {
                firstName = firstNameTextBox.Text;
                lastName = lastNameTextBox.Text;
                father = fatherTextBox.Text;
                mother = motherTextBox.Text;
                address = addressTextBox.Text;
                ClearTextBoxes();
                MessageBox.Show("Information are saved.");
            }
            else
            {
                ClearTextBoxes();
                MessageBox.Show("Please Enter All Information." );
            }
        }

        private void ClearTextBoxes()
        {
            firstNameTextBox.Text = string.Empty;
            lastNameTextBox.Text = string.Empty;
            fatherTextBox.Text = "";
            motherTextBox.Text = "";
            addressTextBox.Text = "";
        }   
           
        private string GetFullName()
        {
            return name = firstName +"  "+ lastName;
        }

        

        private void showButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("FirstName: " + firstName + "\nLast Name: " + lastName+"\nFathers Name: " + father +
                "\nMothers Name: " + mother+ "\nAddress: " +address) ;
          
        }

        private void nameButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Name: " + GetFullName());
        }

        

        private void addressButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Address: "+address);
        }

        private void parentsButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fathers Name: " + father + "\nMothers Name: " + mother);
        }
    }
}
