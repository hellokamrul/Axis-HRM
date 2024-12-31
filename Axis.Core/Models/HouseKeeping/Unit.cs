using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axis.Core.Models.HouseKeeping
{
    public class Unit : BaseModel
    {
        [Display(Name = "unit name")]
        [Required(ErrorMessage = "plz input unit name")]
        [StringLength(100)]
        [DataType("nvarchar(100)")]
        public string UnitName { get; set; }

        [Display(Name = "short name")]
        [StringLength(100)]
        [DataType("nvarchar(100)")]
        public string UnitShortName { get; set; }

        [Display(Name = "unit Local Name")]
        [StringLength(100)]
        [DataType("nvarchar(100)")]
        public string UnitLocalName { get; set; }


       
    }
}
