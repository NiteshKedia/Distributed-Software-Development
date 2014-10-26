using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Temperature
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();


        }


        //convert celcius to fahrenheit on press of enter
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                
                string objTextBox = textBox1.Text;
                if (objTextBox != null && objTextBox != "")
                {
                    int numVal = Convert.ToInt32(objTextBox);
                    ServiceReference1.Service1Client obj = new ServiceReference1.Service1Client();
                    int returned_value = obj.c2f(numVal);
                    Console.WriteLine(returned_value);
                    label5.Text = returned_value.ToString();
                }
                else
                    label5.Text = "Please Enter a value";
                            }
        }

        //convert fahrenheit to celcius on press of enter
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                string objTextBox = textBox2.Text;
                if (objTextBox != null && objTextBox != "")
                {
                    int numVal = Convert.ToInt32(objTextBox);
                    ServiceReference1.Service1Client obj = new ServiceReference1.Service1Client();
                    int returned_value = obj.f2c(numVal);
                    Console.WriteLine(returned_value);
                    label6.Text = returned_value.ToString();
                }
                else
                    label6.Text = "Please Enter a value";

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        

    
       

       
    }
}
