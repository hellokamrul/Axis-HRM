using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axis.Core.Models.HR.Attendance_Leave
{
    public class Holiday : BaseModel
    {
        [Key]
        public string Id { get; set; }
        public int? SlNo { get; set; }
        public DateOnly Date { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public HolidayTemplate HolidayTemplate { get; set; }
        [ForeignKey(nameof(HolidayTemplate))]
        public string HolidayTemplateId { get; set; }
    }
}
