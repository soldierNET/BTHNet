﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BaiThucHanh2
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnSubmit_ServerClick(object sender, EventArgs e)
        {
            divInfo.InnerHtml = "Email: " + txtEmail.Value + "<br>Login is OK!";
        }
    }
}