using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Required : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Label6.Text = "";
        string topic = TextBox1.Text;
        ServiceReference1.Service1Client sc = new ServiceReference1.Service1Client();
        String returnedNews = sc.NewsFocus(topic);
        String[] News = returnedNews.Split('\n');

        TableRow row = new TableRow();
        TableCell cell = new TableCell();
        Label l1 = new Label();
        l1.Text = "Current NEWS";
        cell.Controls.Add(l1);
        row.Cells.Add(cell);

        Table1.Rows.Add(row);

        for (int i = 0; i < News.Length - 1; i++)
        {
            string[] temp = News[i].Split('|');
            row = new TableRow();
            cell = new TableCell();
            //l1 = new Label();
            //l1.Text = temp[0];

            HyperLink h = new HyperLink();
            h.ID = "NEWS" + i;
            h.Text = temp[0];
            h.NavigateUrl = temp[1];
            cell.Controls.Add(h);
            row.Cells.Add(cell);
            Table1.Rows.Add(row);

        }
    }
}