using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BookInfoAPp
{
    public partial class Form1 : Form
    {
        string isbnNumber;
        string bookDetails;
        Hashtable aHashtable = new Hashtable();
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            aHashtable.Add("100","Data Structure");
            aHashtable.Add("101","C Programming");
            aHashtable.Add("102","C#");
            
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string isbnNumber = isbnSearchBox.Text;
            string bookDetails = detailsSearchBox.Text;
            string courseName = (string)aHashtable["100"];
        }
    }
}
