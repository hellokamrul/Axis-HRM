using Axis.Core.Models.HR;
using Axis.DataAccess.IRepository;
using Axis.DataAccess.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axis.DataAccess.Repositories
{
    public class EmpTaxInfoRepository : BaseRepository<EmpTaxInfo, string>, IEmpTaxInfoRepository
    {
        private readonly IAxisDbContext _context;
        public EmpTaxInfoRepository(IAxisDbContext context) : base((DbContext)(context))
        {
            _context = context;
        }
    }  
}
