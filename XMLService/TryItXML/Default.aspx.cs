using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Hosting;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Linq;
using System.Net;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
   
    protected void Button1_Click1(object sender, EventArgs e)
    {
        ServiceReference1.Service1Client sc = new ServiceReference1.Service1Client();
        string result = sc.verification(TextBox1.Text, TextBox2.Text);

        Label4.Text = result;
    }
    protected void Button2_Click1(object sender, EventArgs e)
    {
        ServiceReference2.Service1Client sc = new ServiceReference2.Service1Client();
        string result = sc.transformation(TextBox3.Text, TextBox4.Text);
        string dataFile = HostingEnvironment.ApplicationPhysicalPath+"\\hotels.html";
        System.IO.File.WriteAllText(@dataFile, result);
        
        System.Diagnostics.Process.Start(dataFile);
    }
    protected void Button3_Click(object sender, EventArgs e)
    {

        XmlDocument xmldoc = new XmlDocument();
        xmldoc.Load(HostingEnvironment.ApplicationPhysicalPath + "hotel_template.xml");
        XmlNode root = xmldoc.DocumentElement;
        XmlElement elem = xmldoc.CreateElement("price");
        elem.InnerText = "20";

        //Add the node to the document.
        root.AppendChild(elem);
        xmldoc.Save(HostingEnvironment.ApplicationPhysicalPath + "hotel_template.xml");
    }
}