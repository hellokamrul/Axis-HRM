using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Axis.Core.Models.HR
{
    public class Employee : BaseModel
    {
        // Personal Information
        
        //public Guid EmployeeId { get; set; }
        public string? EmpCode { get; set; } = string.Empty;
        public string? FirstName { get; set; } = string.Empty;
        public string? LastName { get; set; } = string.Empty;
        public string? MiddleName { get; set; } = string.Empty;
        public string? Gender { get; set; } = string.Empty; 
        public DateTime? DateOfBirth { get; set; }
        public string? SocialSecurityNumber { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;

       

        public string EmergencyContactName { get; set; } = string.Empty;
        public string EmergencyContactRelationship { get; set; } = string.Empty;
        public string EmergencyContactPhone { get; set; } = string.Empty;

        public bool IsEligibleForBenefits { get; set; }
        public string HealthInsuranceProvider { get; set; } = string.Empty;
        public string RetirementPlan { get; set; } = string.Empty;

        public string Nationality { get; set; } = "American";
        public string MaritalStatus { get; set; } = string.Empty; // Example: Single, Married, Divorced, Widowed
        public List<string> Skills { get; set; } = new List<string>();
        public List<string> Certifications { get; set; } = new List<string>();
        public string Notes { get; set; } = string.Empty;



       public ICollection<EmployeeFile> EmployeeFiles { get; set; }
       public ICollection<ContactInfo> ContactInfos { get; set; }
       public ICollection<FamilyInfo> FamilyInfos { get; set; }
       public ICollection<EmpTaxInfo> EmpTaxInfos { get; set; }
       public ICollection<Education> Educations { get; set; }
       public ICollection<WorkExperience> WorkExperiences { get; set; }
       public ICollection<JobInformation> JobInformations { get; set; }
       public ICollection<EmployeeAddress> EmployeeAddresses { get; set; }
       public ICollection<BankInfo> BankInfos { get; set; }
       public ICollection<EmpCertificate> EmpCertificates { get; set; }






    }
}
