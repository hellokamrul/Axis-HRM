using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axis.Core.Models.HR
{
    public class WorkExperience : BaseModel
    {        
        public string CompanyName { get; set; }
        public string JobTitle { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Responsibilities { get; set; }
        public string Achievements { get; set; }


        public Employee Employee { get; set; }
        [ForeignKey("Employee")]
        public string? EmpId { get; set; }
    }
}
