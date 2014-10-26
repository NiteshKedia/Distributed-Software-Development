using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TryItWeather
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            weather.Text = "";
            weathertable.Visible = false;
            weathertable.Controls.Clear();
                ServiceReference1.Service1Client obj = new ServiceReference1.Service1Client();
                String returnedWeather = obj.Weather5day(textBox2.Text);
                if (returnedWeather.Equals("Please enter a valid Zip code") || returnedWeather.Equals("No data available right now"))
                {
                    weather.Text = returnedWeather;
                    return;
                }

                String[] ret = returnedWeather.Split('\n');
                //weather.Text = returnedWeather;
                int numLines = ret.Length;
                // TableLayoutPanel dynamicTableLayoutPanel = new TableLayoutPanel();
                //weathertable.Location = new System.Drawing.Point(209, 151);
                weathertable.Name = "weathertable";
                //dynamicTableLayoutPanel.Size = new System.Drawing.Size(400, 200);
                weathertable.AutoSize = true;
                weathertable.TabIndex = 0;
                weathertable.ColumnCount = 2;
                weathertable.RowCount = numLines;
                weathertable.Visible = true;

                for (int row = 0; row < weathertable.RowCount - 1; row++)
                {
                    for (int column = 0; column < weathertable.ColumnCount; column++)
                    {
                        Label et_tag = new Label();
                        et_tag.AutoSize = true;
                        String[] data = ret[row].Split(':');
                        et_tag.Text = data[column];
                        weathertable.Controls.Add(et_tag, column, row);
                    }
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
