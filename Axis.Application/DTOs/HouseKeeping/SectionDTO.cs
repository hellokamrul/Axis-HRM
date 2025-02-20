using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axis.Application.DTOs.HouseKeeping
{
    public class SectionDTO : BaseDTO
    {
        public string SectName { get; set; }       
        public string SectLocalName { get; set; }     
        public int? slno { get; set; }
    }
}
