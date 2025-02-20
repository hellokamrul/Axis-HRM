using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axis.Application.DTOs.HouseKeeping
{
    public class BloodGroupDTO : BaseDTO
    {
        public string BloodName { get; set; }
        public string BloodLocalName { get; set; }
    }
}
