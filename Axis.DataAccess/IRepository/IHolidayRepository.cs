using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Axis.Core.Models.HR.Attendance_Leave;

namespace Axis.DataAccess.IRepository
{
    public interface IHolidayRepository : IRepository<Holiday, string>
    {
    }
}
