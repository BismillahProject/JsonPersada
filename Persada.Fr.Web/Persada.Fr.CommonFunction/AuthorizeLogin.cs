using System.Web;
#pragma warning disable CS0234 // The type or namespace name 'Mvc' does not exist in the namespace 'System.Web' (are you missing an assembly reference?)
using System.Web.Mvc;
#pragma warning restore CS0234 // The type or namespace name 'Mvc' does not exist in the namespace 'System.Web' (are you missing an assembly reference?)
using System.Web.Routing;

namespace CompanyProjectHelper
{
#pragma warning disable CS0246 // The type or namespace name 'AuthorizeAttribute' could not be found (are you missing a using directive or an assembly reference?)
    class AuthorizeLogin : AuthorizeAttribute
#pragma warning restore CS0246 // The type or namespace name 'AuthorizeAttribute' could not be found (are you missing a using directive or an assembly reference?)
    {
#pragma warning disable CS0115 // 'AuthorizeLogin.AuthorizeCore(HttpContextBase)': no suitable method found to override
        protected override bool AuthorizeCore(HttpContextBase httpContext)
#pragma warning restore CS0115 // 'AuthorizeLogin.AuthorizeCore(HttpContextBase)': no suitable method found to override
        {
            bool isValid = false;
            if (CurrentUser.IsAdmin())
            {
                isValid = true;
            }
            return isValid;
        }

#pragma warning disable CS0115 // 'AuthorizeLogin.HandleUnauthorizedRequest(AuthorizationContext)': no suitable method found to override
#pragma warning disable CS0246 // The type or namespace name 'AuthorizationContext' could not be found (are you missing a using directive or an assembly reference?)
        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
#pragma warning restore CS0246 // The type or namespace name 'AuthorizationContext' could not be found (are you missing a using directive or an assembly reference?)
#pragma warning restore CS0115 // 'AuthorizeLogin.HandleUnauthorizedRequest(AuthorizationContext)': no suitable method found to override
        {
            filterContext.Result = new RedirectToRouteResult(new
                RouteValueDictionary(new { controller = "Home", action = "Index" }));
        }
    }
}
