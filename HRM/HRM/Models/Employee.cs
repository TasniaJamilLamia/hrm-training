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

        [StringLength(150)]
        public String BloodGroup { get; set; }

        [StringLength(150)]
        public string Address { get; set; }

        
        public int PhoneNo { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        public int DeptId { get; set; }
        [ForeignKey("DeptId")]
        public virtual Dept Department{ get; set; }
        public int DesignationId { get; set; }
        [ForeignKey("DesignationId")]
        public virtual Designation Designation { get; set; }


        [Display(Name = "Upload File")]
        public string EmployeePhotoPath { get; set; }

        [NotMapped]
        public HttpPostedFileBase EmployeePhoto { get; set; }

    }
}