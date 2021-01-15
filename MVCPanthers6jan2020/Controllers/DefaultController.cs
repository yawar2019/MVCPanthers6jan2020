using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCPanthers6jan2020.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult GetIndex()
        {
            return View();
        }
    }
}