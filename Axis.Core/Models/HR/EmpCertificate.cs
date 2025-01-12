﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axis.Core.Models.HR
{
    public class EmpCertificate : BaseModel
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string CertificateNumber { get; set; } = string.Empty;
        public DateTime DateIssued { get; set; } = DateTime.UtcNow;
        public DateTime ExpirationDate { get; set; } = DateTime.UtcNow;

        public Employee Employee { get; set; }
        [ForeignKey("Employee")]
        public string? EmpId { get; set; }
    }
}
