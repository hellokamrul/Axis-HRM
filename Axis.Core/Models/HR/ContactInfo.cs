using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axis.Core.Models.HR
{
    public class ContactInfo : BaseModel
    {
        public string Id { get; set; } 
        public string FullName { get; set; } = string.Empty; 
        public string Relationship { get; set; } = string.Empty; 
        public string PrimaryContactNumber { get; set; } = string.Empty;
        public string SecondaryContactNumber { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public bool IsPrimary { get; set; }
        public string Notes { get; set; } = string.Empty;

        // Audit Fields
        public DateTime DateAdded { get; set; } = DateTime.UtcNow;
        public DateTime DateUpdated { get; set; } = DateTime.UtcNow;

    }
}
