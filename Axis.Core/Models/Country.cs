using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axis.Core.Models
{
    public class Country 
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public string Name { get; set; }
        public string Code { get; set; }
        public string ShortName { get; set; }
        public string PhoneCode { get; set; }
        public string LocalName { get; set; }
        



        public ICollection<Company> Companies { get; set; }
    }
}
