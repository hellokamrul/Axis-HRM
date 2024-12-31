using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axis.Core.Models
{
    public class Company
    {
        public string ComId { get; set; } = new Guid().ToString();
        public string Name { get; set; }
    }
}
