using Microsoft.AspNetCore.Mvc.Filters;
using System.Net.Http.Headers;
using System.Web.Http.Filters;

namespace WebApplication3.Controllers
{
    public class Caching: System.Web.Http.Filters.ActionFilterAttribute
    {
        public int TimeDuration { get; set; }
        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
            actionExecutedContext.Response.Headers.CacheControl = new CacheControlHeaderValue
            {
                MaxAge = TimeSpan.FromSeconds(TimeDuration),
                MustRevalidate = true,
                Public = true
            };
        }
    }
}
