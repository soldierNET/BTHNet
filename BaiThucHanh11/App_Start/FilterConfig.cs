﻿using System.Web;
using System.Web.Mvc;

namespace BaiThucHanh11
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
