using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HRM.Models
{
    public class Division
    {
        [key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Display(Name="Division Code")]
        public string DivisionCode { get; set; }

        [Display(Name = "Division Name")]
        public string Name { get; set; }

        public List<Dept> Depts { get; set; }

        public List<Designation> Designation { get; set; }

        

    }
}