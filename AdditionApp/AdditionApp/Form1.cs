using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AdditionApp
{
    public partial class AddtionAppUI : Form
    {
        public AddtionAppUI()
        {
            InitializeComponent();
        }

        int number1;
        int number2;
        int result ;
       // int add = 0;

        private void resultButton_Click(object sender, EventArgs e)
        {
         number1 = Convert.ToInt16(number1TextBox.Text);
            number2 = Convert.ToInt16(number2TextBox.Text);

            result = number1 * number2;
            resultTextBox.Text = result.ToString();

        }

       
    }
}
