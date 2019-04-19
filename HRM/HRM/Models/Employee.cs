using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HRM.Models
{
    public class Employee
    {
        [key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Display(Name = "Employee Code")]
        [StringLength(10)]
        public string EmployeeCode { get; set; }


        [Display(Name = "Full Name")]
        [StringLength(150)]
        public string FullName { get; set; }

        [Display(Name = "Nick Name")]
        [StringLength(150)]
        public string NickName { get; set; }

        [Display(Name = "Fathers Name")]
        [StringLength(150)]
        public string FathersName { get; set; }

        [Display(Name = "Mothers Name")]
        [StringLength(150)]
        public string MothersName { get; set; }
        public int DesignationId { get; set; }
        [ForeignKey("DesignationId")]
        public virtual Designation Designation { get; set; }
    }
}