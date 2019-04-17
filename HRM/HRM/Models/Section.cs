using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HRM.Models
{
    public class Section
    {
        [key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string SectionName { get; set; }
        public int DeptId { get; set; }
        [ForeignKey("DeptId")]
        public virtual Dept Dept { get; set; }

    }
}