using Axis.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axis.Application.DTOs
{
    public class BaseDTO
    {
        public string? Id { get; set; }
        public string? ComId { get; set; }
        //public string? CreatedByUserId { get; set; }
        //public string? UpdateByUserId { get; set; }
        //public bool? isdelete { get; set; }
        //[DisplayFormat(DataFormatString = "{0:dd-MMM-yyyy}", ApplyFormatInEditMode = true)]
        //public Nullable<System.DateTime> DateAdded { get; set; }
        //[DisplayFormat(DataFormatString = "{0:dd-MMM-yyyy}", ApplyFormatInEditMode = true)]
        //public Nullable<System.DateTime> CreateDate { get; set; }
        //[DisplayFormat(DataFormatString = "{0:dd-MMM-yyyy}", ApplyFormatInEditMode = true)]
        //public Nullable<System.DateTime> ModifiedDate { get; set; }
    }
}
