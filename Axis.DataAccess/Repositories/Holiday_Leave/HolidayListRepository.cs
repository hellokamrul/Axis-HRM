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
    public class HolidayListRepository : BaseRepository<HolidayList, string>, IHolidayListRepository
    {
        private readonly IAxisDbContext _context;
        public HolidayListRepository(IAxisDbContext context) : base((DbContext)(context))
        {
            _context = context;
        }
    }
   
}
