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
    public class FamilyInfoRepository : BaseRepository<FamilyInfo, string>, IFamilyInfoRepository
    {
        private readonly IAxisDbContext _context;
        public FamilyInfoRepository(IAxisDbContext context) : base((DbContext)(context))
        {
            _context = context;
        }
    }  
}
