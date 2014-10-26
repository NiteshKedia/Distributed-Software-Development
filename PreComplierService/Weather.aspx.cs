using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Weather : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Label6.Text = "";
        ServiceReference1.Service1Client sc = new ServiceReference1.Service1Client();
        String returnedWeather = sc.Weather5day(TextBox1.Text);
        if (returnedWeather.Equals("Please enter a valid Zip code") || returnedWeather.Equals("No data available right now"))
        {
            Label6.Text = returnedWeather;
            return;
        }
        else
        {
            String[] ret = returnedWeather.Split('\n');
            int numLines = ret.Length;

            TableRow row = new TableRow();
            TableCell cell = new TableCell();
            Label l1 = new Label();
            l1.Text = "DAY/TIME";
            cell.Controls.Add(l1);
            row.Cells.Add(cell);

            
            cell = new TableCell();
            l1 = new Label();
            l1.Text = "WEATHER";
            cell.Controls.Add(l1);
            row.Cells.Add(cell);

            Table1.Rows.Add(row);

            for (int i = 0; i < ret.Length - 1; i++)
            {
                string[] temp = ret[i].Split(':');

                row = new TableRow();
                cell = new TableCell();
                l1 = new Label();
                l1.Text = temp[0];
                cell.Controls.Add(l1);
                row.Cells.Add(cell);

                
                cell = new TableCell();
                l1 = new Label();
                l1.Text = temp[1];
                cell.Controls.Add(l1);
                row.Cells.Add(cell);

                Table1.Rows.Add(row);

            }


        }
    }
}