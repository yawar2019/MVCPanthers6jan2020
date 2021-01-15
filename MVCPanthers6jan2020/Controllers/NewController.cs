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
        // GET: New code is updated twice done
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
            return "Rahul Employee id is "+ eid;
        }

        public string getTwoParameter(int? eid,string Name)
        {
            return "Rahul Employee id is " + eid+" Name is "+ Name;
        }


        public string getMultiParameter(int? eid)
        {
            return "Rahul Employee id is " + eid + " Name is " +Request.QueryString["Name"] +" Designation is " + Request.QueryString["Designation"];
        }
        public ActionResult GetmyView() {
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


    }
}
