using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axis.Application.DTOs.HouseKeeping
{
    public class GradeDTO : BaseDTO
    {
        public string GradeName { get; set; }
        public string GradeLocalName { get; set; }
        public double? mings { get; set; }
        public int? ttlmanpower { get; set; }
        public string SalaryRange { get; set; }
        public int? ttlmanpowerworker { get; set; }
        public int? slno { get; set; }
    }
}
