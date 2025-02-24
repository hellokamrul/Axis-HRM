using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axis.Core.Models.HouseKeeping
{
    public class Department : BaseModel
    {
        [Display(Name = "Department Code")]
        public string DeptCode { get; set; }

        [Display(Name = "Department Name")]
        [Required(ErrorMessage = "Please provide department name")]
        [StringLength(100)]
        [DataType("nvarchar(100)")]
        public string DeptName { get; set; }

        [Display(Name = "Department Local Name")]
        [StringLength(100)]
        [DataType("nvarchar(100)")]
        public string DeptLocalName { get; set; }

        [Display(Name = "Serial No")]
        public short? slno { get; set; }

        public ICollection<Designation>? Designations { get; set; }
        
    }
}
