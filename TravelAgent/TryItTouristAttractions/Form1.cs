using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TryItTouristAttractions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            attractiontable.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            attractiontable.Visible = false;
            attractiontable.Controls.Clear();
            ServiceReference1.Service1Client obj = new ServiceReference1.Service1Client();
            string[] nearestTouristAttractions = obj.getTouristAttraction(textBox1.Text, textBox2.Text);
            if (nearestTouristAttractions[0].Equals("error"))
            {
                label3.Text = "Error !!!";
            }
            else
            {
                attractiontable.AutoSize = true;
                attractiontable.TabIndex = 0;
                attractiontable.ColumnCount = 4;
                attractiontable.RowCount = nearestTouristAttractions.Length+1;
                Label et_tag = new Label();
                et_tag.AutoSize = true;
                et_tag.Text = "NAME";
                et_tag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                attractiontable.Controls.Add(et_tag, 0, 0);

                 et_tag = new Label();
                et_tag.AutoSize = true;
                et_tag.Text = "ADDRESS";
                et_tag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                attractiontable.Controls.Add(et_tag, 1, 0);

                 et_tag = new Label();
                et_tag.AutoSize = true;
                et_tag.Text = "TYPE";
                et_tag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                attractiontable.Controls.Add(et_tag, 2, 0);

                 et_tag = new Label();
                et_tag.AutoSize = true;
                et_tag.Text = "RATING";
                et_tag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                attractiontable.Controls.Add(et_tag,3, 0);

                

                for(int i=0;i<nearestTouristAttractions.Length;i++)
                {
                    string result = nearestTouristAttractions[i];
                    string[] results = result.Split('|');

                    et_tag = new Label();
                    et_tag.AutoSize = true;
                    et_tag.Text = results[0];
                    attractiontable.Controls.Add(et_tag, 0,i+1);

                    et_tag = new Label();
                    et_tag.AutoSize = true;
                    et_tag.Text = results[1];
                    attractiontable.Controls.Add(et_tag, 1, i+1);

                    et_tag = new Label();
                    et_tag.AutoSize = true;
                    et_tag.Text = results[2];
                    attractiontable.Controls.Add(et_tag, 2, i+1);

                    et_tag = new Label();
                    et_tag.AutoSize = true;
                    et_tag.Text = results[3];
                    attractiontable.Controls.Add(et_tag, 3, i+1);
                }
                attractiontable.Visible = true;


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
