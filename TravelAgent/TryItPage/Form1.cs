using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace TryItPage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void ll_Click(object sender, EventArgs e)
        {
            LinkLabel ll =  sender as LinkLabel;
            string link = ll.Links[0].LinkData.ToString();
            System.Diagnostics.Process.Start(link);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            newstable.Controls.Clear();
            newstable.Visible = false;
           
                ServiceReference1.Service1Client obj = new ServiceReference1.Service1Client();
                String returnedNews = obj.NewsFocus(textBox1.Text);

                String[] News = returnedNews.Split('\n');
                newstable.RowCount = News.Length;
                newstable.AutoSize = true;
                for (int i = 0; i < News.Length - 1; i++)
                {
                    string[] temp = News[i].Split('|');
                    LinkLabel et_tag = new LinkLabel();
                    et_tag.AutoSize = true;
                    LinkLabel.Link link = new LinkLabel.Link();
                    link.LinkData = temp[1];
                    et_tag.Click += new EventHandler(ll_Click);
                    et_tag.Links.Add(link);
                    et_tag.Text = temp[0].ToString();
                    newstable.Controls.Add(et_tag, 0, i);
                }
                newstable.Visible = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel ll = sender as LinkLabel;
            string link = ll.Text;
            System.Diagnostics.Process.Start(link);
            
        }     
    }
}
