using Axis.Core.Models.Leave_Holiday;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axis.Application.DTOs.Leave_Holiday
{
    public class HolidayListDTO
    {
       // [Key]
        public string? Id { get; set; }
        public int? Serial { get; set; }
        public DateOnly? Date { get; set; }
        public HolidayType? Type { get; set; }
        public string? Description { get; set; }

        //[ForeignKey(nameof(Holiday))]
        //public string? HolidayId { get; set; }
        //public Holiday? Holiday { get; set; }
    }
}
