using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BaiThucHanh5
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string name = Session["username"]?.ToString();
            if (name != null)
            {
            txtGreetUsername.InnerText = Session["username"].ToString();
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }

        protected void btnLogout_ServerClick(object sender, EventArgs e)
        {
            txtGreetUsername.InnerText = Session["username"].ToString();
            Session.Remove("username");
            Session.Remove("password");
            Response.Redirect("Login.aspx");
        }
    }
}