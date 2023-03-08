using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BaiThucHanh4
{
    public partial class RegisteringComplete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string text;

            try
            {
                text = Request.Form.Get("txtHoTen")+"<br>"+ Request.Form.Get("txtGioiTinh") + "<br>" + Request.Form.Get("txtNgaySinh") + "<br>" + Request.Form.Get("txtDiaChi") + "<br>";
            } catch(Exception ex)
            {
                throw ex;
            }

            if (text != "")
                formInfo.InnerHtml = text;
            else
                formInfo.InnerHtml = "An empty string was posted from the previous page.";
        }
    }
}