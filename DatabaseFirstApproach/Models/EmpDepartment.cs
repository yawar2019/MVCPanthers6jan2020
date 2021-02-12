using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatabaseFirstApproach.Models
{
    public class EmpDepartment
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public Nullable<int> EmpSalary { get; set; }
        public int DeptId { get; set; }
        public string DeptName { get; set; }
    }
}