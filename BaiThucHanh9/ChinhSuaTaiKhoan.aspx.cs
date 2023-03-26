using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BaiThucHanh9.Controller;

namespace BaiThucHanh9
{
    public partial class ChinhSuaTaiKhoan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
                return;

            string username = Request.QueryString["username"];
            SetFormData(UserController.GetUser(username));
        }

        public User GetFormData()
        {
            return new User(txtFirstName.Value,
                txtLastName.Value,
                txtEmail.Value,
                (Request.Form["gender"]?.ToString() == "male") ? true : false,
                txtAddress.Value,
                txtUsername.Value,
                txtPassword.Text);
        }

        public void SetFormData(User user)
        {
            txtFirstName.Value = user.firstName;
            txtLastName.Value = user.lastName;
            txtEmail.Value = user.email;
            if (user.gender)
            {
                radFemale.Checked = false;
                radMale.Checked = true;
            }
            else
            {
                radMale.Checked = false;
                radFemale.Checked = true;
            }
            txtAddress.Value = (user.address != null) ? user.address : "";
            txtUsername.Value = user.username;
            txtPassword.Text = user.password;
        }

        protected void btnSave_ServerClick(object sender, EventArgs e)
        {
            User user = GetFormData();

            if (UserController.Update(user))
            {
                Response.Redirect("QuanLyTaiKhoan.aspx");
            }
            txtMessage.InnerText = "Đã xảy ra lỗi";
        }

        protected void btnExit_ServerClick(object sender, EventArgs e)
        {
            Response.Redirect("QuanLyTaiKhoan.aspx");
        }
    }
}