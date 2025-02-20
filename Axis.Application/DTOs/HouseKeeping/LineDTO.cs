using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axis.Application.DTOs.HouseKeeping
{
    public class LineDTO : BaseDTO
    {
        public int? lineid { get; set; }
        public string LineName { get; set; }
        public string LineLocalName { get; set; }

    }
}
