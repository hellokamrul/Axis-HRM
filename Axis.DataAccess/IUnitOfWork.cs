using Axis.DataAccess.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axis.DataAccess
{
    public interface IUnitOfWork : IDisposable
    {
        ICompanyRepository Companies { get; }
        IEmployeeRepository Employees { get; }


        void save();
    }
}
