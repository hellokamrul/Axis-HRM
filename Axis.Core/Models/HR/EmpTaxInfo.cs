using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axis.Core.Models.HR
{
    public class EmpTaxInfo
    {
        public Guid TaxInfoId { get; set; } 
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

        // Audit Fields
        public DateTime DateAdded { get; set; } = DateTime.UtcNow;
        public DateTime DateUpdated { get; set; } = DateTime.UtcNow;
    }
}
