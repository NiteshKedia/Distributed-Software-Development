using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Xsl;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        //XPathDocument doc = new XPathDocument("http://www.public.asu.edu/~nkedia1/hotel_template.xml");
        //XslCompiledTransform xt = new XslCompiledTransform();
        //xt.Load("http://www.public.asu.edu/~nkedia1/hotel_template.xsl");
        //xt.Transform(doc, null, Response.OutputStream);

        
        string xmlurl = TextBox1.Text;
        XmlDocument xref = new XmlDocument();
        xref.Load(xmlurl); // or its URL

        Table1.BorderStyle = System.Web.UI.WebControls.BorderStyle.Solid;
        Table1.GridLines = GridLines.Both;
        TableRow row = new TableRow();
        row.BackColor = System.Drawing.Color.Yellow;
        TableCell cell = new TableCell();
        Label l1 = new Label();
        l1.Text = "TYPE";
        cell.Controls.Add(l1);
        row.Cells.Add(cell);

        cell = new TableCell();
        l1 = new Label();
        l1.Text = "Name";
        cell.Controls.Add(l1);
        row.Cells.Add(cell);

        cell = new TableCell();
        l1 = new Label();
        l1.Text = "Value";
        cell.Controls.Add(l1);
        row.Cells.Add(cell);

        Table1.Rows.Add(row);
        preorderTraverse(xref.DocumentElement);
        Console.WriteLine("Done");
    }

    void preorderTraverse(XmlNode node)
    { // recursive method


        TableRow row = new TableRow();
        TableCell cell = new TableCell();
        Label l1 = new Label();
        l1.Text = node.NodeType.ToString();
        cell.Controls.Add(l1);
        row.Cells.Add(cell);

        cell = new TableCell();
        l1 = new Label();
        l1.Text = node.Name;
        cell.Controls.Add(l1);
        row.Cells.Add(cell);

        cell = new TableCell();
        l1 = new Label();
        l1.Text = node.Value;
        cell.Controls.Add(l1);
        row.Cells.Add(cell);
        Table1.Rows.Add(row);        
        if (node.NodeType == XmlNodeType.Element)
        {
            XmlAttributeCollection att = node.Attributes;
            if (att.Count > 0)
            {
                for (int i = 0; i < att.Count; i++)
                {
                    row = new TableRow();
                    cell = new TableCell();
                    l1 = new Label();
                    l1.Text = "Attribute";
                    cell.Controls.Add(l1);
                    row.Cells.Add(cell);

                    cell = new TableCell();
                    l1 = new Label();
                    l1.Text = att.Item(i).Name;
                    cell.Controls.Add(l1);
                    row.Cells.Add(cell);

                    cell = new TableCell();
                    l1 = new Label();
                    l1.Text = att.Item(i).Value;
                    cell.Controls.Add(l1);
                    row.Cells.Add(cell);
                    Table1.Rows.Add(row);
                }
               

            }
            
        }

        if (node.HasChildNodes)
        {
            XmlNodeList children = node.ChildNodes;
            foreach (XmlNode child in children)
                preorderTraverse(child); // recursive call
        }
    }
}