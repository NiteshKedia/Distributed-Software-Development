using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TemperatureWeb
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TemperatureWeb.ServiceReference1.Service1Client sc = new ServiceReference1.Service1Client();
            int celcius = int.Parse(c2f.Text);
            int result = sc.c2f(celcius);
            c2fresult.Text = result.ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TemperatureWeb.ServiceReference1.Service1Client sc = new ServiceReference1.Service1Client();
            int celcius = int.Parse(f2c.Text);
            int result = sc.f2c(celcius);
            f2cresult.Text = result.ToString();
        }
    }
}