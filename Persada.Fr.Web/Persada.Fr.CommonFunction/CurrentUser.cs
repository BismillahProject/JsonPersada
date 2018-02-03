using System.Web;
#pragma warning disable CS0234 // The type or namespace name 'Mvc' does not exist in the namespace 'System.Web' (are you missing an assembly reference?)
using System.Web.Mvc;
#pragma warning restore CS0234 // The type or namespace name 'Mvc' does not exist in the namespace 'System.Web' (are you missing an assembly reference?)
using System.Web.Routing;
using System.Linq;
using System;

namespace CompanyProjectHelper
{
#pragma warning disable CS0246 // The type or namespace name 'AuthorizeAttribute' could not be found (are you missing a using directive or an assembly reference?)
   public class CurrentUser : AuthorizeAttribute
#pragma warning restore CS0246 // The type or namespace name 'AuthorizeAttribute' could not be found (are you missing a using directive or an assembly reference?)
    {
       public static string GetCurrentUserId()
        {
            if (HttpContext.Current.Session["userId"] != null)
            {
                return HttpContext.Current.Session["userId"].ToString();
            }
            else
            {
                return null;
            }
            
        }

        public static bool IsAdmin()
        {
            if (HttpContext.Current.Session["admin"] != null)
            {
                return (bool)HttpContext.Current.Session["admin"];
            }
            else
            {
                return false;
            }

        }

        public static DateTime GetCurrentDateTime()
        {
            return DateTime.Now;
        }
    }
}
