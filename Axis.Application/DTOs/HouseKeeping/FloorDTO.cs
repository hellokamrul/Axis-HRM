using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axis.Application.DTOs.HouseKeeping
{
    public class FloorDTO : BaseDTO
    {
        public string FloorName { get; set; }
        public string FloorLocalName { get; set; }
    }
}
