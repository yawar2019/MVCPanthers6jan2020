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


        public ActionResult ValidationExample()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ValidationExample(Register r)
        {
            if (ModelState.IsValid)
            {
                //Validate code
                return View(r);
            }
            else
            {
                return View(r);
            }

           
        }


        public ActionResult SendViewData()
        {
            //ViewData["StudentName"] = "Rahul";

            ViewBag.studentName = "Rahul";
            return View();
           // return RedirectToAction("ReceiveViewData");
        }
        public ActionResult ReceiveViewData()
        {
           // string result = ViewData["StudentName"].ToString();
            string result = ViewBag.studentName;
            return View();
        }

        public ActionResult TempdataExample() {
            TempData["life"] = "life is beautiful";
            return RedirectToAction("TempViewData");
        }

        public ActionResult TempViewData()
        {
             //string result = TempData["life"].ToString();
            //ViewBag.rahulLife = result;
            // TempData.Keep();
            string result= TempData.Peek("life").ToString();
            ViewBag.rahulLife = result;
            return View();
        }
    }
}