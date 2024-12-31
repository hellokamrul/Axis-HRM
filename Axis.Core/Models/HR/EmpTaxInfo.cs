using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axis.Core.Models.HR
{
    public class EmpTaxInfo : BaseModel
    {
        //public Guid TaxInfoId { get; set; } 
        public string EmployeeId { get; set; } = string.Empty;
        public string TaxIdentificationNumber { get; set; } = string.Empty;
        public string SocialSecurityNumber { get; set; } = string.Empty;
        public string TaxFilingStatus { get; set; } = string.Empty;
        public int Allowances { get; set; }
        public decimal AdditionalWithholding { get; set; }
        public string StateTaxIdentification { get; set; } = string.Empty;
        public string LocalTaxIdentification { get; set; } = string.Empty;
        public bool IsExempt { get; set; }
        public string Notes { get; set; } = string.Empty;

        public Employee Employee { get; set; }
        [ForeignKey("Employee")]
        public string? EmpId { get; set; }
    }
}
