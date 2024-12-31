using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axis.Core.Models
{
    public class BaseModel
    {
        public string? Id { get; set; } = new Guid().ToString();

        public Company Company { get; set; }
        [ForeignKey(nameof(Company))]
        public string? ComId { get; set; }
        public string? CreatedByUserId { get; set;}
        public string? UpdateByUserId { get; set; }
        public bool? isdelete { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd-MMM-yyyy}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> DateAdded { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd-MMM-yyyy}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> CreateDate { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd-MMM-yyyy}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> ModifiedDate { get; set; }
    }
}
