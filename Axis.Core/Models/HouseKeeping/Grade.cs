using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axis.Core.Models.HouseKeeping
{
    public class Grade : BaseModel
    {
        [Display(Name = "grade name")]
        [Required(ErrorMessage = "please input grade name.")]
        [StringLength(25)]
        [DataType("nvarchar(25)")]
        public string GradeName { get; set; }

        [Display(Name = "grade bangla")]
        [StringLength(25)]
        [DataType("nvarchar(25)")]
        public string GradeLocalName { get; set; }

        [Display(Name = "minimum Gross")]
        public double? mings { get; set; }

        [Display(Name = "total manpower")]
        public int? ttlmanpower { get; set; }

        [Display(Name = "salary range")]
        [StringLength(30)]
        public string SalaryRange { get; set; }

        [Display(Name = "total man power worker")]
        public int? ttlmanpowerworker { get; set; }

        [Display(Name = "Serial no")]
        public int? slno { get; set; }

        
    }
}
