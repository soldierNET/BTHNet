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

            text = PreviousPage.Request.Form.AllKeys.Length.ToString();
            } catch(Exception ex)
            {
                throw ex;
            }

            if (text != "")
                formInfo.InnerText = "The string posted from the previous page is "
                                   + text + ".";
            else
                formInfo.InnerText = "An empty string was posted from the previous page.";
        }
    }
}