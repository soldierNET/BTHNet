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
            string password = Session["password"]?.ToString();
            if(password != null)
            {
                txtGreetUsername.InnerText = Session["username"]?.ToString();
                return;
            }

            password = Application["password"]?.ToString();
            if (password != null)
            {
                txtGreetUsername.InnerText = Application["username"]?.ToString();
                return;
            }

            Response.Redirect("Login.aspx");
        }

        protected void btnLogout_ServerClick(object sender, EventArgs e)
        {
            Session.Remove("username");
            Session.Remove("password");
            Application.Remove("username");
            Application.Remove("password");
            Response.Redirect("Login.aspx");
        }
    }
}