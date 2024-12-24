using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Axis.Core.Models.HR
{
    public class Employee
    {
        // Personal Information
        
        public Guid EmployeeId { get; set; }
        public string? EmpCode { get; set; } = string.Empty;
        public string? FirstName { get; set; } = string.Empty;
        public string? LastName { get; set; } = string.Empty;
        public string? MiddleName { get; set; } = string.Empty;
        public string? Gender { get; set; } = string.Empty; // Example: Male, Female, Other
        public DateTime? DateOfBirth { get; set; }
        public string? SocialSecurityNumber { get; set; } = string.Empty;

        // Contact Information
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        //public Address HomeAddress { get; set; } = new Address();

       

        // Emergency Contact Information
        public string EmergencyContactName { get; set; } = string.Empty;
        public string EmergencyContactRelationship { get; set; } = string.Empty;
        public string EmergencyContactPhone { get; set; } = string.Empty;

        // Benefits and Payroll
        public bool IsEligibleForBenefits { get; set; }
        public string HealthInsuranceProvider { get; set; } = string.Empty;
        public string RetirementPlan { get; set; } = string.Empty;

        // Miscellaneous
        public string Nationality { get; set; } = "American";
        public string MaritalStatus { get; set; } = string.Empty; // Example: Single, Married, Divorced, Widowed
        public List<string> Skills { get; set; } = new List<string>();
        public List<string> Certifications { get; set; } = new List<string>();
        public string Notes { get; set; } = string.Empty;

        // Audit Fields
        public DateTime DateAdded { get; set; } = DateTime.UtcNow;
        public DateTime DateUpdated { get; set; } = DateTime.UtcNow;
    }
}
