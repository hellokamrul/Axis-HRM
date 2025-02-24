using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axis.Application.DTOs.HouseKeeping
{
    public class ReligionDTO
    {
        public string? Id { get; set; }  
        public string ReligionName { get; set; }
        public string ReligionLocalName { get; set; }
    }
}
