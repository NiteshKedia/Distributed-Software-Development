using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TryItNearestBankAtm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            banktable.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            String type = null;
            if(checkBox1.Checked)
            {
                if (checkBox2.Checked)
                {
                    type = "bank" + "|" + "atm";
                }
                else
                    type = "bank";
            }
            else if (checkBox2.Checked)
            {
                type = "atm";
            }
            if (type == null)
            {
                label3.Text = "Please select atleast one check box Bank/ATM";
                return;
            }
            banktable.Visible = false;
            banktable.Controls.Clear();
           ServiceReference1.Service1Client obj = new ServiceReference1.Service1Client();
           String[] returnedWeather = obj.getNearestBankAtm(textBox1.Text, textBox2.Text, type);
           if (returnedWeather == null)
           {
               label3.Text = "Error !!!";
           }
           else
           {
               banktable.AutoSize = true;
               banktable.TabIndex = 0;
               banktable.ColumnCount = 2;
               banktable.RowCount = returnedWeather.Length;
               

               for(int i=0;i<returnedWeather.Length;i++)
               {
                   string[] res = returnedWeather[i].Split('|');
                   Label et_tag = new Label();
                   et_tag.AutoSize = true;
                   et_tag.Text = res[0];
                   banktable.Controls.Add(et_tag, 0, i);

                   et_tag = new Label();
                   et_tag.AutoSize = true;
                   et_tag.Text = res[1];
                   banktable.Controls.Add(et_tag, 1, i);
               }
               banktable.Visible = true;


           }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel ll = sender as LinkLabel;
            string link = ll.Text;
            System.Diagnostics.Process.Start(link);
        }
    }
}
