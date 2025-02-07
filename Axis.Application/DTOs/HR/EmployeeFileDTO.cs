using Axis.Core.Models;
using Axis.Core.Models.HR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axis.Application.DTOs.HR
{
    public class EmployeeFileDTO : BaseDTO
    {
        public string FileName { get; set; } = string.Empty;
        public string FilePath { get; set; } = string.Empty;
        public string FileType { get; set; } = string.Empty;
        public DateTime DateUploaded { get; set; } = DateTime.UtcNow;
        public string? EmpId { get; set; }

    }
}
