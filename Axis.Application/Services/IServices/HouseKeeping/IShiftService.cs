using Axis.Application.DTOs.HouseKeeping;
using Axis.Core.Models.HouseKeeping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axis.Application.Services.IServices.HouseKeeping
{
    public interface IShiftService
    {
        Task<bool> Add(ShiftDTO shiftDTO);
        Task<Shift> Update(ShiftDTO shiftDTO);
        Task<Shift> GetById(string id);
        Task<IEnumerable<Shift>> GetListByComid(string id);
        Task<bool> Delete(string id);
        (IList<Shift> data, int total, int totalDisplay) GetPaginatedList(string? comid, int pageIndex = 1, int pageSize = 10, bool isTrackingOff = false);


    }
}
