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
    public class HolidayRepository : BaseRepository<Holiday, string>, IHolidayRepository
    {
        private readonly IAxisDbContext _context;
        public HolidayRepository(IAxisDbContext context) : base((DbContext)(context))
        {
            _context = context;
        }
    }
   
}
