using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCPanthers6jan2020.Models
{
    public class Register
    {
        [Key]
        public int EmpId { get; set; }
        [Required(ErrorMessage ="Enter Employee Name")]
        public string EmpName { get; set; }
        [Required(ErrorMessage = "Enter Password")]
        public string Password { get; set; }
        [Compare("Password",ErrorMessage ="Pwd and Cpwd Not Matching")]
        public string ConfirmPassword { get; set; }
        [Range(20,90,ErrorMessage ="Age Should be 20 and 90")]
        public DateTime age { get; set; }
        [DataType(DataType.Time,ErrorMessage ="Email id is Invalid")]
        public string EmailId { get; set; }
        [StringLength(10,ErrorMessage ="Address should be 10 character")]
        public string Address { get; set; }

    }
}