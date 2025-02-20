using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axis.Application.DTOs.HouseKeeping
{
    public class ShiftDTO : BaseDTO
    {
        public string ShiftName { get; set; }    
        public string ShiftCode { get; set; }   
        public string ShiftDesc { get; set; }

        [Display(Name = "shift in")]
        [DataType(DataType.Time), DisplayFormat(DataFormatString = @"{0:hh:mm}", ApplyFormatInEditMode = true)]
        public DateTime shiftin { get; set; }
        [Display(Name = "shift out")]
        [DataType(DataType.Time), DisplayFormat(DataFormatString = @"{0:hh:mm}", ApplyFormatInEditMode = true)]
        public DateTime shiftout { get; set; }

        [Display(Name = "shift late")]
        [DataType(DataType.Time), DisplayFormat(DataFormatString = @"{0:hh:mm}", ApplyFormatInEditMode = true)]
        public DateTime shiftlate { get; set; }

        [Display(Name = "lunch time")]
        [DataType(DataType.Time), DisplayFormat(DataFormatString = @"{0:hh:mm}", ApplyFormatInEditMode = true)]
        public DateTime lunchtime { get; set; }

        [Display(Name = "lunch in")]
        [DataType(DataType.Time), DisplayFormat(DataFormatString = @"{0:hh:mm}", ApplyFormatInEditMode = true)]
        public DateTime lunchin { get; set; }

        [Display(Name = "lunch out")]
        [DataType(DataType.Time), DisplayFormat(DataFormatString = @"{0:hh:mm}", ApplyFormatInEditMode = true)]
        public DateTime lunchout { get; set; }

        [Display(Name = "tiffin time")]
        [DataType(DataType.Time), DisplayFormat(DataFormatString = @"{0:hh:mm}", ApplyFormatInEditMode = true)]
        public DateTime tiffintime { get; set; }

        [Display(Name = "tiffin in")]
        [DataType(DataType.Time), DisplayFormat(DataFormatString = @"{0:hh:mm}", ApplyFormatInEditMode = true)]
        public DateTime tiffinin { get; set; }


        [Display(Name = "tiffin out")]
        [DataType(DataType.Time), DisplayFormat(DataFormatString = @"{0:hh:mm}", ApplyFormatInEditMode = true)]
        public DateTime tiffinout { get; set; }


        [Display(Name = "regular hour")]
        [DataType(DataType.Time), DisplayFormat(DataFormatString = @"{0:hh:mm}", ApplyFormatInEditMode = true)]
        public DateTime reghour { get; set; }

        [Display(Name = "shift type")]
        public string shifttype { get; set; }

        [Display(Name = "shift cat")]
        public string shiftcat { get; set; }

        [Display(Name = "is inactive")]
        public bool? isinactive { get; set; }

        [Display(Name = "tiffin time 1")]
        [DataType(DataType.Time), DisplayFormat(DataFormatString = @"{0:hh:mm}", ApplyFormatInEditMode = true)]
        public DateTime? tiffintime1 { get; set; }

        [Display(Name = "tiffin time in 1")]
        [DataType(DataType.Time), DisplayFormat(DataFormatString = @"{0:hh:mm}", ApplyFormatInEditMode = true)]
        public DateTime? tiffintimein1 { get; set; }

        [Display(Name = "tiffin time 2")]
        [DataType(DataType.Time), DisplayFormat(DataFormatString = @"{0:hh:mm}", ApplyFormatInEditMode = true)]
        public DateTime? tiffintime2 { get; set; }

        [Display(Name = "tiffin time in 2")]
        [DataType(DataType.Time), DisplayFormat(DataFormatString = @"{0:hh:mm}", ApplyFormatInEditMode = true)]
        public DateTime? tiffintimein2 { get; set; }
    }
}
