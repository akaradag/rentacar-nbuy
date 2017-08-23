using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RentACar.Filters
{
    public class LoginRequiredAttribute:ActionFilterAttribute
    {

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
           
            if (filterContext.HttpContext.Session["LoginId"] == null)
            {
                filterContext.Result = new RedirectResult("/Login", true);
            }
        }
    }
}