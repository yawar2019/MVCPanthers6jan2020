using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCPanthers6jan2020.MyFilters
{
    [AttributeUsage(AttributeTargets.Method|AttributeTargets.Class)]
    public class CustomFilter :Attribute, IActionFilter,IResultFilter
    {
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            throw new NotImplementedException();
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            throw new NotImplementedException();
        }

        public void OnResultExecuted(ResultExecutedContext filterContext)
        {
            throw new NotImplementedException();
        }

        public void OnResultExecuting(ResultExecutingContext filterContext)
        {
            throw new NotImplementedException();
        }
    }
}