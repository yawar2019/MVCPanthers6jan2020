using MVCPanthers6jan2020.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MVCPanthers6jan2020.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeEntities db = new EmployeeEntities();
        // GET: Employee

        [Authorize(Roles = "Admin,Manager,Employee")]
        public ActionResult Dashboard()
        {
            return View();
        }

        [Authorize(Roles ="Admin")]
        public ActionResult Index()
        {
            return View();
        }
        [Authorize(Roles = "Manager")]
        public ActionResult AboutUs()
        {
            return View();
        }

        [Authorize(Roles = "Employee")]
        public ActionResult ContactUs()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string EmailId, string Password)
        {
            EmployeeInfo emp = db.EmployeeInfoes.Where(s => s.EmailId == EmailId && s.Password== Password).FirstOrDefault();
            if (emp != null)
            {
                FormsAuthentication.SetAuthCookie(emp.EmpName, false);
                return Redirect("~/Employee/Dashboard");

            }
            else
            {
                return View();

            }
            
        }

        [HttpGet]
        public ActionResult SignOut()
        {
            FormsAuthentication.SignOut();
            return View("Login");
        }

    }
}