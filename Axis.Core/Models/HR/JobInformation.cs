using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axis.Core.Models.HR
{
    public class JobInformation : BaseModel
    {
        // Job Information
        public string JobTitle { get; set; } = string.Empty;
        public string EmployeeId { get; set; } = string.Empty;  
        public string Department { get; set; } = string.Empty;
        public DateTime DateOfHire { get; set; }
        public string EmploymentType { get; set; } = string.Empty;
        public decimal Salary { get; set; }
        public string JobLocation { get; set; } = string.Empty; 
        public string Currency { get; set; } = "USD";

        public string ContractPeriod { get; set; } = string.Empty;
        public DateTime ContractStartDate { get; set; }
        public DateTime ContractEndDate { get; set; }
        public string status { get; set; } = string.Empty;



        public Employee Employee { get; set; }
        [ForeignKey("Employee")]
        public string? EmpId { get; set; }

    }
}
