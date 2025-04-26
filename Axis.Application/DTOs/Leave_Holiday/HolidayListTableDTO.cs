using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axis.Application.DTOs.Leave_Holiday
{
    public class HolidayListTableDTO
    {
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "From Date"), DataType(DataType.Date)]
        public DateTime? FromDate { get; set; }

        [Display(Name = "To Date"), DataType(DataType.Date)]
        public DateTime? ToDate { get; set; }
        public string Country { get; set; }

        [Display(Name = "Weekend")]
        public int WeekendCount { get; set; }

        [Display(Name = "Total Holiday")]
        public int TotalHolidays { get; set; }

        public string Color { get; set; }

        [Display(Name = "Status")]
        public HolidayListStatus Status { get; set; }
    }

    public enum HolidayListStatus
    {
        Active,
        Inactive
    }
}
