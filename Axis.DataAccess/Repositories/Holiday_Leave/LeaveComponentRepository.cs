using Axis.Core.Models.Leave_Holiday;
using Axis.DataAccess.IRepository;
using Axis.DataAccess.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axis.DataAccess.Repositories.Holiday_Leave
{
    public class LeaveComponentRepository : BaseRepository<LeaveComponent,string>, ILeaveComponent 
    {
        private readonly IAxisDbContext _context;
        public LeaveComponentRepository(IAxisDbContext context) : base((DbContext)(context))
        {
            _context = context;
        }
    }
}
