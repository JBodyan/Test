using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Filters;

namespace TestApp.Filters
{
    public class SomeDataUpdateFilter : Attribute, IResourceFilter
    {
        private readonly int _id;
        public SomeDataUpdateFilter(int id)
        {
            _id = id;
        }
        public void OnResourceExecuting(ResourceExecutingContext context)
        {
        }
        public void OnResourceExecuted(ResourceExecutedContext context)
        {
            context.HttpContext.Response.Cookies.Append("Id", _id.ToString());
        }
    }
}
