using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axis.Core.Models.HouseKeeping
{
    public class Religion : BaseModel
    {

        [Display(Name = "religion name")]
        [Required(ErrorMessage = "please provide religion name")]
        [StringLength(20)]
        [DataType("nvarchar(20)")]
        public string ReligionName { get; set; }

        [Display(Name = "religion bangla")]
        [Required(ErrorMessage = "Please Provide Religion Local Name")]
        [StringLength(20)]
        [DataType("nvarchar(20)")]
        public string ReligionLocalName { get; set; }
    }
}
