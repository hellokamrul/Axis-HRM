using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axis.Core.Models.HouseKeeping
{
    public class Floor : BaseModel
    {

        [Display(Name = "floor name")]
        [Required(ErrorMessage = "plz input floor name")]
        [StringLength(100)]
        [DataType("nvarchar(100)")]
        public string FloorName { get; set; }

        [Display(Name = "floor local name")]
        [StringLength(100)]
        [DataType("nvarchar(100)")]
        public string FloorLocalName { get; set; }

        
    }
}
