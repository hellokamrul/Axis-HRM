﻿using Axis.Core.Models;
using Axis.Core.Models.HR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axis.Application.DTOs.HR
{
    public class FamilyInfoDTO : BaseDTO
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
        public string? EmpId { get; set; }
    }
}
