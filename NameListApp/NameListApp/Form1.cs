using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NameListApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        ArrayList names = new ArrayList();
      

        private void addButton_Click(object sender, EventArgs e)
        {

           names.Add(nameTextBox.Text);
           nameTextBox.Text = "";

        }
        
        private void showButton_Click(object sender, EventArgs e)
        {
          nameListBox.Items.Clear();  
          foreach(string aName in names)
          {
              nameListBox.Items.Add(aName);
           
          }

         
          countTextBox.Text=names.Count.ToString();
            

         
        }

        
    }
}
