using Axis.Application.DTOs.HouseKeeping;
using Axis.Core.Models.HouseKeeping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axis.Application.Services.IServices.HouseKeeping
{
    public interface IUnitService
    {
        Task<bool> Add(UnitDTO unitDTO);
        Task<Unit> Update(UnitDTO unitDTO);
        Task<Unit> GetById(string id);
        Task<IEnumerable<Unit>> GetListByComid(string id);
        Task<bool> Delete(string id);
        (IList<Unit> data, int total, int totalDisplay) GetPaginatedList(string? comid, int pageIndex = 1, int pageSize = 10, bool isTrackingOff = false);


    }
}
