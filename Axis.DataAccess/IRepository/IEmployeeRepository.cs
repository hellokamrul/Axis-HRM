using Axis.Core.Models.HR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axis.DataAccess.IRepository
{
    public interface IEmployeeRepository : IRepository<Employee, string>
    {

    }
}
