using DatabaseFirstApproach.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DatabaseFirstApproach.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default

        EmployeeEntities db = new EmployeeEntities();
        public ActionResult Index()
        {
            return View(db.employeeDetails.ToList());
        }
    }
}