using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axis.Core.Models.HR
{
    public class EmployeeFile : BaseModel
    {
        public string FileName { get; set; } = string.Empty; 
        public string FilePath { get; set; } = string.Empty;
        public string FileType { get; set; } = string.Empty;
        public DateTime DateUploaded { get; set; } = DateTime.UtcNow;


        public Employee Employee { get; set; }
        [ForeignKey("Employee")]
        public string? EmpId { get; set; }

    }
}
