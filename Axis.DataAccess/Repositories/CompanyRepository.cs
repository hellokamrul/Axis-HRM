using Axis.Core.Models;
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
    public class CompanyRepository : BaseRepository<Company,Guid>, ICompanyRepository
    {
        private readonly IAxisDbContext _context;
        public CompanyRepository(IAxisDbContext context) : base((DbContext)(context))
        {
            _context = context;
        }
    }
}
