using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axis.Core.Models.HouseKeeping
{
    public class Section : BaseModel
    {

        [Display(Name = "section name")]
        [Required(ErrorMessage = "please provide section name")]
        [StringLength(100)]
        [DataType("nvarchar(100)")]
        public string SectName { get; set; }

        [Display(Name = "section bangla")]
        [StringLength(100)]
        [DataType("nvarchar(100)")]
        public string SectLocalName { get; set; }

        [Display(Name = "Serial No")]
        public int? slno { get; set; }

        
    }
}
