using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BaiThucHanh7.Controller;

namespace BaiThucHanh7
{
    public partial class quanLyTaiKhoan : System.Web.UI.Page
    {
        private static List<User> userList = new List<User>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
                return;
            LoadDataToView();
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

        public void LoadDataToView()
        {
            GridView1.DataSource = UserController.GetDataTable();
            GridView1.DataBind();
        }

        protected void btnSave_ServerClick(object sender, EventArgs e)
        {
            User user = GetFormData();
            if (UserController.Exist(user.username))
            {
                txtMessage.InnerText = "Username đã tồn tại";
                return;
            }

            if (UserController.Insert(user))
            {
                txtMessage.InnerText = "Đăng ký thành công!";
                LoadDataToView();
                return;
            }
            txtMessage.InnerText = "Đã xảy ra lỗi";
        }

        protected void btnDelete_ServerClick(object sender, EventArgs e)
        {
            string username = txtUsername.Value;
            if (!UserController.Exist(username))
            {
                txtMessage.InnerText = "Không xóa được, username không tồn tại";
                return;
            }
            if (UserController.Delete(username))
            {
                txtMessage.InnerText = $"Tài khoản {username} đã bị xóa";
                return;
            }
            txtMessage.InnerText = "Đã xảy ra lỗi";
        }
    }
}