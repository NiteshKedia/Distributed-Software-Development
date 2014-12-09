using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebUserControl : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    public string MyText1
    {
        get
        {
            return TextBox1.Text;
        }
    }
    public string MyText2
    {
        get
        {
            return TextBox2.Text;
        }
    }
}