using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axis.Core.Models.HR.Attendance_Leave
{
    public class HolidayTemplate : BaseModel
    {
        [Key]
        public string Id { get; set; }
        public string TemplateName { get; set; }
        public string Description { get; set; }
        public string FiscalYear { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        public string Color { get; set; }

        public string Status { get; set; }
        public Country Country { get; set; }
        [ForeignKey(nameof(Country))]
        public string CountryId { get; set; }
        virtual public ICollection<Holiday> Holidays { get; set; }
    }
}
