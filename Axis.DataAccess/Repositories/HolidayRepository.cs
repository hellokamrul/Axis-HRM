using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Axis.Core.Models.HR.Attendance_Leave;
using Axis.DataAccess.IRepository;
using Axis.DataAccess.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Axis.DataAccess.Repositories
{
    public class HolidayRepository : BaseRepository<Holiday, string>, IHolidayRepository
    {
        public readonly IAxisDbContext _dbContext;
        public HolidayRepository(IAxisDbContext dbContext) : base((DbContext)(dbContext))
        {
            _dbContext = dbContext;
        }
    }
}
