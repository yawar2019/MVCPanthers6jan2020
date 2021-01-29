using MVCPanthers6jan2020.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCPanthers6jan2020.Controllers
{
    public class NewController : Controller
    {

        public string getName()
        {
            return "Rahul " + getStudentName();
        }

        [NonAction]
        public string getStudentName()
        {
            return "Vijay";
        }


        string getStudentName2()
        {
            return "Vijay";
        }

        [Route("Tajkrishna/Rooms")]
        [Route("JioHotel/Rooms")]
        public int getId()
        {
            return 1211;
        }

        public string getNameExample(int? eid)
        {
            return "Rahul Employee id is " + eid;
        }

        public string getTwoParameter(int? eid, string Name)
        {
            return "Rahul Employee id is " + eid + " Name is " + Name;
        }


        public string getMultiParameter(int? eid)
        {
            return "Rahul Employee id is " + eid + " Name is " + Request.QueryString["Name"] + " Designation is " + Request.QueryString["Designation"];
        }
        public ActionResult GetmyView()
        {
            return View("TestView");
        }

        public ActionResult GetmyView1()
        {
            return View("~/Views/Default/GetIndex.cshtml");
        }

        public ActionResult GetTestData()
        {
            string Name = "Prashant";
            ViewBag.info = Name;
            return View();
        }

        public ActionResult GetTestData2()
        {
            EmployeeModel Obj = new EmployeeModel();
            Obj.EmpId = 1;
            Obj.EmpName = "Rahul";
            Obj.EmpSalary = 25600;

            ViewBag.info = Obj;

            return View();
        }

        public ActionResult GetDisplayMultipleEmployees()
        {
            List<EmployeeModel> listObj = new List<EmployeeModel>();

            EmployeeModel Obj = new EmployeeModel();
            Obj.EmpId = 1;
            Obj.EmpName = "Rahul";
            Obj.EmpSalary = 25600;


            EmployeeModel Obj1 = new EmployeeModel();
            Obj1.EmpId = 2;
            Obj1.EmpName = "Vijay";
            Obj1.EmpSalary = 45600;


            EmployeeModel Obj2 = new EmployeeModel();
            Obj2.EmpId = 3;
            Obj2.EmpName = "Prashant";
            Obj2.EmpSalary = 65600;


            listObj.Add(Obj);
            listObj.Add(Obj1);
            listObj.Add(Obj2);


            ViewBag.info = listObj;


            return View();
        }

        public ActionResult GetTestData3()
        {
            EmployeeModel Obj = new EmployeeModel();
            Obj.EmpId = 1;
            Obj.EmpName = "Rahul";
            Obj.EmpSalary = 25600;



            return View(Obj);
        }
        public ViewResult GetTestData4()
        {
            List<EmployeeModel> listObj = new List<EmployeeModel>();

            EmployeeModel Obj = new EmployeeModel();
            Obj.EmpId = 1;
            Obj.EmpName = "Rahul";
            Obj.EmpSalary = 25600;


            EmployeeModel Obj1 = new EmployeeModel();
            Obj1.EmpId = 2;
            Obj1.EmpName = "Vijay";
            Obj1.EmpSalary = 45600;


            EmployeeModel Obj2 = new EmployeeModel();
            Obj2.EmpId = 3;
            Obj2.EmpName = "Prashant";
            Obj2.EmpSalary = 65600;


            listObj.Add(Obj);
            listObj.Add(Obj1);
            listObj.Add(Obj2);



            return View(listObj);
        }

        public ActionResult GetTestData5()
        {
            List<EmployeeModel> listObj = new List<EmployeeModel>();
            List<DepartmentModel> listDepartment = new List<DepartmentModel>();

            EmployeeModel Obj = new EmployeeModel();
            Obj.EmpId = 1;
            Obj.EmpName = "Rahul";
            Obj.EmpSalary = 25600;


            EmployeeModel Obj1 = new EmployeeModel();
            Obj1.EmpId = 2;
            Obj1.EmpName = "Vijay";
            Obj1.EmpSalary = 45600;


            EmployeeModel Obj2 = new EmployeeModel();
            Obj2.EmpId = 3;
            Obj2.EmpName = "Prashant";
            Obj2.EmpSalary = 65600;


            listObj.Add(Obj);
            listObj.Add(Obj1);
            listObj.Add(Obj2);//3 employees




            DepartmentModel dobj = new DepartmentModel();
            dobj.DeptId = 1;
            dobj.DeptName = "ECE";

            DepartmentModel dobj1 = new DepartmentModel();
            dobj1.DeptId = 2;
            dobj1.DeptName = "IT";

            listDepartment.Add(dobj);
            listDepartment.Add(dobj1);//2 dept

            EmpDeptModel empdeptObj = new Models.EmpDeptModel();

            empdeptObj.emp = listObj;
            empdeptObj.dept = listDepartment;


            return View(empdeptObj);
        }

        public ViewResult getPartialView()
        {

            return View();
        }

        public ViewResult getPartialView2()
        {

            List<EmployeeModel> listObj = new List<EmployeeModel>();

            EmployeeModel Obj = new EmployeeModel();
            Obj.EmpId = 1;
            Obj.EmpName = "Rahul";
            Obj.EmpSalary = 25600;


            EmployeeModel Obj1 = new EmployeeModel();
            Obj1.EmpId = 2;
            Obj1.EmpName = "Vijay";
            Obj1.EmpSalary = 45600;


            EmployeeModel Obj2 = new EmployeeModel();
            Obj2.EmpId = 3;
            Obj2.EmpName = "Prashant";
            Obj2.EmpSalary = 65600;


            listObj.Add(Obj);
            listObj.Add(Obj1);
            listObj.Add(Obj2);



            return View(listObj);
        }


        public RedirectResult GotoGoogle()
        {
            return Redirect("http://www.Google.com");
        }

        public RedirectResult GotoNew()
        {
            return Redirect("~/New/GetTestData4");
        }


        public RedirectToRouteResult GotoRoute()
        {
            return RedirectToRoute("Default1");
        }

        public RedirectToRouteResult GotoRoute1()
        {
            return RedirectToAction("GetIndex", "Default", new { id = 1 });
        }


        public RedirectToRouteResult GotoRoute2()
        {
            EmployeeModel Obj = new EmployeeModel();
            Obj.EmpId = 1;
            Obj.EmpName = "Rahul";
            Obj.EmpSalary = 25600;

            return RedirectToAction("GetIndex2", "Default",Obj);
        }

        public JsonResult GetJsonData()
        {

            List<EmployeeModel> listObj = new List<EmployeeModel>();

            EmployeeModel Obj = new EmployeeModel();
            Obj.EmpId = 1;
            Obj.EmpName = "Rahul";
            Obj.EmpSalary = 25600;


            EmployeeModel Obj1 = new EmployeeModel();
            Obj1.EmpId = 2;
            Obj1.EmpName = "Vijay";
            Obj1.EmpSalary = 45600;


            EmployeeModel Obj2 = new EmployeeModel();
            Obj2.EmpId = 3;
            Obj2.EmpName = "Prashant";
            Obj2.EmpSalary = 65600;


            listObj.Add(Obj);
            listObj.Add(Obj1);
            listObj.Add(Obj2);



         
            return Json(listObj,JsonRequestBehavior.AllowGet);
        }

        public FileResult getMeFile()
        {
            return File("~/Doc/GenerateReportPDF.pdf", "application/pdf");
        }

        public ContentResult getContent(int ? id) {
            if (id == 1)
            {
                return Content("Tiger Zinda hai");
            }
            else if (id==2)
            {
                return Content("<p style=color:red;>Hello World</p>");
            }
            else if(id==3)
            {
                return Content("<script>alert('Hello World')</script>");
            }
            else
            {
                return Content("<Employee><id>1</id><name>Rahul</name></Employee>");
            }
        }
    }
}
