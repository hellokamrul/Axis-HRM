using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axis.Core.Models.HouseKeeping
{
    public class Line : BaseModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int lineid { get; set; }

        [Display(Name = "line name")]
        [Required(ErrorMessage = "plz input line name")]
        [StringLength(100)]
        [DataType("nvarchar(100)")]
        public string LineName { get; set; }

        [Display(Name = "line Local Name")]
        [StringLength(100)]
        [DataType("nvarchar(100)")]
        public string LineLocalName { get; set; }

        
    }
}
