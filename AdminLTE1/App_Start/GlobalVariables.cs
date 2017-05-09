using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdminLTE1.App_Start
{
    public static class GlobalVariables
    {
        public static string WebsiteName
        {
            get
            {
                return HttpContext.Current.Application["WebsiteName"] as string;
            }
            set
            {
                HttpContext.Current.Application["WebsiteName"] = value;
            }
        }
    }
}