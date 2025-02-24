using Axis.Application.DTOs.HouseKeeping;
using Axis.Core.Models.HouseKeeping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axis.Application.Services.IServices.HouseKeeping
{
    public interface IFloorService
    {
        Task<bool> Add(FloorDTO     floorDTO);
        Task<Floor> Update(FloorDTO floorDTO);
        Task<Floor> GetById(string id);
        Task<IEnumerable<Floor>> GetListByComid(string id);
       // Task<IEnumerable<Floor>> GetListByDeptId(string id);
        Task<bool> Delete(string id);
        (IList<Floor> data, int total, int totalDisplay) GetPaginatedList(string comid, int pageIndex = 1, int pageSize = 10, bool isTrackingOff = false);

    }
}
