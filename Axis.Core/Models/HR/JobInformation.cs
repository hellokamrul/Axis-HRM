using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Axis.Core.Models.HouseKeeping;

namespace Axis.Core.Models.HR
{
    public class JobInformation : BaseModel
    {
        // Job Information
        public string JobTitle { get; set; } = string.Empty;
        public string EmployeeId { get; set; } = string.Empty;  
        public string DeptName { get; set; } = string.Empty;
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
        
        public Designation Designation { get; set; }
        [ForeignKey("Designation")]
        public string? DesigId { get; set; }

        public Department Department { get; set; }
        [ForeignKey("Department")]
        public string? DeptId { get; set; }

        public Section Section { get; set; }
        [ForeignKey("Section")]
        public string? SecId { get; set; }

        public Shift Shift { get; set; }
        [ForeignKey("Shift")]
        public string? ShiftId { get; set; }

        public Grade Grade { get; set; }
        [ForeignKey("Grade")]
        public string? GradeId { get; set; }

        public Floor Floor { get; set; }
        [ForeignKey("Floor")]
        public string? FloorId { get; set; }

        public Unit Unit { get; set; }
        [ForeignKey("Unit")]
        public string? UnitId { get; set; }

        public Line Line { get; set; }
        [ForeignKey("Line")]
        public string? LineId { get; set; }
    }
}
