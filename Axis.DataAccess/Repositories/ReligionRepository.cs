using Axis.Core.Models.HouseKeeping;
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
    public class ReligionRepository : BaseRepository<Religion, string>, IReligionRepository
    {
        private readonly IAxisDbContext _dbContext;
        public ReligionRepository(IAxisDbContext dbContext) : base((DbContext)(dbContext))
        {
            _dbContext = dbContext;
        }
    }
}
