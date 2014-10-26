using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TryItUpcomingEvents
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            eventtable.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            ServiceReference1.Service1Client obj = new ServiceReference1.Service1Client();
            string[] eventresult = obj.getUpcomingEvents(textBox1.Text, textBox2.Text);
           
            
            if (eventresult == null)
            {
                label3.Text = "Error !!!";
            }
            else
            {
                eventtable.Visible = false;
                eventtable.Controls.Clear();
                eventtable.AutoSize = true;
                eventtable.TabIndex = 0;
                eventtable.ColumnCount = 5;
                eventtable.RowCount = eventresult.Length + 1; 

                Label et_tag = new Label();
                et_tag.AutoSize = true;
                et_tag.Text = "Event Name";
                et_tag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                eventtable.Controls.Add(et_tag, 0, 0);

                et_tag = new Label();
                et_tag.AutoSize = true;
                et_tag.Text = "Start";
                et_tag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                eventtable.Controls.Add(et_tag, 1, 0);

                et_tag = new Label();
                et_tag.AutoSize = true;
                et_tag.Text = "End";
                et_tag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                eventtable.Controls.Add(et_tag, 2, 0);

                et_tag = new Label();
                et_tag.AutoSize = true;
                et_tag.Text = "Address";
                et_tag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                eventtable.Controls.Add(et_tag, 3, 0);

                et_tag = new Label();
                et_tag.AutoSize = true;
                et_tag.Text = "Distance(Miles)";
                et_tag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                eventtable.Controls.Add(et_tag, 4, 0);


                for (int i = 0; i < eventresult.Length; i++)
                {
                    string result = eventresult[i];
                    string[] results = result.Split('|');

                    et_tag = new Label();
                    et_tag.AutoSize = true;
                    et_tag.Text = results[0];
                    eventtable.Controls.Add(et_tag, 0, i + 1);

                    et_tag = new Label();
                    et_tag.AutoSize = true;
                    et_tag.Text = results[1];
                    eventtable.Controls.Add(et_tag, 1, i + 1);

                    et_tag = new Label();
                    et_tag.AutoSize = true;
                    et_tag.Text = results[2];
                    eventtable.Controls.Add(et_tag, 2, i + 1);

                    et_tag = new Label();
                    et_tag.AutoSize = true;
                    et_tag.Text = results[3];
                    eventtable.Controls.Add(et_tag, 3, i + 1);

                    et_tag = new Label();
                    et_tag.AutoSize = true;
                    et_tag.Text = results[4];
                    eventtable.Controls.Add(et_tag, 4, i + 1);
                }
                eventtable.Visible = true;

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
