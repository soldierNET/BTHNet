using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BaiThucHanh5
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
                return;

            string username = Request.Cookies["username"]?.Value.ToString();
            string password = Request.Cookies["password"]?.Value.ToString();
            txtUsername.Value = username;
            txtPassword.Value = password;
        }
        protected void btnSubmit_ServerClick(object sender, EventArgs e)
        {
            if (!Page.IsValid)
                return;
            if (txtUsername.Value != "tanphat" || txtPassword.Value != "12345")
            {
                info.InnerText = "Sai thông tin";
                return;
            }
            if (chkSave.Checked)
            {
                Response.Cookies.Add(new HttpCookie("username", txtUsername.Value));
                Response.Cookies.Add(new HttpCookie("password", txtPassword.Value));
            }
            Session.Add("username", txtUsername.Value);
            Session.Add("password", txtPassword.Value);
            Response.Redirect("Default.aspx");
        }
    }
}