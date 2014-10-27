using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ArList
{
    public partial class Form1 : Form
    {
        int id;
        string name;
        double salary;
        public Form1()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt16(idTextBox.Text);
            name = nameTextBox.Text;
            salary = Convert.ToDouble(salaryTextBox.Text);
            idTextBox.Text = "";
            nameTextBox.Text = "";
            salaryTextBox.Text = "";
            MessageBox.Show("All items are saved.");

        }

        private void retriveButton_Click(object sender, EventArgs e)
        {
            idTextBox.Text = id.ToString();
            nameTextBox.Text = name;
            salaryTextBox.Text = salary.ToString();
        }
    }
}
