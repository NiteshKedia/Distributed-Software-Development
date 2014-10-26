using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Elective : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Label6.Text = "";
        string lat = TextBox1.Text;
        string lng =  TextBox2.Text;
        string choice = null;
        if (CheckBox1.Checked)
        {
            if (CheckBox2.Checked)
            {
                choice = "bank|atm";

            }
            else
                choice = "bank";
        }
        else
            if (CheckBox2.Checked)
            {
                choice = "atm";
            }
        if (choice == null)
        {
            Label6.Text = "Please select at least one check box";
            return;
        }
        ServiceReference1.Service1Client sc = new ServiceReference1.Service1Client();
        String[] returnedbankatm = sc.getNearestBankAtm(lat,lng,choice);
        if (returnedbankatm == null)
        {
            Label6.Text = "Error !!!";
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
            Label l2 = new Label();
            l2.Text = "ADDRESS";
            cell.Controls.Add(l2);
            row.Cells.Add(cell);

            Table1.Rows.Add(row);

            for (int i = 0; i < returnedbankatm.Length; i++)
            {
                string[] res = returnedbankatm[i].Split('|');
                row = new TableRow();
                

                cell = new TableCell();
                l1= new Label();
                l1.Text = res[0];
                cell.Controls.Add(l1);
                row.Cells.Add(cell);

                cell = new TableCell();
                l2 = new Label();
                l2.Text = res[1];
                cell.Controls.Add(l2);
                row.Cells.Add(cell);

                Table1.Rows.Add(row);

            }   
        }
    }
    
}