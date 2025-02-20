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
    public class BloodGroupRepository : BaseRepository<BloodGroup, string>, IBloodGroupRepository
    {
        private readonly IAxisDbContext _dbContext;  
        public BloodGroupRepository(IAxisDbContext dbContext) : base((DbContext) (dbContext))
        {
            _dbContext = dbContext; 
        }
    }
}
