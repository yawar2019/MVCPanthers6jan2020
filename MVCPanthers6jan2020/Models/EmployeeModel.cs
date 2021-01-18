using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCPanthers6jan2020.Models
{
    public class EmployeeModel
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public int EmpSalary { get; set; }
       
    }

    public class EmpDeptModel
    {

        public List<EmployeeModel> emp { get; set; }
        public List<DepartmentModel> dept { get; set; }
    }

}