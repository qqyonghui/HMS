using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Http;

namespace HMS.Web.Controllers
{
    public class BaseController : Controller
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            byte[] result = context.HttpContext.Session.Get("CurrentUser");
            //string sessionvalue = context.HttpContext.Session.GetString("CurrentUser");
            if (result==null)
            {
                context.Result = new RedirectResult("/Account/login");
                return;
            }
            base.OnActionExecuting(context);
        }
    }
}