using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axis.Core.Models.HR
{
    public class Department : BaseModel
    {
        [Display(Name = "department code")]
        public string DeptCode { get; set; }

        [Display(Name = "department name")]
        [Required(ErrorMessage = "please provide department name")]
        [StringLength(100)]
        [DataType("nvarchar(100)")]
        public string DeptName { get; set; }

        [Display(Name = "department name bangla")]
        [StringLength(100)]
        [DataType("nvarchar(100)")]
        public string DeptLocalName { get; set; }

        [Display(Name = "sl no")]
        public short? slno { get; set; }

        }
}
