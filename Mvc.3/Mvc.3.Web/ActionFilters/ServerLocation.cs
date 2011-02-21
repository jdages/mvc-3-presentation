using System;
using System.Web.Mvc;

namespace Mvc._3.Web.ActionFilters
{
    public class ServerDescription : ActionFilterAttribute
    {
        public override void OnResultExecuted(ResultExecutedContext context)
        {
            context.HttpContext.Response.Write(string.Format("<!-- {0} -->", Environment.MachineName));
        }
    }
}