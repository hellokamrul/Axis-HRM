using Axis.Application.DTOs.HouseKeeping;
using Axis.Core.Models.HouseKeeping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axis.Application.Services.IServices.HouseKeeping
{
    public interface ILineService
    {
        Task<bool> Add(Line lineDTO);
        Task<Line> Update(LineDTO lineDTO);
        Task<Line> GetById(string id);
        Task<IEnumerable<Line>> GetListByComid(string id);
        Task<bool> Delete(string id);
        (IList<Line> data, int total, int totalDisplay) GetPaginatedList(string? comid, int pageIndex = 1, int pageSize = 10, bool isTrackingOff = false);


    }
}
