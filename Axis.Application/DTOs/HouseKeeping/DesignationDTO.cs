using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axis.Application.DTOs.HouseKeeping
{
    public class DesignationDTO : BaseDTO
    {   
        public string DesigName { get; set; }     
        public string DesigLocalName { get; set; }
        public string? SalaryRange { get; set; }
        public int? slno { get; set; }    
        public decimal? gsmin { get; set; }
        public decimal? attbonus { get; set; }  
        public decimal? holidaybonus { get; set; }
        public decimal nightallow { get; set; }
        public int? ttlmanpower { get; set; }
        public int? proposedmanpower { get; set; }
        public string? DeptId { get; set; }
    }
}
