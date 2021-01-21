using MVCPanthers6jan2020.Models;
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
        public ActionResult GetIndex(int? id)
        {
            ViewBag.testId = id;
            return View();
        }



        public ActionResult GetIndex2(EmployeeModel Obj)
        {
            ViewBag.testObj = Obj;
            return View();
        }

    }
}