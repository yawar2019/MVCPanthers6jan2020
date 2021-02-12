using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCPanthers6jan2020.Models
{
    public class EmployeeModel
    {
        public int EmpId { get; set; }
        [Display(Name ="Employee Name")]
        public string EmpName { get; set; }
        public int EmpSalary { get; set; }
       
    }

    public class EmpDeptModel
    {

        public List<EmployeeModel> emp { get; set; }
        public List<DepartmentModel> dept { get; set; }
    }

}