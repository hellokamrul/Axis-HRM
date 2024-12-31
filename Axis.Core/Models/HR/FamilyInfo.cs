using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axis.Core.Models.HR
{
    public class FamilyInfo : BaseModel
    {
        //public Guid FamilyMemberId { get; set; }
        public string FullName { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; } 
        public string Relationship { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;
        public string Occupation { get; set; } = string.Empty;
        public bool IsDependent { get; set; }
        public string ContactNumber { get; set; } = string.Empty;
        public string Notes { get; set; } = string.Empty;

        // Audit Fields
        public DateTime DateAdded { get; set; } = DateTime.UtcNow;
        public DateTime DateUpdated { get; set; } = DateTime.UtcNow;
    }
}
