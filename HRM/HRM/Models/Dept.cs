using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HRM.Models
{
    public class Dept
    {
        [key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [Display(Name = "Dept Code")]
        public string DeptCode { get; set; }
        public string DeptName { get; set; }
        public int DivisionId { get; set; }
        [ForeignKey("DivisionId")]
        public virtual Division Division { get; set; }

        public List<Section> Sec { get; set; }
    }
}