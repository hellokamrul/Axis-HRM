using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axis.Core.Models.Leave_Holiday
{
    public class Holiday : BaseModel
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; }

        /// UI color to display this list in calendars (e.g. "#5B5FF5" or "Blue").
        [MaxLength(20)]
        public string Color { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FromDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ToDate { get; set; }

        public string? Weekday1 { get; set; }
        public string? Weekday2 { get; set; }
        public string? Weekday3 { get; set; }
        public string? Weekday4 { get; set; }
        public string? Weekday5 { get; set; }
        public string? Weekday6 { get; set; }
        public string? Weekday7 { get; set; }

        public string? Country { get; set; }
        public string? State { get; set; }
        public virtual ICollection<HolidayList> HolidayLists { get; set; }
        public bool? IsActive { get; set; } = true;
    }

    

}