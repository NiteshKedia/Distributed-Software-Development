using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TryItNearestAirport
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client obj = new ServiceReference1.Service1Client();
            String nearestAirport = obj.GetNearestAirport(textBox1.Text, textBox2.Text);

            if (nearestAirport.Equals("Error"))
            {

            }
            String[] result = nearestAirport.Split('|');

            airport.Text = result[0];
            city.Text = result[1];
            state.Text = result[2];
            country.Text = result[3];
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel ll = sender as LinkLabel;
            string link = ll.Text;
            System.Diagnostics.Process.Start(link);
        }
    }
}
