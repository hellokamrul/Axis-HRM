using Axis.Core.Models.HouseKeeping;
using Axis.Core.Models.HR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axis.Core.Models
{
    public class Company
    {
        [Key]
        public string ComId { get; set; } = new Guid().ToString();
        public string Name { get; set; }

        public Country Country { get; set; }

        //[ForeignKey("Country")]
        [ForeignKey(nameof(Company.Country))]
        public string? CountryId { get; set; }


        public ICollection<Employee> Employees { get; set; }
        public ICollection<Department> Departments { get; set; }
        public ICollection<Designation> Designations { get; set; }
        public ICollection<Floor> Floors { get; set; }
        public ICollection<Grade> Grades { get; set; }
        public ICollection<Line> Lines { get; set; }    
        public ICollection<Unit> Units { get; set; }
        public ICollection<Section> Sections { get; set; }
        public ICollection<Shift> Shifts { get; set; }

    }
}
