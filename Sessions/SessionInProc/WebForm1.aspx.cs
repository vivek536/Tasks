using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SessionInProc
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        protected void Button_Click(object sender, EventArgs e)
        {
            Session["Username"] = TextBox1.Text;
            Response.Redirect("~/WebForm2.aspx");
        }
    }
}