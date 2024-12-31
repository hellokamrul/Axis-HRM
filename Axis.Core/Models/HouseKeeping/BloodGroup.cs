using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axis.Core.Models.HouseKeeping
{
    public class BloodGroup : BaseModel
    {

        [Display(Name = "blood group")]
        [Required(ErrorMessage = "plz input blood group name")]
        [StringLength(30)]
        [DataType("nvarchar(40)")]
        public string BloodName { get; set; }

        [Display(Name = "blood group bangla")]
        [Required(ErrorMessage = "plz input blood group local name ")]
        [StringLength(30)]
        [DataType("nvarchar(40)")]
        public string BloodLocalName { get; set; }


    }
}
