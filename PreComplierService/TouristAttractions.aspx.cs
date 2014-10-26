using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TouristAttractions : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button2_Click(object sender, EventArgs e)
    {

        Label14.Text = "";
        string lat = TextBox3.Text;
        string lng = TextBox4.Text;
        ServiceReference1.Service1Client sc = new ServiceReference1.Service1Client();
        string[] nearestTouristAttractions = sc.getTouristAttraction(lat, lng);
        if (nearestTouristAttractions[0].Equals("error"))
        {
            Label14.Text = "Error !!!";
        }
        else
        {
            TableRow row = new TableRow();


            TableCell cell = new TableCell();
            Label l1 = new Label();
            l1.Text = "NAME";
            cell.Controls.Add(l1);
            row.Cells.Add(cell);

            cell = new TableCell();
            l1 = new Label();
            l1.Text = "ADDRESS";
            cell.Controls.Add(l1);
            row.Cells.Add(cell);

            cell = new TableCell();
            l1 = new Label();
            l1.Text = "CATEGORY";
            cell.Controls.Add(l1);
            row.Cells.Add(cell);

            cell = new TableCell();
            l1 = new Label();
            l1.Text = "RATING";
            cell.Controls.Add(l1);
            row.Cells.Add(cell);

            Table2.Rows.Add(row);

            for (int i = 0; i < nearestTouristAttractions.Length; i++)
            {
                string[] res = nearestTouristAttractions[i].Split('|');

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

                Table2.Rows.Add(row);

            }

        }
    }

}