using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CodeFirstApproach.Models;
using System.Data.Entity;

namespace CodeFirstApproach.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        EmployeeContext db = new EmployeeContext();
        public ActionResult Index()
        {

            return View(db.EmployeeModel.ToList());
        }


        public ActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Create(EmployeeModel emp)
        {
            db.EmployeeModel.Add(emp);
            int i = db.SaveChanges();
            if (i > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        public ActionResult Edit(int ? id)
        {
            EmployeeModel emp = db.EmployeeModel.Find(id);
            return View(emp);
        }

        [HttpPost]
        public ActionResult Edit(EmployeeModel emp)
        {
            db.Entry(emp).State= EntityState.Modified;
            int i = db.SaveChanges();
            if (i > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }


        public ActionResult Delete(int? id)
        {
            EmployeeModel emp = db.EmployeeModel.Find(id);
            return View(emp);
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int? id)
        {
            EmployeeModel emp = db.EmployeeModel.Find(id);
            db.EmployeeModel.Remove(emp);
            int i = db.SaveChanges();
            if (i > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }
    }
}