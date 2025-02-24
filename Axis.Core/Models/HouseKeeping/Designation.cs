using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axis.Core.Models.HouseKeeping
{
    public class Designation : BaseModel
    {

        [Display(Name = "Designation Name")]
        [Required(ErrorMessage = "please provide desingation name")]
        [StringLength(100)]
        [DataType("nvarchar(100)")]
        public string DesigName { get; set; }

        [Display(Name = "designation bangla")]
        [StringLength(100)]
        [DataType("nvarchar(100)")]
        public string DesigLocalName { get; set; }

        [Display(Name = "salary range")]
        [StringLength(100)]
        public string? SalaryRange { get; set; }

        [Display(Name = "Serial no")]
        public int? slno { get; set; }
        [Display(Name = "minimum gs")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal? gsmin { get; set; }

        [Display(Name = "grade")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal? attbonus { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal? holidaybonus { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal nightallow { get; set; }

        [Display(Name = "total manpower")]
        public int? ttlmanpower { get; set; }

        [Display(Name = "total manpower")]
        public int? proposedmanpower { get; set; }


        [ForeignKey(nameof(Department))]
        public string? DeptId { get; set; }
        public Department? Department { get; set; }  


    }
}
