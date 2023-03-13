using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BaiThucHanh5
{
    public partial class Login2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
                return;
        }
        protected void btnSubmit_ServerClick(object sender, EventArgs e)
        {
            if (!Page.IsValid)
                return;

            if (txtPassword.Attributes["value"] != "123")
            {
                info.InnerText = "Sai thông tin";
                return;
            }
            
            Application.Add("username", txtUsername.Value);
            Application.Add("password", txtPassword.Attributes["value"]);
            Response.Redirect("Default.aspx");
        }
    }
}