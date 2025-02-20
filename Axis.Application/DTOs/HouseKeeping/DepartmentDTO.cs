using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axis.Application.DTOs.HouseKeeping
{
    public class DepartmentDTO : BaseDTO
    {
       
        public string DeptCode { get; set; }
        public string DeptName { get; set; }
        public string DeptLocalName { get; set; }
        public short? slno { get; set; }
    }
}
