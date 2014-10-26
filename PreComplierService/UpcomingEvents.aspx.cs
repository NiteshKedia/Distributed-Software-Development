using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UpcomingEvents : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        Label18.Text = "";
        ServiceReference1.Service1Client sc = new ServiceReference1.Service1Client();
        string[] eventresult = sc.getUpcomingEvents(TextBox5.Text, TextBox6.Text);
        if (eventresult == null)
        {
            Label18.Text = "Error !!!";
        }
        else
        {
            TableRow row = new TableRow();


            TableCell cell = new TableCell();
            Label l1 = new Label();
            l1.Text = "EVENT NAME";
            cell.Controls.Add(l1);
            row.Cells.Add(cell);

            cell = new TableCell();
            l1 = new Label();
            l1.Text = "START";
            cell.Controls.Add(l1);
            row.Cells.Add(cell);

            cell = new TableCell();
            l1 = new Label();
            l1.Text = "END";
            cell.Controls.Add(l1);
            row.Cells.Add(cell);

            cell = new TableCell();
            l1 = new Label();
            l1.Text = "ADDRESS";
            cell.Controls.Add(l1);
            row.Cells.Add(cell);

            cell = new TableCell();
            l1 = new Label();
            l1.Text = "DISTANCE(Miles)";
            cell.Controls.Add(l1);
            row.Cells.Add(cell);

            Table3.Rows.Add(row);

            for (int i = 0; i < eventresult.Length; i++)
            {
                string[] res = eventresult[i].Split('|');

                row = new TableRow();

                cell = new TableCell();
                l1 = new Label();
                l1.Text = res[0];
                cell.Controls.Add(l1);
                row.Cells.Add(cell);

                cell = new TableCell();
                l1 = new Label();
                l1.Text = res[1];
                cell.Controls.Add(l1);
                row.Cells.Add(cell);

                cell = new TableCell();
                l1 = new Label();
                l1.Text = res[2];
                cell.Controls.Add(l1);
                row.Cells.Add(cell);

                cell = new TableCell();
                l1 = new Label();
                l1.Text = res[3];
                cell.Controls.Add(l1);
                row.Cells.Add(cell);

                cell = new TableCell();
                l1 = new Label();
                l1.Text = res[4];
                cell.Controls.Add(l1);
                row.Cells.Add(cell);

                Table3.Rows.Add(row);

            }

        }

    }


}