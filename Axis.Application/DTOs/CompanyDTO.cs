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
    public class CompanyDTO
    {    public string? Comid { get; set; }
        public string Name { get; set; }
        public string? CountryId { get; set; }
    }
}
