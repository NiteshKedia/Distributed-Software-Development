using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;

public partial class NearestAirport : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        Label1.Visible = false;
        Label2.Visible = false;
        Label3.Visible = false;
        Label4.Visible = false;
        Label5.Visible = false;
        Label6.Visible = false;
        Label7.Visible = false;
        Label8.Visible = false;


        string baseurl = "http://webstrar39.fulton.asu.edu/Page6/Service1.svc/GetNearestAirport?";
        string location = "latitude=" + TextBox7.Text + "&longitude=" + TextBox8.Text;
        string finalURL = baseurl + location;

        WebClient wc = new WebClient();
        try
        {
            string resultairport = wc.DownloadString(finalURL);
            string[] results = resultairport.Split('|');

            Label2.Text = results[0];
            Label4.Text = results[1];
            Label6.Text = results[2];
            Label8.Text = results[3];

            Label1.Visible = true;
            Label3.Visible = true;
            Label5.Visible = true;
            Label7.Visible = true;
            Label2.Visible = true;
            Label4.Visible = true;
            Label6.Visible = true;
            Label8.Visible = true;


        }
        catch(Exception)
        {
            Label9.Text = "Error !!!";
        }

    }
}