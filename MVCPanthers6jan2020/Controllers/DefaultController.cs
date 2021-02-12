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


        public ActionResult HtmlHelpersExample()
        {
            AmithDbEntities db = new Models.AmithDbEntities();
            ViewBag.Country = new SelectList(db.Countries, "Id", "Name",4);
            EmployeeModel emp = new EmployeeModel();
            emp.EmpName = "Chandra";
            return View(emp);
        }

    }
}