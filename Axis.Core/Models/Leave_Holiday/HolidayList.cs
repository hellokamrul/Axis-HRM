using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axis.Core.Models.Leave_Holiday
{
    public class HolidayList
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public int? Serial { get; set; }
        public DateOnly? Date { get; set; }
        public HolidayType? Type { get; set; }
        public string? Description { get; set; }

        [ForeignKey(nameof(Holiday))]   
        public string? HolidayId { get; set; }  
        public Holiday? Holiday { get; set; } // Navigation property to the Holiday entity
    }

    public enum HolidayType
    {
        Weekend = 0,
        Public = 1,
        Custom = 2
    }
}
